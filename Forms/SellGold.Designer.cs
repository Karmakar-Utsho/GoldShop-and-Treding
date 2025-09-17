namespace Store.Forms
{
    partial class SellGold
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
            this.lblBoughtQty = new System.Windows.Forms.Label();
            this.lblBoughtPrice = new System.Windows.Forms.Label();
            this.lblCurrentPrice = new System.Windows.Forms.Label();
            this.lblPlus = new System.Windows.Forms.Button();
            this.lblMinus = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblSellPrice = new System.Windows.Forms.Label();
            this.lblSellTotal = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBoughtQty
            // 
            this.lblBoughtQty.AutoSize = true;
            this.lblBoughtQty.Location = new System.Drawing.Point(235, 133);
            this.lblBoughtQty.Name = "lblBoughtQty";
            this.lblBoughtQty.Size = new System.Drawing.Size(44, 16);
            this.lblBoughtQty.TabIndex = 0;
            this.lblBoughtQty.Text = "label1";
            this.lblBoughtQty.Click += new System.EventHandler(this.lblBoughtQty_Click);
            // 
            // lblBoughtPrice
            // 
            this.lblBoughtPrice.AutoSize = true;
            this.lblBoughtPrice.Location = new System.Drawing.Point(235, 193);
            this.lblBoughtPrice.Name = "lblBoughtPrice";
            this.lblBoughtPrice.Size = new System.Drawing.Size(44, 16);
            this.lblBoughtPrice.TabIndex = 1;
            this.lblBoughtPrice.Text = "label2";
            // 
            // lblCurrentPrice
            // 
            this.lblCurrentPrice.AutoSize = true;
            this.lblCurrentPrice.Location = new System.Drawing.Point(235, 246);
            this.lblCurrentPrice.Name = "lblCurrentPrice";
            this.lblCurrentPrice.Size = new System.Drawing.Size(44, 16);
            this.lblCurrentPrice.TabIndex = 2;
            this.lblCurrentPrice.Text = "label1";
            // 
            // lblPlus
            // 
            this.lblPlus.Location = new System.Drawing.Point(465, 296);
            this.lblPlus.Name = "lblPlus";
            this.lblPlus.Size = new System.Drawing.Size(55, 33);
            this.lblPlus.TabIndex = 3;
            this.lblPlus.Text = "+";
            this.lblPlus.UseVisualStyleBackColor = true;
            this.lblPlus.Click += new System.EventHandler(this.lblPlus_Click);
            // 
            // lblMinus
            // 
            this.lblMinus.Location = new System.Drawing.Point(354, 296);
            this.lblMinus.Name = "lblMinus";
            this.lblMinus.Size = new System.Drawing.Size(55, 33);
            this.lblMinus.TabIndex = 4;
            this.lblMinus.Text = "-";
            this.lblMinus.UseVisualStyleBackColor = true;
            this.lblMinus.Click += new System.EventHandler(this.lblMinus_Click);
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(400, 369);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(73, 41);
            this.btnSell.TabIndex = 5;
            this.btnSell.Text = "Sell";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(415, 304);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(44, 16);
            this.lblQuantity.TabIndex = 6;
            this.lblQuantity.Text = "label1";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSellPrice
            // 
            this.lblSellPrice.AutoSize = true;
            this.lblSellPrice.Location = new System.Drawing.Point(102, 133);
            this.lblSellPrice.Name = "lblSellPrice";
            this.lblSellPrice.Size = new System.Drawing.Size(107, 16);
            this.lblSellPrice.TabIndex = 7;
            this.lblSellPrice.Text = "Gold Remaining:";
            // 
            // lblSellTotal
            // 
            this.lblSellTotal.AutoSize = true;
            this.lblSellTotal.Location = new System.Drawing.Point(465, 225);
            this.lblSellTotal.Name = "lblSellTotal";
            this.lblSellTotal.Size = new System.Drawing.Size(44, 16);
            this.lblSellTotal.TabIndex = 8;
            this.lblSellTotal.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Store.Properties.Resources.Back;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Buying Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Current Market Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Total Selling Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(254, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 31);
            this.label4.TabIndex = 13;
            this.label4.Text = "Make Profit! Sell Now";
            // 
            // SellGold
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSellTotal);
            this.Controls.Add(this.lblSellPrice);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.lblMinus);
            this.Controls.Add(this.lblPlus);
            this.Controls.Add(this.lblCurrentPrice);
            this.Controls.Add(this.lblBoughtPrice);
            this.Controls.Add(this.lblBoughtQty);
            this.Name = "SellGold";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellGold";
            this.Load += new System.EventHandler(this.SellGold_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBoughtQty;
        private System.Windows.Forms.Label lblBoughtPrice;
        private System.Windows.Forms.Label lblCurrentPrice;
        private System.Windows.Forms.Button lblPlus;
        private System.Windows.Forms.Button lblMinus;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblSellPrice;
        private System.Windows.Forms.Label lblSellTotal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}