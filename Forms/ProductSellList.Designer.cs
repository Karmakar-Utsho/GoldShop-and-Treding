namespace Store.Properties
{
    partial class ProductSellList
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
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.comboBoxShort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTotalSell = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonPrintSellReport = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(12, 98);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(276, 22);
            this.dateTimePicker.TabIndex = 0;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 146);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1147, 497);
            this.dataGridView.TabIndex = 1;
            // 
            // comboBoxShort
            // 
            this.comboBoxShort.FormattingEnabled = true;
            this.comboBoxShort.Location = new System.Drawing.Point(1005, 96);
            this.comboBoxShort.Name = "comboBoxShort";
            this.comboBoxShort.Size = new System.Drawing.Size(154, 24);
            this.comboBoxShort.TabIndex = 2;
            this.comboBoxShort.SelectedIndexChanged += new System.EventHandler(this.comboBoxShort_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1002, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sort By";
            // 
            // textBoxTotalSell
            // 
            this.textBoxTotalSell.Location = new System.Drawing.Point(559, 99);
            this.textBoxTotalSell.Name = "textBoxTotalSell";
            this.textBoxTotalSell.ReadOnly = true;
            this.textBoxTotalSell.Size = new System.Drawing.Size(313, 22);
            this.textBoxTotalSell.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(385, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total Sell Amount:";
            // 
            // buttonPrintSellReport
            // 
            this.buttonPrintSellReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.buttonPrintSellReport.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrintSellReport.ForeColor = System.Drawing.Color.White;
            this.buttonPrintSellReport.Location = new System.Drawing.Point(481, 665);
            this.buttonPrintSellReport.Name = "buttonPrintSellReport";
            this.buttonPrintSellReport.Size = new System.Drawing.Size(180, 42);
            this.buttonPrintSellReport.TabIndex = 6;
            this.buttonPrintSellReport.Text = "Print sell report";
            this.buttonPrintSellReport.UseVisualStyleBackColor = false;
            this.buttonPrintSellReport.Click += new System.EventHandler(this.buttonPrintSellReport_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label3.Location = new System.Drawing.Point(394, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 40);
            this.label3.TabIndex = 7;
            this.label3.Text = "Product Sell List";
            // 
            // ProductSellList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1171, 729);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonPrintSellReport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTotalSell);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxShort);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.dateTimePicker);
            this.Name = "ProductSellList";
            this.Text = "ProductSellList";
            this.Load += new System.EventHandler(this.ProductSellList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ComboBox comboBoxShort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTotalSell;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonPrintSellReport;
        private System.Windows.Forms.Label label3;
    }
}