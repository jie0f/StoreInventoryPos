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
    public partial class staffInventory : Form
    {
        public staffInventory()
        {
            InitializeComponent();
            this.Load += Product_Load;
        }
        private void Product_Load(object sender, EventArgs e)
        {
            LoadProductIntoGrid();
        }

        private void LoadProductIntoGrid()
        {
            try
            {
                DataAccess db = new DataAccess();
                DataTable product = db.getProductPOS();

                searchGrid.DataSource = product;


                if (searchGrid.Columns.Contains("ProductID"))
                    searchGrid.Columns["ProductID"].HeaderText = "Product ID";
                if (searchGrid.Columns.Contains("ProductName"))
                    searchGrid.Columns["ProductName"].HeaderText = "Product Name";
                if (searchGrid.Columns.Contains("Price"))
                    searchGrid.Columns["Price"].HeaderText = "Price";
                if (searchGrid.Columns.Contains("Quantity"))
                    searchGrid.Columns["Quantity"].HeaderText = "Quantity";
                if (searchGrid.Columns.Contains("Size"))
                    searchGrid.Columns["Size"].HeaderText = "Size";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message);
            }
        }

        private DataAccess dataAccess = new DataAccess();


        private void searchField_TextChanged(object sender, EventArgs e)
        {
            string productname = searchField.Text.Trim();
            DataTable result = dataAccess.SearchByProductnameStaff(productname);
            searchGrid.DataSource = result;
        }

        private void backButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            staffDashboard Back = new staffDashboard();
            Back.Show();
        }
    }
}
