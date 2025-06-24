namespace StoreInventoryPos
{
    partial class modifyProduct
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
            SearchLabel = new Label();
            backButton = new Button();
            searchGrid = new DataGridView();
            sizeBox = new ComboBox();
            roleLabel = new Label();
            updateButton = new Button();
            deleteButton = new Button();
            costField = new TextBox();
            costLabel = new Label();
            productIDlabel = new Label();
            productNameLabel = new Label();
            searchField = new TextBox();
            label1 = new Label();
            QuantityField = new TextBox();
            priceField = new TextBox();
            quantityLabel = new Label();
            priceLabel = new Label();
            ProductNameField = new TextBox();
            productIDField = new TextBox();
            clearButton = new Button();
            ((System.ComponentModel.ISupportInitialize)searchGrid).BeginInit();
            SuspendLayout();
            // 
            // SearchLabel
            // 
            SearchLabel.AutoSize = true;
            SearchLabel.BackColor = SystemColors.ActiveCaption;
            SearchLabel.Font = new Font("Impact", 19.8F);
            SearchLabel.Location = new Point(-194, 27);
            SearchLabel.Name = "SearchLabel";
            SearchLabel.Size = new Size(127, 41);
            SearchLabel.TabIndex = 31;
            SearchLabel.Text = "Search :";
            // 
            // backButton
            // 
            backButton.BackColor = Color.White;
            backButton.Cursor = Cursors.Hand;
            backButton.FlatStyle = FlatStyle.Popup;
            backButton.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            backButton.ForeColor = Color.Crimson;
            backButton.Location = new Point(1241, 47);
            backButton.Name = "backButton";
            backButton.Size = new Size(112, 51);
            backButton.TabIndex = 73;
            backButton.Text = "BACK";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // searchGrid
            // 
            searchGrid.AllowUserToAddRows = false;
            searchGrid.AllowUserToDeleteRows = false;
            searchGrid.AllowUserToResizeRows = false;
            searchGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            searchGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            searchGrid.Location = new Point(69, 109);
            searchGrid.MultiSelect = false;
            searchGrid.Name = "searchGrid";
            searchGrid.ReadOnly = true;
            searchGrid.RowHeadersVisible = false;
            searchGrid.RowHeadersWidth = 51;
            searchGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            searchGrid.Size = new Size(842, 415);
            searchGrid.TabIndex = 72;
            searchGrid.CellClick += searchGrid_CellClick;
            // 
            // sizeBox
            // 
            sizeBox.DropDownStyle = ComboBoxStyle.DropDownList;
            sizeBox.FormattingEnabled = true;
            sizeBox.Items.AddRange(new object[] { "38", "39", "40", "41", "42", "43", "44" });
            sizeBox.Location = new Point(1097, 467);
            sizeBox.Name = "sizeBox";
            sizeBox.Size = new Size(163, 28);
            sizeBox.TabIndex = 70;
            // 
            // roleLabel
            // 
            roleLabel.BorderStyle = BorderStyle.FixedSingle;
            roleLabel.Font = new Font("Impact", 13.8F);
            roleLabel.Location = new Point(1047, 467);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(52, 28);
            roleLabel.TabIndex = 69;
            roleLabel.Text = "Size";
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.FromArgb(128, 255, 128);
            updateButton.Cursor = Cursors.Hand;
            updateButton.FlatStyle = FlatStyle.Popup;
            updateButton.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateButton.ForeColor = Color.Black;
            updateButton.Location = new Point(997, 552);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(158, 48);
            updateButton.TabIndex = 68;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.Red;
            deleteButton.Cursor = Cursors.Hand;
            deleteButton.FlatStyle = FlatStyle.Popup;
            deleteButton.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteButton.ForeColor = Color.LavenderBlush;
            deleteButton.Location = new Point(1194, 552);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(158, 48);
            deleteButton.TabIndex = 67;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // costField
            // 
            costField.BackColor = SystemColors.ControlLightLight;
            costField.BorderStyle = BorderStyle.FixedSingle;
            costField.Font = new Font("Segoe UI", 13.8F);
            costField.Location = new Point(1096, 265);
            costField.Multiline = true;
            costField.Name = "costField";
            costField.Size = new Size(257, 43);
            costField.TabIndex = 66;
            // 
            // costLabel
            // 
            costLabel.BackColor = Color.Transparent;
            costLabel.BorderStyle = BorderStyle.FixedSingle;
            costLabel.FlatStyle = FlatStyle.Flat;
            costLabel.Font = new Font("Impact", 19.8F);
            costLabel.Location = new Point(968, 265);
            costLabel.Name = "costLabel";
            costLabel.Size = new Size(131, 43);
            costLabel.TabIndex = 63;
            costLabel.Text = "Cost";
            // 
            // productIDlabel
            // 
            productIDlabel.BackColor = Color.Transparent;
            productIDlabel.BorderStyle = BorderStyle.FixedSingle;
            productIDlabel.FlatStyle = FlatStyle.Flat;
            productIDlabel.Font = new Font("Impact", 19.8F);
            productIDlabel.Location = new Point(968, 124);
            productIDlabel.Name = "productIDlabel";
            productIDlabel.Size = new Size(131, 45);
            productIDlabel.TabIndex = 62;
            productIDlabel.Text = "Product ID";
            // 
            // productNameLabel
            // 
            productNameLabel.BackColor = Color.Transparent;
            productNameLabel.BorderStyle = BorderStyle.FixedSingle;
            productNameLabel.FlatStyle = FlatStyle.Flat;
            productNameLabel.Font = new Font("Impact", 19.8F);
            productNameLabel.Location = new Point(968, 195);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new Size(131, 43);
            productNameLabel.TabIndex = 61;
            productNameLabel.Text = "Name";
            // 
            // searchField
            // 
            searchField.BackColor = SystemColors.ControlLightLight;
            searchField.BorderStyle = BorderStyle.FixedSingle;
            searchField.Font = new Font("Segoe UI", 13.8F);
            searchField.Location = new Point(195, 47);
            searchField.Multiline = true;
            searchField.Name = "searchField";
            searchField.Size = new Size(715, 41);
            searchField.TabIndex = 60;
            searchField.TextChanged += searchField_TextChanged;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Impact", 19.8F);
            label1.Location = new Point(75, 47);
            label1.Name = "label1";
            label1.Size = new Size(127, 41);
            label1.TabIndex = 74;
            label1.Text = "Search :";
            // 
            // QuantityField
            // 
            QuantityField.BackColor = SystemColors.ControlLightLight;
            QuantityField.BorderStyle = BorderStyle.FixedSingle;
            QuantityField.Font = new Font("Segoe UI", 13.8F);
            QuantityField.Location = new Point(1097, 408);
            QuantityField.Multiline = true;
            QuantityField.Name = "QuantityField";
            QuantityField.Size = new Size(256, 43);
            QuantityField.TabIndex = 78;
            // 
            // priceField
            // 
            priceField.BackColor = SystemColors.ControlLightLight;
            priceField.BorderStyle = BorderStyle.FixedSingle;
            priceField.Font = new Font("Segoe UI", 13.8F);
            priceField.Location = new Point(1097, 339);
            priceField.Multiline = true;
            priceField.Name = "priceField";
            priceField.Size = new Size(256, 43);
            priceField.TabIndex = 77;
            // 
            // quantityLabel
            // 
            quantityLabel.BackColor = Color.Transparent;
            quantityLabel.BorderStyle = BorderStyle.FixedSingle;
            quantityLabel.FlatStyle = FlatStyle.Flat;
            quantityLabel.Font = new Font("Impact", 19.8F);
            quantityLabel.Location = new Point(968, 408);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(138, 43);
            quantityLabel.TabIndex = 76;
            quantityLabel.Text = "Quantity";
            // 
            // priceLabel
            // 
            priceLabel.BackColor = Color.Transparent;
            priceLabel.BorderStyle = BorderStyle.FixedSingle;
            priceLabel.FlatStyle = FlatStyle.Flat;
            priceLabel.Font = new Font("Impact", 19.8F);
            priceLabel.Location = new Point(968, 339);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(138, 43);
            priceLabel.TabIndex = 75;
            priceLabel.Text = "Price";
            // 
            // ProductNameField
            // 
            ProductNameField.BackColor = SystemColors.ControlLightLight;
            ProductNameField.BorderStyle = BorderStyle.FixedSingle;
            ProductNameField.Font = new Font("Segoe UI", 13.8F);
            ProductNameField.Location = new Point(1096, 195);
            ProductNameField.Multiline = true;
            ProductNameField.Name = "ProductNameField";
            ProductNameField.Size = new Size(256, 43);
            ProductNameField.TabIndex = 65;
            // 
            // productIDField
            // 
            productIDField.BackColor = SystemColors.Info;
            productIDField.BorderStyle = BorderStyle.FixedSingle;
            productIDField.Font = new Font("Segoe UI", 13.8F);
            productIDField.Location = new Point(1096, 124);
            productIDField.Multiline = true;
            productIDField.Name = "productIDField";
            productIDField.ReadOnly = true;
            productIDField.Size = new Size(257, 45);
            productIDField.TabIndex = 79;
            // 
            // clearButton
            // 
            clearButton.BackColor = SystemColors.WindowText;
            clearButton.Cursor = Cursors.Hand;
            clearButton.FlatStyle = FlatStyle.Popup;
            clearButton.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clearButton.ForeColor = Color.LavenderBlush;
            clearButton.Location = new Point(1096, 636);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(158, 48);
            clearButton.TabIndex = 80;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // modifyProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1403, 757);
            Controls.Add(clearButton);
            Controls.Add(productIDField);
            Controls.Add(QuantityField);
            Controls.Add(priceField);
            Controls.Add(quantityLabel);
            Controls.Add(priceLabel);
            Controls.Add(label1);
            Controls.Add(backButton);
            Controls.Add(searchGrid);
            Controls.Add(sizeBox);
            Controls.Add(roleLabel);
            Controls.Add(updateButton);
            Controls.Add(deleteButton);
            Controls.Add(costField);
            Controls.Add(ProductNameField);
            Controls.Add(costLabel);
            Controls.Add(productIDlabel);
            Controls.Add(productNameLabel);
            Controls.Add(searchField);
            Controls.Add(SearchLabel);
            Name = "modifyProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modify Product";
            ((System.ComponentModel.ISupportInitialize)searchGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SearchLabel;
        private Button backButton;
        private DataGridView searchGrid;
        private ComboBox sizeBox;
        private Label roleLabel;
        private Button updateButton;
        private Button deleteButton;
        private TextBox costField;
        private TextBox fullNameField;
        private TextBox userNameField;
        private Label costLabel;
        private Label productIDlabel;
        private Label productNameLabel;
        private TextBox searchField;
        private Label label1;
        private TextBox QuantityField;
        private TextBox priceField;
        private Label quantityLabel;
        private Label priceLabel;
        private TextBox ProductNameField;
        private TextBox productIDField;
        private Button clearButton;
    }
}