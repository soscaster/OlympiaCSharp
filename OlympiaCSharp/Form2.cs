using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;
using Control = System.Windows.Forms.Control;
using Excel = Microsoft.Office.Interop.Excel;
using UserControl = System.Windows.Forms.UserControl;

namespace OlympiaCSharp
{
    public partial class ControlUI : Form
    {
        NhapDe nd = new NhapDe();
        Server sv = new Server();
        DiemSo ds = new DiemSo();
        KhoiDong kd = new KhoiDong();
        VCNV vcnv = new VCNV();
        TangToc tt = new TangToc();
        VeDich vd = new VeDich();
        CauHoiPhu chp = new CauHoiPhu();

        public ControlUI()
        {
            InitializeComponent();
            this.FormClosing += MainForm_FormClosing;

            UIPanel.Controls.Add(nd);
            UIPanel.Controls.Add(sv);
            UIPanel.Controls.Add(ds);
            UIPanel.Controls.Add(kd);
            UIPanel.Controls.Add(vcnv);
            UIPanel.Controls.Add(tt);
            UIPanel.Controls.Add(vd);
            UIPanel.Controls.Add(chp);

            // Set each user control to invisible
            nd.Visible = false;
            sv.Visible = false;
            ds.Visible = false;
            kd.Visible = false;
            vcnv.Visible = false;
            tt.Visible = false;
            vd.Visible = false;
            chp.Visible = false;
        }

