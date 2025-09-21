namespace Store.Forms
{
    partial class OrderVeiw
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
            this.buttonConfirmOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewCart = new System.Windows.Forms.DataGridView();
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.buttonAddToCart = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonConfirmOrder);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridViewCart);
            this.panel1.Location = new System.Drawing.Point(693, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 684);
            this.panel1.TabIndex = 1;
            // 
            // buttonConfirmOrder
            // 
            this.buttonConfirmOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.buttonConfirmOrder.Font = new System.Drawing.Font("Segoe UI Historic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmOrder.ForeColor = System.Drawing.Color.White;
            this.buttonConfirmOrder.Location = new System.Drawing.Point(570, 646);
            this.buttonConfirmOrder.Name = "buttonConfirmOrder";
            this.buttonConfirmOrder.Size = new System.Drawing.Size(144, 45);
            this.buttonConfirmOrder.TabIndex = 12;
            this.buttonConfirmOrder.Text = "Confirm Order";
            this.buttonConfirmOrder.UseVisualStyleBackColor = false;
            this.buttonConfirmOrder.Click += new System.EventHandler(this.buttonConfirmOrder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your Oder List";
            // 
            // dataGridViewCart
            // 
            this.dataGridViewCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCart.Location = new System.Drawing.Point(8, 86);
            this.dataGridViewCart.Name = "dataGridViewCart";
            this.dataGridViewCart.RowHeadersWidth = 51;
            this.dataGridViewCart.RowTemplate.Height = 24;
            this.dataGridViewCart.Size = new System.Drawing.Size(706, 554);
            this.dataGridViewCart.TabIndex = 0;
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduct.Location = new System.Drawing.Point(12, 98);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.RowHeadersWidth = 51;
            this.dataGridViewProduct.RowTemplate.Height = 24;
            this.dataGridViewProduct.Size = new System.Drawing.Size(667, 554);
            this.dataGridViewProduct.TabIndex = 1;
            // 
            // buttonAddToCart
            // 
            this.buttonAddToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.buttonAddToCart.Font = new System.Drawing.Font("Segoe UI Historic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddToCart.ForeColor = System.Drawing.Color.White;
            this.buttonAddToCart.Location = new System.Drawing.Point(535, 658);
            this.buttonAddToCart.Name = "buttonAddToCart";
            this.buttonAddToCart.Size = new System.Drawing.Size(144, 45);
            this.buttonAddToCart.TabIndex = 11;
            this.buttonAddToCart.Text = "Add to Cart";
            this.buttonAddToCart.UseVisualStyleBackColor = false;
            this.buttonAddToCart.Click += new System.EventHandler(this.buttonAddToCart_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Segoe UI Historic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.Color.Black;
            this.buttonBack.Location = new System.Drawing.Point(12, 59);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(144, 33);
            this.buttonBack.TabIndex = 13;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel2.Location = new System.Drawing.Point(685, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 633);
            this.panel2.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkOrange;
            this.label5.Location = new System.Drawing.Point(490, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(390, 40);
            this.label5.TabIndex = 15;
            this.label5.Text = "Crown Unity Jewellery ";
            // 
            // OrderVeiw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 746);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonAddToCart);
            this.Controls.Add(this.dataGridViewProduct);
            this.Controls.Add(this.panel1);
            this.Name = "OrderVeiw";
            this.Text = "OrderVeiw";
            this.Load += new System.EventHandler(this.OrderVeiw_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewCart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewProduct;
        private System.Windows.Forms.Button buttonConfirmOrder;
        private System.Windows.Forms.Button buttonAddToCart;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
    }
}