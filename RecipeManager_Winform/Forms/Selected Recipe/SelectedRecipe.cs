using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RecipeManager_Winform.Forms.Selected_Recipe
{
    public partial class SelectedRecipe : Form
    {
        public SelectedRecipe()
        {
            InitializeComponent();
        }

        private void SelectedRecipe_Load(object sender, EventArgs e)
        {
            // Set ScrollBar-Slider to top of form
            labelRecipeName.Select();

            LoadMainRecipeInformation();
            LoadDBIngredients();
            LoadDBSteps();
        }
        public void LoadMainRecipeInformation()
        {
            using (RecipesContext db = new RecipesContext())
            {
                int selectedRecipeID = Form1.SelectedRecipeID;

                // Set Main labels
                labelRecipeName.Text = (from r in db.Recipes
                                        where r.RecipeId == selectedRecipeID
                                        select r.RecipeName).FirstOrDefault();

                labelRecipeDescription.Text = (from r in db.Recipes
                                               where r.RecipeId == selectedRecipeID
                                               select r.RecipeDescription).FirstOrDefault();

                labelRecipeRating.Text = (from r in db.Recipes
                                          where r.RecipeId == selectedRecipeID
                                          select r.Rating).FirstOrDefault().ToString() + " likes";

                labelRecipeDuration.Text = CalculateRecipeDuration(selectedRecipeID);
                labelRecipeCalories.Text = CalculateRecipeCalories(selectedRecipeID) + " kcal";
            }
        }
        public string CalculateRecipeDuration(int selectedRecipeID)
        {
            using (RecipesContext db = new RecipesContext())
            {
                double totalMinutes = (double)(from r in db.Recipes
                                               where r.RecipeId == selectedRecipeID
                                               select r.Duration).FirstOrDefault();
                var time = TimeSpan.FromMinutes(totalMinutes);
                return string.Format("{0:00}:{1:00}", (int)time.TotalHours, time.Minutes);
            }
        }
        public string CalculateRecipeCalories(int selectedRecipeID)
        {
            // Get all the calories from db
            List<double?> recipeCalorieList = new List<double?>();
            using (RecipesContext db = new RecipesContext())
            {
                recipeCalorieList = (from ri in db.RecipeIngredients
                                     where ri.Recipe.RecipeId == selectedRecipeID
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
            return ((double)decimal.Round((decimal)totalCalories, 2, MidpointRounding.AwayFromZero)).ToString();
        }

        public void LoadDBIngredients()
        {
            using (RecipesContext db = new RecipesContext())
            {
                int selectedRecipeID = Form1.SelectedRecipeID;                 // Selected recipe referenceID

                List<string> dbIngredients = new List<string>();
                dbIngredients = (from r_i in db.RecipeIngredients
                                 where r_i.RecipeId == selectedRecipeID
                                 select r_i.Ingredient.IngredientName).ToList();

                List<double?> dbQuantity = new List<double?>();
                dbQuantity = (from r_i in db.RecipeIngredients
                              where r_i.RecipeId == selectedRecipeID
                              select r_i.Quantity.Quantity1).ToList();

                List<double?> dbCalories = new List<double?>();
                dbCalories = (from r_i in db.RecipeIngredients
                              where r_i.RecipeId == selectedRecipeID
                              select r_i.Ingredient.CaloriesPer100g).ToList();

                for (int i = 0; i < dbIngredients.Count; i++)
                {
                    // Add 1row to DGV
                    DataGridViewRow row = (DataGridViewRow)dataGridViewRecipeIngredients.Rows[0].Clone();
                    dataGridViewRecipeIngredients.Rows.Add(row);

                    // Fill row with values
                    dataGridViewRecipeIngredients.Rows[i].Cells[0].Value = dbIngredients.ElementAt(i);
                    dataGridViewRecipeIngredients.Rows[i].Cells[1].Value = dbQuantity.ElementAt(i);
                    dataGridViewRecipeIngredients.Rows[i].Cells[2].Value = "g";
                    dataGridViewRecipeIngredients.Rows[i].Cells[3].Value = dbCalories.ElementAt(i);
                }
            }

            // Display rowNumber
            int countRows = 0;
            foreach (DataGridViewRow row in dataGridViewRecipeIngredients.Rows)
            {
                if (row.IsNewRow) continue;

                countRows++;
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }

            // Autorezise rowNumber column
            dataGridViewRecipeIngredients.AutoResizeRowHeadersWidth(0, DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);

            // Set RecipeCount label
            labelRecipeIngredients.Text = $"{countRows.ToString()}";
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
                    if (row.IsNewRow) continue;

                    countRows++;
                    row.HeaderCell.Value = (row.Index + 1).ToString();
                }

                // Autorezise rowNumber column
                dataGridViewRecipeSteps.AutoResizeRowHeadersWidth(0, DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);

                // Set RecipeCount label
                labelRecipeSteps.Text = $"{countRows.ToString()}";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
