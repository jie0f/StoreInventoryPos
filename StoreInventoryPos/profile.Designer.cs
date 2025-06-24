namespace StoreInventoryPos
{
    partial class profile
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            profileLabel = new Label();
            backButton = new Button();
            lblFullName = new Label();
            lblUsername = new Label();
            lblRole = new Label();
            txtFullName = new TextBox();
            txtUsername = new TextBox();
            txtRole = new TextBox();
            SuspendLayout();
            // 
            // profileLabel
            // 
            profileLabel.AutoSize = true;
            profileLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            profileLabel.Location = new Point(34, 27);
            profileLabel.Name = "profileLabel";
            profileLabel.Size = new Size(217, 54);
            profileLabel.TabIndex = 0;
            profileLabel.Text = "My Profile";
            // 
            // backButton
            // 
            backButton.Location = new Point(400, 27);
            backButton.Margin = new Padding(3, 4, 3, 4);
            backButton.Name = "backButton";
            backButton.Size = new Size(86, 43);
            backButton.TabIndex = 1;
            backButton.Text = "Back";
            backButton.Click += backButton_Click;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblFullName.Location = new Point(34, 107);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(97, 25);
            lblFullName.TabIndex = 2;
            lblFullName.Text = "Full Name";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblUsername.Location = new Point(34, 160);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(97, 25);
            lblUsername.TabIndex = 4;
            lblUsername.Text = "Username";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblRole.Location = new Point(34, 213);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(50, 25);
            lblRole.TabIndex = 6;
            lblRole.Text = "Role";
            // 
            // txtFullName
            // 
            txtFullName.BackColor = SystemColors.ControlLight;
            txtFullName.Font = new Font("Times New Roman", 12F);
            txtFullName.Location = new Point(137, 100);
            txtFullName.Margin = new Padding(3, 4, 3, 4);
            txtFullName.Name = "txtFullName";
            txtFullName.ReadOnly = true;
            txtFullName.Size = new Size(228, 30);
            txtFullName.TabIndex = 3;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.ControlLight;
            txtUsername.Font = new Font("Times New Roman", 12F);
            txtUsername.Location = new Point(137, 153);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(228, 30);
            txtUsername.TabIndex = 5;
            // 
            // txtRole
            // 
            txtRole.BackColor = SystemColors.ControlLight;
            txtRole.Font = new Font("Times New Roman", 12F);
            txtRole.Location = new Point(137, 207);
            txtRole.Margin = new Padding(3, 4, 3, 4);
            txtRole.Name = "txtRole";
            txtRole.ReadOnly = true;
            txtRole.Size = new Size(228, 30);
            txtRole.TabIndex = 7;
            // 
            // profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 293);
            Controls.Add(profileLabel);
            Controls.Add(backButton);
            Controls.Add(lblFullName);
            Controls.Add(txtFullName);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblRole);
            Controls.Add(txtRole);
            Margin = new Padding(3, 4, 3, 4);
            Name = "profile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Profile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label profileLabel;
        private Button backButton;
        private Label lblFullName;
        private Label lblUsername;
        private Label lblRole;
        private TextBox txtFullName;
        private TextBox txtUsername;
        private TextBox txtRole;
    }
}
