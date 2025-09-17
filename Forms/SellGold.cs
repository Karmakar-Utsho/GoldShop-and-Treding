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

namespace Store.Forms
{
    public partial class SellGold : Form
    {
        private readonly int currentUserId;
        private DatabaseQ db = new DatabaseQ();
        private decimal buyQty, buyPrice, currentPrice;
        private int quantity = 1;
        private int investmentId;
        public SellGold(int userId)
        {
            InitializeComponent();
            currentUserId = userId;
            
        }

        private void lblPlus_Click(object sender, EventArgs e)
        {
            if (quantity < buyQty) quantity++; 
            lblQuantity.Text = quantity + ""; 
            UpdateSellDisplay();
        }

        private void lblMinus_Click(object sender, EventArgs e)
        {
            if (quantity > 1) quantity--; 
            lblQuantity.Text = quantity + ""; 
            UpdateSellDisplay();
        }

        private void SellGold_Load(object sender, EventArgs e)
        {
            var dt = db.GetInvestment(currentUserId);
            if (dt.Rows.Count == 0)

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No investment has been done yet");
                    // send back to JewellerySection
                    
                    return;   // <— stop here!
                }
            var row = dt.Rows[0];

            investmentId = Convert.ToInt32(row["InvestmentID"]);

            buyQty = Convert.ToDecimal(row["QuantityBought"]); buyPrice = Convert.ToDecimal(row["GramPriceAtBuy"]);
            currentPrice = db.GetGramPrice();
            lblBoughtQty.Text = buyQty + "g"; lblBoughtPrice.Text = buyPrice + " $/g"; lblCurrentPrice.Text = currentPrice + " $/g";
            lblQuantity.Text = quantity + "";
            
            UpdateSellDisplay();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            InvestmentSection investmentsection = new InvestmentSection(currentUserId);
            investmentsection.Show();
        }

        private void lblBoughtQty_Click(object sender, EventArgs e)
        {

        }

        private void UpdateSellDisplay() 
        { 
            lblSellTotal.Text = (quantity * currentPrice) + " $"; 
        }


        private void btnSell_Click(object sender, EventArgs e)
        {
            decimal totalRecv = quantity * currentPrice;
            db.AddSell(investmentId, quantity, totalRecv);
            MessageBox.Show("Gold sold.");
            new InvestmentSection(currentUserId).Show(); Hide();
        }
    }
}
