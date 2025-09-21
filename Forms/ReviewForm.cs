using System;
using System.Drawing;
using System.Windows.Forms;
using Store.DataQ; // DatabaseQ (optional, for saving)

namespace Store.Forms
{
    public class ReviewForm : Form
    {
        private readonly int currentUserId;
        private readonly string currentBranchName;

        private Label[] stars = new Label[5];
        private int selectedRating = 0;

        private Label lblBranch;
        private Label lblComment;
        private TextBox txtComment;
        private Button btnSubmit;
        private Button btnCancel;

        public ReviewForm(int userId, string branch)
        {
            currentUserId = userId;
            currentBranchName = branch;
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            // Form
            this.Text = "Submit Review";
            this.StartPosition = FormStartPosition.CenterParent;
            this.ClientSize = new Size(440, 320);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            // Branch label
            lblBranch = new Label
            {
                Text = $"Review for {currentBranchName} branch",
                AutoSize = true,
                Location = new Point(20, 14)
            };
            this.Controls.Add(lblBranch);

            // Star labels (Unicode stars)
            for (int i = 0; i < 5; i++)
            {
                var lbl = new Label
                {
                    Text = "☆",
                    Tag = i + 1,
                    Font = new Font("Segoe UI Symbol", 28, FontStyle.Regular),
                    Size = new Size(44, 44),
                    Location = new Point(20 + i * 50, 50),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Cursor = Cursors.Hand,
                    ForeColor = Color.Gray
                };
                lbl.MouseEnter += Star_MouseEnter;
                lbl.MouseLeave += Star_MouseLeave;
                lbl.Click += Star_Click;
                stars[i] = lbl;
                this.Controls.Add(lbl);
            }

            // Comment
            lblComment = new Label { Text = "Comment:", AutoSize = true, Location = new Point(20, 115) };
            txtComment = new TextBox { Multiline = true, Location = new Point(20, 135), Size = new Size(400, 110) };

            // Buttons
            btnSubmit = new Button { Text = "Submit", Location = new Point(240, 260), Size = new Size(80, 30) };
            btnCancel = new Button { Text = "Cancel", Location = new Point(330, 260), Size = new Size(80, 30) };
            btnSubmit.Click += BtnSubmit_Click;
            btnCancel.Click += (s, e) => this.Close();

            // Add controls
            this.Controls.Add(lblComment);
            this.Controls.Add(txtComment);
            this.Controls.Add(btnSubmit);
            this.Controls.Add(btnCancel);
        }

        private void Star_MouseEnter(object sender, EventArgs e)
        {
            int hover = (int)((Label)sender).Tag;
            for (int i = 0; i < 5; i++)
            {
                if (i < hover) { stars[i].Text = "★"; stars[i].ForeColor = Color.Gold; }
                else { stars[i].Text = "☆"; stars[i].ForeColor = Color.Gray; }
            }
        }

        private void Star_MouseLeave(object sender, EventArgs e)
        {
            UpdateStars(selectedRating);
        }

        private void Star_Click(object sender, EventArgs e)
        {
            selectedRating = (int)((Label)sender).Tag;
            UpdateStars(selectedRating);
        }

        private void UpdateStars(int rating)
        {
            for (int i = 0; i < 5; i++)
            {
                if (i < rating) { stars[i].Text = "★"; stars[i].ForeColor = Color.Gold; }
                else { stars[i].Text = "☆"; stars[i].ForeColor = Color.Gray; }
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (selectedRating == 0)
            {
                MessageBox.Show("Please select a star rating.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtComment.Text))
            {
                MessageBox.Show("Please enter a comment.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string comment = txtComment.Text.Trim();

            try
            {
                var db = new DatabaseQ();
                db.AddUserReview(currentUserId, null, selectedRating, comment);

                MessageBox.Show("Review submitted. Thank you!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving review: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ReviewForm
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "ReviewForm";
            this.ResumeLayout(false);

        }
    }
}
