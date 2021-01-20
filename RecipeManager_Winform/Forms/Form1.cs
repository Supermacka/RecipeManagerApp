using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RecipeManager_Winform.Models;
using RecipeManager_Winform.Data;
using Microsoft.EntityFrameworkCore;
using RecipeManager_Winform.Forms;
using RecipeManager_Winform.Forms.Update_Recipe;
using RecipeManager_Winform.Forms.Selected_Recipe;

namespace RecipeManager_Winform
{
    public partial class Form1 : Form
    {


        public DataGridView MainList { get; set; }
        public static int SelectedRecipeID { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayRecipesOnDGV();
        }
        public void DisplayRecipesOnDGV()
        {
            using (RecipesContext db = new RecipesContext())
            {
                // Display data as list
                List<LoadRecipes> displayRecipeList = new List<LoadRecipes>();
                displayRecipeList = db.Recipes.Select(i => new LoadRecipes
                {
                    Source = i.RecipeSource.RecipeSourceName,
                    Type = i.FoodCategory.FoodCategoryName,
                    Name = i.RecipeName,
                    Duration = i.Duration,
                    Rating = i.Rating,
                    Calories = CalculateRecipeCalories(i.RecipeName)

                }).ToList();

                dataGridViewRecipes.DataSource = displayRecipeList;
                this.MainList = dataGridViewRecipes; // Set DGV reference name

                // Display rowNumber
                int countRows = 0;
                foreach (DataGridViewRow row in dataGridViewRecipes.Rows)
                {
                    countRows++;
                    row.HeaderCell.Value = (row.Index + 1).ToString();
                }

                // Autorezise rowNumber column
                if (dataGridViewRecipes.Rows.Count > 0)
                {
                    dataGridViewRecipes.AutoResizeRowHeadersWidth(0, DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
                }
                // Count of recipes
                labelRecipesCount.Text = $"Recipes: {countRows.ToString()}";
            }
        }

        public static double CalculateRecipeCalories(string recipeName)
        {
            // Get all the calories from db
            List<double?> recipeCalorieList = new List<double?>();
            using (RecipesContext db = new RecipesContext())
            {
                recipeCalorieList = (from ri in db.RecipeIngredients
                                 where ri.Recipe.RecipeName == recipeName
                                 select ri.Ingredient.CaloriesPer100g * (ri.Quantity.Quantity1 / 100)).ToList();
            }

            double totalCalories = 0;
            foreach (double? calorie in recipeCalorieList)
            {
                if (calorie.HasValue)
                {
                    totalCalories += (double)calorie;
                }
            }
            return (double)decimal.Round((decimal)totalCalories, 2, MidpointRounding.AwayFromZero);
        }

        private void labelRecipesCount_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            new AddRecipe1().ShowDialog();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            SetSelectedRecipeID();

            // Delete from DB
            DeleteDBSteps();
            DeleteDBRecipeIngredients();
            DeleteDBRecipe();

            // Display updated DGV
            DisplayRecipesOnDGV();
        }
        public void SetSelectedRecipeID()
        {
            using (RecipesContext db = new RecipesContext())
            {
                foreach (DataGridViewRow row in dataGridViewRecipes.SelectedRows)
                {
                    // Set prop to reference
                    SelectedRecipeID = (from recipe in db.Recipes
                                        where recipe.RecipeName == row.Cells["Name"].Value.ToString()
                                        select recipe.RecipeId).Single();
                }
            }
        }
        public void DeleteDBSteps()
        {
            using (RecipesContext db = new RecipesContext())
            {
                // Delete db row...
                int selectedRecipeID = SelectedRecipeID;

                var recipeStepList = (from r_s in db.RecipeSteps
                                        where r_s.RecipeId == selectedRecipeID
                                        select r_s).ToList();

                foreach (RecipeStep recipeStep in recipeStepList)
                {
                    db.RecipeSteps.Remove(recipeStep);
                }
                db.SaveChanges();
            }
        }
        public void DeleteDBRecipeIngredients()
        {
            using (RecipesContext db = new RecipesContext())
            {
                // Delete db row...
                int selectedRecipeID = SelectedRecipeID;

                var recipeIngredientList = (from r_i in db.RecipeIngredients
                                            where r_i.RecipeId == selectedRecipeID
                                            select r_i).ToList();

                foreach (RecipeIngredient recipeIngredient in recipeIngredientList)
                {
                    db.RecipeIngredients.Remove(recipeIngredient);
                }
                db.SaveChanges();
            }
        }
        public void DeleteDBRecipe()
        {
            using (RecipesContext db = new RecipesContext())
            {
                // Delete db row...
                int selectedRecipeID = SelectedRecipeID;

                var recipeList = (from r in db.Recipes
                                  where r.RecipeId == selectedRecipeID
                                  select r).ToList();

                foreach (Recipe recipe in recipeList)
                {
                    db.Recipes.Remove(recipe);
                }
                db.SaveChanges();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            SetSelectedRecipeID();
            new UpdateRecipe1().ShowDialog();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            SetSelectedRecipeID();
            new SelectedRecipe().ShowDialog();
        }

        private void buttonCloseProgram_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridViewRecipes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewRecipes_Enter(object sender, EventArgs e)
        {
        }

        private void dataGridViewRecipes_DataSourceChanged(object sender, EventArgs e)
        {
            bool isEnabled = false;
            if (dataGridViewRecipes.Rows.Count > 0)
            {
                isEnabled = true;
            }
            else
            {
                isEnabled = false;
            }

            buttonUpdate.Enabled = isEnabled;
            buttonDelete.Enabled = isEnabled;
            buttonSelect.Enabled = isEnabled;
        }
    }
}
