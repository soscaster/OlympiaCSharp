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
    public partial class DiemSo : UserControl
    {
        int ts1_scoreInt = 0;
        int ts2_scoreInt = 0;
        int ts3_scoreInt = 0;
        int ts4_scoreInt = 0;
        public DiemSo()
        {
            InitializeComponent();
        }

        private void ts1_plus5_Click(object sender, EventArgs e)
        {
            ts1_scoreInt = ts1_scoreInt + 5;
            ts1_score.Text = ts1_scoreInt.ToString();
        }

        private void ts1_minus5_Click(object sender, EventArgs e)
        {
            ts1_scoreInt = ts1_scoreInt - 5;
            ts1_score.Text = ts1_scoreInt.ToString();
        }

        private void ts2_plus5_Click(object sender, EventArgs e)
        {
            ts2_scoreInt = ts2_scoreInt + 5;
            ts2_score.Text = ts2_scoreInt.ToString();
        }

        private void ts2_minus5_Click(object sender, EventArgs e)
        {
            ts2_scoreInt = ts2_scoreInt - 5;
            ts2_score.Text = ts2_scoreInt.ToString();
        }

        private void ts3_plus5_Click(object sender, EventArgs e)
        {
            ts3_scoreInt = ts3_scoreInt + 5;
            ts3_score.Text = ts3_scoreInt.ToString();
        }

        private void ts3_minus5_Click(object sender, EventArgs e)
        {
            ts3_scoreInt = ts3_scoreInt - 5;
            ts3_score.Text = ts3_scoreInt.ToString();
        }

        private void ts4_plus5_Click(object sender, EventArgs e)
        {
            ts4_scoreInt = ts4_scoreInt + 5;
            ts4_score.Text = ts4_scoreInt.ToString();
        }

        private void ts4_minus5_Click(object sender, EventArgs e)
        {
            ts4_scoreInt = ts4_scoreInt - 5;
            ts4_score.Text = ts4_scoreInt.ToString();
        }

        private void ts1_reset_Click(object sender, EventArgs e)
        {
            ts1_scoreInt = 0;
            ts1_score.Text = ts1_scoreInt.ToString();
        }

        private void ts2_reset_Click(object sender, EventArgs e)
        {
            ts2_scoreInt = 0;
            ts2_score.Text = ts2_scoreInt.ToString();
        }

        private void ts3_reset_Click(object sender, EventArgs e)
        {
            ts3_scoreInt = 0;
            ts3_score.Text = ts3_scoreInt.ToString();
        }

        private void ts4_reset_Click(object sender, EventArgs e)
        {
            ts4_scoreInt = 0;
            ts4_score.Text = ts4_scoreInt.ToString();
        }
    }
}
