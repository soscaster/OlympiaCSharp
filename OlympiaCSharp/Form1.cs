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

        private void FadeIn()
        {
            // Set the initial opacity of the form to 0.0
            this.Opacity = 0.0;

            // Create a Timer control with a 500 millisecond interval
            Timer timer = new Timer();
            timer.Interval = 50;

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
                progMain.Width = progMain.Width + 3 / 1;
                // Print progMain value percentage
                label2.Text = progMain.Width / 8 + "%";
                // Random character for label
                randomChar.Text = "Đang khởi tạo môi trường...";
            }
            else
            {
                randomChar.Text = "Khởi tạo môi trường thành công!";
                timer1.Stop();
                System.Threading.Thread.Sleep(2000);
                ControlUI form2 = new ControlUI();
                form2.Show();
                this.Hide();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CloseApp();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            FadeIn();  
        }

    }
}
