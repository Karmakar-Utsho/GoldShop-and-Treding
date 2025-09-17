using Store.Forms;
using Store.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            UserManage um = new UserManage();
            um.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageInvestment manage = new ManageInvestment();
            manage.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProductSellList ps = new ProductSellList();
            ps.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ProductManagement pm = new ProductManagement();
            pm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BillManagement bm = new BillManagement();
            bm.Show();
        }
    }
}
