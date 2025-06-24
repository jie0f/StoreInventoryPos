namespace StoreInventoryPos
{
    partial class PromoCode
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
            promoField = new TextBox();
            label1 = new Label();
            backButton = new Button();
            searchGrid = new DataGridView();
            deleteButton = new Button();
            discountField = new TextBox();
            promoLabel = new Label();
            discountLabl = new Label();
            deleteLabl = new Label();
            deletePanel = new Panel();
            searchField = new TextBox();
            createPanel = new Panel();
            label5 = new Label();
            promoBox = new TextBox();
            label6 = new Label();
            addButton = new Button();
            discountBox = new TextBox();
            label7 = new Label();
            clearButton = new Button();
            updatePanel = new Panel();
            label2 = new Label();
            label3 = new Label();
            UdiscountField = new TextBox();
            label4 = new Label();
            updateButton = new Button();
            UpromoField = new TextBox();
            ((System.ComponentModel.ISupportInitialize)searchGrid).BeginInit();
            deletePanel.SuspendLayout();
            createPanel.SuspendLayout();
            updatePanel.SuspendLayout();
            SuspendLayout();
            // 
            // promoField
            // 
            promoField.BackColor = SystemColors.Info;
            promoField.BorderStyle = BorderStyle.FixedSingle;
            promoField.Font = new Font("Segoe UI", 13.8F);
            promoField.Location = new Point(237, 63);
            promoField.Multiline = true;
            promoField.Name = "promoField";
            promoField.ReadOnly = true;
            promoField.Size = new Size(189, 42);
            promoField.TabIndex = 91;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Impact", 19.8F);
            label1.Location = new Point(26, 67);
            label1.Name = "label1";
            label1.Size = new Size(127, 41);
            label1.TabIndex = 88;
            label1.Text = "Search :";
            // 
            // backButton
            // 
            backButton.BackColor = Color.White;
            backButton.Cursor = Cursors.Hand;
            backButton.FlatStyle = FlatStyle.Popup;
            backButton.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            backButton.ForeColor = Color.Crimson;
            backButton.Location = new Point(907, 9);
            backButton.Name = "backButton";
            backButton.Size = new Size(149, 51);
            backButton.TabIndex = 87;
            backButton.Text = "BACK";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // searchGrid
            // 
            searchGrid.AllowUserToAddRows = false;
            searchGrid.AllowUserToDeleteRows = false;
            searchGrid.AllowUserToResizeColumns = false;
            searchGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            searchGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            searchGrid.Location = new Point(26, 123);
            searchGrid.MultiSelect = false;
            searchGrid.Name = "searchGrid";
            searchGrid.ReadOnly = true;
            searchGrid.RowHeadersVisible = false;
            searchGrid.RowHeadersWidth = 51;
            searchGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            searchGrid.Size = new Size(485, 203);
            searchGrid.TabIndex = 86;
            searchGrid.CellClick += searchGrid_CellClick_1;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.Red;
            deleteButton.Cursor = Cursors.Hand;
            deleteButton.FlatStyle = FlatStyle.Popup;
            deleteButton.Font = new Font("Impact", 18F);
            deleteButton.ForeColor = Color.LavenderBlush;
            deleteButton.Location = new Point(174, 205);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(158, 48);
            deleteButton.TabIndex = 83;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // discountField
            // 
            discountField.BackColor = SystemColors.Info;
            discountField.BorderStyle = BorderStyle.FixedSingle;
            discountField.Font = new Font("Segoe UI", 13.8F);
            discountField.Location = new Point(237, 124);
            discountField.Multiline = true;
            discountField.Name = "discountField";
            discountField.ReadOnly = true;
            discountField.Size = new Size(189, 42);
            discountField.TabIndex = 81;
            // 
            // promoLabel
            // 
            promoLabel.AutoSize = true;
            promoLabel.BackColor = Color.Transparent;
            promoLabel.Font = new Font("Impact", 19.8F);
            promoLabel.Location = new Point(14, 63);
            promoLabel.Name = "promoLabel";
            promoLabel.Size = new Size(175, 41);
            promoLabel.TabIndex = 80;
            promoLabel.Text = "PromoCode";
            // 
            // discountLabl
            // 
            discountLabl.AutoSize = true;
            discountLabl.BackColor = Color.Transparent;
            discountLabl.Font = new Font("Impact", 19.8F);
            discountLabl.Location = new Point(51, 124);
            discountLabl.Name = "discountLabl";
            discountLabl.Size = new Size(138, 41);
            discountLabl.TabIndex = 92;
            discountLabl.Text = "Discount";
            // 
            // deleteLabl
            // 
            deleteLabl.AutoSize = true;
            deleteLabl.BackColor = Color.Transparent;
            deleteLabl.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteLabl.ForeColor = Color.IndianRed;
            deleteLabl.Location = new Point(161, 9);
            deleteLabl.Name = "deleteLabl";
            deleteLabl.Size = new Size(202, 42);
            deleteLabl.TabIndex = 93;
            deleteLabl.Text = "Delete Promo";
            deleteLabl.TextAlign = ContentAlignment.TopCenter;
            // 
            // deletePanel
            // 
            deletePanel.BackColor = Color.LemonChiffon;
            deletePanel.Controls.Add(promoLabel);
            deletePanel.Controls.Add(deleteLabl);
            deletePanel.Controls.Add(discountField);
            deletePanel.Controls.Add(discountLabl);
            deletePanel.Controls.Add(deleteButton);
            deletePanel.Controls.Add(promoField);
            deletePanel.Location = new Point(567, 377);
            deletePanel.Name = "deletePanel";
            deletePanel.Size = new Size(485, 276);
            deletePanel.TabIndex = 94;
            // 
            // searchField
            // 
            searchField.BackColor = SystemColors.ControlLightLight;
            searchField.BorderStyle = BorderStyle.FixedSingle;
            searchField.Font = new Font("Segoe UI", 13.8F);
            searchField.Location = new Point(150, 67);
            searchField.Multiline = true;
            searchField.Name = "searchField";
            searchField.Size = new Size(361, 41);
            searchField.TabIndex = 95;
            searchField.TextChanged += searchField_TextChanged;
            // 
            // createPanel
            // 
            createPanel.BackColor = Color.LemonChiffon;
            createPanel.Controls.Add(label5);
            createPanel.Controls.Add(promoBox);
            createPanel.Controls.Add(label6);
            createPanel.Controls.Add(addButton);
            createPanel.Controls.Add(discountBox);
            createPanel.Controls.Add(label7);
            createPanel.Location = new Point(567, 67);
            createPanel.Name = "createPanel";
            createPanel.Size = new Size(489, 259);
            createPanel.TabIndex = 100;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Impact", 19.8F);
            label5.Location = new Point(16, 57);
            label5.Name = "label5";
            label5.Size = new Size(175, 41);
            label5.TabIndex = 94;
            label5.Text = "PromoCode";
            // 
            // promoBox
            // 
            promoBox.BackColor = SystemColors.ControlLightLight;
            promoBox.BorderStyle = BorderStyle.FixedSingle;
            promoBox.Font = new Font("Segoe UI", 13.8F);
            promoBox.Location = new Point(239, 57);
            promoBox.Multiline = true;
            promoBox.Name = "promoBox";
            promoBox.Size = new Size(189, 42);
            promoBox.TabIndex = 97;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SeaGreen;
            label6.Location = new Point(163, 3);
            label6.Name = "label6";
            label6.Size = new Size(205, 42);
            label6.TabIndex = 99;
            label6.Text = "Create Promo";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // addButton
            // 
            addButton.BackColor = Color.MediumSeaGreen;
            addButton.Cursor = Cursors.Hand;
            addButton.FlatStyle = FlatStyle.Popup;
            addButton.Font = new Font("Impact", 18F);
            addButton.ForeColor = Color.Black;
            addButton.Location = new Point(176, 200);
            addButton.Name = "addButton";
            addButton.Size = new Size(158, 48);
            addButton.TabIndex = 96;
            addButton.Text = "ADD";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // discountBox
            // 
            discountBox.BackColor = SystemColors.ControlLightLight;
            discountBox.BorderStyle = BorderStyle.FixedSingle;
            discountBox.Font = new Font("Segoe UI", 13.8F);
            discountBox.Location = new Point(239, 117);
            discountBox.Multiline = true;
            discountBox.Name = "discountBox";
            discountBox.Size = new Size(189, 42);
            discountBox.TabIndex = 95;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Impact", 19.8F);
            label7.Location = new Point(53, 117);
            label7.Name = "label7";
            label7.Size = new Size(138, 41);
            label7.TabIndex = 98;
            label7.Text = "Discount";
            // 
            // clearButton
            // 
            clearButton.BackColor = SystemColors.WindowText;
            clearButton.Cursor = Cursors.Hand;
            clearButton.FlatStyle = FlatStyle.Popup;
            clearButton.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clearButton.ForeColor = Color.LavenderBlush;
            clearButton.Location = new Point(269, 205);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(158, 48);
            clearButton.TabIndex = 94;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // updatePanel
            // 
            updatePanel.BackColor = Color.LemonChiffon;
            updatePanel.Controls.Add(label2);
            updatePanel.Controls.Add(clearButton);
            updatePanel.Controls.Add(label3);
            updatePanel.Controls.Add(UdiscountField);
            updatePanel.Controls.Add(label4);
            updatePanel.Controls.Add(updateButton);
            updatePanel.Controls.Add(UpromoField);
            updatePanel.Location = new Point(26, 377);
            updatePanel.Name = "updatePanel";
            updatePanel.Size = new Size(485, 276);
            updatePanel.TabIndex = 101;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Impact", 19.8F);
            label2.Location = new Point(14, 63);
            label2.Name = "label2";
            label2.Size = new Size(175, 41);
            label2.TabIndex = 80;
            label2.Text = "PromoCode";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MediumBlue;
            label3.Location = new Point(161, 9);
            label3.Name = "label3";
            label3.Size = new Size(212, 42);
            label3.TabIndex = 93;
            label3.Text = "Update Promo";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // UdiscountField
            // 
            UdiscountField.BackColor = SystemColors.ControlLightLight;
            UdiscountField.BorderStyle = BorderStyle.FixedSingle;
            UdiscountField.Font = new Font("Segoe UI", 13.8F);
            UdiscountField.Location = new Point(237, 124);
            UdiscountField.Multiline = true;
            UdiscountField.Name = "UdiscountField";
            UdiscountField.Size = new Size(189, 42);
            UdiscountField.TabIndex = 81;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Impact", 19.8F);
            label4.Location = new Point(51, 124);
            label4.Name = "label4";
            label4.Size = new Size(138, 41);
            label4.TabIndex = 92;
            label4.Text = "Discount";
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.MediumBlue;
            updateButton.Cursor = Cursors.Hand;
            updateButton.FlatStyle = FlatStyle.Popup;
            updateButton.Font = new Font("Impact", 18F);
            updateButton.ForeColor = Color.LavenderBlush;
            updateButton.Location = new Point(70, 205);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(158, 48);
            updateButton.TabIndex = 83;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // UpromoField
            // 
            UpromoField.BackColor = SystemColors.Info;
            UpromoField.BorderStyle = BorderStyle.FixedSingle;
            UpromoField.Font = new Font("Segoe UI", 13.8F);
            UpromoField.Location = new Point(237, 63);
            UpromoField.Multiline = true;
            UpromoField.Name = "UpromoField";
            UpromoField.ReadOnly = true;
            UpromoField.Size = new Size(189, 42);
            UpromoField.TabIndex = 91;
            // 
            // PromoCode
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 720);
            Controls.Add(searchField);
            Controls.Add(updatePanel);
            Controls.Add(deletePanel);
            Controls.Add(createPanel);
            Controls.Add(label1);
            Controls.Add(backButton);
            Controls.Add(searchGrid);
            Name = "PromoCode";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Promo Code";
            Load += createPromo_Load;
            ((System.ComponentModel.ISupportInitialize)searchGrid).EndInit();
            deletePanel.ResumeLayout(false);
            deletePanel.PerformLayout();
            createPanel.ResumeLayout(false);
            createPanel.PerformLayout();
            updatePanel.ResumeLayout(false);
            updatePanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox promoField;
        private Label label1;
        private Button backButton;
        private DataGridView searchGrid;
        private Button deleteButton;
        private TextBox discountField;
        private Label promoLabel;
        private Label discountLabl;
        private Label deleteLabl;
        private Panel deletePanel;
        private TextBox searchField;
        private Panel createPanel;
        private Label label5;
        private TextBox promoBox;
        private Label label6;
        private Button addButton;
        private TextBox discountBox;
        private Label label7;
        private Button clearButton;
        private Panel updatePanel;
        private Label label2;
        private Label label3;
        private TextBox UdiscountField;
        private Label label4;
        private Button updateButton;
        private TextBox UpromoField;
    }
}