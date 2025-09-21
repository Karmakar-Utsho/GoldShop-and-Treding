namespace Store.Forms
{
    partial class MyUserProfile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pbProfilePicture = new System.Windows.Forms.PictureBox();
            this.updatepic = new System.Windows.Forms.Button();
            this.editbutton = new System.Windows.Forms.Button();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.savebutton = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.mobile = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.usernametextBox = new System.Windows.Forms.TextBox();
            this.emailtextBox = new System.Windows.Forms.TextBox();
            this.mobiletextBox = new System.Windows.Forms.TextBox();
            this.addresstextBox = new System.Windows.Forms.TextBox();
            this.backpic = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backpic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(156, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 57);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(130, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(260, 34);
            this.label6.TabIndex = 1;
            this.label6.Text = "Profile Information";
            // 
            // pbProfilePicture
            // 
            this.pbProfilePicture.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbProfilePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbProfilePicture.Location = new System.Drawing.Point(23, 70);
            this.pbProfilePicture.Name = "pbProfilePicture";
            this.pbProfilePicture.Size = new System.Drawing.Size(118, 115);
            this.pbProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbProfilePicture.TabIndex = 1;
            this.pbProfilePicture.TabStop = false;
            this.pbProfilePicture.Click += new System.EventHandler(this.pbProfilePicture_Click);
            // 
            // updatepic
            // 
            this.updatepic.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatepic.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updatepic.Location = new System.Drawing.Point(147, 103);
            this.updatepic.Name = "updatepic";
            this.updatepic.Size = new System.Drawing.Size(158, 46);
            this.updatepic.TabIndex = 2;
            this.updatepic.Text = "Update Picture";
            this.updatepic.UseVisualStyleBackColor = true;
            this.updatepic.Click += new System.EventHandler(this.updatepic_Click);
            // 
            // editbutton
            // 
            this.editbutton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.editbutton.Location = new System.Drawing.Point(512, 103);
            this.editbutton.Name = "editbutton";
            this.editbutton.Size = new System.Drawing.Size(167, 50);
            this.editbutton.TabIndex = 3;
            this.editbutton.Text = "Edit Profile";
            this.editbutton.UseVisualStyleBackColor = true;
            this.editbutton.Click += new System.EventHandler(this.editbutton_Click);
            // 
            // cancelbutton
            // 
            this.cancelbutton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbutton.Location = new System.Drawing.Point(536, 342);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(160, 44);
            this.cancelbutton.TabIndex = 4;
            this.cancelbutton.Text = "Cancel";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // savebutton
            // 
            this.savebutton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebutton.Location = new System.Drawing.Point(147, 343);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(175, 43);
            this.savebutton.TabIndex = 5;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.username.Location = new System.Drawing.Point(31, 245);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(93, 23);
            this.username.TabIndex = 6;
            this.username.Text = "UserName";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.email.Location = new System.Drawing.Point(70, 287);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(54, 23);
            this.email.TabIndex = 7;
            this.email.Text = "Email";
            // 
            // mobile
            // 
            this.mobile.AutoSize = true;
            this.mobile.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mobile.Location = new System.Drawing.Point(393, 240);
            this.mobile.Name = "mobile";
            this.mobile.Size = new System.Drawing.Size(116, 20);
            this.mobile.TabIndex = 8;
            this.mobile.Text = "Mobile Number";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.ForeColor = System.Drawing.Color.White;
            this.address.Location = new System.Drawing.Point(432, 285);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(70, 23);
            this.address.TabIndex = 9;
            this.address.Text = "Address";
            // 
            // usernametextBox
            // 
            this.usernametextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametextBox.Location = new System.Drawing.Point(130, 245);
            this.usernametextBox.Name = "usernametextBox";
            this.usernametextBox.Size = new System.Drawing.Size(226, 30);
            this.usernametextBox.TabIndex = 10;
            // 
            // emailtextBox
            // 
            this.emailtextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailtextBox.Location = new System.Drawing.Point(130, 287);
            this.emailtextBox.Name = "emailtextBox";
            this.emailtextBox.Size = new System.Drawing.Size(226, 30);
            this.emailtextBox.TabIndex = 11;
            // 
            // mobiletextBox
            // 
            this.mobiletextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobiletextBox.Location = new System.Drawing.Point(508, 240);
            this.mobiletextBox.Name = "mobiletextBox";
            this.mobiletextBox.Size = new System.Drawing.Size(220, 30);
            this.mobiletextBox.TabIndex = 12;
            // 
            // addresstextBox
            // 
            this.addresstextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresstextBox.Location = new System.Drawing.Point(508, 285);
            this.addresstextBox.Name = "addresstextBox";
            this.addresstextBox.Size = new System.Drawing.Size(220, 30);
            this.addresstextBox.TabIndex = 13;
            // 
            // backpic
            // 
            this.backpic.Image = global::Store.Properties.Resources.Back;
            this.backpic.Location = new System.Drawing.Point(12, 12);
            this.backpic.Name = "backpic";
            this.backpic.Size = new System.Drawing.Size(47, 42);
            this.backpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backpic.TabIndex = 14;
            this.backpic.TabStop = false;
            this.backpic.Click += new System.EventHandler(this.backpic_Click);
            // 
            // MyUserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backpic);
            this.Controls.Add(this.addresstextBox);
            this.Controls.Add(this.mobiletextBox);
            this.Controls.Add(this.emailtextBox);
            this.Controls.Add(this.usernametextBox);
            this.Controls.Add(this.address);
            this.Controls.Add(this.mobile);
            this.Controls.Add(this.email);
            this.Controls.Add(this.username);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.editbutton);
            this.Controls.Add(this.updatepic);
            this.Controls.Add(this.pbProfilePicture);
            this.Controls.Add(this.panel1);
            this.Name = "MyUserProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyUserProfile";
            this.Load += new System.EventHandler(this.MyUserProfile_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbProfilePicture;
        private System.Windows.Forms.Button updatepic;
        private System.Windows.Forms.Button editbutton;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label mobile;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.TextBox usernametextBox;
        private System.Windows.Forms.TextBox emailtextBox;
        private System.Windows.Forms.TextBox mobiletextBox;
        private System.Windows.Forms.TextBox addresstextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox backpic;
    }
}