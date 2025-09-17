namespace Store.Forms
{
    partial class JewellerySection
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
            this.Profilebutton = new System.Windows.Forms.Button();
            this.necklace30 = new System.Windows.Forms.PictureBox();
            this.earring10 = new System.Windows.Forms.PictureBox();
            this.ringpic20 = new System.Windows.Forms.PictureBox();
            this.signoutbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelOrderView = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.necklace30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.earring10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ringpic20)).BeginInit();
            this.SuspendLayout();
            // 
            // Profilebutton
            // 
            this.Profilebutton.Location = new System.Drawing.Point(12, 16);
            this.Profilebutton.Name = "Profilebutton";
            this.Profilebutton.Size = new System.Drawing.Size(88, 41);
            this.Profilebutton.TabIndex = 0;
            this.Profilebutton.Text = "My Profile";
            this.Profilebutton.UseVisualStyleBackColor = true;
            this.Profilebutton.Click += new System.EventHandler(this.Profilebutton_Click);
            // 
            // necklace30
            // 
            this.necklace30.Image = global::Store.Properties.Resources.necklace3;
            this.necklace30.Location = new System.Drawing.Point(658, 174);
            this.necklace30.Name = "necklace30";
            this.necklace30.Size = new System.Drawing.Size(280, 232);
            this.necklace30.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.necklace30.TabIndex = 4;
            this.necklace30.TabStop = false;
            this.necklace30.Click += new System.EventHandler(this.necklace30_Click);
            // 
            // earring10
            // 
            this.earring10.Image = global::Store.Properties.Resources.earring1;
            this.earring10.Location = new System.Drawing.Point(346, 174);
            this.earring10.Name = "earring10";
            this.earring10.Size = new System.Drawing.Size(289, 232);
            this.earring10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.earring10.TabIndex = 3;
            this.earring10.TabStop = false;
            this.earring10.Click += new System.EventHandler(this.earring10_Click);
            // 
            // ringpic20
            // 
            this.ringpic20.BackgroundImage = global::Store.Properties.Resources.rings2;
            this.ringpic20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ringpic20.Location = new System.Drawing.Point(44, 174);
            this.ringpic20.Name = "ringpic20";
            this.ringpic20.Size = new System.Drawing.Size(280, 232);
            this.ringpic20.TabIndex = 2;
            this.ringpic20.TabStop = false;
            this.ringpic20.Click += new System.EventHandler(this.ringpic20_Click);
            // 
            // signoutbutton
            // 
            this.signoutbutton.BackgroundImage = global::Store.Properties.Resources.sign_out;
            this.signoutbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.signoutbutton.Location = new System.Drawing.Point(884, 12);
            this.signoutbutton.Name = "signoutbutton";
            this.signoutbutton.Size = new System.Drawing.Size(72, 39);
            this.signoutbutton.TabIndex = 1;
            this.signoutbutton.UseVisualStyleBackColor = true;
            this.signoutbutton.Click += new System.EventHandler(this.signoutbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ring";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(458, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Earrings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(760, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Necklace";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(831, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Invest in Gold";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(299, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(384, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "Welcome to our Jewellery Store";
            // 
            // labelOrderView
            // 
            this.labelOrderView.AutoSize = true;
            this.labelOrderView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderView.Location = new System.Drawing.Point(899, 493);
            this.labelOrderView.Name = "labelOrderView";
            this.labelOrderView.Size = new System.Drawing.Size(57, 20);
            this.labelOrderView.TabIndex = 10;
            this.labelOrderView.Text = "Order";
            this.labelOrderView.Click += new System.EventHandler(this.labelOrderView_Click);
            // 
            // JewellerySection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.labelOrderView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.necklace30);
            this.Controls.Add(this.earring10);
            this.Controls.Add(this.ringpic20);
            this.Controls.Add(this.signoutbutton);
            this.Controls.Add(this.Profilebutton);
            this.Name = "JewellerySection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JewellerySection";
            this.Load += new System.EventHandler(this.JewellerySection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.necklace30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.earring10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ringpic20)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Profilebutton;
        private System.Windows.Forms.Button signoutbutton;
        private System.Windows.Forms.PictureBox ringpic20;
        private System.Windows.Forms.PictureBox earring10;
        private System.Windows.Forms.PictureBox necklace30;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelOrderView;
    }
}