        private void add_UControls(UserControl ucToShow)
        {
            foreach (Control co in UIPanel.Controls)
            {
                UserControl uc = co as UserControl;
                if (uc != null && uc != ucToShow)
                {
                    uc.Visible = false;
                }    
            }
            ucToShow.Visible = true;
            ucToShow.Dock = DockStyle.Right;
            ucToShow.BringToFront();

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

        private void btnNhapDe_Click(object sender, EventArgs e)
        {
            // Change font style of buttons
            btnNhapDe.Font = new Font(btnNhapDe.Font, FontStyle.Bold | FontStyle.Italic);
            btnServer.Font = new Font(btnServer.Font, FontStyle.Regular);
            btnScore.Font = new Font(btnScore.Font, FontStyle.Regular);
            btnStart.Font = new Font(btnStart.Font, FontStyle.Regular);
            btnObs.Font = new Font(btnObs.Font, FontStyle.Regular);
            btnAcc.Font = new Font(btnAcc.Font, FontStyle.Regular);
            btnFin.Font = new Font(btnFin.Font, FontStyle.Regular);
            btnAdd.Font = new Font(btnAdd.Font, FontStyle.Regular);
            add_UControls(nd);
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            // Change font style of buttons
            btnNhapDe.Font = new Font(btnNhapDe.Font, FontStyle.Regular);
            btnServer.Font = new Font(btnServer.Font, FontStyle.Bold | FontStyle.Italic);
            btnScore.Font = new Font(btnScore.Font, FontStyle.Regular);
            btnStart.Font = new Font(btnStart.Font, FontStyle.Regular);
            btnObs.Font = new Font(btnObs.Font, FontStyle.Regular);
            btnAcc.Font = new Font(btnAcc.Font, FontStyle.Regular);
            btnFin.Font = new Font(btnFin.Font, FontStyle.Regular);
            btnAdd.Font = new Font(btnAdd.Font, FontStyle.Regular);
            add_UControls(sv);
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            // Change font style of buttons
            btnNhapDe.Font = new Font(btnNhapDe.Font, FontStyle.Regular);
            btnServer.Font = new Font(btnServer.Font, FontStyle.Regular);
            btnScore.Font = new Font(btnScore.Font, FontStyle.Bold | FontStyle.Italic);
            btnStart.Font = new Font(btnStart.Font, FontStyle.Regular);
            btnObs.Font = new Font(btnObs.Font, FontStyle.Regular);
            btnAcc.Font = new Font(btnAcc.Font, FontStyle.Regular);
            btnFin.Font = new Font(btnFin.Font, FontStyle.Regular);
            btnAdd.Font = new Font(btnAdd.Font, FontStyle.Regular);
            add_UControls(ds);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Change font style of buttons
            btnNhapDe.Font = new Font(btnNhapDe.Font, FontStyle.Regular);
            btnServer.Font = new Font(btnServer.Font, FontStyle.Regular);
            btnScore.Font = new Font(btnScore.Font, FontStyle.Regular);
            btnStart.Font = new Font(btnStart.Font, FontStyle.Bold | FontStyle.Italic);
            btnObs.Font = new Font(btnObs.Font, FontStyle.Regular);
            btnAcc.Font = new Font(btnAcc.Font, FontStyle.Regular);
            btnFin.Font = new Font(btnFin.Font, FontStyle.Regular);
            add_UControls(kd);
        }

        private void btnObs_Click(object sender, EventArgs e)
        {
            // Change font style of buttons
            btnNhapDe.Font = new Font(btnNhapDe.Font, FontStyle.Regular);
            btnServer.Font = new Font(btnServer.Font, FontStyle.Regular);
            btnScore.Font = new Font(btnScore.Font, FontStyle.Regular);
            btnStart.Font = new Font(btnStart.Font, FontStyle.Regular);
            btnObs.Font = new Font(btnObs.Font, FontStyle.Bold | FontStyle.Italic);
            btnAcc.Font = new Font(btnAcc.Font, FontStyle.Regular);
            btnFin.Font = new Font(btnFin.Font, FontStyle.Regular);
            btnAdd.Font = new Font(btnAdd.Font, FontStyle.Regular);
            add_UControls(vcnv);
        }

        private void btnAcc_Click(object sender, EventArgs e)
        {
            // Change font style of buttons
            btnNhapDe.Font = new Font(btnNhapDe.Font, FontStyle.Regular);
            btnServer.Font = new Font(btnServer.Font, FontStyle.Regular);
            btnScore.Font = new Font(btnScore.Font, FontStyle.Regular);
            btnStart.Font = new Font(btnStart.Font, FontStyle.Regular);
            btnObs.Font = new Font(btnObs.Font, FontStyle.Regular);
            btnAcc.Font = new Font(btnAcc.Font, FontStyle.Bold | FontStyle.Italic);
            btnFin.Font = new Font(btnFin.Font, FontStyle.Regular);
            btnAdd.Font = new Font(btnAdd.Font, FontStyle.Regular);
            add_UControls(tt);
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            // Change font style of buttons
            btnNhapDe.Font = new Font(btnNhapDe.Font, FontStyle.Regular);
            btnServer.Font = new Font(btnServer.Font, FontStyle.Regular);
            btnScore.Font = new Font(btnScore.Font, FontStyle.Regular);
            btnStart.Font = new Font(btnStart.Font, FontStyle.Regular);
            btnObs.Font = new Font(btnObs.Font, FontStyle.Regular);
            btnAcc.Font = new Font(btnAcc.Font, FontStyle.Regular);
            btnFin.Font = new Font(btnFin.Font, FontStyle.Bold | FontStyle.Italic);
            btnAdd.Font = new Font(btnAdd.Font, FontStyle.Regular);
            add_UControls(vd);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Change font style of buttons
            btnNhapDe.Font = new Font(btnNhapDe.Font, FontStyle.Regular);
            btnServer.Font = new Font(btnServer.Font, FontStyle.Regular);
            btnScore.Font = new Font(btnScore.Font, FontStyle.Regular);
            btnStart.Font = new Font(btnStart.Font, FontStyle.Regular);
            btnObs.Font = new Font(btnObs.Font, FontStyle.Regular);
            btnAcc.Font = new Font(btnAcc.Font, FontStyle.Regular);
            btnFin.Font = new Font(btnFin.Font, FontStyle.Regular);
            btnAdd.Font = new Font(btnAdd.Font, FontStyle.Bold | FontStyle.Italic);
            add_UControls(chp);
        }

        private void exitUI_Click(object sender, EventArgs e)
        {
            ExitForm();
        }
    }
}
