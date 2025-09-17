using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Store.Models;


namespace Store.Forms
{
    public partial class CartForm : Form
    {

        private readonly int currentUserId;
        private readonly CartItem cartItem;
        public CartForm(int userId, CartItem item)
        {
            InitializeComponent();
            currentUserId = userId;
            cartItem = item;
        }

        private void CartForm_Load(object sender, EventArgs e)
        {
            lblProuct.Text = cartItem.ProductName;
            lblKarat.Text = cartItem.Karat + "K";
            lblQuantity.Text = cartItem.Quantity.ToString();
            lblTotal.Text = (cartItem.Price * cartItem.Quantity).ToString("N0") + " $";
            
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            var payment = new PaymentForm(currentUserId, cartItem);
            this.Hide();
            payment.Show();
        }
    }
}
