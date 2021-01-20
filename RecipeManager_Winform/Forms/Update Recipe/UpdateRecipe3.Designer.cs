
namespace RecipeManager_Winform.Forms.Update_Recipe
{
    partial class UpdateRecipe3
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonUpdateRecipe = new System.Windows.Forms.Button();
            this.labelRecipeSteps = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.dataGridViewRecipeSteps = new System.Windows.Forms.DataGridView();
            this.RecipeSteps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecipeSteps)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCancel.Location = new System.Drawing.Point(48, 400);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 31;
            this.buttonCancel.Text = "Back";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(571, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 30;
            this.label2.Text = "Update the recipe";
            // 
            // buttonUpdateRecipe
            // 
            this.buttonUpdateRecipe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdateRecipe.Enabled = false;
            this.buttonUpdateRecipe.Location = new System.Drawing.Point(678, 400);
            this.buttonUpdateRecipe.Name = "buttonUpdateRecipe";
            this.buttonUpdateRecipe.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateRecipe.TabIndex = 29;
            this.buttonUpdateRecipe.Text = "Update";
            this.buttonUpdateRecipe.UseVisualStyleBackColor = true;
            this.buttonUpdateRecipe.Click += new System.EventHandler(this.ButtonUpdateRecipe_Click);
            // 
            // labelRecipeSteps
            // 
            this.labelRecipeSteps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRecipeSteps.AutoSize = true;
            this.labelRecipeSteps.Location = new System.Drawing.Point(48, 86);
            this.labelRecipeSteps.Name = "labelRecipeSteps";
            this.labelRecipeSteps.Size = new System.Drawing.Size(47, 15);
            this.labelRecipeSteps.TabIndex = 28;
            this.labelRecipeSteps.Text = "Steps: 0";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(48, 28);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(297, 37);
            this.labelTitle.TabIndex = 26;
            this.labelTitle.Text = "Update the recipe steps";
            // 
            // dataGridViewRecipeSteps
            // 
            this.dataGridViewRecipeSteps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRecipeSteps.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRecipeSteps.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewRecipeSteps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecipeSteps.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RecipeSteps});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRecipeSteps.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewRecipeSteps.Location = new System.Drawing.Point(48, 104);
            this.dataGridViewRecipeSteps.Name = "dataGridViewRecipeSteps";
            this.dataGridViewRecipeSteps.RowTemplate.Height = 25;
            this.dataGridViewRecipeSteps.Size = new System.Drawing.Size(705, 271);
            this.dataGridViewRecipeSteps.TabIndex = 25;
            this.dataGridViewRecipeSteps.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRecipeSteps_CellEndEdit);
            this.dataGridViewRecipeSteps.Enter += new System.EventHandler(this.dataGridViewRecipeSteps_Enter);
            // 
            // RecipeSteps
            // 
            this.RecipeSteps.HeaderText = "Steps";
            this.RecipeSteps.Name = "RecipeSteps";
            // 
            // UpdateRecipe3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonUpdateRecipe);
            this.Controls.Add(this.labelRecipeSteps);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.dataGridViewRecipeSteps);
            this.Name = "UpdateRecipe3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UpdateRecipe3";
            this.Load += new System.EventHandler(this.UpdateRecipe3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecipeSteps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonUpdateRecipe;
        private System.Windows.Forms.Label labelRecipeSteps;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataGridView dataGridViewRecipeSteps;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecipeSteps;
    }
}