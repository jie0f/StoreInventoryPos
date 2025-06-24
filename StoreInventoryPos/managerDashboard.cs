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
    public partial class managerDashboard : Form
    {
        public managerDashboard()
        {
            InitializeComponent();
        }
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage back = new LoginPage(); // Back
            back.Show();

        }

        private void editInventory_Click(object sender, EventArgs e)
        {
            this.Hide();
            inventoryManagement Open = new inventoryManagement(); // Back
            Open.Show();

        }


        private void promoCode_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            PromoCode Open = new PromoCode();
            Open.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            refundManagement Open = new refundManagement();
            Open.Show();
        }

        private void refundReport_Click(object sender, EventArgs e)
        {

            this.Hide();
            refundReport Open = new refundReport();
            Open.Show();
        }

        private void saleReport_Click(object sender, EventArgs e)
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

        private void viewStaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewStaff Open = new ViewStaff();
            Open.Show();
        }
    }


}
