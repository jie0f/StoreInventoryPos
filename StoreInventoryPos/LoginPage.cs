using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFAManagementPro;


namespace StoreInventoryPos
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }


        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = userNameField.Text.Trim();
            string password = passWordField.Text.Trim();
            string role;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Create instance of DataAccess
                DataAccess dataAccess = new DataAccess();

                bool isValid = dataAccess.ValidateUser(username, password, out role);

                if (isValid)
                {
                    Users.Username = username;
                    Users.Role = role;

                    this.Hide();

                    if (role == "ADMIN")
                    {
                        adminDashboard Dashboard = new adminDashboard();
                        Dashboard.Show();
                    }
                    else if (role == "MANAGER")
                    {
                        managerDashboard Dashboard = new managerDashboard();
                        Dashboard.Show();
                    }
                    else if (role == "STAFF")
                    {
                        staffDashboard Dashboard = new staffDashboard();
                        Dashboard.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during login:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

