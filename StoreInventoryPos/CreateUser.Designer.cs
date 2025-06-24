
namespace StoreInventoryPos
{
    partial class CreateUser
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
            fNameField = new TextBox();
            fullName = new Label();
            userName = new Label();
            userNameField = new TextBox();
            passWord = new Label();
            passWordField = new TextBox();
            label1 = new Label();
            createButton = new Button();
            confirmPassword = new Label();
            CpassWordField = new TextBox();
            backButton = new Button();
            roleBox = new ComboBox();
            SuspendLayout();
            // 
            // fNameField
            // 
            fNameField.BorderStyle = BorderStyle.FixedSingle;
            fNameField.Location = new Point(86, 75);
            fNameField.Name = "fNameField";
            fNameField.Size = new Size(290, 27);
            fNameField.TabIndex = 0;
            // 
            // fullName
            // 
            fullName.AutoSize = true;
            fullName.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fullName.Location = new Point(85, 29);
            fullName.Name = "fullName";
            fullName.Size = new Size(103, 28);
            fullName.TabIndex = 1;
            fullName.Text = "Full Name";
            // 
            // userName
            // 
            userName.AutoSize = true;
            userName.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userName.Location = new Point(412, 29);
            userName.Name = "userName";
            userName.Size = new Size(114, 28);
            userName.TabIndex = 4;
            userName.Text = "User Name";
            // 
            // userNameField
            // 
            userNameField.BorderStyle = BorderStyle.FixedSingle;
            userNameField.Location = new Point(412, 75);
            userNameField.Name = "userNameField";
            userNameField.Size = new Size(290, 27);
            userNameField.TabIndex = 5;
            // 
            // passWord
            // 
            passWord.AutoSize = true;
            passWord.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passWord.Location = new Point(86, 137);
            passWord.Name = "passWord";
            passWord.Size = new Size(105, 28);
            passWord.TabIndex = 6;
            passWord.Text = "Password";
            // 
            // passWordField
            // 
            passWordField.BorderStyle = BorderStyle.FixedSingle;
            passWordField.Location = new Point(86, 168);
            passWordField.Name = "passWordField";
            passWordField.Size = new Size(290, 27);
            passWordField.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(86, 231);
            label1.Name = "label1";
            label1.Size = new Size(122, 28);
            label1.TabIndex = 9;
            label1.Text = "Assign Role";
            label1.Click += label1_Click;
            // 
            // createButton
            // 
            createButton.BackColor = Color.White;
            createButton.Cursor = Cursors.Hand;
            createButton.FlatStyle = FlatStyle.Popup;
            createButton.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createButton.ForeColor = Color.Crimson;
            createButton.Location = new Point(276, 312);
            createButton.Name = "createButton";
            createButton.Size = new Size(290, 51);
            createButton.TabIndex = 13;
            createButton.Text = "CREATE";
            createButton.UseVisualStyleBackColor = false;
            createButton.Click += createButton_Click;
            // 
            // confirmPassword
            // 
            confirmPassword.AutoSize = true;
            confirmPassword.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirmPassword.Location = new Point(412, 137);
            confirmPassword.Name = "confirmPassword";
            confirmPassword.Size = new Size(185, 28);
            confirmPassword.TabIndex = 19;
            confirmPassword.Text = "Confirm Password";
            // 
            // CpassWordField
            // 
            CpassWordField.BorderStyle = BorderStyle.FixedSingle;
            CpassWordField.Location = new Point(412, 168);
            CpassWordField.Name = "CpassWordField";
            CpassWordField.Size = new Size(290, 27);
            CpassWordField.TabIndex = 20;
            // 
            // backButton
            // 
            backButton.BackColor = Color.White;
            backButton.Cursor = Cursors.Hand;
            backButton.FlatStyle = FlatStyle.Popup;
            backButton.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            backButton.ForeColor = Color.Crimson;
            backButton.Location = new Point(693, 13);
            backButton.Name = "backButton";
            backButton.Size = new Size(112, 51);
            backButton.TabIndex = 21;
            backButton.Text = "BACK";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // roleBox
            // 
            roleBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            roleBox.DropDownStyle = ComboBoxStyle.DropDownList;
            roleBox.FormattingEnabled = true;
            roleBox.Items.AddRange(new object[] { "ADMIN", "MANAGER", "STAFF" });
            roleBox.Location = new Point(214, 235);
            roleBox.Name = "roleBox";
            roleBox.Size = new Size(163, 28);
            roleBox.TabIndex = 22;
            roleBox.SelectedIndexChanged += roleBox_SelectedIndexChanged;
            // 
            // CreateUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 484);
            Controls.Add(roleBox);
            Controls.Add(backButton);
            Controls.Add(CpassWordField);
            Controls.Add(confirmPassword);
            Controls.Add(createButton);
            Controls.Add(label1);
            Controls.Add(passWordField);
            Controls.Add(passWord);
            Controls.Add(userNameField);
            Controls.Add(userName);
            Controls.Add(fullName);
            Controls.Add(fNameField);
            Name = "CreateUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateUser";
            ResumeLayout(false);
            PerformLayout();
        }

        private void roleBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // You can leave it empty if you don't want anything to happen on selection change:
            // Or add your code here, e.g.:
            // MessageBox.Show("Selected role: " + roleBox.SelectedItem?.ToString());
        }


        #endregion

        private TextBox fNameField;
        private Label fullName;
        private Label userName;
        private TextBox userNameField;
        private Label passWord;
        private TextBox passWordField;
        private Label label1;
        private Button createButton;
        private Label confirmPassword;
        private TextBox CpassWordField;
        private Button backButton;
        private ComboBox roleBox;
    }
}