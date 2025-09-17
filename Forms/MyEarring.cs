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
    public partial class MyEarring : Form
    {

        private readonly int currentUserId;
        
        public MyEarring(int userId)
        {
            InitializeComponent();
            this.currentUserId = userId;
        }

        private void MyEarring_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            JewellerySection jewellery = new JewellerySection(currentUserId);
            jewellery.Show();
        }

        private void earRing1_Click(object sender, EventArgs e)
        {
            this.Hide();
            BuyEarring1 buy1 = new BuyEarring1(currentUserId);
            buy1.Show();
        }

        private void earRing2_Click(object sender, EventArgs e)
        {
            this.Hide();
            BuyEarring2 buy2 = new BuyEarring2(currentUserId);
            buy2.Show();
        }

        private void earRing3_Click(object sender, EventArgs e)
        {
            this.Hide();
            BuyEarring3 buy3 = new BuyEarring3(currentUserId);
            buy3.Show();
        }
    }
}
