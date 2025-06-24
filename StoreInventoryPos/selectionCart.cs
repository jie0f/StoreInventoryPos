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
    public partial class selectionCart : Form
    {
        public selectionCart()
        {
            InitializeComponent();
            this.Load += PosGrid;
            addButton.Click += addButton_Click;
            removeButton.Click += removeButton_Click;
            cartItems = new List<CartItem>();

        }
        public selectionCart(List<CartItem> existingCart)
        {
            InitializeComponent();
            this.Load += PosGrid;
            addButton.Click += addButton_Click;
            removeButton.Click += removeButton_Click;

            this.cartItems = existingCart;
            RefreshCartGrid();
        }

        private void PosGrid(object sender, EventArgs e)
        {
            LoadProductIntoGrid();
        }
        private void LoadProductIntoGrid(string productName = "")
        {
            try
            {
                DataAccess db = new DataAccess();
                DataTable posProduct;

                if (string.IsNullOrWhiteSpace(productName))
                {
                    posProduct = db.getProductPOS();
                }
                else
                {
                    posProduct = db.getProductPOS(productName);
                }
                DataView filteredView = new DataView(posProduct);
                filteredView.RowFilter = "Quantity > 0";

                productGrid.DataSource = filteredView;

                if (productGrid.Columns.Contains("ProductID"))
                    productGrid.Columns["ProductID"].HeaderText = "Product ID";
                if (productGrid.Columns.Contains("ProductName"))
                    productGrid.Columns["ProductName"].HeaderText = "Product Name";
                if (productGrid.Columns.Contains("Price"))
                    productGrid.Columns["Price"].HeaderText = "Price";
                if (productGrid.Columns.Contains("Quantity"))
                    productGrid.Columns["Quantity"].HeaderText = "Quantity";
                if (productGrid.Columns.Contains("Size"))
                    productGrid.Columns["Size"].HeaderText = "Size";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message);
            }
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            staffDashboard Open = new staffDashboard();
            Open.Show();
        }






        //////////////////cart//////////////

        private List<CartItem> cartItems;

        private void RefreshCartGrid()
        {
            cartGrid.DataSource = null;
            cartGrid.DataSource = cartItems;
            cartGrid.Columns["ProductID"].Visible = false;

            cartTotalLabel.Text = $"Total: {cartItems.Sum(i => i.Total):c}";
        }

        ///add Button//////////
        private void addButton_Click(object sender, EventArgs e)
        {
            if (productGrid.CurrentRow != null)
            {
                string productId = productGrid.CurrentRow.Cells["ProductID"].Value.ToString();
                string productName = productGrid.CurrentRow.Cells["ProductName"].Value.ToString();
                string size = productGrid.CurrentRow.Cells["Size"].Value.ToString();
                double price = Convert.ToDouble(productGrid.CurrentRow.Cells["Price"].Value);



                // Check if the product already exists in the cart
                var existing = cartItems.FirstOrDefault(i => i.ProductID == productId && i.Size == size);
                if (existing != null)
                {
                    existing.Quantity++;
                }
                else
                {
                    cartItems.Add(new CartItem
                    {
                        ProductID = productId,
                        ProductName = productName,
                        Size = size,
                        Price = price,
                        Quantity = 1
                    });
                }

                RefreshCartGrid();
            }
        }


        ///Remove//////////////
        private void removeButton_Click(object sender, EventArgs e)
        {
            if (cartGrid.CurrentRow != null)
            {
                string productId = cartGrid.CurrentRow.Cells["ProductID"].Value.ToString();
                string size = cartGrid.CurrentRow.Cells["Size"].Value.ToString();

                var item = cartItems.FirstOrDefault(i => i.ProductID == productId && i.Size == size);
                if (item != null)
                {
                    cartItems.Remove(item);
                    RefreshCartGrid();
                }
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (cartItems.Count == 0)
            {
                MessageBox.Show("Cart is empty. Please add items first.");
                return;
            }

            Billing billingForm = new Billing(cartItems);
            billingForm.Show();
            this.Hide();
        }

        private void searchField_TextChanged_1(object sender, EventArgs e)
        {
            string productname = searchField.Text.Trim();
            LoadProductIntoGrid(productname);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            searchField.Text = string.Empty;    
            LoadProductIntoGrid();           
            cartItems.Clear();                   
            RefreshCartGrid();
        }
    }
}

