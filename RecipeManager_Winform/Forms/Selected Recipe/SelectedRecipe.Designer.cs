
namespace RecipeManager_Winform.Forms.Selected_Recipe
{
    partial class SelectedRecipe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelRecipeIngredients = new System.Windows.Forms.Label();
            this.labelRecipeSteps = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewRecipeSteps = new System.Windows.Forms.DataGridView();
            this.Step = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewRecipeIngredients = new System.Windows.Forms.DataGridView();
            this.Ingredient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Measurement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calories = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelRecipeCalories = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelRecipeRating = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelRecipeDuration = new System.Windows.Forms.Label();
            this.labelRecipeDescription = new System.Windows.Forms.Label();
            this.labelRecipeName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecipeSteps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecipeIngredients)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.labelRecipeIngredients);
            this.panel1.Controls.Add(this.labelRecipeSteps);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dataGridViewRecipeSteps);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dataGridViewRecipeIngredients);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.labelRecipeCalories);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelRecipeRating);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelRecipeDuration);
            this.panel1.Controls.Add(this.labelRecipeDescription);
            this.panel1.Controls.Add(this.labelRecipeName);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 1046);
            this.panel1.TabIndex = 0;
            // 
            // labelRecipeIngredients
            // 
            this.labelRecipeIngredients.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRecipeIngredients.AutoSize = true;
            this.labelRecipeIngredients.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRecipeIngredients.Location = new System.Drawing.Point(170, 246);
            this.labelRecipeIngredients.Name = "labelRecipeIngredients";
            this.labelRecipeIngredients.Size = new System.Drawing.Size(19, 21);
            this.labelRecipeIngredients.TabIndex = 16;
            this.labelRecipeIngredients.Text = "0";
            // 
            // labelRecipeSteps
            // 
            this.labelRecipeSteps.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRecipeSteps.AutoSize = true;
            this.labelRecipeSteps.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRecipeSteps.Location = new System.Drawing.Point(119, 637);
            this.labelRecipeSteps.Name = "labelRecipeSteps";
            this.labelRecipeSteps.Size = new System.Drawing.Size(19, 21);
            this.labelRecipeSteps.TabIndex = 15;
            this.labelRecipeSteps.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 991);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewRecipeSteps
            // 
            this.dataGridViewRecipeSteps.AllowUserToDeleteRows = false;
            this.dataGridViewRecipeSteps.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRecipeSteps.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRecipeSteps.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewRecipeSteps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecipeSteps.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Step});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRecipeSteps.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewRecipeSteps.Location = new System.Drawing.Point(71, 662);
            this.dataGridViewRecipeSteps.Name = "dataGridViewRecipeSteps";
            this.dataGridViewRecipeSteps.ReadOnly = true;
            this.dataGridViewRecipeSteps.RowTemplate.Height = 25;
            this.dataGridViewRecipeSteps.Size = new System.Drawing.Size(648, 301);
            this.dataGridViewRecipeSteps.TabIndex = 13;
            // 
            // Step
            // 
            this.Step.HeaderText = "Step";
            this.Step.Name = "Step";
            this.Step.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(66, 637);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "Steps:";
            // 
            // dataGridViewRecipeIngredients
            // 
            this.dataGridViewRecipeIngredients.AllowUserToDeleteRows = false;
            this.dataGridViewRecipeIngredients.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRecipeIngredients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRecipeIngredients.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewRecipeIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecipeIngredients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ingredient,
            this.Quantity,
            this.Measurement,
            this.Calories});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRecipeIngredients.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewRecipeIngredients.Location = new System.Drawing.Point(71, 270);
            this.dataGridViewRecipeIngredients.Name = "dataGridViewRecipeIngredients";
            this.dataGridViewRecipeIngredients.ReadOnly = true;
            this.dataGridViewRecipeIngredients.RowTemplate.Height = 25;
            this.dataGridViewRecipeIngredients.Size = new System.Drawing.Size(648, 301);
            this.dataGridViewRecipeIngredients.TabIndex = 10;
            // 
            // Ingredient
            // 
            this.Ingredient.HeaderText = "Ingredient";
            this.Ingredient.Name = "Ingredient";
            this.Ingredient.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Measurement
            // 
            this.Measurement.HeaderText = "Measurement (g)";
            this.Measurement.Name = "Measurement";
            this.Measurement.ReadOnly = true;
            // 
            // Calories
            // 
            this.Calories.HeaderText = "Calories";
            this.Calories.Name = "Calories";
            this.Calories.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(71, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ingredients:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(440, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Calories:";
            // 
            // labelRecipeCalories
            // 
            this.labelRecipeCalories.AutoSize = true;
            this.labelRecipeCalories.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRecipeCalories.Location = new System.Drawing.Point(521, 175);
            this.labelRecipeCalories.Name = "labelRecipeCalories";
            this.labelRecipeCalories.Size = new System.Drawing.Size(50, 21);
            this.labelRecipeCalories.TabIndex = 6;
            this.labelRecipeCalories.Text = "0 kcal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(260, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Rating:";
            // 
            // labelRecipeRating
            // 
            this.labelRecipeRating.AutoSize = true;
            this.labelRecipeRating.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRecipeRating.Location = new System.Drawing.Point(330, 175);
            this.labelRecipeRating.Name = "labelRecipeRating";
            this.labelRecipeRating.Size = new System.Drawing.Size(19, 21);
            this.labelRecipeRating.TabIndex = 4;
            this.labelRecipeRating.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(71, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Duration:";
            // 
            // labelRecipeDuration
            // 
            this.labelRecipeDuration.AutoSize = true;
            this.labelRecipeDuration.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRecipeDuration.Location = new System.Drawing.Point(159, 175);
            this.labelRecipeDuration.Name = "labelRecipeDuration";
            this.labelRecipeDuration.Size = new System.Drawing.Size(19, 21);
            this.labelRecipeDuration.TabIndex = 2;
            this.labelRecipeDuration.Text = "0";
            // 
            // labelRecipeDescription
            // 
            this.labelRecipeDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRecipeDescription.AutoEllipsis = true;
            this.labelRecipeDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRecipeDescription.Location = new System.Drawing.Point(71, 81);
            this.labelRecipeDescription.Name = "labelRecipeDescription";
            this.labelRecipeDescription.Size = new System.Drawing.Size(648, 73);
            this.labelRecipeDescription.TabIndex = 1;
            this.labelRecipeDescription.Text = "This will be the recipedescription.";
            // 
            // labelRecipeName
            // 
            this.labelRecipeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRecipeName.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRecipeName.Location = new System.Drawing.Point(71, 35);
            this.labelRecipeName.Name = "labelRecipeName";
            this.labelRecipeName.Size = new System.Drawing.Size(648, 37);
            this.labelRecipeName.TabIndex = 0;
            this.labelRecipeName.Text = "Recipename";
            // 
            // SelectedRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(817, 450);
            this.Controls.Add(this.panel1);
            this.Name = "SelectedRecipe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SelectedRecipe";
            this.Load += new System.EventHandler(this.SelectedRecipe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecipeSteps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecipeIngredients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelRecipeCalories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelRecipeRating;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelRecipeDuration;
        private System.Windows.Forms.Label labelRecipeDescription;
        private System.Windows.Forms.Label labelRecipeName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridViewRecipeIngredients;
        private System.Windows.Forms.Label labelRecipeSteps;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewRecipeSteps;
        private System.Windows.Forms.Label labelRecipeIngredients;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ingredient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Measurement;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calories;
        private System.Windows.Forms.DataGridViewTextBoxColumn Step;
    }
}