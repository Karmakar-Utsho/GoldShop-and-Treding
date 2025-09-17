using Store.DataQ;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store.Properties
{
    public partial class UserManage : Form
    {

        private readonly DatabaseQ db = new DatabaseQ();
        private int selectedUserId = 0;

        public UserManage()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            button.Visible = false; // Initially hide button

        }

        private void UserManage_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            DataTable dt = db.GetAllUsersExceptAdmin();
            dataGridView.DataSource = dt;
            button.Visible = false; // Hide button until row selected
            selectedUserId = 0;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBox.Text.Trim();
            DataTable dt = db.SearchUsers(keyword);
            dataGridView.DataSource = dt;
            button.Visible = false; // Hide button until row selected
            selectedUserId = 0;
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView.SelectedRows[0];
                selectedUserId = Convert.ToInt32(row.Cells["UserID"].Value);
                bool isActive = Convert.ToBoolean(row.Cells["IsActive"].Value);

                button.Visible = true;
                button.Text = isActive ? "Deactivate User" : "Activate User";
                button.BackColor = isActive ? Color.Red : Color.Green;
            }
            else
            {
                button.Visible = false;
                selectedUserId = 0;
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (selectedUserId > 0)
            {
                bool isCurrentlyActive = button.Text == "Deactivate User";
                db.ToggleUserActive(selectedUserId, !isCurrentlyActive); // Toggle status
                LoadUsers(); // Refresh grid
            }
        }
    }
}
