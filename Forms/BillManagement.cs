using Store.DataQ;
using System;
using System.Data;
using System.Windows.Forms;

namespace Store.Forms
{
    public partial class BillManagement : Form
    {
        private readonly DatabaseQ db = new DatabaseQ();
        private DataGridViewRow selectedRow;

        public BillManagement()
        {
            InitializeComponent();
        }

        private void BillManagement_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridViewSell.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridViewSell.MultiSelect = false;

                LoadSales();

                // Automatically select the first row if available
                if (dataGridViewSell.Rows.Count > 0)
                {
                    dataGridViewSell.CurrentCell = dataGridViewSell.Rows[0].Cells[0];
                    selectedRow = dataGridViewSell.CurrentRow;
                    buttonPrint.Enabled = true;
                }

                // Handle selection changes dynamically
                dataGridViewSell.SelectionChanged += DataGridViewSell_SelectionChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing form: " + ex.Message);
            }
        }

        private void DataGridViewSell_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewSell.CurrentRow != null)
            {
                selectedRow = dataGridViewSell.CurrentRow; // always keep selectedRow updated
                buttonPrint.Enabled = true;
            }
            else
            {
                selectedRow = null;
                buttonPrint.Enabled = false;
            }
        }
        private void LoadSales()
        {
            try
            {
                DataTable dt = db.GetAllSales();
                dataGridViewSell.DataSource = dt;

                // Optionally adjust column headers
                dataGridViewSell.Columns["ProductBuyID"].HeaderText = "ID";
                dataGridViewSell.Columns["UserID"].HeaderText = "User ID";
                dataGridViewSell.Columns["ProductName"].HeaderText = "Product";
                dataGridViewSell.Columns["Karat"].HeaderText = "Karat";
                dataGridViewSell.Columns["Price"].HeaderText = "Price";
                dataGridViewSell.Columns["Quantity"].HeaderText = "Qty";
                dataGridViewSell.Columns["OrderDate"].HeaderText = "Date";
                dataGridViewSell.Columns["PaymentMethod"].HeaderText = "Payment";
                dataGridViewSell.Columns["Username"].HeaderText = "Customer";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading sales data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewSell_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridViewSell.CurrentRow != null && dataGridViewSell.CurrentRow.Index >= 0)
                {
                    selectedRow = dataGridViewSell.CurrentRow;
                    buttonPrint.Enabled = true;
                }
                else
                {
                    buttonPrint.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error selecting row: " + ex.Message);
            }
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedRow != null)
                {
                    BillForm billForm = new BillForm(selectedRow);
                    billForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No row selected to print.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error printing bill: " + ex.Message);
            }
        }
    }
}
