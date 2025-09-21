namespace Store.Forms
{
    partial class BuyEarring1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblPlus = new System.Windows.Forms.Label();
            this.LblMinus = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radio22K = new System.Windows.Forms.RadioButton();
            this.radio18K = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAddToCart = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Store.Properties.Resources.earring1;
            this.pictureBox1.Location = new System.Drawing.Point(39, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 304);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LblPlus);
            this.panel1.Controls.Add(this.LblMinus);
            this.panel1.Controls.Add(this.lblQuantity);
            this.panel1.Controls.Add(this.price);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.radio22K);
            this.panel1.Controls.Add(this.radio18K);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(355, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 304);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // LblPlus
            // 
            this.LblPlus.AutoSize = true;
            this.LblPlus.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlus.ForeColor = System.Drawing.Color.White;
            this.LblPlus.Location = new System.Drawing.Point(174, 105);
            this.LblPlus.Name = "LblPlus";
            this.LblPlus.Size = new System.Drawing.Size(30, 31);
            this.LblPlus.TabIndex = 7;
            this.LblPlus.Text = "+";
            this.LblPlus.Click += new System.EventHandler(this.LblPlus_Click);
            // 
            // LblMinus
            // 
            this.LblMinus.AutoSize = true;
            this.LblMinus.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMinus.ForeColor = System.Drawing.Color.White;
            this.LblMinus.Location = new System.Drawing.Point(85, 105);
            this.LblMinus.Name = "LblMinus";
            this.LblMinus.Size = new System.Drawing.Size(23, 31);
            this.LblMinus.TabIndex = 6;
            this.LblMinus.Text = "-";
            this.LblMinus.Click += new System.EventHandler(this.LblMinus_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.White;
            this.lblQuantity.Location = new System.Drawing.Point(109, 107);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(63, 25);
            this.lblQuantity.TabIndex = 5;
            this.lblQuantity.Text = "label3";
            this.lblQuantity.Click += new System.EventHandler(this.lblQuantity_Click);
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.ForeColor = System.Drawing.Color.White;
            this.price.Location = new System.Drawing.Point(51, 64);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(54, 25);
            this.price.TabIndex = 4;
            this.price.Text = "price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(108, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // radio22K
            // 
            this.radio22K.AutoSize = true;
            this.radio22K.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio22K.ForeColor = System.Drawing.Color.White;
            this.radio22K.Location = new System.Drawing.Point(203, 185);
            this.radio22K.Name = "radio22K";
            this.radio22K.Size = new System.Drawing.Size(99, 27);
            this.radio22K.TabIndex = 2;
            this.radio22K.TabStop = true;
            this.radio22K.Text = "22 Karat";
            this.radio22K.UseVisualStyleBackColor = true;
            // 
            // radio18K
            // 
            this.radio18K.AutoSize = true;
            this.radio18K.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio18K.ForeColor = System.Drawing.Color.White;
            this.radio18K.Location = new System.Drawing.Point(72, 185);
            this.radio18K.Name = "radio18K";
            this.radio18K.Size = new System.Drawing.Size(99, 27);
            this.radio18K.TabIndex = 1;
            this.radio18K.TabStop = true;
            this.radio18K.Text = "18 Karat";
            this.radio18K.UseVisualStyleBackColor = true;
            this.radio18K.CheckedChanged += new System.EventHandler(this.radio18K_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Turkish Earring";
            // 
            // BtnAddToCart
            // 
            this.BtnAddToCart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddToCart.ForeColor = System.Drawing.Color.Green;
            this.BtnAddToCart.Location = new System.Drawing.Point(489, 453);
            this.BtnAddToCart.Name = "BtnAddToCart";
            this.BtnAddToCart.Size = new System.Drawing.Size(188, 38);
            this.BtnAddToCart.TabIndex = 2;
            this.BtnAddToCart.Text = "Add to Cart";
            this.BtnAddToCart.UseVisualStyleBackColor = true;
            this.BtnAddToCart.Click += new System.EventHandler(this.BtnAddToCart_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Store.Properties.Resources.Back;
            this.pictureBox4.Location = new System.Drawing.Point(12, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(47, 42);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // BuyEarring1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.BtnAddToCart);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "BuyEarring1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuyEarring1";
            this.Load += new System.EventHandler(this.BuyEarring1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radio22K;
        private System.Windows.Forms.RadioButton radio18K;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnAddToCart;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label LblPlus;
        private System.Windows.Forms.Label LblMinus;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}