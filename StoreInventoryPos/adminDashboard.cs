using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreInventoryPos
{
    public partial class adminDashboard : Form
    {
        public adminDashboard()
        {
            InitializeComponent();
        }


        private void logOut_Click(object sender, EventArgs e)
        {
            Users.ClearSession();
            this.Hide();
            LoginPage Back = new LoginPage();
            Back.Show();
        }

        private void CreateUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateUser Open = new CreateUser();
            Open.Show();
        }

        private void modifyUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            modifyUser Open = new modifyUser();
            Open.Show();
        }

        private void viewUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewUser Open = new viewUser();
            Open.Show();
        }



        private void salesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            saleReport Open = new saleReport();
            Open.Show();
        }

        private void managerProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            profile Open = new profile();
            Open.Show();

        }
    }
}
