using System;
using System.Data;
using System.Windows.Forms;
using Store.DataQ; // so you can use DatabaseQ

namespace Store.Properties
{
    public partial class UserReview : Form
    {
        private DatabaseQ db;

        public UserReview()
        {
            InitializeComponent();
            db = new DatabaseQ();
        }

        private void UserReview_Load(object sender, EventArgs e)
        {
            LoadReviews();
        }

        private void LoadReviews()
        {
            try
            {
                DataTable dt = db.GetAllUserReviews();
                dataGridViewReview.DataSource = dt;

                // Optional: auto resize columns for better view
                dataGridViewReview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading reviews: " + ex.Message);
            }
        }
    }
}
