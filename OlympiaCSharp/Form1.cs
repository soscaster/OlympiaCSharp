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
    public partial class Splash : Form
    {
        // Close app function
        private void CloseApp()
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

        public Splash()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Do nothing
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (progMain.Width != 0 && progMain.Width < 800)
            {
                // Increase progMain value
                progMain.Width = progMain.Width + 2 / 1;
                // Print progMain value percentage
                label2.Text = progMain.Width / 8 + "%";
                // Random character for label
                Random random = new Random();
                randomChar.Text = "Đang khởi tạo môi trường...";
                string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                randomChar.Text = new string(Enumerable.Repeat(chars, 45).Select(s => s[random.Next(s.Length)]).ToArray());
            }
            else
            {
                randomChar.Text = "Khởi tạo môi trường thành công!";
                timer1.Stop();
                // Pause for 3 second using Async
                Task.Delay(3000).Wait();
                // Open Form2.cs
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CloseApp();
        }
    }
}
