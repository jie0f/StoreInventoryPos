using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFAManagementPro;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace StoreInventoryPos
{
    public partial class Billing : Form
    {
        private List<CartItem> cartItems;
        private double appliedDiscount = 0;
        internal Billing(List<CartItem> items)
        {
            InitializeComponent();
            this.cartItems = items;
            txtSalesman.Text = Users.Username;
            LoadBillingData();
        }

        private void LoadBillingData()
        {
            dgvCartItems.DataSource = null;
            dgvCartItems.DataSource = cartItems;

            if (dgvCartItems.Columns.Contains("ProductID"))

                txtSalesman.Text = Users.Username;

            double total = cartItems.Sum(item => item.Total);
            double discountAmount = total * (appliedDiscount / 100.0);
            double discountedTotal = total - discountAmount;

            if (appliedDiscount > 0)
            {
                lblTotalAmount.Text = $"Total: {discountedTotal:C} (Discount: {appliedDiscount}% Off)";
            }
            else
            {
                lblTotalAmount.Text = $"Total: {total:C}";
            }
        }


        private void cmbPaymentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPaymentType.SelectedItem != null && cmbPaymentType.SelectedItem.ToString() == "CARD")
            {
                txtPaymentToken.Enabled = true;
            }
            else
            {
                txtPaymentToken.Enabled = false;
                txtPaymentToken.Text = "";
            }

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string customerName = txtCustomerName.Text.Trim();
            string paymentType = cmbPaymentType.SelectedItem?.ToString();
            string paymentToken = txtPaymentToken.Text.Trim();
            string promoCode = PromoCodeField.Text.Trim();
            double total = cartItems.Sum(item => item.Total);
            DateTime saleDate = DateTime.Now;

            if (string.IsNullOrEmpty(customerName) || string.IsNullOrEmpty(paymentType))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }
            try
            {
                DataAccess db = new DataAccess();
                int SaleID = db.InsertSale(customerName, total, paymentType, promoCode, paymentToken, saleDate);

                if (SaleID > 0)
                {
                    MessageBox.Show("Sale completed successfully!");
                    db.InsertUserSale(Users.Username, SaleID);

                    foreach (var item in cartItems)
                    {
                        db.UpdateProductQuantity(int.Parse(item.ProductID), item.Quantity);
                        db.InsertSaleProduct(item.ProductID, SaleID);
                    }
                    this.Hide();
                    selectionCart Open = new selectionCart();
                    Open.Show();

                }
                else
                {
                    MessageBox.Show("Failed to complete the sale.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            selectionCart backToCart = new selectionCart(cartItems);
            backToCart.Show();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string code = PromoCodeField.Text.Trim();
            int discountPercent;

            if (string.IsNullOrEmpty(code))
            {
                MessageBox.Show("Please enter a promo code.");
                return;
            }

            try
            {
                DataAccess dataAccess = new DataAccess();

                bool isValid = dataAccess.ValidatePromo(code, out discountPercent);

                if (isValid)
                {
                    appliedDiscount = discountPercent;
                    MessageBox.Show($"Promo code applied: {discountPercent}% off.");
                    LoadBillingData();
                }
                else
                {
                    appliedDiscount = 0;
                    MessageBox.Show("Invalid promo code.");
                    LoadBillingData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Validation Error: " + ex.Message);
            }
        }

    }

}

