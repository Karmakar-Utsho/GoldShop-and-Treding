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
    public partial class Rings : Form
    {
        private readonly int currentUserId;
        private readonly string currentBranchName;

        public Rings(int userId, string currentBranchName)
        {
            InitializeComponent();
            this.currentUserId = userId;
            this.currentBranchName = currentBranchName;
        }

        private void Rings_Load(object sender, EventArgs e)
        {

        }

        private void backpic_Click(object sender, EventArgs e)
        {
            this.Hide();
            JewellerySection jewellery = new JewellerySection(currentUserId, currentBranchName);
            jewellery.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ring2 buy2 = new Ring2(currentUserId);
            buy2.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ring1 buy1 = new Ring1(currentUserId);
            buy1.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ring3 buy3 = new Ring3(currentUserId);
            buy3.Show();
        }
    }
}
