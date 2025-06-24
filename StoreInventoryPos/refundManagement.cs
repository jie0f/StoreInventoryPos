using System.Data;
using WFAManagementPro;

namespace StoreInventoryPos
{
    public partial class refundManagement : Form
    {
        public refundManagement()
        {
            InitializeComponent();
            this.Load += refundManagement_Load;
        }
        private void ClearField()
        {
            saleIDField.Clear();
            amountField.Clear();
            refundReasonBox.SelectedIndex = -1;
            searchField.Clear();
            searchGrid.ClearSelection();
            LoadSalesIntoGrid();
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            managerDashboard Back = new managerDashboard();
            Back.Show();
        }
        private void refundManagement_Load(object sender, EventArgs e)
        {
            LoadSalesIntoGrid();
        }
        private void LoadSalesIntoGrid()
        {
            try
            {
                DataAccess db = new DataAccess();
                DataTable sales = db.GetSaleReport();
                searchGrid.DataSource = sales;

                if (searchGrid.Columns.Contains("SaleID"))
                    searchGrid.Columns["SaleID"].HeaderText = "Sale ID";
                if (searchGrid.Columns.Contains("CustomerName"))
                    searchGrid.Columns["CustomerName"].HeaderText = "Customer";
                if (searchGrid.Columns.Contains("TotalAmount"))
                    searchGrid.Columns["TotalAmount"].HeaderText = "Amount";
                if (searchGrid.Columns.Contains("PaymentType"))
                    searchGrid.Columns["PaymentType"].HeaderText = "Payment";
                if (searchGrid.Columns.Contains("UsedPromo"))
                    searchGrid.Columns["UsedPromo"].HeaderText = "Promo";
                if (searchGrid.Columns.Contains("Date"))
                    searchGrid.Columns["Date"].HeaderText = "Date";
                if (searchGrid.Columns.Contains("PaymentToken"))
                    searchGrid.Columns["PaymentToken"].Visible = false;

                foreach (DataGridViewRow row in searchGrid.Rows)
                {
                    string saleId = row.Cells["SaleID"].Value?.ToString();
                    if (!string.IsNullOrEmpty(saleId) && db.IsSaleRefunded(saleId))
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading sales: " + ex.Message);
            }
        }


        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearField();
        }


        private void refundButton_Click(object sender, EventArgs e)
        {
            string amountText = amountField.Text.Trim();
            string reason = refundReasonBox.Text.Trim();
            string saleId = saleIDField.Text.Trim();

            if (string.IsNullOrEmpty(amountText) || string.IsNullOrEmpty(reason) || string.IsNullOrEmpty(saleId))
            {
                MessageBox.Show("All fields are required.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(amountText, out decimal amount))
            {
                MessageBox.Show("Invalid amount format.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataAccess dataAccess = new DataAccess();
            try
            {
                int refundId = dataAccess.InsertRefundAndGetId(amount, reason);

                if (refundId > 0)
                {
                    bool linkSuccess = dataAccess.LinkSaleToRefund(saleId, refundId);

                    if (linkSuccess)
                    {
                        MessageBox.Show("Refund successfully recorded.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearButton_Click(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Refund failed", "Partial Success", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Failed to record refund.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataAccess db = new DataAccess();
        private void searchField_TextChanged_1(object sender, EventArgs e)
        {
            string searchText = searchField.Text.Trim();
            searchGrid.DataSource = db.GetSaleReport(searchText);
        }

        private void searchGrid_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = searchGrid.Rows[e.RowIndex];
                string saleId = row.Cells["SaleID"].Value?.ToString() ?? "";

                saleIDField.Text = saleId;
                amountField.Text = row.Cells["TotalAmount"].Value?.ToString() ?? "";
                if (!string.IsNullOrEmpty(saleId) && db.IsSaleRefunded(saleId))
                {
                    refundButton.Enabled = false;
                    refundButton.Text = "Already Refunded";
                }
                else
                {
                    refundButton.Enabled = true;
                    refundButton.Text = "Refund";
                }
            }
        }
    }
}
