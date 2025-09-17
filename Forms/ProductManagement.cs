using Store.DataQ;
using System;
using System.Data;
using System.Windows.Forms;

namespace Store.Forms
{
    public partial class ProductManagement : Form
    {
        private readonly DatabaseQ db = new DatabaseQ();
        private int selectedProductId = 0;

        public ProductManagement()
        {
            InitializeComponent();
        }

        private void ProductManagement_Load(object sender, EventArgs e)
        {
            try
            {
                LoadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBoxProductName.Text.Trim();
                string category = textBoxCategory.Text.Trim();

                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(category))
                {
                    MessageBox.Show("Please fill all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(textBoxPrice.Text, out decimal price))
                {
                    MessageBox.Show("Invalid price value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(textBoxQuantity.Text, out int quantity))
                {
                    MessageBox.Show("Invalid quantity value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                db.AddProduct(name, category, price, quantity);

                MessageBox.Show("Product added successfully!");
                LoadProducts();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridViewProduct.Rows[e.RowIndex];
                    selectedProductId = Convert.ToInt32(row.Cells["Id"].Value);

                    textBoxProductName.Text = row.Cells["ProductName"].Value.ToString();
                    textBoxCategory.Text = row.Cells["Category"].Value.ToString();
                    textBoxPrice.Text = row.Cells["Price"].Value.ToString();
                    textBoxQuantity.Text = row.Cells["Quantity"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error selecting product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedProductId == 0)
                {
                    MessageBox.Show("Please select a product to update.");
                    return;
                }

                string name = textBoxProductName.Text.Trim();
                string category = textBoxCategory.Text.Trim();

                if (!decimal.TryParse(textBoxPrice.Text, out decimal price))
                {
                    MessageBox.Show("Invalid price value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(textBoxQuantity.Text, out int quantity))
                {
                    MessageBox.Show("Invalid quantity value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                db.UpdateProduct(selectedProductId, name, category, price, quantity);

                MessageBox.Show("Product updated successfully!");
                LoadProducts();
                ClearInputs();
                selectedProductId = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedProductId == 0)
                {
                    MessageBox.Show("Please select a product to delete.");
                    return;
                }

                DialogResult confirm = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    db.DeleteProduct(selectedProductId);
                    MessageBox.Show("Product deleted successfully!");
                    LoadProducts();
                    ClearInputs();
                    selectedProductId = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string keyword = textBoxSearch.Text.Trim();
                DataTable dt = db.SearchProducts(keyword);
                dataGridViewProduct.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching products: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputs()
        {
            textBoxProductName.Clear();
            textBoxCategory.Clear();
            textBoxPrice.Clear();
            textBoxQuantity.Clear();
        }
    }
}
