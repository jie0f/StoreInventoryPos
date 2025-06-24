namespace StoreInventoryPos
{
    partial class selectionCart
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
            productGrid = new DataGridView();
            searchField = new TextBox();
            label1 = new Label();
            clearButton = new Button();
            nextButton = new Button();
            backButton = new Button();
            cart = new Label();
            removeButton = new Button();
            addButton = new Button();
            cartGrid = new DataGridView();
            cartTotalLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)productGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cartGrid).BeginInit();
            SuspendLayout();
            // 
            // productGrid
            // 
            productGrid.AllowUserToAddRows = false;
            productGrid.AllowUserToDeleteRows = false;
            productGrid.AllowUserToResizeColumns = false;
            productGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productGrid.CausesValidation = false;
            productGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productGrid.Location = new Point(19, 73);
            productGrid.Margin = new Padding(3, 2, 3, 2);
            productGrid.Name = "productGrid";
            productGrid.ReadOnly = true;
            productGrid.RowHeadersVisible = false;
            productGrid.RowHeadersWidth = 51;
            productGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productGrid.Size = new Size(561, 308);
            productGrid.TabIndex = 0;
            // 
            // searchField
            // 
            searchField.BackColor = SystemColors.ControlLightLight;
            searchField.BorderStyle = BorderStyle.FixedSingle;
            searchField.Font = new Font("Segoe UI", 13.8F);
            searchField.Location = new Point(126, 32);
            searchField.Margin = new Padding(3, 2, 3, 2);
            searchField.Multiline = true;
            searchField.Name = "searchField";
            searchField.Size = new Size(454, 31);
            searchField.TabIndex = 39;
            searchField.TextChanged += searchField_TextChanged_1;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Impact", 18.8F);
            label1.Location = new Point(19, 32);
            label1.Name = "label1";
            label1.Size = new Size(110, 31);
            label1.TabIndex = 38;
            label1.Text = "Search :";
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.Black;
            clearButton.Cursor = Cursors.Hand;
            clearButton.Font = new Font("Impact", 18F);
            clearButton.ForeColor = Color.White;
            clearButton.Location = new Point(156, 401);
            clearButton.Margin = new Padding(3, 2, 3, 2);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(131, 38);
            clearButton.TabIndex = 42;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // nextButton
            // 
            nextButton.BackColor = Color.LightSkyBlue;
            nextButton.Cursor = Cursors.Hand;
            nextButton.Font = new Font("Impact", 18F);
            nextButton.Location = new Point(19, 401);
            nextButton.Margin = new Padding(3, 2, 3, 2);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(131, 38);
            nextButton.TabIndex = 40;
            nextButton.Text = "Next";
            nextButton.UseVisualStyleBackColor = false;
            nextButton.Click += nextButton_Click;
            // 
            // backButton
            // 
            backButton.BackColor = Color.Snow;
            backButton.Cursor = Cursors.Hand;
            backButton.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            backButton.ForeColor = Color.Crimson;
            backButton.Location = new Point(292, 401);
            backButton.Margin = new Padding(3, 2, 3, 2);
            backButton.Name = "backButton";
            backButton.Size = new Size(131, 38);
            backButton.TabIndex = 43;
            backButton.Text = "BACK";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // cart
            // 
            cart.BackColor = SystemColors.Desktop;
            cart.Font = new Font("Impact", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cart.ForeColor = Color.FloralWhite;
            cart.Location = new Point(744, 19);
            cart.Name = "cart";
            cart.Size = new Size(438, 52);
            cart.TabIndex = 44;
            cart.Text = "Cart";
            cart.TextAlign = ContentAlignment.TopCenter;
            // 
            // removeButton
            // 
            removeButton.AutoSize = true;
            removeButton.BackColor = Color.Firebrick;
            removeButton.Cursor = Cursors.Hand;
            removeButton.Font = new Font("Impact", 18F);
            removeButton.ForeColor = Color.White;
            removeButton.Location = new Point(597, 221);
            removeButton.Margin = new Padding(3, 2, 3, 2);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(141, 39);
            removeButton.TabIndex = 46;
            removeButton.Text = "<<Remove";
            removeButton.UseVisualStyleBackColor = false;
            // 
            // addButton
            // 
            addButton.AutoSize = true;
            addButton.BackColor = Color.OliveDrab;
            addButton.Cursor = Cursors.Hand;
            addButton.Font = new Font("Impact", 18F);
            addButton.Location = new Point(597, 145);
            addButton.Margin = new Padding(3, 2, 3, 2);
            addButton.Name = "addButton";
            addButton.Size = new Size(141, 39);
            addButton.TabIndex = 45;
            addButton.Text = "ADD>>";
            addButton.UseVisualStyleBackColor = false;
            // 
            // cartGrid
            // 
            cartGrid.AllowUserToAddRows = false;
            cartGrid.AllowUserToDeleteRows = false;
            cartGrid.AllowUserToResizeColumns = false;
            cartGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cartGrid.Location = new Point(744, 73);
            cartGrid.Margin = new Padding(3, 2, 3, 2);
            cartGrid.Name = "cartGrid";
            cartGrid.ReadOnly = true;
            cartGrid.RowHeadersVisible = false;
            cartGrid.RowHeadersWidth = 51;
            cartGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            cartGrid.Size = new Size(438, 254);
            cartGrid.TabIndex = 1;
            // 
            // cartTotalLabel
            // 
            cartTotalLabel.BackColor = SystemColors.Desktop;
            cartTotalLabel.Font = new Font("Impact", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cartTotalLabel.ForeColor = Color.FloralWhite;
            cartTotalLabel.Location = new Point(744, 329);
            cartTotalLabel.Name = "cartTotalLabel";
            cartTotalLabel.Size = new Size(438, 52);
            cartTotalLabel.TabIndex = 48;
            cartTotalLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // selectionCart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1205, 484);
            Controls.Add(cartTotalLabel);
            Controls.Add(removeButton);
            Controls.Add(addButton);
            Controls.Add(cart);
            Controls.Add(backButton);
            Controls.Add(clearButton);
            Controls.Add(nextButton);
            Controls.Add(searchField);
            Controls.Add(label1);
            Controls.Add(cartGrid);
            Controls.Add(productGrid);
            Margin = new Padding(3, 2, 3, 2);
            Name = "selectionCart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product Selection";
            ((System.ComponentModel.ISupportInitialize)productGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)cartGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView productGrid;
        private TextBox searchField;
        private Label label1;
        private Button clearButton;
        private Button nextButton;
        private Button backButton;
        private Label cart;
        private Button removeButton;
        private Button addButton;
        private DataGridView cartGrid;
        private Label cartTotalLabel;
    }
}