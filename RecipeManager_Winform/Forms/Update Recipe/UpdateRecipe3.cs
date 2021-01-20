using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using RecipeManager_Winform.Data;
using RecipeManager_Winform.Models;

namespace RecipeManager_Winform.Forms.Update_Recipe
{
    public partial class UpdateRecipe3 : Form
    {
        public UpdateRecipe3()
        {
            InitializeComponent();
        }

        private void UpdateRecipe3_Load(object sender, EventArgs e)
        {
            LoadDBSteps();
        }
        public void LoadDBSteps()
        {
            using (RecipesContext db = new RecipesContext())
            {
                // Selected recipe referenceID
                int selectedRecipeID = Form1.SelectedRecipeID;

                List<string> dbSteps = new List<string>();
                dbSteps = (from r_s in db.RecipeSteps
                           where r_s.RecipeId == selectedRecipeID
                           select r_s.StepDescription).ToList();

                for (int i = 0; i < dbSteps.Count; i++)
                {
                    // Add 1row to DGV
                    DataGridViewRow row = (DataGridViewRow)dataGridViewRecipeSteps.Rows[0].Clone();
                    dataGridViewRecipeSteps.Rows.Add(row);

                    // Fill row with values
                    dataGridViewRecipeSteps.Rows[i].Cells[0].Value = dbSteps.ElementAt(i);
                }

                // Display rowNumber
                int countRows = 0;
                foreach (DataGridViewRow row in dataGridViewRecipeSteps.Rows)
                {
                    countRows++;
                    row.HeaderCell.Value = (row.Index + 1).ToString();
                }

                // Autorezise rowNumber column
                dataGridViewRecipeSteps.AutoResizeRowHeadersWidth(0, DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);

                // Set RecipeCount label
                labelRecipeSteps.Text = $"Steps: {countRows.ToString()}";
            }
        }

