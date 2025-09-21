using Store.DataQ;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Store.Forms
{
    public partial class OrderVeiw : Form
    {
        private readonly DatabaseQ db = new DatabaseQ();
        private int currentUserId;
        private string currentBranchName;


        private string defaultKarat = "22";

        public OrderVeiw(int userId, string currentBranchName)
        {
            InitializeComponent();
            this.currentUserId = userId;
            this.currentBranchName = currentBranchName;
        }

        private void LoadProducts()
        {
            try
            {
                DataTable dt = db.GetAllProducts();
                dataGridViewProduct.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load products: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupCartGrid()
        {
            dataGridViewCart.Columns.Clear();
            dataGridViewCart.Columns.Add("ProductName", "Product Name");
            dataGridViewCart.Columns.Add("Karat", "Karat");
            dataGridViewCart.Columns.Add("Price", "Price");
            dataGridViewCart.Columns.Add("Quantity", "Quantity");
            dataGridViewCart.Columns.Add("TotalPrice", "Total Price");
        }

        private void OrderVeiw_Load(object sender, EventArgs e)
        {
            try
            {
                LoadProducts();
                SetupCartGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            if (dataGridViewProduct.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewProduct.SelectedRows[0];
                string productName = row.Cells["ProductName"].Value.ToString();
                string karat = defaultKarat;
                decimal price = Convert.ToDecimal(row.Cells["Price"].Value);
                int availableQty = Convert.ToInt32(row.Cells["Quantity"].Value);

                // Ask user quantity
                string input = Microsoft.VisualBasic.Interaction.InputBox(
                    $"Enter quantity (Available: {availableQty})",
                    "Add to Cart", "1");

                if (int.TryParse(input, out int qty) && qty > 0 && qty <= availableQty)
                {
                    decimal totalPrice = price * qty;
                    dataGridViewCart.Rows.Add(productName, karat, price, qty, totalPrice);
                }
                else
                {
                    MessageBox.Show("Invalid quantity!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a product.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void buttonConfirmOrder_Click(object sender, EventArgs e)
        {
            if (dataGridViewCart.Rows.Count == 0)
            {
                MessageBox.Show("Cart is empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("Do you want to confirm this order?", "Confirm Order",
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    string currentUsername = db.GetUsernameById(currentUserId);

                    foreach (DataGridViewRow row in dataGridViewCart.Rows)
                    {
                        if (row.IsNewRow) continue;

                        string productName = row.Cells["ProductName"].Value.ToString();
                        string karat = row.Cells["Karat"].Value.ToString();
                        decimal price = Convert.ToDecimal(row.Cells["Price"].Value);
                        int qty = Convert.ToInt32(row.Cells["Quantity"].Value);

                        string query = @"INSERT INTO ProductsBuy 
                                (UserID, ProductName, Karat, Price, Quantity, OrderDate, PaymentMethod, Username, Branch)
                                VALUES (@UserID, @ProductName, @Karat, @Price, @Quantity, @OrderDate, @PaymentMethod, @Username, @Branch)";

                        db.ExecuteQuery(query,
                            new SqlParameter("@UserID", currentUserId),
                            new SqlParameter("@ProductName", productName),
                            new SqlParameter("@Karat", karat),
                            new SqlParameter("@Price", price),
                            new SqlParameter("@Quantity", qty),
                            new SqlParameter("@OrderDate", DateTime.Now),
                            new SqlParameter("@PaymentMethod", "Cash"),
                            new SqlParameter("@Username", currentUsername),  // ✅ now real username
                            new SqlParameter("@Branch", currentBranchName)
                        );

                        string updateQuery = @"UPDATE Product 
                                       SET Quantity = Quantity - @Qty 
                                       WHERE ProductName = @ProductName";
                        db.ExecuteQuery(updateQuery,
                            new SqlParameter("@Qty", qty),
                            new SqlParameter("@ProductName", productName)
                        );
                    }

                    MessageBox.Show("Order confirmed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridViewCart.Rows.Clear();
                    LoadProducts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error confirming order: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            JewellerySection jc = new JewellerySection(currentUserId, currentBranchName);
            jc.Show();
        }
    }
}
