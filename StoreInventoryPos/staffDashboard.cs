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
    public partial class staffDashboard : Form
    {
        public staffDashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage back = new LoginPage();
            back.Show();

        }

        private void staffProfileButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            profile open = new profile();
            open.Show();
        }

        private void inventoryButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            staffInventory Open = new staffInventory();
            Open.Show();
        }

        private void posButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            selectionCart Open = new selectionCart();
            Open.Show();
        }

        private void salesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffSale Open = new StaffSale();
            Open.Show();
        }
    }
}
