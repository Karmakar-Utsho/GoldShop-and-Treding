namespace Store.Forms
{
    partial class InvestmentSection
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
            this.radio1g = new System.Windows.Forms.RadioButton();
            this.radio5g = new System.Windows.Forms.RadioButton();
            this.radio10g = new System.Windows.Forms.RadioButton();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPlus = new System.Windows.Forms.Button();
            this.lblMinus = new System.Windows.Forms.Button();
            this.btnBuyNow = new System.Windows.Forms.Button();
            this.btnSellGold = new System.Windows.Forms.Button();
            this.lblCurrentPrice = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // radio1g
            // 
            this.radio1g.AutoSize = true;
            this.radio1g.Location = new System.Drawing.Point(136, 161);
            this.radio1g.Name = "radio1g";
            this.radio1g.Size = new System.Drawing.Size(75, 20);
            this.radio1g.TabIndex = 0;
            this.radio1g.TabStop = true;
            this.radio1g.Text = "1g Gold";
            this.radio1g.UseVisualStyleBackColor = true;
            // 
            // radio5g
            // 
            this.radio5g.AutoSize = true;
            this.radio5g.Location = new System.Drawing.Point(136, 212);
            this.radio5g.Name = "radio5g";
            this.radio5g.Size = new System.Drawing.Size(75, 20);
            this.radio5g.TabIndex = 1;
            this.radio5g.TabStop = true;
            this.radio5g.Text = "5g Gold";
            this.radio5g.UseVisualStyleBackColor = true;
            // 
            // radio10g
            // 
            this.radio10g.AutoSize = true;
            this.radio10g.Location = new System.Drawing.Point(136, 263);
            this.radio10g.Name = "radio10g";
            this.radio10g.Size = new System.Drawing.Size(82, 20);
            this.radio10g.TabIndex = 2;
            this.radio10g.TabStop = true;
            this.radio10g.Text = "10g Gold";
            this.radio10g.UseVisualStyleBackColor = true;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(377, 295);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(44, 16);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "label1";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlus
            // 
            this.lblPlus.Location = new System.Drawing.Point(404, 287);
            this.lblPlus.Name = "lblPlus";
            this.lblPlus.Size = new System.Drawing.Size(64, 32);
            this.lblPlus.TabIndex = 4;
            this.lblPlus.Text = "+";
            this.lblPlus.UseVisualStyleBackColor = true;
            this.lblPlus.Click += new System.EventHandler(this.lblPlus_Click);
            // 
            // lblMinus
            // 
            this.lblMinus.Location = new System.Drawing.Point(307, 287);
            this.lblMinus.Name = "lblMinus";
            this.lblMinus.Size = new System.Drawing.Size(64, 32);
            this.lblMinus.TabIndex = 5;
            this.lblMinus.Text = "-";
            this.lblMinus.UseVisualStyleBackColor = true;
            this.lblMinus.Click += new System.EventHandler(this.lblMinus_Click);
            // 
            // btnBuyNow
            // 
            this.btnBuyNow.Location = new System.Drawing.Point(358, 367);
            this.btnBuyNow.Name = "btnBuyNow";
            this.btnBuyNow.Size = new System.Drawing.Size(84, 38);
            this.btnBuyNow.TabIndex = 6;
            this.btnBuyNow.Text = "Buy Now";
            this.btnBuyNow.UseVisualStyleBackColor = true;
            this.btnBuyNow.Click += new System.EventHandler(this.btnBuyNow_Click);
            // 
            // btnSellGold
            // 
            this.btnSellGold.Location = new System.Drawing.Point(656, 54);
            this.btnSellGold.Name = "btnSellGold";
            this.btnSellGold.Size = new System.Drawing.Size(95, 50);
            this.btnSellGold.TabIndex = 7;
            this.btnSellGold.Text = "Sell Your Gold";
            this.btnSellGold.UseVisualStyleBackColor = true;
            this.btnSellGold.Click += new System.EventHandler(this.btnSellGold_Click);
            // 
            // lblCurrentPrice
            // 
            this.lblCurrentPrice.AutoSize = true;
            this.lblCurrentPrice.Location = new System.Drawing.Point(277, 109);
            this.lblCurrentPrice.Name = "lblCurrentPrice";
            this.lblCurrentPrice.Size = new System.Drawing.Size(44, 16);
            this.lblCurrentPrice.TabIndex = 8;
            this.lblCurrentPrice.Text = "label1";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(424, 232);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 16);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "label1";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Store.Properties.Resources.Back;
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Current Market Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Calculated Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(256, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 31);
            this.label3.TabIndex = 13;
            this.label3.Text = "Invest In Your Future";
            // 
            // InvestmentSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblCurrentPrice);
            this.Controls.Add(this.btnSellGold);
            this.Controls.Add(this.btnBuyNow);
            this.Controls.Add(this.lblMinus);
            this.Controls.Add(this.lblPlus);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.radio10g);
            this.Controls.Add(this.radio5g);
            this.Controls.Add(this.radio1g);
            this.Name = "InvestmentSection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InvestmentSection";
            this.Load += new System.EventHandler(this.InvestmentSection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radio1g;
        private System.Windows.Forms.RadioButton radio5g;
        private System.Windows.Forms.RadioButton radio10g;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button lblPlus;
        private System.Windows.Forms.Button lblMinus;
        private System.Windows.Forms.Button btnBuyNow;
        private System.Windows.Forms.Button btnSellGold;
        private System.Windows.Forms.Label lblCurrentPrice;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}