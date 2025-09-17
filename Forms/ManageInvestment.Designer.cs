namespace Store.Forms
{
    partial class ManageInvestment
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
            this.BtnSavePrice = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.signoutbutton = new System.Windows.Forms.Button();
            this.numericGramPrice = new System.Windows.Forms.NumericUpDown();
            this.dgvInvestments = new System.Windows.Forms.DataGridView();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericGramPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvestments)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSavePrice
            // 
            this.BtnSavePrice.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSavePrice.Location = new System.Drawing.Point(237, 14);
            this.BtnSavePrice.Name = "BtnSavePrice";
            this.BtnSavePrice.Size = new System.Drawing.Size(77, 53);
            this.BtnSavePrice.TabIndex = 0;
            this.BtnSavePrice.Text = "Initiate Price";
            this.BtnSavePrice.UseVisualStyleBackColor = true;
            this.BtnSavePrice.Click += new System.EventHandler(this.BtnSavePrice_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TxtSearch);
            this.panel1.Controls.Add(this.signoutbutton);
            this.panel1.Controls.Add(this.numericGramPrice);
            this.panel1.Controls.Add(this.BtnSavePrice);
            this.panel1.Location = new System.Drawing.Point(5, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 96);
            this.panel1.TabIndex = 1;
            // 
            // signoutbutton
            // 
            this.signoutbutton.BackgroundImage = global::Store.Properties.Resources.sign_out;
            this.signoutbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.signoutbutton.Location = new System.Drawing.Point(883, 13);
            this.signoutbutton.Name = "signoutbutton";
            this.signoutbutton.Size = new System.Drawing.Size(72, 39);
            this.signoutbutton.TabIndex = 2;
            this.signoutbutton.UseVisualStyleBackColor = true;
            this.signoutbutton.Click += new System.EventHandler(this.signoutbutton_Click);
            // 
            // numericGramPrice
            // 
            this.numericGramPrice.Location = new System.Drawing.Point(59, 30);
            this.numericGramPrice.Name = "numericGramPrice";
            this.numericGramPrice.Size = new System.Drawing.Size(163, 22);
            this.numericGramPrice.TabIndex = 1;
            this.numericGramPrice.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // dgvInvestments
            // 
            this.dgvInvestments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvestments.Location = new System.Drawing.Point(10, 112);
            this.dgvInvestments.Name = "dgvInvestments";
            this.dgvInvestments.RowHeadersWidth = 51;
            this.dgvInvestments.RowTemplate.Height = 24;
            this.dgvInvestments.Size = new System.Drawing.Size(964, 430);
            this.dgvInvestments.TabIndex = 2;
            this.dgvInvestments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvestments_CellContentClick);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(463, 30);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(238, 22);
            this.TxtSearch.TabIndex = 3;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(717, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search";
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.dgvInvestments);
            this.Controls.Add(this.panel1);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericGramPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvestments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSavePrice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numericGramPrice;
        private System.Windows.Forms.DataGridView dgvInvestments;
        private System.Windows.Forms.Button signoutbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSearch;
    }
}