
namespace RecipeManager_Winform.Forms.Update_Recipe
{
    partial class UpdateRecipe2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonUpdateRecipe2 = new System.Windows.Forms.Button();
            this.labelRecipeIngredients = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.dataGridViewRecipeIngredients = new System.Windows.Forms.DataGridView();
            this.RecipeIngredient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecipeQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecipyMeasurement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecipeCalories = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecipeIngredients)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonBack.Location = new System.Drawing.Point(48, 400);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 31;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(546, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 15);
            this.label2.TabIndex = 30;
            this.label2.Text = "Add the required steps";
            // 
            // buttonUpdateRecipe2
            // 
            this.buttonUpdateRecipe2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdateRecipe2.Enabled = false;
            this.buttonUpdateRecipe2.Location = new System.Drawing.Point(678, 400);
            this.buttonUpdateRecipe2.Name = "buttonUpdateRecipe2";
            this.buttonUpdateRecipe2.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateRecipe2.TabIndex = 29;
            this.buttonUpdateRecipe2.Text = "Next";
            this.buttonUpdateRecipe2.UseVisualStyleBackColor = true;
            this.buttonUpdateRecipe2.Click += new System.EventHandler(this.buttonUpdateRecipe2_Click);
            // 
            // labelRecipeIngredients
            // 
            this.labelRecipeIngredients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRecipeIngredients.AutoSize = true;
            this.labelRecipeIngredients.Location = new System.Drawing.Point(48, 86);
            this.labelRecipeIngredients.Name = "labelRecipeIngredients";
            this.labelRecipeIngredients.Size = new System.Drawing.Size(78, 15);
            this.labelRecipeIngredients.TabIndex = 28;
            this.labelRecipeIngredients.Text = "Ingredients: 0";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(48, 28);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(324, 37);
            this.labelTitle.TabIndex = 26;
            this.labelTitle.Text = "Update recipe ingredients";
            // 
            // dataGridViewRecipeIngredients
            // 
            this.dataGridViewRecipeIngredients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRecipeIngredients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRecipeIngredients.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewRecipeIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecipeIngredients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RecipeIngredient,
            this.RecipeQuantity,
            this.RecipyMeasurement,
            this.RecipeCalories});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRecipeIngredients.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewRecipeIngredients.Location = new System.Drawing.Point(48, 104);
            this.dataGridViewRecipeIngredients.Name = "dataGridViewRecipeIngredients";
            this.dataGridViewRecipeIngredients.RowTemplate.Height = 25;
            this.dataGridViewRecipeIngredients.Size = new System.Drawing.Size(705, 271);
            this.dataGridViewRecipeIngredients.TabIndex = 25;
            this.dataGridViewRecipeIngredients.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRecipeIngredients_CellEndEdit);
            this.dataGridViewRecipeIngredients.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridViewRecipeIngredients_DefaultValuesNeeded);
            this.dataGridViewRecipeIngredients.Enter += new System.EventHandler(this.dataGridViewRecipeIngredients_Enter);
            // 
            // RecipeIngredient
            // 
            this.RecipeIngredient.HeaderText = "Ingredient*";
            this.RecipeIngredient.Name = "RecipeIngredient";
            // 
            // RecipeQuantity
            // 
            this.RecipeQuantity.HeaderText = "Quantity";
            this.RecipeQuantity.Name = "RecipeQuantity";
            // 
            // RecipyMeasurement
            // 
            this.RecipyMeasurement.HeaderText = "Measurement (g)";
            this.RecipyMeasurement.Name = "RecipyMeasurement";
            this.RecipyMeasurement.ReadOnly = true;
            // 
            // RecipeCalories
            // 
            this.RecipeCalories.HeaderText = "Calories";
            this.RecipeCalories.Name = "RecipeCalories";
            // 
            // UpdateRecipe2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonUpdateRecipe2);
            this.Controls.Add(this.labelRecipeIngredients);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.dataGridViewRecipeIngredients);
            this.Name = "UpdateRecipe2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UpdateRecipe2";
            this.Load += new System.EventHandler(this.UpdateRecipe2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecipeIngredients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonUpdateRecipe2;
        private System.Windows.Forms.Label labelRecipeIngredients;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataGridView dataGridViewRecipeIngredients;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecipeIngredient;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecipeQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecipyMeasurement;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecipeCalories;
    }
}