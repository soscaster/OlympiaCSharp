using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlympiaCSharp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.FormClosing += MainForm_FormClosing;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
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
    }
}
