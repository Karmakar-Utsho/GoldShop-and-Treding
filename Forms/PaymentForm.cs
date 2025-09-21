using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Store.DataQ;
using Store.Models;


namespace Store.Forms
{
    public partial class PaymentForm : Form
    {

        private readonly int currentUserId;
        private readonly CartItem cartItem;
        private readonly DatabaseQ dbHelper = new DatabaseQ();

        public PaymentForm(int userId, CartItem item)
        {
            InitializeComponent();
            currentUserId = userId;
            cartItem = item;
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            lblAmount.Text = (cartItem.Price * cartItem.Quantity).ToString("N0") + " $";
            

        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            string paymentMethod = radioBkash.Checked ? "Bkash"
                : radioNagad.Checked ? "Nagad"
                : radiocash.Checked ? "CashOnDelivery"
                : null;

            string branch = dbHelper.GetUserBranchById(currentUserId);

            // Delegate to DatabaseQ
            dbHelper.AddProductBuy(
                currentUserId,
                cartItem.ProductName,
                cartItem.Karat,
                cartItem.Price,
                cartItem.Quantity,
                paymentMethod,
                branch
            );

            MessageBox.Show("Your order is confirmed!", "Order Placed",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            var jewellery = new JewellerySection(currentUserId, dbHelper.GetUserBranchById(currentUserId));
            this.Hide();
            jewellery.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
