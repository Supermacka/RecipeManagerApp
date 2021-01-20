
namespace RecipeManager_Winform.Forms
{
    partial class AddRecipe3
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
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddRecipe = new System.Windows.Forms.Button();
            this.labelRecipeSteps = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.dataGridViewRecipeSteps = new System.Windows.Forms.DataGridView();
            this.RecipeSteps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecipeSteps)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(588, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Add the recipe";
            // 
            // buttonAddRecipe
            // 
            this.buttonAddRecipe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddRecipe.Enabled = false;
            this.buttonAddRecipe.Location = new System.Drawing.Point(678, 400);
            this.buttonAddRecipe.Name = "buttonAddRecipe";
            this.buttonAddRecipe.Size = new System.Drawing.Size(75, 23);
            this.buttonAddRecipe.TabIndex = 20;
            this.buttonAddRecipe.Text = "Add";
            this.buttonAddRecipe.UseVisualStyleBackColor = true;
            this.buttonAddRecipe.Click += new System.EventHandler(this.buttonAddRecipe_Click);
            // 
            // labelRecipeSteps
            // 
            this.labelRecipeSteps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRecipeSteps.AutoSize = true;
            this.labelRecipeSteps.Location = new System.Drawing.Point(48, 86);
            this.labelRecipeSteps.Name = "labelRecipeSteps";
            this.labelRecipeSteps.Size = new System.Drawing.Size(35, 15);
            this.labelRecipeSteps.TabIndex = 19;
            this.labelRecipeSteps.Text = "Steps";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(276, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Step 3: Steps";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(48, 28);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(222, 37);
            this.labelTitle.TabIndex = 17;
            this.labelTitle.Text = "Add a new recipe";
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
            this.dataGridViewRecipeSteps.Location = new System.Drawing.Point(48, 106);
            this.dataGridViewRecipeSteps.Name = "dataGridViewRecipeSteps";
            this.dataGridViewRecipeSteps.RowTemplate.Height = 25;
            this.dataGridViewRecipeSteps.Size = new System.Drawing.Size(705, 271);
            this.dataGridViewRecipeSteps.TabIndex = 16;
            this.dataGridViewRecipeSteps.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRecipeSteps_CellEndEdit);
            this.dataGridViewRecipeSteps.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRecipeSteps_RowLeave);
            this.dataGridViewRecipeSteps.Enter += new System.EventHandler(this.dataGridViewRecipeSteps_Enter);
            // 
            // RecipeSteps
            // 
            this.RecipeSteps.HeaderText = "Steps";
            this.RecipeSteps.Name = "RecipeSteps";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCancel.Location = new System.Drawing.Point(48, 400);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 24;
            this.buttonCancel.Text = "Back";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // AddRecipe3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAddRecipe);
            this.Controls.Add(this.labelRecipeSteps);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.dataGridViewRecipeSteps);
            this.Name = "AddRecipe3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddRecipe3";
            this.Load += new System.EventHandler(this.AddRecipe3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecipeSteps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddRecipe;
        private System.Windows.Forms.Label labelRecipeSteps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataGridView dataGridViewRecipeSteps;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecipeSteps;
        private System.Windows.Forms.Button buttonCancel;
    }
}