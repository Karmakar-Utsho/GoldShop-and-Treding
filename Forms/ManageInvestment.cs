using Store.DataQ;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store.Forms
{
    public partial class ManageInvestment : Form
    {
        private readonly DatabaseQ db = new DatabaseQ();
        public ManageInvestment()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

            numericGramPrice.Value = db.GetGramPrice();

            // initial load (no filter)
            dgvInvestments.DataSource = db.SearchInvestmentsByUsername(null);

            LoadInvestments();

        }

        private void BtnSavePrice_Click(object sender, EventArgs e)
        {
            db.SetGramPrice(numericGramPrice.Value);
            MessageBox.Show("Gram price updated.");
        }

        private void LoadInvestments()
        {
            DataTable dt = db.GetInvestment(/* all: no filter*/0);
            dgvInvestments.DataSource = dt;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

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

        private void dgvInvestments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            // server - side filter on every keystroke:
        dgvInvestments.DataSource = db.SearchInvestmentsByUsername(TxtSearch.Text.Trim());

    }
}
}
