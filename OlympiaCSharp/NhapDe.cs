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
    public partial class NhapDe : UserControl
    {
        bool toggled = true;
        public NhapDe()
        {
            InitializeComponent();
        }

        public void readExcel_Click(object sender, EventArgs e)
        {
            if (toggled)
            {
                // Create a new OpenFileDialog to allow the user to select an Excel file
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
                openFileDialog1.Title = "Select an Excel File";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    // Open the Excel file
                    string filePath = openFileDialog1.FileName;
                    Excel.Application excelApp = new Excel.Application();
                    Excel.Workbook workbook = excelApp.Workbooks.Open(filePath);

                    // Find the existing TabControl on the form
                    TabControl tabControl = this.Controls.OfType<TabControl>().FirstOrDefault();

                    // Create five TabPages if they don't already exist
                    TabPage tabPage1 = tabControl.TabPages.OfType<TabPage>().FirstOrDefault(x => x.Text == "Sheet 1");
                    if (tabPage1 == null)
                    {
                        tabPage1 = new TabPage("KHỞI ĐỘNG");
                        tabControl.TabPages.Add(tabPage1);
                        // Resize the TabPage to match the parent TabControl
                        tabPage1.Size = tabControl.Size;

                    }
                    TabPage tabPage2 = tabControl.TabPages.OfType<TabPage>().FirstOrDefault(x => x.Text == "Sheet 2");
                    if (tabPage2 == null)
                    {
                        tabPage2 = new TabPage("VƯỢT CHƯỚNG NGẠI VẬT");
                        tabControl.TabPages.Add(tabPage2);
                        // Resize the TabPage to match the parent TabControl
                        tabPage2.Size = tabControl.Size;
                    }
                    TabPage tabPage3 = tabControl.TabPages.OfType<TabPage>().FirstOrDefault(x => x.Text == "Sheet 3");
                    if (tabPage3 == null)
                    {
                        tabPage3 = new TabPage("TĂNG TỐC");
                        tabControl.TabPages.Add(tabPage3);
                        // Resize the TabPage to match the parent TabControl
                        tabPage3.Size = tabControl.Size;
                    }
                    TabPage tabPage4 = tabControl.TabPages.OfType<TabPage>().FirstOrDefault(x => x.Text == "Sheet 4");
                    if (tabPage4 == null)
                    {
                        tabPage4 = new TabPage("VỀ ĐÍCH");
                        tabControl.TabPages.Add(tabPage4);
                        // Resize the TabPage to match the parent TabControl
                        tabPage4.Size = tabControl.Size;
                    }
                    TabPage tabPage5 = tabControl.TabPages.OfType<TabPage>().FirstOrDefault(x => x.Text == "Sheet 5");
                    if (tabPage5 == null)
                    {
                        tabPage5 = new TabPage("CÂU HỎI PHỤ");
                        tabControl.TabPages.Add(tabPage5);
                        // Resize the TabPage to match the parent TabControl
                        tabPage5.Size = tabControl.Size;
                    }

                    // Create five DataGridViews, one for each tab
                    DataGridView dataGridView1 = new DataGridView();
                    DataGridView dataGridView2 = new DataGridView();
                    DataGridView dataGridView3 = new DataGridView();
                    DataGridView dataGridView4 = new DataGridView();
                    DataGridView dataGridView5 = new DataGridView();

                    // Add the DataGridViews to the appropriate TabPages
                    tabPage1.Controls.Add(dataGridView1);
                    tabPage2.Controls.Add(dataGridView2);
                    tabPage3.Controls.Add(dataGridView3);
                    tabPage4.Controls.Add(dataGridView4);
                    tabPage5.Controls.Add(dataGridView5);

                    // Resize the DataGridViews to match the parent TabPage
                    dataGridView1.Size = tabPage1.Size;
                    dataGridView2.Size = tabPage2.Size;
                    dataGridView3.Size = tabPage3.Size;
                    dataGridView4.Size = tabPage4.Size;
                    dataGridView5.Size = tabPage5.Size;

                    // Read data from the first sheet and bind it to the first DataGridView
                    Excel.Worksheet worksheet1 = (Excel.Worksheet)workbook.Worksheets[1];
                    Excel.Range range1 = worksheet1.UsedRange;
                    DataTable dataTable1 = new DataTable();
                    for (int i = 1; i <= range1.Columns.Count; i++)
                    {
                        string columnName = (string)(range1.Cells[1, i].Value2 ?? $"Column {i}");
                        dataTable1.Columns.Add(columnName);
                    }
                    object[,] values1 = (object[,])range1.Value2;
                    for (int i = 2; i <= range1.Rows.Count; i++)
                    {
                        DataRow dataRow = dataTable1.NewRow();
                        for (int j = 1; j <= range1.Columns.Count; j++)
                        {
                            dataRow[j - 1] = values1[i, j];
                        }
                        dataTable1.Rows.Add(dataRow);
                    }
                    dataGridView1.DataSource = dataTable1;

                    // Read data from the second sheet and bind it to the second DataGridView
                    Excel.Worksheet worksheet2 = (Excel.Worksheet)workbook.Worksheets[2];
                    Excel.Range range2 = worksheet2.UsedRange;
                    DataTable dataTable2 = new DataTable();
                    for (int i = 1; i <= range2.Columns.Count; i++)
                    {
                        string columnName = (string)(range2.Cells[1, i].Value2 ?? $"Column {i}");
                        dataTable2.Columns.Add(columnName);
                    }
                    object[,] values2 = (object[,])range2.Value2;
                    for (int i = 2; i <= range2.Rows.Count; i++)
                    {
                        DataRow dataRow = dataTable2.NewRow();
                        for (int j = 1; j <= range2.Columns.Count; j++)
                        {
                            dataRow[j - 1] = values2[i, j];
                        }
                        dataTable2.Rows.Add(dataRow);
                    }
                    dataGridView2.DataSource = dataTable2;

                    // Read data from the third sheet and bind it to the third DataGridView
                    Excel.Worksheet worksheet3 = (Excel.Worksheet)workbook.Worksheets[3];
                    Excel.Range range3 = worksheet3.UsedRange;
                    DataTable dataTable3 = new DataTable();
                    for (int i = 1; i <= range3.Columns.Count; i++)
                    {
                        string columnName = (string)(range3.Cells[1, i].Value2 ?? $"Column {i}");
                        dataTable3.Columns.Add(columnName);
                    }
                    object[,] values3 = (object[,])range3.Value2;
                    for (int i = 2; i <= range3.Rows.Count; i++)
                    {
                        DataRow dataRow = dataTable3.NewRow();
                        for (int j = 1; j <= range3.Columns.Count; j++)
                        {
                            dataRow[j - 1] = values3[i, j];
                        }
                        dataTable3.Rows.Add(dataRow);
                    }
                    dataGridView3.DataSource = dataTable3;

                    // Read data from the fourth sheet and bind it to the fourth DataGridView
                    Excel.Worksheet worksheet4 = (Excel.Worksheet)workbook.Worksheets[4];
                    Excel.Range range4 = worksheet4.UsedRange;
                    DataTable dataTable4 = new DataTable();
                    for (int i = 1; i <= range4.Columns.Count; i++)
                    {
                        string columnName = (string)(range4.Cells[1, i].Value2 ?? $"Column {i}");
                        dataTable4.Columns.Add(columnName);
                    }
                    object[,] values4 = (object[,])range4.Value2;
                    for (int i = 2; i <= range4.Rows.Count; i++)
                    {
                        DataRow dataRow = dataTable4.NewRow();
                        for (int j = 1; j <= range4.Columns.Count; j++)
                        {
                            dataRow[j - 1] = values4[i, j];
                        }
                        dataTable4.Rows.Add(dataRow);
                    }
                    dataGridView4.DataSource = dataTable4;

                    // Read data from the fifth sheet and bind it to the fifth DataGridView
                    Excel.Worksheet worksheet5 = (Excel.Worksheet)workbook.Worksheets[5];
                    Excel.Range range5 = worksheet5.UsedRange;
                    DataTable dataTable5 = new DataTable();
                    for (int i = 1; i <= range5.Columns.Count; i++)
                    {
                        string columnName = (string)(range5.Cells[1, i].Value2 ?? $"Column {i}");
                        dataTable5.Columns.Add(columnName);
                    }
                    object[,] values5 = (object[,])range5.Value2;
                    for (int i = 2; i <= range5.Rows.Count; i++)
                    {
                        DataRow dataRow = dataTable5.NewRow();
                        for (int j = 1; j <= range5.Columns.Count; j++)
                        {
                            dataRow[j - 1] = values5[i, j];
                        }
                        dataTable5.Rows.Add(dataRow);
                    }
                    dataGridView5.DataSource = dataTable5;

                    // Close the Excel file
                    workbook.Close(false);
                    excelApp.Quit();

                    // Add the TabControl to the form
                    this.Controls.Add(this.tabControl);
                    toggled = false;
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Giai đoạn thử nghiệm không thể ghi đè dữ liệu. Vui lòng thoát phần mềm và thao tác lại.", "THIS PROGRAM IS IN DEVELOPMENT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                toggled = false;
            }    
        }


        private void flushExcel_Click(object sender, EventArgs e)
        {
            
        }
    }
}
