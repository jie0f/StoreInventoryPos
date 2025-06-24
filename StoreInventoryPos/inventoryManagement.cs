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
    public partial class inventoryManagement : Form
    {
        public inventoryManagement()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            addProduct addProduct = new addProduct();
            addProduct.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            managerDashboard Back = new managerDashboard();
            Back.Show();
        }

        private void viewProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            searchProduct Open = new searchProduct();
            Open.Show();
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            modifyProduct Open = new modifyProduct();
            Open.Show();

        }
    }
}
