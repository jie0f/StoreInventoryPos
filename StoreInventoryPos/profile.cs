using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFAManagementPro;

namespace StoreInventoryPos
{
    public partial class profile : Form
    {

        public profile()
        {
            InitializeComponent();

            this.Load += Profile_Load;
        }
        private DataAccess dataAccess = new DataAccess();
        private void Profile_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT Fullname, Username, Role FROM users WHERE Username = @username";
                using (SqlCommand cmd = new SqlCommand(sql, dataAccess.Sqlcon))
                {
                    cmd.Parameters.AddWithValue("@username", Users.Username);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtFullName.Text = reader["Fullname"].ToString();
                            txtUsername.Text = reader["Username"].ToString();
                            txtRole.Text = reader["Role"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("No profile data found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile: " + ex.Message);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {

            if (Users.Role == "ADMIN")
            {
                this.Hide();
                adminDashboard Back = new adminDashboard();
                Back.Show();
            }
            if (Users.Role == "MANAGER")
            {
                this.Hide();
                managerDashboard Back = new managerDashboard();
                Back.Show();
            }
            if (Users.Role == "STAFF")
            {
                this.Hide();
                staffDashboard Back = new staffDashboard();
                Back.Show();
            }

        }
    }
}

