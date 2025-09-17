using Store.DataQ;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Store.Properties
{
    public partial class ProductSellList : Form
    {
        private readonly DatabaseQ db = new DatabaseQ();
        private PrintDocument printDocument = new PrintDocument();
        private PrintPreviewDialog printPreview = new PrintPreviewDialog();

        private int currentRow = 0; // Track current row for multi-page printing
        private float rowHeight = 25f;

        public ProductSellList()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            printDocument.PrintPage += PrintDocument_PrintPage;
        }

        private void ProductSellList_Load(object sender, EventArgs e)
        {
            dateTimePicker.Value = DateTime.Today;

            comboBoxShort.Items.Clear();
            comboBoxShort.Items.Add("High to Low");
            comboBoxShort.Items.Add("Low to High");
            comboBoxShort.SelectedIndex = 0;

            LoadProducts();
        }

        private void LoadProducts()
        {
            DateTime selectedDate = dateTimePicker.Value.Date;
            string sortOrder = comboBoxShort.SelectedItem?.ToString() == "High to Low" ? "DESC" : "ASC";

            DataTable dt = db.GetProductsByDate(selectedDate, sortOrder);
            dataGridView.DataSource = dt;

            decimal totalSell = db.GetTotalSellByDate(selectedDate);
            textBoxTotalSell.Text = totalSell.ToString("N2");
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e) => LoadProducts();
        private void comboBoxShort_SelectedIndexChanged(object sender, EventArgs e) => LoadProducts();

        private void buttonPrintSellReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView.Rows.Count > 0)
                {
                    currentRow = 0; // Reset for multi-page printing
                    printDocument.DefaultPageSettings.Landscape = true;
                    printPreview.Document = printDocument;
                    printPreview.Width = 900;
                    printPreview.Height = 600;
                    printPreview.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No sell data to print.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error printing report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                Font headerFont = new Font("Arial", 12, FontStyle.Bold);
                Font cellFont = new Font("Arial", 10);

                float x = e.MarginBounds.Left;
                float y = e.MarginBounds.Top;

                int colCount = dataGridView.Columns.Count;
                float totalWidth = e.MarginBounds.Width;
                float colWidth = totalWidth / colCount;

                // Draw Title
                string title = "SALES REPORT";
                e.Graphics.DrawString(title, new Font("Arial", 16, FontStyle.Bold), Brushes.Black, x + 200, y);
                y += 40;

                // Draw column headers
                for (int i = 0; i < colCount; i++)
                {
                    RectangleF rect = new RectangleF(x + i * colWidth, y, colWidth, rowHeight);
                    e.Graphics.FillRectangle(Brushes.LightGray, rect);
                    e.Graphics.DrawRectangle(Pens.Black, rect.X, rect.Y, rect.Width, rect.Height);
                    StringFormat sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                    e.Graphics.DrawString(dataGridView.Columns[i].HeaderText, headerFont, Brushes.Black, rect, sf);
                }
                y += rowHeight;

                // Draw rows
                while (currentRow < dataGridView.Rows.Count)
                {
                    DataGridViewRow row = dataGridView.Rows[currentRow];
                    if (row.IsNewRow)
                    {
                        currentRow++;
                        continue;
                    }

                    for (int i = 0; i < colCount; i++)
                    {
                        RectangleF rect = new RectangleF(x + i * colWidth, y, colWidth, rowHeight);
                        e.Graphics.DrawRectangle(Pens.Black, rect.X, rect.Y, rect.Width, rect.Height);
                        StringFormat sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                        string value = row.Cells[i].Value?.ToString() ?? "";
                        e.Graphics.DrawString(value, cellFont, Brushes.Black, rect, sf);
                    }

                    y += rowHeight;
                    currentRow++;

                    // Page break if needed
                    if (y + rowHeight > e.MarginBounds.Bottom)
                    {
                        e.HasMorePages = true;
                        return;
                    }
                }

                // Draw Total Sell at the bottom
                y += 20;
                string totalText = "TOTAL SELL: " + textBoxTotalSell.Text;
                e.Graphics.DrawString(totalText, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, x, y);

                // Finished printing
                e.HasMorePages = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error printing report: " + ex.Message);
            }
        }
    }
}
