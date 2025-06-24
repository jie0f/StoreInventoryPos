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
    public partial class ViewStaff : Form
    {
        public ViewStaff()
        {
            InitializeComponent();
            this.Load += mViewUser_Load;
        }

        private void mViewUser_Load(object sender, EventArgs e)
        {
            LoadUsersIntoGrid();
        }
        private void LoadUsersIntoGrid()
        {
            try
            {
                DataAccess db = new DataAccess();
                DataTable users = db.getUserManager();

                searchGrid.DataSource = users;

                // Optionally adjust column headers if those columns exist
                if (searchGrid.Columns.Contains("Username"))
                    searchGrid.Columns["Username"].HeaderText = "Username";
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


        private void searchField_TextChanged_1(object sender, EventArgs e)
        {
            string username = searchField.Text.Trim();
            DataTable result = dataAccess.SearchUsersByUsernameManager(username);
            searchGrid.DataSource = result;
        }

        private void backButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            managerDashboard Back = new managerDashboard();
            Back.Show();
        }
    }
}
