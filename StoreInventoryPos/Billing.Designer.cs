namespace StoreInventoryPos
{
    partial class Billing
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label = new Label();
            lblCustomerName = new Label();
            txtCustomerName = new TextBox();
            lblSalesman = new Label();
            txtSalesman = new TextBox();
            lblPaymentType = new Label();
            cmbPaymentType = new ComboBox();
            lblPaymentToken = new Label();
            txtPaymentToken = new TextBox();
            dgvCartItems = new DataGridView();
            lblTotalAmount = new Label();
            btnConfirm = new Button();
            btnBack = new Button();
            lblPromo = new Label();
            PromoCodeField = new TextBox();
            btnCheck = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCartItems).BeginInit();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Impact", 27.75F);
            label.ForeColor = Color.IndianRed;
            label.Location = new Point(448, 24);
            label.Name = "label";
            label.Size = new Size(256, 59);
            label.TabIndex = 0;
            label.Text = "Billing Page";
            // 
            // lblCustomerName
            // 
            lblCustomerName.Location = new Point(34, 120);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(114, 31);
            lblCustomerName.TabIndex = 1;
            lblCustomerName.Text = "Customer Name:";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(171, 116);
            txtCustomerName.Margin = new Padding(3, 4, 3, 4);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(228, 27);
            txtCustomerName.TabIndex = 2;
            // 
            // lblSalesman
            // 
            lblSalesman.Location = new Point(457, 120);
            lblSalesman.Name = "lblSalesman";
            lblSalesman.Size = new Size(114, 31);
            lblSalesman.TabIndex = 3;
            lblSalesman.Text = "Salesman:";
            // 
            // txtSalesman
            // 
            txtSalesman.BackColor = SystemColors.Info;
            txtSalesman.Location = new Point(594, 120);
            txtSalesman.Margin = new Padding(3, 4, 3, 4);
            txtSalesman.Name = "txtSalesman";
            txtSalesman.ReadOnly = true;
            txtSalesman.Size = new Size(228, 27);
            txtSalesman.TabIndex = 4;
            // 
            // lblPaymentType
            // 
            lblPaymentType.Location = new Point(34, 173);
            lblPaymentType.Name = "lblPaymentType";
            lblPaymentType.Size = new Size(114, 31);
            lblPaymentType.TabIndex = 5;
            lblPaymentType.Text = "Payment Type:";
            // 
            // cmbPaymentType
            // 
            cmbPaymentType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaymentType.Items.AddRange(new object[] { "CASH", "CARD" });
            cmbPaymentType.Location = new Point(171, 169);
            cmbPaymentType.Margin = new Padding(3, 4, 3, 4);
            cmbPaymentType.Name = "cmbPaymentType";
            cmbPaymentType.Size = new Size(228, 28);
            cmbPaymentType.TabIndex = 6;
            cmbPaymentType.SelectedIndexChanged += cmbPaymentType_SelectedIndexChanged;
            // 
            // lblPaymentToken
            // 
            lblPaymentToken.Location = new Point(457, 173);
            lblPaymentToken.Name = "lblPaymentToken";
            lblPaymentToken.Size = new Size(114, 31);
            lblPaymentToken.TabIndex = 7;
            lblPaymentToken.Text = "Payment Token:";
            // 
            // txtPaymentToken
            // 
            txtPaymentToken.Enabled = false;
            txtPaymentToken.Location = new Point(594, 169);
            txtPaymentToken.Margin = new Padding(3, 4, 3, 4);
            txtPaymentToken.Name = "txtPaymentToken";
            txtPaymentToken.Size = new Size(182, 27);
            txtPaymentToken.TabIndex = 8;
            // 
            // dgvCartItems
            // 
            dgvCartItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCartItems.ColumnHeadersHeight = 29;
            dgvCartItems.ColumnHeadersVisible = false;
            dgvCartItems.Location = new Point(34, 297);
            dgvCartItems.Margin = new Padding(3, 4, 3, 4);
            dgvCartItems.Name = "dgvCartItems";
            dgvCartItems.ReadOnly = true;
            dgvCartItems.RowHeadersVisible = false;
            dgvCartItems.RowHeadersWidth = 51;
            dgvCartItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCartItems.Size = new Size(914, 276);
            dgvCartItems.TabIndex = 9;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalAmount.Location = new Point(800, 587);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(229, 40);
            lblTotalAmount.TabIndex = 10;
            lblTotalAmount.Text = "Total: $0.00";
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.White;
            btnConfirm.Cursor = Cursors.Hand;
            btnConfirm.FlatStyle = FlatStyle.Popup;
            btnConfirm.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirm.ForeColor = Color.Crimson;
            btnConfirm.Location = new Point(777, 629);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(171, 51);
            btnConfirm.TabIndex = 13;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.White;
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.Crimson;
            btnBack.Location = new Point(34, 629);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(171, 51);
            btnBack.TabIndex = 14;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblPromo
            // 
            lblPromo.Location = new Point(34, 225);
            lblPromo.Name = "lblPromo";
            lblPromo.Size = new Size(114, 31);
            lblPromo.TabIndex = 15;
            lblPromo.Text = "Promo Code";
            // 
            // PromoCodeField
            // 
            PromoCodeField.Location = new Point(171, 225);
            PromoCodeField.Margin = new Padding(3, 4, 3, 4);
            PromoCodeField.Name = "PromoCodeField";
            PromoCodeField.Size = new Size(228, 27);
            PromoCodeField.TabIndex = 16;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(407, 225);
            btnCheck.Margin = new Padding(3, 4, 3, 4);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(86, 31);
            btnCheck.TabIndex = 17;
            btnCheck.Text = "Check";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // Billing
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 707);
            Controls.Add(btnCheck);
            Controls.Add(PromoCodeField);
            Controls.Add(lblPromo);
            Controls.Add(btnBack);
            Controls.Add(btnConfirm);
            Controls.Add(label);
            Controls.Add(lblCustomerName);
            Controls.Add(txtCustomerName);
            Controls.Add(lblSalesman);
            Controls.Add(txtSalesman);
            Controls.Add(lblPaymentType);
            Controls.Add(cmbPaymentType);
            Controls.Add(lblPaymentToken);
            Controls.Add(txtPaymentToken);
            Controls.Add(dgvCartItems);
            Controls.Add(lblTotalAmount);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Billing";
            Text = "Billing";
            ((System.ComponentModel.ISupportInitialize)dgvCartItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label;
        private Label lblCustomerName;
        private TextBox txtCustomerName;
        private Label lblSalesman;
        private TextBox txtSalesman;
        private Label lblPaymentType;
        private ComboBox cmbPaymentType;
        private Label lblPaymentToken;
        private TextBox txtPaymentToken;
        private DataGridView dgvCartItems;
        private Label lblTotalAmount;
        private Button btnConfirm;
        private Button btnBack;
        private Label lblPromo;
        private TextBox PromoCodeField;
        private Button btnCheck;
    }
}
