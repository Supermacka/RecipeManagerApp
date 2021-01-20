using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RecipeManager_Winform.Forms;
using RecipeManager_Winform.Data;
using System.Linq;
using RecipeManager_Winform.Models;

namespace RecipeManager_Winform.Forms
{
    public partial class AddRecipe3 : Form
    {
        public AddRecipe3()
        {
            InitializeComponent();
        }

        private void buttonAddRecipe_Click(object sender, EventArgs e)
        {
            // Add information to db
            MainRecipeInformation();
            DBIngredientsContainValidation();
            AddRecipeIngredients();
            AddRecipeSteps();

            UpdateMainRecipeDGV();

            // Close all opened forms
            Application.OpenForms["AddRecipe1"].Close();
            Application.OpenForms["AddRecipe2"].Close();
            Close();
        }
        public void MainRecipeInformation()
        {
            using (RecipesContext db = new RecipesContext())
            {
                // Compare Category entries with existing DB
                string userInputCategory = AddRecipe1.UserInputCategory;
                List<string> foodCategoryList = new List<string>();
                foodCategoryList = db.FoodCategories.Select(i => i.FoodCategoryName).ToList();
                if (!foodCategoryList.Contains(userInputCategory) && !string.IsNullOrWhiteSpace(userInputCategory))
                {
                    db.FoodCategories.Add(new FoodCategory { FoodCategoryName = userInputCategory });
                }

                // Compare Source entries with existing DB
                string userInputSource = AddRecipe1.UserInputSource;
                List<string> SourceList = new List<string>();
                SourceList = db.RecipeSources.Select(i => i.RecipeSourceName).ToList();
                if (!SourceList.Contains(userInputSource) && !string.IsNullOrWhiteSpace(userInputCategory))
                {
                    db.RecipeSources.Add(new RecipeSource { RecipeSourceName = userInputSource });
                }
                db.SaveChanges();

                // Add MainRecipe information to DB
                db.Recipes.Add(AddRecipe1.MainRecipe);
                db.SaveChanges();
            }
        }
        // Add to DB if not existing
        public void DBIngredientsContainValidation()
        {
            using (RecipesContext db = new RecipesContext())
            {
                //Ingredient && Calorie database table
                List<string> dbIngredientList = new List<string>();
                dbIngredientList = db.Ingredients.Select((i) => i.IngredientName).ToList();

                for (int i = 0; i < AddRecipe2.userInputIngredientProp.Count; i++)
                {
                    if (!dbIngredientList.Contains(AddRecipe2.userInputIngredientProp[i]))
                    {
                        db.Ingredients.Add(new Ingredient 
                        { 
                            IngredientName = AddRecipe2.userInputIngredientProp[i], 
                            CaloriesPer100g = AddRecipe2.userInputCaloriesProp[i] 
                        });
                    }
                }

                //Quantity database table
                List<double?> dbQuantityList = new List<double?>();
                dbQuantityList = db.Quantities.Select(i => i.Quantity1).ToList();

                foreach (double quantityItem in AddRecipe2.userInputQuantityProp)
                {
                    if (!dbQuantityList.Contains(quantityItem))
                    {
                        db.Quantities.Add(new Quantity { Quantity1 = quantityItem });
                    }
                }
                db.SaveChanges();
            }
        }
        public void AddRecipeIngredients()
        {
            using (RecipesContext db = new RecipesContext())
            {
                // Add Ingredients to db
                for (int x = 0; x < AddRecipe2.userInputIngredientProp.Count(); x++)
                {
                    db.RecipeIngredients.Add(new RecipeIngredient
                    {
                        RecipeId = (from r in db.Recipes
                                    where r.RecipeName == AddRecipe1.MainRecipe.RecipeName
                                    select r.RecipeId).FirstOrDefault(),
                        IngredientId = (from i in db.Ingredients
                                        where i.IngredientName == AddRecipe2.userInputIngredientProp[x]
                                        select i.IngredientId).FirstOrDefault(),
                        QuantityId = (from q in db.Quantities
                                    where q.Quantity1 == AddRecipe2.userInputQuantityProp[x]
                                    select q.QuantityId).FirstOrDefault(),
                        MeasurementId = (from m in db.Measurements
                                         where m.MeasurementName == "g"
                                         select m.MeasurementId).FirstOrDefault()
                    });
                    db.SaveChanges();
                }
            }
        }
        public void AddRecipeSteps()
        {
            using (RecipesContext db = new RecipesContext())
            {
                int stepNumber = 1;
                foreach (DataGridViewRow row in dataGridViewRecipeSteps.Rows)
                {
                    if (row.IsNewRow) continue;
                    db.RecipeSteps.Add(new RecipeStep
                    {
                        RecipeId = (from r in db.Recipes
                                    where r.RecipeName == AddRecipe1.MainRecipe.RecipeName
                                    select r.RecipeId).FirstOrDefault(),
                        StepNumber = stepNumber,
                        StepDescription = row.Cells[0].Value.ToString()
                    });
                    db.SaveChanges();
                    stepNumber++;
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

        private void AddRecipe3_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewRecipeSteps_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            int stepCount = 0;
            foreach (DataGridViewRow row in dataGridViewRecipeSteps.Rows)
            {
                if (row.IsNewRow)
                {
                    continue; // Skip the blank row
                }

                stepCount++;
            }
            labelRecipeSteps.Text = $"Ingredients: {stepCount}";
        }

        private void dataGridViewRecipeSteps_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            CheckCellValueNotNull();
        }
        private void dataGridViewRecipeSteps_Enter(object sender, EventArgs e)
        {
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

            buttonAddRecipe.Enabled = allValid;
        }
    }
}