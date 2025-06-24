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
    public partial class refundReport : Form
    {
        public refundReport()
        {
            InitializeComponent();
            LoadRefunds();  // Correct method name
            searchField.TextChanged += searchField_TextChanged;
            clearButton.Click += clearButton_Click;
        }

        private void LoadRefunds(string saleId = "")
        {
            try
            {
                DataTable dt = new DataAccess().GetRefundReport(saleId);
                searchGrid.DataSource = dt;

                if (searchGrid.Columns.Contains("SaleID"))
                    searchGrid.Columns["SaleID"].HeaderText = "Sale ID";
                if (searchGrid.Columns.Contains("Username"))
                    searchGrid.Columns["Username"].HeaderText = "Sold By";
                if (searchGrid.Columns.Contains("RefundID"))
                    searchGrid.Columns["RefundID"].HeaderText = "Refund ID";
                if (searchGrid.Columns.Contains("Amount"))
                    searchGrid.Columns["Amount"].HeaderText = "Amount";
                if (searchGrid.Columns.Contains("Reason"))
                    searchGrid.Columns["Reason"].HeaderText = "Reason";
                if (searchGrid.Columns.Contains("ProductName"))
                    searchGrid.Columns["ProductName"].HeaderText = "Product";
                if (searchGrid.Columns.Contains("Size"))
                    searchGrid.Columns["Size"].HeaderText = "Size";
                if (searchGrid.Columns.Contains("Price"))
                    searchGrid.Columns["Price"].HeaderText = "Price";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load refunds: " + ex.Message);
            }
        }

        private void searchField_TextChanged(object sender, EventArgs e)
        {
            LoadRefunds(searchField.Text.Trim());
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            searchField.Text = "";
            LoadRefunds();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            managerDashboard back = new managerDashboard();
            back.Show();
        }


    }
}
