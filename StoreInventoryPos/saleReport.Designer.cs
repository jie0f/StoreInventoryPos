namespace StoreInventoryPos
{
    partial class saleReport
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
            searchField = new TextBox();
            searchLabel = new Label();
            clearButton = new Button();
            backButton = new Button();
            searchGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)searchGrid).BeginInit();
            SuspendLayout();
            // 
            // searchField
            // 
            searchField.BackColor = SystemColors.ControlLightLight;
            searchField.BorderStyle = BorderStyle.FixedSingle;
            searchField.Font = new Font("Segoe UI", 13.8F);
            searchField.Location = new Point(149, 19);
            searchField.Margin = new Padding(3, 2, 3, 2);
            searchField.Multiline = true;
            searchField.Name = "searchField";
            searchField.Size = new Size(384, 31);
            searchField.TabIndex = 44;
            searchField.TextChanged += searchField_TextChanged;
            // 
            // searchLabel
            // 
            searchLabel.BackColor = SystemColors.ActiveCaption;
            searchLabel.Font = new Font("Impact", 19.8F);
            searchLabel.Location = new Point(44, 19);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(111, 31);
            searchLabel.TabIndex = 43;
            searchLabel.Text = "Search :";
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.Black;
            clearButton.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clearButton.ForeColor = Color.White;
            clearButton.Location = new Point(539, 19);
            clearButton.Margin = new Padding(3, 2, 3, 2);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(78, 31);
            clearButton.TabIndex = 42;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click_1;
            // 
            // backButton
            // 
            backButton.BackColor = Color.White;
            backButton.Font = new Font("Impact", 18F);
            backButton.ForeColor = Color.Crimson;
            backButton.Location = new Point(989, 19);
            backButton.Margin = new Padding(3, 2, 3, 2);
            backButton.Name = "backButton";
            backButton.Size = new Size(105, 38);
            backButton.TabIndex = 41;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // searchGrid
            // 
            searchGrid.AllowUserToAddRows = false;
            searchGrid.AllowUserToDeleteRows = false;
            searchGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            searchGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            searchGrid.Location = new Point(44, 64);
            searchGrid.Margin = new Padding(3, 2, 3, 2);
            searchGrid.Name = "searchGrid";
            searchGrid.ReadOnly = true;
            searchGrid.RowHeadersVisible = false;
            searchGrid.RowHeadersWidth = 51;
            searchGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            searchGrid.Size = new Size(1050, 300);
            searchGrid.TabIndex = 38;
            // 
            // saleReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 435);
            Controls.Add(searchField);
            Controls.Add(searchLabel);
            Controls.Add(clearButton);
            Controls.Add(backButton);
            Controls.Add(searchGrid);
            Margin = new Padding(3, 2, 3, 2);
            Name = "saleReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sales Report";
            ((System.ComponentModel.ISupportInitialize)searchGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox searchField;
        private Label searchLabel;
        private Button clearButton;
        private Button backButton;
        private DataGridView searchGrid;
    }
}