using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Store.DataQ;
using Store.Models;

namespace Store.Forms
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            rolecomboBox.Items.Clear();
            rolecomboBox.Items.AddRange(new string[] { "Admin", "User" });
            rolecomboBox.SelectedIndex = -1;

            comboBoxBranch.Items.Clear();
            comboBoxBranch.Items.AddRange(new string[] { "Jashore","Kuril", "Banani", "Badda", "Mirpur", "Bashundhara", "Farmgate", "Uttara", "Joypurhat" });
            comboBoxBranch.SelectedIndex = -1;
        }

        private void registerbutton_Click(object sender, EventArgs e)
        {
            string username = usernametext.Text.Trim();
            string password = passwordBox.Text;
            string confirmPassword = confirmtext.Text;
            string email = emailtext.Text.Trim();
            string address = Addresstext.Text.Trim();
            string mobile = mobiletext.Text.Trim();
            string role = rolecomboBox.SelectedItem?.ToString();
            string branch = comboBoxBranch.SelectedItem?.ToString();

            // Input Validation
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(mobile) || string.IsNullOrEmpty(role) || string.IsNullOrEmpty(branch))
            {
                MessageBox.Show("Please fill in all required fields.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Initialize DatabaseQ
            DatabaseQ db = new DatabaseQ();

            // **NEW**: Check for existing username
            if (db.GetUserByUsername(username) != null)
            {
                MessageBox.Show($"The username '{username}' is already taken. Please choose another.",
                                "Registration Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }


            try
            {

                // Create User Object
                User newUser = new User
                {
                    Username = username,
                    Password = password,
                    Email = email,
                    Address = address,
                    Mobile = mobile,
                    Role = role,
                    Branch = branch

                };

                

                // Insert User and Get New UserID
                int newUserId = db.CreateUser(newUser);

                // Insert into tblUserProfile for the new user
                if (role == "User")
                {
                    UserProfile newProfile = new UserProfile
                    {
                        UserID = newUserId,
                        Username = username, // Default to username or empty
                        ProfilePicture = null,
                        Email = email,
                        Address = address,
                        Mobile = mobile,
                    };
                    db.CreateUserProfile(newProfile);
                }

                MessageBox.Show("Registration Successful! You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Navigate back to Login Form
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
            catch (SqlException sqlEx)
            {
                if (sqlEx.Number == 2627) // Unique constraint violation
                {
                    MessageBox.Show("Username or Email already exists. Please choose another.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("An error occurred during registration: " + sqlEx.Message, "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
             this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
