using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Store.Forms
{
    public class BillForm : Form
    {
        private DataGridViewRow row;
        private PrintDocument printDocument = new PrintDocument();
        private PrintPreviewDialog previewDialog = new PrintPreviewDialog();

        public BillForm(DataGridViewRow selectedRow)
        {
            row = selectedRow;

            // Form setup
            this.Text = "Sales Bill";
            this.Size = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Hook print event
            printDocument.PrintPage += PrintDocument_PrintPage;

            // Show print preview when form loads
            this.Load += BillForm_Load;
        }

        private void BillForm_Load(object sender, EventArgs e)
        {
            previewDialog.Document = printDocument;
            previewDialog.Width = 800;
            previewDialog.Height = 600;
            previewDialog.StartPosition = FormStartPosition.CenterScreen;
            previewDialog.ShowDialog(); // Show preview window
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                Font font = new Font("Arial", 12);
                float y = 20;

                e.Graphics.DrawString("***** SALES BILL *****", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, 250, y);
                y += 40;

                e.Graphics.DrawString("Order ID: " + row.Cells["ProductBuyID"].Value.ToString(), font, Brushes.Black, 50, y); y += 25;
                e.Graphics.DrawString("User ID: " + row.Cells["UserID"].Value.ToString(), font, Brushes.Black, 50, y); y += 25;
                e.Graphics.DrawString("Customer Name: " + row.Cells["Username"].Value.ToString(), font, Brushes.Black, 50, y); y += 25;
                e.Graphics.DrawString("Product: " + row.Cells["ProductName"].Value.ToString(), font, Brushes.Black, 50, y); y += 25;
                e.Graphics.DrawString("Karat: " + row.Cells["Karat"].Value.ToString(), font, Brushes.Black, 50, y); y += 25;
                e.Graphics.DrawString("Price: " + row.Cells["Price"].Value.ToString(), font, Brushes.Black, 50, y); y += 25;
                e.Graphics.DrawString("Quantity: " + row.Cells["Quantity"].Value.ToString(), font, Brushes.Black, 50, y); y += 25;
                e.Graphics.DrawString("Payment Method: " + row.Cells["PaymentMethod"].Value.ToString(), font, Brushes.Black, 50, y); y += 25;
                e.Graphics.DrawString("Order Date: " + row.Cells["OrderDate"].Value.ToString(), font, Brushes.Black, 50, y); y += 25;

                decimal total = Convert.ToDecimal(row.Cells["Price"].Value) * Convert.ToInt32(row.Cells["Quantity"].Value);
                e.Graphics.DrawString("Total Amount: " + total.ToString("C"), new Font("Arial", 14, FontStyle.Bold), Brushes.Black, 50, y); y += 40;

                e.Graphics.DrawString("Thank you for your purchase!", font, Brushes.Black, 200, y);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error printing bill: " + ex.Message);
            }
        }
    }
}
