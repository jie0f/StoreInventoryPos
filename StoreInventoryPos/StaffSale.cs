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
    public partial class StaffSale : Form
    {
        public StaffSale()
        {
            InitializeComponent();
            LoadSaleIntoGrid();
        }

        private void LoadSaleIntoGrid()
        {
            try
            {
                DataAccess db = new DataAccess();
                DataTable sale = db.GetSalesByUser();

                searchGrid.DataSource = sale;

                if (searchGrid.Columns.Contains("Username"))
                    searchGrid.Columns["Username"].HeaderText = "Username";

                if (searchGrid.Columns.Contains("CustomerName"))
                    searchGrid.Columns["CustomerName"].HeaderText = "Customer";

                if (searchGrid.Columns.Contains("TotalAmount"))
                    searchGrid.Columns["TotalAmount"].HeaderText = "Total";

                if (searchGrid.Columns.Contains("PaymentType"))
                    searchGrid.Columns["PaymentType"].HeaderText = "Payment";
                if (searchGrid.Columns.Contains("PaymentToken"))
                    searchGrid.Columns["PaymentToken"].Visible = false;


                if (searchGrid.Columns.Contains("UsedPromo"))
                    searchGrid.Columns["UsedPromo"].HeaderText = "Promo";

                if (searchGrid.Columns.Contains("Date"))
                    searchGrid.Columns["Date"].HeaderText = "Sale Date";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Data: " + ex.Message);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            staffDashboard Back = new staffDashboard();
            Back.Show();
        }
    }
}
