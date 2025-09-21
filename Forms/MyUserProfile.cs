using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Store.Models;
using System.IO;
using Store.DataQ;

namespace Store.Forms
{
    public partial class MyUserProfile : Form
    {

        private readonly int currentUserId;
        private readonly string currentBranchName;
        private readonly DatabaseQ dbHelper;

        // You can still use an absolute path if you wish:
        // private readonly string profileImagePath = @"C:\C#\FirstProject\ResearchLinkApp\Resources\profile\";
        // But a relative path is often better for deployment:
        private readonly string profileImagePath = @"C:\Users\msi\Music\Store\Images\";
        //private readonly string profileImagePath;


        public MyUserProfile(int currentUserId, string currentBranchName)
        {
            InitializeComponent();
            usernametextBox.ReadOnly = true;
            this.currentUserId = currentUserId;

            dbHelper = new DatabaseQ();


            profileImagePath = Path.Combine(Application.StartupPath, "Images");
            EnsureProfileDirectoryExists();

            pbProfilePicture.SizeMode = PictureBoxSizeMode.Zoom;
            this.currentBranchName = currentBranchName;
        }

        private void MyUserProfile_Load(object sender, EventArgs e)
        {


            editbutton.Click += editbutton_Click;
            savebutton.Click += savebutton_Click;
            cancelbutton.Click += cancelbutton_Click;
            updatepic.Click += updatepic_Click;


            LoadUserProfile();
        }



        private void EnsureProfileDirectoryExists()
        {
            try
            {
                if (!Directory.Exists(profileImagePath))
                {
                    Directory.CreateDirectory(profileImagePath);
                    // Optionally copy default.png here if needed
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating profile directory: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void LoadUserProfile()
        {
            try
            {
                DataRow userProfile = dbHelper.GetUserProfileById(currentUserId);
                if (userProfile == null)
                {
                    MessageBox.Show("User profile not found.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                // Populate text fields
                usernametextBox.Text = userProfile["Username"]?.ToString() ?? string.Empty;
                emailtextBox.Text = userProfile["Email"]?.ToString() ?? string.Empty;
                mobiletextBox.Text = userProfile["Mobile"]?.ToString() ?? string.Empty;
                addresstextBox.Text = userProfile["Address"]?.ToString() ?? string.Empty;

                // Handle profile picture
                string profilePictureFile = userProfile["ProfilePicture"]?.ToString();
                string fullProfilePicturePath;

                if (string.IsNullOrEmpty(profilePictureFile))
                {
                    // Use default image if no profile picture is set
                    fullProfilePicturePath = Path.Combine(profileImagePath, "default.png");
                }
                else
                {
                    fullProfilePicturePath = Path.Combine(profileImagePath, profilePictureFile);

                    // Fallback to default if the specified image doesn't exist
                    if (!File.Exists(fullProfilePicturePath))
                    {
                        fullProfilePicturePath = Path.Combine(profileImagePath, "default.png");
                    }
                }

                // Load the image
                if (File.Exists(fullProfilePicturePath))
                {
                    pbProfilePicture.Image = Image.FromFile(fullProfilePicturePath);
                    pbProfilePicture.ImageLocation = fullProfilePicturePath;
                }
                
                ToggleEditMode(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading user profile: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void ToggleEditMode(bool isEditable)
        {
            emailtextBox.ReadOnly = !isEditable;
            mobiletextBox.ReadOnly = !isEditable;
            addresstextBox.ReadOnly = !isEditable;
            cancelbutton.Visible = isEditable;
            savebutton.Visible = isEditable;
            editbutton.Visible = !isEditable;
            updatepic.Visible = isEditable;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void updatepic_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";
                fileDialog.Title = "Select a Profile Image";

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string selectedFile = fileDialog.FileName;
                        string fileName = Path.GetFileName(selectedFile);
                        string destinationPath = Path.Combine(profileImagePath, fileName);

                        File.Copy(selectedFile, destinationPath, true);
                        pbProfilePicture.Image = Image.FromFile(destinationPath);
                        pbProfilePicture.ImageLocation = destinationPath;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error updating profile picture: {ex.Message}",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }


        }

        private void editbutton_Click(object sender, EventArgs e)
        {
            ToggleEditMode(true);
        }

        private void savebutton_Click(object sender, EventArgs e)
        {


            try
            {
                // Validate inputs
                string email = emailtextBox.Text.Trim();
                string username = usernametextBox.Text.Trim();
                string mobile = mobiletextBox.Text.Trim();
                string address = addresstextBox.Text.Trim();

                if (string.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Email is required.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(username))
                {
                    MessageBox.Show("Full Name is required.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Determine what profile picture file to store in the DB.
                string profilePictureFileName = null;

                // If the PictureBox has an ImageLocation, we take the file name from it
                if (!string.IsNullOrEmpty(pbProfilePicture.ImageLocation))
                {
                    profilePictureFileName = Path.GetFileName(pbProfilePicture.ImageLocation);
                }

                // Debug: Log profile update details
                Console.WriteLine($"Updating Profile: Username={username}, ProfilePicture={profilePictureFileName}, Email={email}, Address={address},  Mobile={mobile}");

                // Save to DB
                dbHelper.UpdateUserProfile(currentUserId, profilePictureFileName, email, address, mobile);

                MessageBox.Show("Profile updated successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reset form to view-only mode
                ToggleEditMode(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving profile: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            ToggleEditMode(false);
        }

        private void backpic_Click(object sender, EventArgs e)
        {
            this.Hide();
            JewellerySection jewellery = new JewellerySection(currentUserId, currentBranchName);
            jewellery.Show();
        }

        private void pbProfilePicture_Click(object sender, EventArgs e)
        {

        }
    }
}
