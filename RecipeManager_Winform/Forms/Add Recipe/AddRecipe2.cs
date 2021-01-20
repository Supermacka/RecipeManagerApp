using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RecipeManager_Winform.Models;
using RecipeManager_Winform.Data;
using System.Linq;

namespace RecipeManager_Winform.Forms
{
    public partial class AddRecipe2 : Form
    {
        public static List<string> userInputIngredientProp { get; private set; }
        public static List<double?> userInputQuantityProp { get; private set; }
        public static List<double?> userInputCaloriesProp { get; private set; }

        public AddRecipe2()
        {
            InitializeComponent();
        }

        private void buttonAddRecipe2_Click(object sender, EventArgs e)
        {
            List<string> userInputIngredient = new List<string>();
            List<double?> userInputQuantity = new List<double?>();
            List<double?> userInputCalories = new List<double?>();
            // Add user input from DGV to properties

            foreach (DataGridViewRow row in dataGridViewRecipeIngredients.Rows)
            {
                if (row.IsNewRow)
                {
                    continue; // Skip the blank row
                }

                userInputIngredient.Add(row.Cells[0].Value?.ToString());
                userInputQuantity.Add(Convert.ToDouble(row.Cells[1].Value));
                userInputCalories.Add(Convert.ToDouble(row.Cells[3].Value));    
            }
            userInputIngredientProp = userInputIngredient;
            userInputQuantityProp = userInputQuantity;
            userInputCaloriesProp = userInputCalories;
            new AddRecipe3().ShowDialog();

            // Autorezise rowNumber column
            dataGridViewRecipeIngredients.AutoResizeRowHeadersWidth(0, DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddRecipe2_Load(object sender, EventArgs e)
        {
        }

        private void dataGridViewRecipeIngredients_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            // Set "g" as default value for all "Masurement" rows
            e.Row.Cells[2].Value = "g";
        }

        private void dataGridViewRecipeIngredients_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            CheckCellValueNotNull();
        }
        public void CheckCellValueNotNull()
        {
            bool allValid = true;

            foreach (DataGridViewRow row in dataGridViewRecipeIngredients.Rows)
            {
                if (row.Index != dataGridViewRecipeIngredients.CurrentRow.Index && row.IsNewRow) continue;

                var v = row.Cells[0].Value;
                if (v == null || v == DBNull.Value || string.IsNullOrEmpty(v?.ToString()) || string.IsNullOrWhiteSpace(v.ToString()))
                {
                    string text = "Ingredient must have a name";
                    string caption = "Missing name!";
                    MessageBox.Show(text, caption);

                    allValid = false;
                    break;
                }
            }

            buttonAddRecipe2.Enabled = allValid;
            CheckCellValueNumeric(allValid);
        }
        public void CheckCellValueNumeric(bool allValid)
        {
            foreach (DataGridViewRow row in dataGridViewRecipeIngredients.Rows)
            {
                if (row.IsNewRow) continue;

                // ALLOWED: Null, Numeric (0 or pos)s 
                var v1 = row.Cells[1].Value;
                if (row.Cells[1].Value != null)
                {
                    if (!Double.TryParse(row.Cells[1].Value.ToString(), out _) || Convert.ToDouble(v1) < 0)
                    {
                        string text = "Must be a positive number";
                        string caption = "Incorrect value";
                        MessageBox.Show(text, caption);

                        allValid = false;
                        break;
                    }
                }

                var v3 = row.Cells[3].Value;
                if (row.Cells[3].Value != null)
                {
                    if (!Double.TryParse(row.Cells[3].Value.ToString(), out _) || Convert.ToDouble(v3) < 0)
                    {
                        string text = "Quantity and Calories must be a positive numbers (or blank)";
                        string caption = "Incorrect value";
                        MessageBox.Show(text, caption);

                        allValid = false;
                        break;
                    }
                }
            }

            buttonAddRecipe2.Enabled = allValid;
        }

        // Not needed
        private void dataGridViewRecipeIngredients_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void dataGridViewRecipeIngredients_SelectionChanged(object sender, EventArgs e)
        {
        }
        private void dataGridViewRecipeIngredients_Enter(object sender, EventArgs e)
        {
        }

        private void dataGridViewRecipeIngredients_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            int ingredientsCount = 0;
            foreach (DataGridViewRow row in dataGridViewRecipeIngredients.Rows)
            {
                if (row.IsNewRow)
                {
                    continue; // Skip the blank row
                }

                ingredientsCount++;
            }
            labelRecipeIngredients.Text = $"Ingredients: {ingredientsCount}";
        }
    }
}
