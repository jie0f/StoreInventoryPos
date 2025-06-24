namespace StoreInventoryPos
{
    partial class refundManagement
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            backButton = new Button();
            searchGrid = new DataGridView();
            refundReasonBox = new ComboBox();
            saleIDLabel = new Label();
            refundAmountLabel = new Label();
            refundReasonLabel = new Label();
            refundButton = new Button();
            clearButton = new Button();
            label1 = new Label();
            searchField = new TextBox();
            saleIDField = new TextBox();
            amountField = new TextBox();
            ((System.ComponentModel.ISupportInitialize)searchGrid).BeginInit();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.BackColor = Color.White;
            backButton.Font = new Font("Impact", 18F);
            backButton.ForeColor = Color.Crimson;
            backButton.Location = new Point(1120, 22);
            backButton.Margin = new Padding(3, 2, 3, 2);
            backButton.Name = "backButton";
            backButton.Size = new Size(105, 38);
            backButton.TabIndex = 16;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // searchGrid
            // 
            searchGrid.AllowUserToAddRows = false;
            searchGrid.AllowUserToDeleteRows = false;
            searchGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            searchGrid.ColumnHeadersHeight = 29;
            searchGrid.ColumnHeadersVisible = false;
            searchGrid.Location = new Point(60, 82);
            searchGrid.Margin = new Padding(3, 2, 3, 2);
            searchGrid.Name = "searchGrid";
            searchGrid.ReadOnly = true;
            searchGrid.RowHeadersVisible = false;
            searchGrid.RowHeadersWidth = 51;
            searchGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            searchGrid.Size = new Size(737, 311);
            searchGrid.TabIndex = 2;
            searchGrid.CellClick += searchGrid_CellClick_1;
            // 
            // refundReasonBox
            // 
            refundReasonBox.Font = new Font("Segoe UI", 13F);
            refundReasonBox.Items.AddRange(new object[] { "Damaged", "Customer Return", "Wrong Item", "Other" });
            refundReasonBox.DropDownStyle = ComboBoxStyle.DropDownList;
            refundReasonBox.Location = new Point(945, 172);
            refundReasonBox.Margin = new Padding(3, 2, 3, 2);
            refundReasonBox.Name = "refundReasonBox";
            refundReasonBox.Size = new Size(219, 31);
            refundReasonBox.TabIndex = 12;
            // 
            // saleIDLabel
            // 
            saleIDLabel.Font = new Font("Impact", 16F);
            saleIDLabel.Location = new Point(822, 82);
            saleIDLabel.Name = "saleIDLabel";
            saleIDLabel.Size = new Size(88, 27);
            saleIDLabel.TabIndex = 5;
            saleIDLabel.Text = "Sale ID";
            // 
            // refundAmountLabel
            // 
            refundAmountLabel.Font = new Font("Impact", 16F);
            refundAmountLabel.Location = new Point(822, 128);
            refundAmountLabel.Name = "refundAmountLabel";
            refundAmountLabel.Size = new Size(88, 27);
            refundAmountLabel.TabIndex = 7;
            refundAmountLabel.Text = "Amount";
            // 
            // refundReasonLabel
            // 
            refundReasonLabel.Font = new Font("Impact", 16F);
            refundReasonLabel.Location = new Point(822, 172);
            refundReasonLabel.Name = "refundReasonLabel";
            refundReasonLabel.Size = new Size(88, 28);
            refundReasonLabel.TabIndex = 11;
            refundReasonLabel.Text = "Reason";
            // 
            // refundButton
            // 
            refundButton.BackColor = Color.FromArgb(128, 255, 128);
            refundButton.Font = new Font("Impact", 18F);
            refundButton.Location = new Point(945, 222);
            refundButton.Margin = new Padding(3, 2, 3, 2);
            refundButton.Name = "refundButton";
            refundButton.Size = new Size(106, 38);
            refundButton.TabIndex = 13;
            refundButton.Text = "Refund";
            refundButton.UseVisualStyleBackColor = false;
            refundButton.Click += refundButton_Click;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.Black;
            clearButton.Font = new Font("Impact", 18F);
            clearButton.ForeColor = Color.White;
            clearButton.Location = new Point(1057, 222);
            clearButton.Margin = new Padding(3, 2, 3, 2);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(107, 38);
            clearButton.TabIndex = 15;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Impact", 19.8F);
            label1.Location = new Point(60, 35);
            label1.Name = "label1";
            label1.Size = new Size(111, 31);
            label1.TabIndex = 0;
            label1.Text = "Search :";
            // 
            // searchField
            // 
            searchField.BackColor = SystemColors.ControlLightLight;
            searchField.BorderStyle = BorderStyle.FixedSingle;
            searchField.Font = new Font("Segoe UI", 13.8F);
            searchField.Location = new Point(169, 35);
            searchField.Margin = new Padding(3, 2, 3, 2);
            searchField.Multiline = true;
            searchField.Name = "searchField";
            searchField.Size = new Size(628, 31);
            searchField.TabIndex = 37;
            searchField.TextChanged += searchField_TextChanged_1;
            // 
            // saleIDField
            // 
            saleIDField.BackColor = SystemColors.Info;
            saleIDField.BorderStyle = BorderStyle.FixedSingle;
            saleIDField.Font = new Font("Segoe UI", 13.8F);
            saleIDField.Location = new Point(945, 78);
            saleIDField.Margin = new Padding(3, 2, 3, 2);
            saleIDField.Multiline = true;
            saleIDField.Name = "saleIDField";
            saleIDField.ReadOnly = true;
            saleIDField.Size = new Size(219, 32);
            saleIDField.TabIndex = 38;
            // 
            // amountField
            // 
            amountField.BackColor = SystemColors.ControlLightLight;
            amountField.BorderStyle = BorderStyle.FixedSingle;
            amountField.Font = new Font("Segoe UI", 13.8F);
            amountField.Location = new Point(945, 128);
            amountField.Margin = new Padding(3, 2, 3, 2);
            amountField.Multiline = true;
            amountField.Name = "amountField";
            amountField.Size = new Size(219, 32);
            amountField.TabIndex = 39;
            // 
            // refundManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1269, 450);
            Controls.Add(amountField);
            Controls.Add(saleIDField);
            Controls.Add(searchField);
            Controls.Add(label1);
            Controls.Add(searchGrid);
            Controls.Add(saleIDLabel);
            Controls.Add(refundAmountLabel);
            Controls.Add(refundReasonLabel);
            Controls.Add(refundReasonBox);
            Controls.Add(refundButton);
            Controls.Add(clearButton);
            Controls.Add(backButton);
            Margin = new Padding(3, 2, 3, 2);
            Name = "refundManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Refund Management";
            Load += refundManagement_Load;
            ((System.ComponentModel.ISupportInitialize)searchGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1, refundIDLabel, saleIDLabel, refundAmountLabel, refundDateLabel, refundReasonLabel;
        private DateTimePicker refundDateField;
        private ComboBox refundReasonBox;
        private DataGridView searchGrid;
        private Button refundButton, deleteButton, clearButton, backButton;
        private TextBox searchField;
        private TextBox saleIDField;
        private TextBox amountField;
    }
}
