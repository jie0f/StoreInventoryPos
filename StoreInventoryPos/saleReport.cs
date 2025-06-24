using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WFAManagementPro;

namespace StoreInventoryPos
{
    public partial class saleReport : Form
    {
        public saleReport()
        {
            InitializeComponent();
            LoadSaleIntoGrid();
        }


        private void backButton_Click(object sender, EventArgs e)
        {

            if (Users.Role == "ADMIN")
            {
                this.Hide();
                adminDashboard Back = new adminDashboard();
                Back.Show();
            }
            if (Users.Role == "MANAGER")
            {
                this.Hide();
                managerDashboard Back = new managerDashboard();
                Back.Show();
            }
            if (Users.Role == "STAFF")
            {
                this.Hide();
                staffDashboard Back = new staffDashboard();
                Back.Show();
            }
        }
        private void LoadSaleIntoGrid(string saleId = "")

        {
            try
            {
                DataAccess db = new DataAccess();
                DataTable sales = db.GetSaleReport(saleId);

                searchGrid.DataSource = sales;

                if (searchGrid.Columns.Contains("SaleID"))
                    searchGrid.Columns["SaleID"].HeaderText = "Sale ID";

                if (searchGrid.Columns.Contains("CustomerName"))
                    searchGrid.Columns["CustomerName"].HeaderText = "Customer";

                if (searchGrid.Columns.Contains("TotalAmount"))
                    searchGrid.Columns["TotalAmount"].HeaderText = "Total";

                if (searchGrid.Columns.Contains("PaymentType"))
                    searchGrid.Columns["PaymentType"].HeaderText = "Payment";

                if (searchGrid.Columns.Contains("UsedPromo"))
                    searchGrid.Columns["UsedPromo"].HeaderText = "Promo";

                if (searchGrid.Columns.Contains("Date"))
                    searchGrid.Columns["Date"].HeaderText = "Sale Date";

                if (searchGrid.Columns.Contains("TotalProfit"))
                    searchGrid.Columns["TotalProfit"].HeaderText = "Profit";

                if (searchGrid.Columns.Contains("Quantity"))
                    searchGrid.Columns["Quantity"].HeaderText = "Quantity";

                if (searchGrid.Columns.Contains("PaymentToken"))
                    searchGrid.Columns["PaymentToken"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Data: " + ex.Message);
            }
        }

        private void searchField_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchField.Text.Trim();
            LoadSaleIntoGrid(searchText);
        }



        private void clearButton_Click_1(object sender, EventArgs e)
        {
            searchField.Text = "";
            LoadSaleIntoGrid();
        }
    }
}
