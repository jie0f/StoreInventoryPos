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
    public partial class addProduct : Form
    {
        public addProduct()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            inventoryManagement Back = new inventoryManagement();
            Back.Show();
        }
        private void ClearField()
        {
            pNameField.Clear();
            costField.Clear();
            priceField.Clear();
            quantityField.Clear();
            sizeBox.SelectedIndex = -1;
        }
        private void addButton_Click(object sender, EventArgs e)
        {


            // Validate empty fields first
            if (string.IsNullOrWhiteSpace(pNameField.Text) ||
                string.IsNullOrWhiteSpace(costField.Text) ||
                string.IsNullOrWhiteSpace(priceField.Text) ||
                string.IsNullOrWhiteSpace(quantityField.Text) ||
                sizeBox.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            try
            {
                // Parse inputs
                string productname = pNameField.Text.Trim();
                double cost = double.Parse(costField.Text.Trim());
                double price = double.Parse(priceField.Text.Trim());
                int quantity = int.Parse(quantityField.Text.Trim());
                int Size = int.Parse(sizeBox.SelectedItem.ToString().Trim());

                // Convert size int to string for InsertProduct
                string size = Size.ToString();

                // Insert product into database
                DataAccess db = new DataAccess();
                int rows = db.InsertProduct(productname, cost, price, quantity, size);

                if (rows > 0)
                { 
                    MessageBox.Show("Product inserted successfully!");
                ClearField();
            }
                else
                    MessageBox.Show("Insertion failed.");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers for Cost, Price, Quantity, and Size.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



    }
}

