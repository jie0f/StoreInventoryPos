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
    public partial class CreateUser : Form
    {
        public CreateUser()
        {
            InitializeComponent();
        }
        private void ClearField()
        {
            fNameField.Clear();
            userNameField.Clear();
            passWordField.Clear();
            CpassWordField.Clear();
            roleBox.SelectedIndex = -1;
        }

        private void createButton_Click(object sender, EventArgs e)
{
            string username = userNameField.Text.Trim();
            string password = passWordField.Text.Trim();
            string confirmPassword = CpassWordField.Text.Trim();
            string fullname = fNameField.Text.Trim();
            string role = roleBox.SelectedItem?.ToString().Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(confirmPassword) || string.IsNullOrEmpty(fullname) ||
                string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Password and Confirm Password do not match.");
                return;
            }

            try
            {
                DataAccess db = new DataAccess();
                int rows = db.InsertUser(username, password, fullname, role);

                if (rows > 0)
                {
                    MessageBox.Show("User inserted successfully!");
                    ClearField();
                }
                else
                    MessageBox.Show("Insertion failed.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminDashboard Back = new adminDashboard();
            Back.Show();
        }
    }
}
