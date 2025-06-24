namespace StoreInventoryPos
{
    partial class staffInventory
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
            backButton = new Button();
            searchGrid = new DataGridView();
            searchField = new TextBox();
            SearchLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)searchGrid).BeginInit();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.BackColor = Color.White;
            backButton.Cursor = Cursors.Hand;
            backButton.FlatStyle = FlatStyle.Popup;
            backButton.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            backButton.ForeColor = Color.Crimson;
            backButton.Location = new Point(930, 36);
            backButton.Name = "backButton";
            backButton.Size = new Size(112, 51);
            backButton.TabIndex = 43;
            backButton.Text = "BACK";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click_1;
            // 
            // searchGrid
            // 
            searchGrid.AllowUserToAddRows = false;
            searchGrid.AllowUserToDeleteRows = false;
            searchGrid.AllowUserToResizeRows = false;
            searchGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            searchGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            searchGrid.ColumnHeadersVisible = false;
            searchGrid.Location = new Point(30, 104);
            searchGrid.MultiSelect = false;
            searchGrid.Name = "searchGrid";
            searchGrid.ReadOnly = true;
            searchGrid.RowHeadersVisible = false;
            searchGrid.RowHeadersWidth = 51;
            searchGrid.ScrollBars = ScrollBars.Vertical;
            searchGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            searchGrid.Size = new Size(879, 415);
            searchGrid.TabIndex = 42;
            // 
            // searchField
            // 
            searchField.BackColor = SystemColors.ControlLightLight;
            searchField.BorderStyle = BorderStyle.FixedSingle;
            searchField.Font = new Font("Segoe UI", 13.8F);
            searchField.Location = new Point(154, 48);
            searchField.Multiline = true;
            searchField.Name = "searchField";
            searchField.Size = new Size(754, 41);
            searchField.TabIndex = 41;
            searchField.TextChanged += searchField_TextChanged;
            // 
            // SearchLabel
            // 
            SearchLabel.AutoSize = true;
            SearchLabel.BackColor = SystemColors.ActiveCaption;
            SearchLabel.Font = new Font("Impact", 19.8F);
            SearchLabel.Location = new Point(30, 48);
            SearchLabel.Name = "SearchLabel";
            SearchLabel.Size = new Size(127, 41);
            SearchLabel.TabIndex = 40;
            SearchLabel.Text = "Search :";
            // 
            // staffInventory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 605);
            Controls.Add(backButton);
            Controls.Add(searchGrid);
            Controls.Add(searchField);
            Controls.Add(SearchLabel);
            Name = "staffInventory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory";
            ((System.ComponentModel.ISupportInitialize)searchGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backButton;
        private DataGridView searchGrid;
        private TextBox searchField;
        private Label SearchLabel;
    }
}