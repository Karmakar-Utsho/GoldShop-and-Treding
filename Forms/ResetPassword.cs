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
    public partial class ResetPassword : Form
    {

        private DatabaseQ dbHelper;
        public ResetPassword()
        {
            InitializeComponent();
            dbHelper = new DatabaseQ();
        }

        private void ResetPassword_Load(object sender, EventArgs e)
        {

        }

        private void savebutton_Click(object sender, EventArgs e)
        {


            string email = textBox1.Text.Trim();
            string newPassword = textBox2.Text;
            string confirmPassword = textBox3.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {

                bool success = dbHelper.ResetUserPassword(email, newPassword);

                if (success)
                {
                    MessageBox.Show("Password reset successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Email not found. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