        private void ButtonUpdateRecipe_Click(object sender, EventArgs e)
        {
            // Update db information
            UpdateMainRecipeInformation();
            DBIngredientsContainValidation();
            UpdateIngredientValues(); // Updates the single value ingredient
            UpdateRecipeIngredients(); // Updated the Junction-Table of RecipeIngredients
            UpdateRecipeSteps();
            UpdateMainRecipeDGV();

            // Close all opened forms
            Application.OpenForms["UpdateRecipe1"].Close();
            Application.OpenForms["UpdateRecipe2"].Close();
            Close();
        }
        public void UpdateMainRecipeInformation()
        {
            using (RecipesContext db = new RecipesContext())
            {
                // Compare Category entries with existing DB
                string userInputCategory = UpdateRecipe1.UserInputCategory;
                List<string> foodCategoryList = new List<string>();
                foodCategoryList = db.FoodCategories.Select(i => i.FoodCategoryName).ToList();
                if (!foodCategoryList.Contains(userInputCategory) && !string.IsNullOrWhiteSpace(userInputCategory))
                {
                    db.FoodCategories.Add(new FoodCategory { FoodCategoryName = userInputCategory });
                    db.SaveChanges();
                }

                // Compare Source entries with existing DB
                string userInputSource = UpdateRecipe1.UserInputSource;
                List<string> SourceList = new List<string>();
                SourceList = db.RecipeSources.Select(i => i.RecipeSourceName).ToList();
                if (!SourceList.Contains(userInputSource) && !string.IsNullOrWhiteSpace(userInputCategory))
                {
                    db.RecipeSources.Add(new RecipeSource { RecipeSourceName = userInputSource });
                    db.SaveChanges();
                }

                // Compare Category entries with existing DB
                int selectedRecipeID = Form1.SelectedRecipeID;

                Recipe recipe = (from r in db.Recipes
                                      where r.RecipeId == selectedRecipeID
                                      select r).FirstOrDefault();

                if (recipe != null)
                {
                    recipe.FoodCategoryId = (from c in db.FoodCategories
                                                            where c.FoodCategoryName == UpdateRecipe1.UserInputCategory
                                                            select c.FoodCategoryId).FirstOrDefault();

                    recipe.RecipeSourceId = (from s in db.RecipeSources
                                                            where s.RecipeSourceName == UpdateRecipe1.UserInputSource
                                                            select s.RecipeSourceId).FirstOrDefault();

                    recipe.RecipeName = UpdateRecipe1.MainRecipe.RecipeName;
                    recipe.RecipeDescription = UpdateRecipe1.MainRecipe.RecipeDescription;
                    recipe.Duration = UpdateRecipe1.MainRecipe.Duration;
                    recipe.Rating = UpdateRecipe1.MainRecipe.Rating;
                    db.SaveChanges();
                }
            }
        }
        // Add to DB if not existing
        public void DBIngredientsContainValidation()
        {
            using (RecipesContext db = new RecipesContext())
            {
                //Ingredient DB table
                List<string> dbIngredientList = new List<string>();
                dbIngredientList = db.Ingredients.Select((i) => i.IngredientName).ToList();

                for (int i = 0; i < UpdateRecipe2.userInputIngredientProp.Count; i++)
                {
                    if (!dbIngredientList.Contains(UpdateRecipe2.userInputIngredientProp[i]))
                    {
                        db.Ingredients.Add(new Ingredient
                        {
                            IngredientName = UpdateRecipe2.userInputIngredientProp[i],
                            CaloriesPer100g = UpdateRecipe2.userInputCaloriesProp[i]
                        });
                    }
                }

                //Quantity database table
                List<double?> dbQuantityList = new List<double?>();
                dbQuantityList = db.Quantities.Select(i => i.Quantity1).ToList();

                foreach (double quantityItem in UpdateRecipe2.userInputQuantityProp)
                {
                    if (!dbQuantityList.Contains(quantityItem))
                    {
                        db.Quantities.Add(new Quantity { Quantity1 = quantityItem });
                    }
                }
                db.SaveChanges();
                db.SaveChanges();
            }
        }
        public void UpdateIngredientValues()
        {
            using (RecipesContext db = new RecipesContext())
            {
                var ingredient = UpdateRecipe2.userInputIngredientProp;
                for (int x = 0; x < ingredient.Count; x++)
                {
                    // Delete Steps from DB
                    var selectedIngredient = db.Ingredients.FirstOrDefault(i => i.IngredientName == ingredient.ElementAt(x));
                    if (selectedIngredient != null)
                    {
                        selectedIngredient.CaloriesPer100g = UpdateRecipe2.userInputCaloriesProp.ElementAt(x);
                        db.SaveChanges();
                    }
                }
            }
        }
        public void UpdateRecipeIngredients()
        {
            using (RecipesContext db = new RecipesContext())
            {
                // Delete existing Ingredients from DB
                int selectedRecipeID = Form1.SelectedRecipeID;

                var recipeIngredientList = (from r_i in db.RecipeIngredients
                                            where r_i.RecipeId == selectedRecipeID
                                            select r_i).ToList();

                foreach (RecipeIngredient recipeIngredient in recipeIngredientList)
                {
                    db.RecipeIngredients.Remove(recipeIngredient);
                }
                db.SaveChanges();

                // Add DGV ingredients to DB
                for (int x = 0; x < UpdateRecipe2.userInputIngredientProp.Count(); x++)
                {
                    db.RecipeIngredients.Add(new RecipeIngredient
                    {
                        RecipeId = (from r in db.Recipes
                                    where r.RecipeName == UpdateRecipe1.MainRecipe.RecipeName
                                    select r.RecipeId).FirstOrDefault(),
                        IngredientId = (from i in db.Ingredients
                                        where i.IngredientName == UpdateRecipe2.userInputIngredientProp[x]
                                        select i.IngredientId).FirstOrDefault(),
                        QuantityId = (from q in db.Quantities
                                      where q.Quantity1 == UpdateRecipe2.userInputQuantityProp[x]
                                      select q.QuantityId).FirstOrDefault(),
                        MeasurementId = (from m in db.Measurements
                                         where m.MeasurementName == "g"
                                         select m.MeasurementId).FirstOrDefault()
                    });
                    db.SaveChanges();
                }
            }
        }
        public void UpdateRecipeSteps()
        {
            using (RecipesContext db = new RecipesContext())
            {
                int selectedRecipeID = Form1.SelectedRecipeID;

                // Delete Steps from DB
                var recipeStepList = (from r_s in db.RecipeSteps
                                      where r_s.RecipeId == selectedRecipeID
                                      select r_s).ToList();

                foreach (RecipeStep recipeStep in recipeStepList)
                {
                    db.RecipeSteps.Remove(recipeStep);
                }
                db.SaveChanges();

                // Add new Steps from DGV to DB
                int stepNumber = 1;
                foreach (DataGridViewRow row in dataGridViewRecipeSteps.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        if (row.IsNewRow) continue;
                        db.RecipeSteps.Add(new RecipeStep
                        {
                            RecipeId = (from r in db.Recipes
                                        where r.RecipeName == UpdateRecipe1.MainRecipe.RecipeName
                                        select r.RecipeId).FirstOrDefault(),
                            StepNumber = stepNumber,
                            StepDescription = row.Cells[0].Value.ToString()
                        });
                        db.SaveChanges();
                        stepNumber++;
                    }
                }
            }
        }
        public void UpdateMainRecipeDGV()
        {
            // Update Mainrecipe list in Form1
            Form1 mainForm = (Form1)Application.OpenForms["Form1"];
            mainForm.MainList.DataSource = null;
            mainForm.MainList.Rows.Clear();

            // Display updated items in MainForm DGV
            using (RecipesContext db = new RecipesContext())
            {
                List<LoadRecipes> displayRecipeList = new List<LoadRecipes>();
                displayRecipeList = db.Recipes.Select(i => new LoadRecipes
                {
                    Source = i.RecipeSource.RecipeSourceName,
                    Type = i.FoodCategory.FoodCategoryName,
                    Name = i.RecipeName,
                    Duration = i.Duration,
                    Rating = i.Rating,
                    Calories = Form1.CalculateRecipeCalories(i.RecipeName)
                }).ToList();

                mainForm.MainList.DataSource = displayRecipeList;

                // Display rowNumber
                int countRows = 0;
                foreach (DataGridViewRow row in mainForm.MainList.Rows)
                {
                    countRows++;
                    row.HeaderCell.Value = (row.Index + 1).ToString();
                }
                mainForm.MainList.RowHeadersWidth = 50;
            }
        }

        private void dataGridViewRecipeSteps_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            CheckCellValueNotNull();
        }
        private void dataGridViewRecipeSteps_Enter(object sender, EventArgs e)
        {
            CheckCellValueNotNull();
        }
        public void CheckCellValueNotNull()
        {
            bool allValid = true;

            foreach (DataGridViewRow row in dataGridViewRecipeSteps.Rows)
            {
                if (row.Index != dataGridViewRecipeSteps.CurrentRow.Index && row.IsNewRow) continue;

                var v = row.Cells[0].Value;
                if (v == null || v == DBNull.Value || string.IsNullOrEmpty(v?.ToString()) || string.IsNullOrWhiteSpace(v.ToString()))
                {
                    string text = "Recipe step can not be empty";
                    string caption = "Step empty!";
                    MessageBox.Show(text, caption);

                    allValid = false;
                    break;
                }
            }

            buttonUpdateRecipe.Enabled = allValid;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
