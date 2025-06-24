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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;

namespace StoreInventoryPos
{
    public partial class PromoCode : Form
    {
        public PromoCode()
        {
            InitializeComponent();
            this.Load += PromoCode_Load;
        }
        private void PromoCode_Load(object sender, EventArgs e)
        {
            LoadPromoIntoGrid();
        }

        private void ClearField()
        {
            promoBox.Clear();
            discountBox.Clear();
            UpromoField.Clear();
            UdiscountField.Clear();
            promoField.Clear();
            discountField.Clear();
            searchField.Clear();
            searchGrid.ClearSelection();
        }


        private void LoadPromoIntoGrid()
        {
            try
            {
                DataAccess db = new DataAccess();
                DataTable Promo = db.getPromo();

                searchGrid.DataSource = Promo;


                if (searchGrid.Columns.Contains("Code"))
                    searchGrid.Columns["Code"].HeaderText = "Promo Code";
                if (searchGrid.Columns.Contains("DiscountPercent"))
                    searchGrid.Columns["DiscountPercent"].HeaderText = "Discount Percent";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Products: " + ex.Message);
            }
        }
        private void createPromo_Load(object sender, EventArgs e)
        {
            createPanel.Visible = true;
            deletePanel.Visible = true;
            updatePanel.Visible = true;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            managerDashboard Back = new managerDashboard();
            Back.Show();
        }

        private DataAccess dataAccess = new DataAccess();




        private void addButton_Click(object sender, EventArgs e)
        {
            string code = promoBox.Text.Trim();
            string discountpercent = discountBox.Text.Trim();

            if (string.IsNullOrEmpty(code) || string.IsNullOrEmpty(discountpercent))
            {
                MessageBox.Show("Please enter both promo code and discount percent.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int result = dataAccess.InsertCode(code, discountpercent);

            if (result > 0)
            {
                MessageBox.Show("Promo code added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearField();
                LoadPromoIntoGrid();
            }
            else
            {
                MessageBox.Show("Failed to add promo code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void searchButton_Click_1(object sender, EventArgs e)
        {
            string code = searchField.Text.Trim();
            DataTable result = dataAccess.SearchByPromoCode(code);
            searchGrid.DataSource = result;
        }

        private void searchGrid_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = searchGrid.Rows[e.RowIndex];
                promoField.Text = row.Cells["Code"].Value.ToString();
                discountField.Text = row.Cells["DiscountPercent"].Value.ToString();
                UpromoField.Text = row.Cells["Code"].Value.ToString();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string code = promoField.Text.Trim();

            if (string.IsNullOrEmpty(code))
            {
                MessageBox.Show("Please select Promo Code", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataAccess dataAccess = new DataAccess();

            int row = dataAccess.DeletePromoCode(code);
            if (row > 0)
            {
                MessageBox.Show("Product deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearField();
                LoadPromoIntoGrid();
            }
            else
            {
                MessageBox.Show("Select Valid Promo Code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchField_TextChanged(object sender, EventArgs e)
        {
            string code = searchField.Text.Trim();
            DataTable result = dataAccess.SearchByPromoCode(code);
            searchGrid.DataSource = result;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearField();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string code = UpromoField.Text.Trim();
            string discountpercent = UdiscountField.Text.Trim();

            if (string.IsNullOrEmpty(code) || string.IsNullOrEmpty(discountpercent))
            {
                MessageBox.Show("Please enter both promo code and discount percent.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int result = dataAccess.UpdateCode(code, discountpercent);

                if (result > 0)
                {
                    MessageBox.Show("Promo code updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearField();
                    LoadPromoIntoGrid();
                }
                else
                {
                    MessageBox.Show("Failed to update promo code. Make sure the code exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

