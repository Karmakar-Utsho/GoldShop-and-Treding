using Store.DataQ;
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
    public partial class InvestmentSection : Form
    {


        private readonly int currentUserId;
        private decimal unitPrice;
        private int quantity = 1;
        private DatabaseQ db = new DatabaseQ();
        public InvestmentSection(int userId)
        {
            InitializeComponent();
            currentUserId = userId;
        }

        private void InvestmentSection_Load(object sender, EventArgs e)
        {

            unitPrice = db.GetGramPrice();
            lblCurrentPrice.Text = unitPrice.ToString("N2") + " $/g";

            radio1g.CheckedChanged += RadioChanged;
            radio5g.CheckedChanged += RadioChanged;
            radio10g.CheckedChanged += RadioChanged;
            lblQuantity.Text = quantity.ToString();
           
           

            UpdateDisplay();
        }

        private void RadioChanged(object s, EventArgs e) 
        { 
            UpdateDisplay(); 
        }


        private void btnBuyNow_Click(object sender, EventArgs e)
        {
            var user = /* fetch username,address,mobile via db*/ db.GetUserById(currentUserId);
            db.AddInvestment(currentUserId, user["Username"].ToString(),
                quantity * (radio1g.Checked ? 1 : radio5g.Checked ? 5 : 10), Convert.ToDecimal(lblTotal.Text.Replace(" $", "")), unitPrice);
            MessageBox.Show("You have successfully invested in gold.");
            new JewellerySection(currentUserId).Show();
            Hide();
        }

        private void btnSellGold_Click(object sender, EventArgs e)
        {
            var sellForm = new SellGold(currentUserId);
            sellForm.Show(); Hide();
        }

        private void lblPlus_Click(object sender, EventArgs e)
        {
            quantity++; lblQuantity.Text = quantity + ""; 
            UpdateDisplay();
        }

        private void lblMinus_Click(object sender, EventArgs e)
        {
            if (quantity > 1) quantity--; lblQuantity.Text = quantity + "";
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            decimal factor = radio1g.Checked ? 1m : radio5g.Checked ? 5m : 10m;
            decimal total = unitPrice * factor * quantity;
            lblTotal.Text = total.ToString("N2") + " $";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            JewellerySection jewellery = new JewellerySection(currentUserId);
            jewellery.Show();
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
