using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using RecipeManager_Winform.Models;
using RecipeManager_Winform.Data;

namespace RecipeManager_Winform.Forms
{
    public partial class AddRecipe1 : Form
    {
        public static Recipe MainRecipe { get; private set; }
        public static string UserInputCategory { get; set; }
        public static string UserInputSource { get; set; }

        public AddRecipe1()
        {
            InitializeComponent();
        }

        private void labelIngredientList_Click(object sender, EventArgs e)
        {

        }

        private void AddRecipe1_Load(object sender, EventArgs e)
        {
            FillComboBox();
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

        private void buttonAddRecipe2_Click(object sender, EventArgs e)
        {
            RecipeMainInformation();
            new AddRecipe2().ShowDialog();
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
        private void comboBoxCategory_TextChanged(object sender, EventArgs e)
        {
            SetButtonVisibility();
        }
        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            SetButtonVisibility();
        }
        private void comboBoxSource_TextChanged(object sender, EventArgs e)
        {
            SetButtonVisibility();
        }
        private void numericUpDownDuration_ValueChanged(object sender, EventArgs e)
        {
            SetButtonVisibility();
        }
        private void numericUpDownRating_ValueChanged(object sender, EventArgs e)
        {
            SetButtonVisibility();
        }
        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {
            SetButtonVisibility();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = "Simply add new Categories and Sources by writing in their respective field";
            string caption = "Adding a new Category or Source";
            MessageBox.Show(text, caption);
        }
    }
}
