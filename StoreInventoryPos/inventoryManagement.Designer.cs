namespace StoreInventoryPos
{
    partial class inventoryManagement
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
            addButton = new Button();
            modifyButton = new Button();
            viewProduct = new Button();
            backButton = new Button();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.BackColor = Color.LightSteelBlue;
            addButton.Cursor = Cursors.Hand;
            addButton.FlatStyle = FlatStyle.Popup;
            addButton.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addButton.ForeColor = Color.Black;
            addButton.Location = new Point(262, 141);
            addButton.Name = "addButton";
            addButton.Size = new Size(270, 51);
            addButton.TabIndex = 12;
            addButton.Text = "Add Product";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // modifyButton
            // 
            modifyButton.BackColor = Color.LightSteelBlue;
            modifyButton.Cursor = Cursors.Hand;
            modifyButton.FlatStyle = FlatStyle.Popup;
            modifyButton.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            modifyButton.ForeColor = Color.Black;
            modifyButton.Location = new Point(262, 244);
            modifyButton.Name = "modifyButton";
            modifyButton.Size = new Size(270, 51);
            modifyButton.TabIndex = 13;
            modifyButton.Text = "Modify Product";
            modifyButton.UseVisualStyleBackColor = false;
            modifyButton.Click += modifyButton_Click;
            // 
            // viewProduct
            // 
            viewProduct.BackColor = Color.LightSteelBlue;
            viewProduct.Cursor = Cursors.Hand;
            viewProduct.FlatStyle = FlatStyle.Popup;
            viewProduct.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            viewProduct.ForeColor = Color.Black;
            viewProduct.Location = new Point(262, 46);
            viewProduct.Name = "viewProduct";
            viewProduct.Size = new Size(270, 51);
            viewProduct.TabIndex = 14;
            viewProduct.Text = "View Product";
            viewProduct.UseVisualStyleBackColor = false;
            viewProduct.Click += viewProduct_Click;
            // 
            // backButton
            // 
            backButton.BackColor = Color.LightPink;
            backButton.Cursor = Cursors.Hand;
            backButton.FlatStyle = FlatStyle.Popup;
            backButton.Font = new Font("Impact", 19.8F);
            backButton.ForeColor = Color.Crimson;
            backButton.Location = new Point(315, 342);
            backButton.Name = "backButton";
            backButton.Size = new Size(171, 51);
            backButton.TabIndex = 15;
            backButton.Text = "BACK";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // inventoryManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(backButton);
            Controls.Add(viewProduct);
            Controls.Add(modifyButton);
            Controls.Add(addButton);
            Name = "inventoryManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Management";
            ResumeLayout(false);
        }

        #endregion

        private Button addButton;
        private Button modifyButton;
        private Button viewProduct;
        private Button backButton;
    }
}