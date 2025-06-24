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
    public partial class viewUser : Form
    {
        public viewUser()
        {
            InitializeComponent();
            this.Load += ViewUser_Load;
        }
        private void ViewUser_Load(object sender, EventArgs e)
        {
            LoadUsersIntoGrid();
        }
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

        private DataAccess dataAccess = new DataAccess();

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminDashboard Back = new adminDashboard();
            Back.Show();
        }



        private void searchField_TextChanged(object sender, EventArgs e)
        {
            string username = searchField.Text.Trim();
            DataTable result = dataAccess.SearchUsersByUsername(username);
            searchGrid.DataSource = result;
        }
    }
}
