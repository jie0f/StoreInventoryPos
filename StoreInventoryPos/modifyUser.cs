using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using WFAManagementPro;

namespace StoreInventoryPos
{
    public partial class modifyUser : Form
    {



        public modifyUser()
        {
            InitializeComponent();
            this.Load += ModifyUser_Load;
        }

        // On form load, load users into the grid
        private void ModifyUser_Load(object sender, EventArgs e)
        {
            LoadUsersIntoGrid();
        }

        // Load all users from DB and bind to searchGrid
        private void LoadUsersIntoGrid()
        {
            try
            {
                DataAccess db = new DataAccess();
                DataTable users = db.getUser();

                searchGrid.DataSource = users;

                // Optionally adjust column headers if those columns exist
                if (searchGrid.Columns.Contains("Username"))
                    searchGrid.Columns["Username"].HeaderText = "Username";
                if (searchGrid.Columns.Contains("Password"))
                    searchGrid.Columns["Password"].HeaderText = "Password";
                if (searchGrid.Columns.Contains("Fullname"))
                    searchGrid.Columns["Fullname"].HeaderText = "Full Name";
                if (searchGrid.Columns.Contains("Role"))
                    searchGrid.Columns["Role"].HeaderText = "Role";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message);
            }
        }
        private void ClearField()
        {
            userNameField.Clear();
            passwordField.Clear();
            fullNameField.Clear();
            roleBox.SelectedIndex = -1;
            searchField.Clear();
            searchGrid.ClearSelection();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminDashboard back = new adminDashboard();
            back.Show();
        }





        private void deleteButton_Click(object sender, EventArgs e)
        {
            string username = userNameField.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please select user", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataAccess dataAccess = new DataAccess();

            int row = dataAccess.DeleteUser(username);
            if (row > 0)
            {
                MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearField();
                LoadUsersIntoGrid();
            }
            else
            {
                MessageBox.Show("Select Valid User.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = searchGrid.Rows[e.RowIndex];
                userNameField.Text = row.Cells["Username"].Value.ToString();
                passwordField.Text = row.Cells["Password"].Value.ToString();
                fullNameField.Text = row.Cells["Fullname"].Value.ToString();
                roleBox.Text = row.Cells["Role"].Value.ToString();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string username = userNameField.Text.Trim();
            string fullname = fullNameField.Text.Trim();
            string password = passwordField.Text.Trim();
            string role = roleBox.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please select a valid user to update.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(fullname) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Full Name, Password and Role are required.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataAccess dataAccess = new DataAccess();
            int rowsAffected = dataAccess.UpdateUser(username, fullname, password, role);

            if (rowsAffected > 0)
            {
                MessageBox.Show("User updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearField();
                LoadUsersIntoGrid();
            }
            else
            {
                MessageBox.Show("Failed to update user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            adminDashboard Back = new adminDashboard();
            Back.Show();
        }

        private DataAccess dataAccess = new DataAccess();
        private void searchField_TextChanged(object sender, EventArgs e)
        {

            string username = searchField.Text.Trim();
            DataTable result = dataAccess.SearchUsersByUsername(username);
            searchGrid.DataSource = result;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearField();
        }
    }
}
