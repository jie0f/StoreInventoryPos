namespace StoreInventoryPos
{
    partial class LoginPage
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
            label1 = new Label();
            userNameField = new TextBox();
            passWord = new Label();
            passWordField = new TextBox();
            loginButton = new Button();
            userName = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(278, 59);
            label1.Name = "label1";
            label1.Size = new Size(171, 42);
            label1.TabIndex = 7;
            label1.Text = "USER LOGIN";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // userNameField
            // 
            userNameField.BackColor = SystemColors.ControlLightLight;
            userNameField.BorderStyle = BorderStyle.FixedSingle;
            userNameField.Cursor = Cursors.IBeam;
            userNameField.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userNameField.Location = new Point(253, 126);
            userNameField.Name = "userNameField";
            userNameField.Size = new Size(313, 38);
            userNameField.TabIndex = 9;
            // 
            // passWord
            // 
            passWord.BackColor = SystemColors.ActiveCaption;
            passWord.Font = new Font("Impact", 18F);
            passWord.Location = new Point(96, 244);
            passWord.Name = "passWord";
            passWord.Size = new Size(160, 38);
            passWord.TabIndex = 10;
            passWord.Text = "PASSWORD";
            passWord.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // passWordField
            // 
            passWordField.BackColor = SystemColors.ControlLightLight;
            passWordField.BorderStyle = BorderStyle.FixedSingle;
            passWordField.Cursor = Cursors.IBeam;
            passWordField.Font = new Font("Segoe UI", 13.8F);
            passWordField.Location = new Point(253, 244);
            passWordField.Name = "passWordField";
            passWordField.PasswordChar = '*';
            passWordField.Size = new Size(313, 38);
            passWordField.TabIndex = 9;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.White;
            loginButton.Cursor = Cursors.Hand;
            loginButton.FlatStyle = FlatStyle.Popup;
            loginButton.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginButton.ForeColor = Color.Crimson;
            loginButton.Location = new Point(278, 315);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(171, 51);
            loginButton.TabIndex = 12;
            loginButton.Text = "LOGIN";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // userName
            // 
            userName.BackColor = SystemColors.ActiveCaption;
            userName.Font = new Font("Impact", 18F);
            userName.Location = new Point(96, 126);
            userName.Name = "userName";
            userName.Size = new Size(160, 38);
            userName.TabIndex = 13;
            userName.Text = "USERNAME";
            userName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 445);
            Controls.Add(userNameField);
            Controls.Add(userName);
            Controls.Add(loginButton);
            Controls.Add(passWordField);
            Controls.Add(passWord);
            Controls.Add(label1);
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LOGIN PAGE";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox userNameField;
        private Label passWord;
        private TextBox passWordField;
        private Button loginButton; // Renamed button variable
        private Label userName;
    }
    }