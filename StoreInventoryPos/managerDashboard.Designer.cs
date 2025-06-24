namespace StoreInventoryPos
{
    partial class managerDashboard
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
            refundReport = new Button();
            promoCode = new Button();
            viewStaff = new Button();
            editInventory = new Button();
            logoutButton = new Button();
            saleReport = new Button();
            managerProfile = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // refundReport
            // 
            refundReport.BackColor = Color.LightSteelBlue;
            refundReport.Cursor = Cursors.Hand;
            refundReport.FlatStyle = FlatStyle.Popup;
            refundReport.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            refundReport.ForeColor = Color.Black;
            refundReport.Location = new Point(328, 229);
            refundReport.Name = "refundReport";
            refundReport.Size = new Size(270, 147);
            refundReport.TabIndex = 14;
            refundReport.Text = "Refund Report";
            refundReport.UseVisualStyleBackColor = false;
            refundReport.Click += refundReport_Click;
            // 
            // promoCode
            // 
            promoCode.BackColor = Color.LightSteelBlue;
            promoCode.Cursor = Cursors.Hand;
            promoCode.FlatStyle = FlatStyle.Popup;
            promoCode.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            promoCode.ForeColor = Color.Black;
            promoCode.Location = new Point(37, 229);
            promoCode.Name = "promoCode";
            promoCode.Size = new Size(270, 51);
            promoCode.TabIndex = 13;
            promoCode.Text = "Promo Code";
            promoCode.UseVisualStyleBackColor = false;
            promoCode.Click += promoCode_Click_1;
            // 
            // viewStaff
            // 
            viewStaff.BackColor = Color.LightSteelBlue;
            viewStaff.Cursor = Cursors.Hand;
            viewStaff.FlatStyle = FlatStyle.Popup;
            viewStaff.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            viewStaff.ForeColor = Color.Black;
            viewStaff.Location = new Point(37, 38);
            viewStaff.Name = "viewStaff";
            viewStaff.Size = new Size(270, 51);
            viewStaff.TabIndex = 12;
            viewStaff.Text = "View Staff";
            viewStaff.UseVisualStyleBackColor = false;
            viewStaff.Click += viewStaff_Click;
            // 
            // editInventory
            // 
            editInventory.BackColor = Color.LightSteelBlue;
            editInventory.Cursor = Cursors.Hand;
            editInventory.FlatStyle = FlatStyle.Popup;
            editInventory.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editInventory.ForeColor = Color.Black;
            editInventory.Location = new Point(37, 131);
            editInventory.Name = "editInventory";
            editInventory.Size = new Size(270, 51);
            editInventory.TabIndex = 11;
            editInventory.Text = "Edit Inventory";
            editInventory.UseVisualStyleBackColor = false;
            editInventory.Click += editInventory_Click;
            // 
            // logoutButton
            // 
            logoutButton.BackColor = Color.LightPink;
            logoutButton.Cursor = Cursors.Hand;
            logoutButton.FlatStyle = FlatStyle.Popup;
            logoutButton.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logoutButton.ForeColor = Color.Crimson;
            logoutButton.Location = new Point(617, 131);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(171, 51);
            logoutButton.TabIndex = 10;
            logoutButton.Text = "Log Out";
            logoutButton.UseVisualStyleBackColor = false;
            logoutButton.Click += LogoutButton_Click;
            // 
            // saleReport
            // 
            saleReport.BackColor = Color.LightSteelBlue;
            saleReport.Cursor = Cursors.Hand;
            saleReport.FlatStyle = FlatStyle.Popup;
            saleReport.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saleReport.ForeColor = Color.Black;
            saleReport.Location = new Point(328, 38);
            saleReport.Name = "saleReport";
            saleReport.Size = new Size(270, 144);
            saleReport.TabIndex = 15;
            saleReport.Text = "Sale Report";
            saleReport.UseVisualStyleBackColor = false;
            saleReport.Click += saleReport_Click;
            // 
            // managerProfile
            // 
            managerProfile.BackColor = Color.Cyan;
            managerProfile.Cursor = Cursors.Hand;
            managerProfile.FlatStyle = FlatStyle.Popup;
            managerProfile.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            managerProfile.ForeColor = Color.Black;
            managerProfile.Location = new Point(617, 38);
            managerProfile.Name = "managerProfile";
            managerProfile.Size = new Size(171, 51);
            managerProfile.TabIndex = 16;
            managerProfile.Text = "My Profile";
            managerProfile.UseVisualStyleBackColor = false;
            managerProfile.Click += managerProfile_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSteelBlue;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Impact", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(37, 325);
            button1.Name = "button1";
            button1.Size = new Size(270, 51);
            button1.TabIndex = 17;
            button1.Text = "Refund Management";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // managerDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(managerProfile);
            Controls.Add(saleReport);
            Controls.Add(refundReport);
            Controls.Add(promoCode);
            Controls.Add(viewStaff);
            Controls.Add(editInventory);
            Controls.Add(logoutButton);
            Name = "managerDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manager Dashboard";
            ResumeLayout(false);
        }

        #endregion

        private Button refundReport;
        private Button promoCode;
        private Button viewStaff;
        private Button editInventory;
        private Button logoutButton;
        private Button saleReport;
        private Button managerProfile;
        private Button button1;
    }
}