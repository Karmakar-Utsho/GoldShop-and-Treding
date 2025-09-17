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
    public partial class JewellerySection : Form
    {
        private int currentUserId;

        public JewellerySection(int userId)
        {
            InitializeComponent();
            this.currentUserId = userId;
            
        }

        private void JewellerySection_Load(object sender, EventArgs e)
        {

        }

        private void ringpic20_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rings R1 = new Rings(currentUserId);
            R1.Show();
        }

        private void earring10_Click(object sender, EventArgs e)
        {
            this.Hide();
            MyEarring E1 = new MyEarring(currentUserId);
            E1.Show();
        }

        private void necklace30_Click(object sender, EventArgs e)
        {
            this.Hide();
            Necklaces N1 = new Necklaces(currentUserId);
            N1.Show();
        }

        private void signoutbutton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
        }

        private void Profilebutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MyUserProfile myuserprofile = new MyUserProfile(currentUserId);
            myuserprofile.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            InvestmentSection investmentsection = new InvestmentSection(currentUserId);
            investmentsection.Show();
        }

        private void labelOrderView_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderVeiw ov = new OrderVeiw(currentUserId);
            ov.Show();
        }
    }
}
