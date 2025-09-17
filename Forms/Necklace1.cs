using Store.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store.Forms
{
    public partial class Necklace1 : Form
    {
        private readonly int currentUserId;
        private decimal basePrice = 900;
        private int selectedKarat = 18;
        private int quantity = 1;
        public Necklace1(int userId)
        {
            InitializeComponent();
            currentUserId = userId;
        }

        private void Necklace1_Load(object sender, EventArgs e)
        {
            radio18K.Checked = true;
            label2.Text = basePrice.ToString("N0") + " $";

            radio18K.CheckedChanged += RadioKarat_CheckedChanged;
            radio22K.CheckedChanged += RadioKarat_CheckedChanged;



            lblQuantity.Text = quantity.ToString();

            UpdatePriceDisplay();
        }

        private void UpdatePriceDisplay()
        {
            decimal unitPrice = (selectedKarat == 22) ? 1000m : basePrice;
            decimal total = unitPrice * quantity;
            label2.Text = total.ToString("N0") + " $";
        }

        private void RadioKarat_CheckedChanged(object sender, EventArgs e)
        {

            selectedKarat = radio22K.Checked ? 22 : 18;
            UpdatePriceDisplay();

        }

        private void BtnAddToCart_Click(object sender, EventArgs e)
        {
            var unitPrice = (selectedKarat == 22) ? 1000m : basePrice;
            var item = new CartItem
            {
                ProductName = "Turkish Necklace",
                Karat = selectedKarat,
                Price = unitPrice,
                Quantity = quantity
            };
            var cartForm = new CartForm(currentUserId, item);
            Hide();
            cartForm.Show();
        }

        private void LblMinus_Click(object sender, EventArgs e)
        {
            if (quantity > 1)
            {
                quantity--;
                lblQuantity.Text = quantity.ToString();
                UpdatePriceDisplay();
            }
        }

        private void LblPlus_Click(object sender, EventArgs e)
        {
            quantity++;
            lblQuantity.Text = quantity.ToString();
            UpdatePriceDisplay();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Necklaces buy4 = new Necklaces(currentUserId);
            buy4.Show();
        }
    }
}
