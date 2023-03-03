using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace OlympiaCSharp
{
    public partial class Control : Form
    {
        public Control()
        {
            InitializeComponent();
            this.FormClosing += MainForm_FormClosing;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Set the initial opacity of the form to 0.0
            this.Opacity = 0.0;

            // Create a Timer control with a 500 millisecond interval
            Timer timer = new Timer();
            timer.Interval = 10;

            // Start the timer and handle its Tick event
            timer.Start();
            timer.Tick += (s, args) =>
            {
                // Increase the form's opacity by 0.05 until it reaches 1.0
                if (this.Opacity < 1.0)
                {
                    this.Opacity += 0.05;
                }
                else
                {
                    // Stop the timer when the opacity reaches 1.0
                    timer.Stop();
                }
            };
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true; // Cancel the default close behavior
                ExitForm(); // Close the application
            }
        }

        // Exit form function
        private void ExitForm()
        {
            // Confirm box with icon
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thoát chương trình?", "Dừng hệ thống khẩn cấp", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                // Do nothing
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExitForm();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xlsx;*.xls";
            openFileDialog.Title = "Select an Excel File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Create an instance of the Excel.Application class
                Excel.Application excelApp = new Excel.Application();

                // Open the Excel file
                Excel.Workbook workbook = excelApp.Workbooks.Open(openFileDialog.FileName);

                // Get a reference to the first worksheet
                Excel.Worksheet worksheet = workbook.Worksheets[1];

                // Get the range of cells that contain data
                Excel.Range range = worksheet.UsedRange;

                // Read the data into a two-dimensional array
                object[,] values = (object[,])range.Value2;

                // Create a new DataTable
                DataTable dataTable = new DataTable();

                // Add columns to the DataTable based on the column headers in the Excel file
                for (int i = 1; i <= range.Columns.Count; i++)
                {
                    string columnName = (string)(range.Cells[1, i].Value2 ?? $"Column {i}");
                    dataTable.Columns.Add(columnName);
                }

                // Add rows to the DataTable based on the data in the Excel file
                for (int i = 2; i <= range.Rows.Count; i++)
                {
                    DataRow dataRow = dataTable.NewRow();
                    for (int j = 1; j <= range.Columns.Count; j++)
                    {
                        dataRow[j - 1] = values[i, j];
                    }
                    dataTable.Rows.Add(dataRow);
                }

                // Bind the DataTable to the DataGridView control
                dataGridView1.DataSource = dataTable;

                // Clean up
                workbook.Close(false);
                excelApp.Quit();
            }
        }
    }
}
