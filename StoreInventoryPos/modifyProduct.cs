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
    public partial class modifyProduct : Form
    {
        public modifyProduct()
        {
            InitializeComponent();
            this.Load += ModifyProduct_Load;
        }
        private void ModifyProduct_Load(object sender, EventArgs e)
        {
            LoadProductIntoGrid();
        }
        private void LoadProductIntoGrid()
        {
            try
            {
                DataAccess db = new DataAccess();
                DataTable users = db.getProducts();

                searchGrid.DataSource = users;


                if (searchGrid.Columns.Contains("ProductID"))
                    searchGrid.Columns["ProductID"].HeaderText = "Product ID";
                if (searchGrid.Columns.Contains("ProductName"))
                    searchGrid.Columns["ProductName"].HeaderText = "Product Name";
                if (searchGrid.Columns.Contains("Cost"))
                    searchGrid.Columns["Cost"].HeaderText = "Cost";
                if (searchGrid.Columns.Contains("Price"))
                    searchGrid.Columns["Price"].HeaderText = "Price";
                if (searchGrid.Columns.Contains("Quantity"))
                    searchGrid.Columns["Quantity"].HeaderText = "Quantity";
                if (searchGrid.Columns.Contains("Size"))
                    searchGrid.Columns["Size"].HeaderText = "Size";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Products: " + ex.Message);
            }
        }

        private void ClearField()
        {
            productIDField.Clear();
            ProductNameField.Clear();
            costField.Clear();
            priceField.Clear();
            QuantityField.Clear();
            sizeBox.SelectedIndex = -1;
            searchField.Clear();
            searchGrid.ClearSelection();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            inventoryManagement Back = new inventoryManagement();
            Back.Show();
        }
        private DataAccess dataAccess = new DataAccess();


        private void searchGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // To avoid header clicks
            {
                DataGridViewRow row = searchGrid.Rows[e.RowIndex];
                productIDField.Text = row.Cells["ProductID"].Value.ToString();
                ProductNameField.Text = row.Cells["ProductName"].Value.ToString();
                costField.Text = row.Cells["Cost"].Value.ToString();
                priceField.Text = row.Cells["Price"].Value.ToString();
                QuantityField.Text = row.Cells["Quantity"].Value.ToString();
                sizeBox.Text = row.Cells["Size"].Value.ToString();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string productname = ProductNameField.Text.Trim();
            string productID = productIDField.Text.Trim();
            string cost = costField.Text.Trim();
            string price = priceField.Text.Trim();
            string quantity = QuantityField.Text.Trim();
            string size = sizeBox.Text.Trim();

            if (string.IsNullOrEmpty(productname) || string.IsNullOrEmpty(productID))
            {
                MessageBox.Show("Please select a valid Product to update.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(productname) || string.IsNullOrEmpty(cost) || string.IsNullOrEmpty(price) || string.IsNullOrEmpty(quantity))
            {
                MessageBox.Show("Product Name, Cost, Price, Quantity, Size are required.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            DataAccess dataAccess = new DataAccess();
            int rowsAffected = dataAccess.UpdateProduct(productID, productname, cost, price, quantity, size);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Product updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearField();
                LoadProductIntoGrid();
            }
            else
            {
                MessageBox.Show("Failed to update Product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string productID = productIDField.Text.Trim();

            if (string.IsNullOrEmpty(productID))
            {
                MessageBox.Show("Please select Product", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataAccess dataAccess = new DataAccess();

            int row = dataAccess.DeleteProduct(productID);
            if (row > 0)
            {
                MessageBox.Show("Product deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearField();
                LoadProductIntoGrid();
            }
            else
            {
                MessageBox.Show("Select Valid Product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchField_TextChanged(object sender, EventArgs e)
        {
            string productname = searchField.Text.Trim();
            DataTable result = dataAccess.SearchByProductname(productname);
            searchGrid.DataSource = result;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearField();
        }
    }
}
