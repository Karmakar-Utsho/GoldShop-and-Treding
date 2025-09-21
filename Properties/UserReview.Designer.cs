namespace Store.Properties
{
    partial class UserReview
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
            this.dataGridViewReview = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReview)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewReview
            // 
            this.dataGridViewReview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReview.Location = new System.Drawing.Point(12, 108);
            this.dataGridViewReview.Name = "dataGridViewReview";
            this.dataGridViewReview.RowHeadersWidth = 51;
            this.dataGridViewReview.RowTemplate.Height = 24;
            this.dataGridViewReview.Size = new System.Drawing.Size(771, 517);
            this.dataGridViewReview.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkOrange;
            this.label6.Location = new System.Drawing.Point(242, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(284, 45);
            this.label6.TabIndex = 19;
            this.label6.Text = "Customer Review";
            // 
            // UserReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 650);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridViewReview);
            this.Name = "UserReview";
            this.Text = "UserReview";
            this.Load += new System.EventHandler(this.UserReview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewReview;
        private System.Windows.Forms.Label label6;
    }
}