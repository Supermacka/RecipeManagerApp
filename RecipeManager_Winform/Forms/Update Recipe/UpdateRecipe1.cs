using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace RecipeManager_Winform.Forms.Update_Recipe
{
    public partial class UpdateRecipe1 : Form
    {
        public static Recipe MainRecipe { get; private set; }
        public static string UserInputCategory { get; set; }
        public static string UserInputSource { get; set; }

        public UpdateRecipe1()
        {
            InitializeComponent();
        }

        private void UpdateRecipe1_Load(object sender, EventArgs e)
        {
            FillComboBox();
            LoadRecipeMainInformation();
        }
        public void FillComboBox()
        {
            // Put sources in 
            using (RecipesContext db = new RecipesContext())
            {
                // Load FoodCategories
                List<string> categoryList = new List<string>();
                categoryList = db.FoodCategories.Select(i => i.FoodCategoryName).ToList();

                for (int i = 0; i < categoryList.Count; i++)
                {
                    comboBoxCategory.Items.Insert(i, categoryList[i]);
                }

                // Load FoodCategories
                List<string> sourceList = new List<string>();
                sourceList = db.RecipeSources.Select(i => i.RecipeSourceName).ToList();

                for (int i = 0; i < sourceList.Count; i++)
                {
                    comboBoxSource.Items.Insert(i, sourceList[i]);
                }
            }
        }
        public void LoadRecipeMainInformation()
        {
            using (RecipesContext db = new RecipesContext())
            {
                int selectedRecipe = Form1.SelectedRecipeID;

                // Set combobox
                comboBoxCategory.Text = (from r in db.Recipes
                                         where r.RecipeId == selectedRecipe
                                         select r.FoodCategory.FoodCategoryName).FirstOrDefault();
                comboBoxSource.Text = (from r in db.Recipes
                                         where r.RecipeId == selectedRecipe
                                         select r.RecipeSource.RecipeSourceName).FirstOrDefault();

                // NumericUpDown
                numericUpDownDuration.Value = (decimal)(from r in db.Recipes
                                               where r.RecipeId == selectedRecipe
                                               select r.Duration).FirstOrDefault();
                numericUpDownRating.Value = (decimal)(from r in db.Recipes
                                                        where r.RecipeId == selectedRecipe
                                                        select r.Rating).FirstOrDefault();

                // recipeName && recipeDescription
                textBoxName.Text = (from r in db.Recipes
                                    where r.RecipeId == selectedRecipe
                                    select r.RecipeName).FirstOrDefault();
                textBoxDescription.Text = (from r in db.Recipes
                                    where r.RecipeId == selectedRecipe
                                    select r.RecipeDescription).FirstOrDefault();
            }
        }

        private void buttonUpdateRecipe2_Click(object sender, EventArgs e)
        {
            RecipeMainInformation();
            new UpdateRecipe2().ShowDialog();
        }
        public void RecipeMainInformation()
        {
            using (RecipesContext db = new RecipesContext())
            {
                // Set category reference
                UserInputCategory = comboBoxCategory.Text;

                // Set Source reference
                UserInputSource = comboBoxSource.Text;

                // Get and Save recipe information for later use
                Recipe recipe = new Recipe
                {
                    FoodCategoryId = (from c in db.FoodCategories
                                      where c.FoodCategoryName == comboBoxCategory.Text
                                      select c.FoodCategoryId).FirstOrDefault(),
                    RecipeSourceId = (from s in db.RecipeSources
                                      where s.RecipeSourceName == comboBoxSource.Text
                                      select s.RecipeSourceId).FirstOrDefault(),
                    RecipeName = textBoxName.Text,
                    RecipeDescription = textBoxDescription.Text,
                    Duration = (int?)numericUpDownDuration.Value,
                    Rating = (int?)numericUpDownRating.Value,
                };
                MainRecipe = recipe;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SetButtonVisibility()
        {
            buttonUpdateRecipe2.Enabled =
                (
                    !string.IsNullOrWhiteSpace(comboBoxCategory.Text) &&
                    !string.IsNullOrWhiteSpace(comboBoxSource.Text) &&
                    !string.IsNullOrWhiteSpace(textBoxName.Text) &&
                    !string.IsNullOrWhiteSpace(textBoxDescription.Text)
                );
        }
        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            SetButtonVisibility();
        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {
            SetButtonVisibility();
        }

        private void comboBoxCategory_TextChanged(object sender, EventArgs e)
        {
            SetButtonVisibility();
        }

        private void comboBoxSource_TextChanged(object sender, EventArgs e)
        {
            SetButtonVisibility();
        }

        private void buttonCancel_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
