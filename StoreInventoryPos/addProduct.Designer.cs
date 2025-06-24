namespace StoreInventoryPos
{
    partial class addProduct
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
            nameLabel = new Label();
            sizeBox = new ComboBox();
            backButton = new Button();
            priceField = new TextBox();
            priceLabel = new Label();
            addButton = new Button();
            sizeLabel = new Label();
            costField = new TextBox();
            costLabel = new Label();
            productName = new Label();
            pNameField = new TextBox();
            quantityLabel = new Label();
            quantityField = new TextBox();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = Color.Transparent;
            nameLabel.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameLabel.ForeColor = Color.IndianRed;
            nameLabel.Location = new Point(284, 20);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(249, 42);
            nameLabel.TabIndex = 8;
            nameLabel.Text = "Add New Product";
            nameLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // sizeBox
            // 
            sizeBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            sizeBox.FormattingEnabled = true;
            sizeBox.DropDownStyle = ComboBoxStyle.DropDownList;
            sizeBox.Items.AddRange(new object[] { "38", "39", "40", "41", "42", "43", "44" });
            sizeBox.Location = new Point(388, 288);
            sizeBox.Name = "sizeBox";
            sizeBox.Size = new Size(163, 28);
            sizeBox.Sorted = true;
            sizeBox.TabIndex = 34;
            // 
            // backButton
            // 
            backButton.BackColor = Color.White;
            backButton.Cursor = Cursors.Hand;
            backButton.FlatStyle = FlatStyle.Popup;
            backButton.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            backButton.ForeColor = Color.Crimson;
            backButton.Location = new Point(667, 37);
            backButton.Name = "backButton";
            backButton.Size = new Size(112, 51);
            backButton.TabIndex = 33;
            backButton.Text = "BACK";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // priceField
            // 
            priceField.BorderStyle = BorderStyle.FixedSingle;
            priceField.Location = new Point(386, 210);
            priceField.Name = "priceField";
            priceField.Size = new Size(290, 27);
            priceField.TabIndex = 32;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            priceLabel.Location = new Point(386, 179);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(61, 28);
            priceLabel.TabIndex = 31;
            priceLabel.Text = "Price";
            // 
            // addButton
            // 
            addButton.BackColor = Color.White;
            addButton.Cursor = Cursors.Hand;
            addButton.FlatStyle = FlatStyle.Popup;
            addButton.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addButton.ForeColor = Color.Crimson;
            addButton.Location = new Point(264, 361);
            addButton.Name = "addButton";
            addButton.Size = new Size(290, 51);
            addButton.TabIndex = 30;
            addButton.Text = "ADD";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // sizeLabel
            // 
            sizeLabel.AutoSize = true;
            sizeLabel.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sizeLabel.Location = new Point(388, 257);
            sizeLabel.Name = "sizeLabel";
            sizeLabel.Size = new Size(50, 28);
            sizeLabel.TabIndex = 29;
            sizeLabel.Text = "Size";
            // 
            // costField
            // 
            costField.BorderStyle = BorderStyle.FixedSingle;
            costField.Location = new Point(60, 210);
            costField.Name = "costField";
            costField.Size = new Size(290, 27);
            costField.TabIndex = 28;
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            costLabel.Location = new Point(60, 179);
            costLabel.Name = "costLabel";
            costLabel.Size = new Size(55, 28);
            costLabel.TabIndex = 27;
            costLabel.Text = "Cost";
            // 
            // productName
            // 
            productName.AutoSize = true;
            productName.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productName.Location = new Point(60, 88);
            productName.Name = "productName";
            productName.Size = new Size(144, 28);
            productName.TabIndex = 24;
            productName.Text = "Product Name";
            // 
            // pNameField
            // 
            pNameField.BorderStyle = BorderStyle.FixedSingle;
            pNameField.Location = new Point(60, 119);
            pNameField.Name = "pNameField";
            pNameField.Size = new Size(616, 27);
            pNameField.TabIndex = 23;
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            quantityLabel.Location = new Point(56, 257);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(91, 28);
            quantityLabel.TabIndex = 35;
            quantityLabel.Text = "Quantity";
            // 
            // quantityField
            // 
            quantityField.BorderStyle = BorderStyle.FixedSingle;
            quantityField.Location = new Point(60, 288);
            quantityField.Name = "quantityField";
            quantityField.Size = new Size(290, 27);
            quantityField.TabIndex = 36;
            // 
            // addProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(quantityField);
            Controls.Add(quantityLabel);
            Controls.Add(sizeBox);
            Controls.Add(backButton);
            Controls.Add(priceField);
            Controls.Add(priceLabel);
            Controls.Add(addButton);
            Controls.Add(sizeLabel);
            Controls.Add(costField);
            Controls.Add(costLabel);
            Controls.Add(productName);
            Controls.Add(pNameField);
            Controls.Add(nameLabel);
            Name = "addProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Product";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private ComboBox sizeBox;
        private Button backButton;
        private TextBox priceField;
        private Label priceLabel;
        private Button addButton;
        private Label sizeLabel;
        private TextBox costField;
        private Label costLabel;
        private Label productName;
        private TextBox pNameField;
        private Label quantityLabel;
        private TextBox quantityField;
    }
}