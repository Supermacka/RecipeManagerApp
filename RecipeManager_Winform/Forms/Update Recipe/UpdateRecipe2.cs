using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RecipeManager_Winform.Forms.Update_Recipe
{
    public partial class UpdateRecipe2 : Form
    {
        public static List<string> userInputIngredientProp { get; private set; }
        public static List<double?> userInputQuantityProp { get; private set; }
        public static List<double?> userInputCaloriesProp { get; private set; }

        public UpdateRecipe2()
        {
            InitializeComponent();
        }

        private void UpdateRecipe2_Load(object sender, EventArgs e)
        {
            LoadDBIngredients();
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
                countRows++;
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }

            // Autorezise rowNumber column
            dataGridViewRecipeIngredients.AutoResizeRowHeadersWidth(0, DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);

            // Set RecipeCount label
            labelRecipeIngredients.Text = $"Ingredients: {countRows.ToString()}";
        }

        private void buttonUpdateRecipe2_Click(object sender, EventArgs e)
        {
            SetIngredientsPropertie();

            // Open next form (steps)
            new UpdateRecipe3().ShowDialog();
        }
        public void SetIngredientsPropertie()
        {
            using (RecipesContext db = new RecipesContext())
            {
                // Add user input from DGV to properties
                List<string> userInputIngredient = new List<string>();
                List<double?> userInputQuantity = new List<double?>();
                List<double?> userInputCalories = new List<double?>();

                foreach (DataGridViewRow row in dataGridViewRecipeIngredients.Rows)
                {
                    if (row.IsNewRow)   continue; // Skip the blank row

                    userInputIngredient.Add(row.Cells[0].Value?.ToString());
                    userInputQuantity.Add(Convert.ToDouble(row.Cells[1].Value));
                    userInputCalories.Add(Convert.ToDouble(row.Cells[3].Value));
                }
                userInputIngredientProp = userInputIngredient;
                userInputQuantityProp = userInputQuantity;
                userInputCaloriesProp = userInputCalories;
            }
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
        private void dataGridViewRecipeIngredients_Enter(object sender, EventArgs e)
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

            buttonUpdateRecipe2.Enabled = allValid;
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

            buttonUpdateRecipe2.Enabled = allValid;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
