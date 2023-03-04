namespace OlympiaCSharp
{
    partial class ControlUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlUI));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.modelLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.exitUI = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAdd = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnFin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnAcc = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnObs = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnStart = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnScore = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnServer = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnNhapDe = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.UIPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.centreUILogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.UIPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.centreUILogo)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.guna2Panel1.Controls.Add(this.modelLabel);
            this.guna2Panel1.Controls.Add(this.versionLabel);
            this.guna2Panel1.Controls.Add(this.exitUI);
            this.guna2Panel1.Controls.Add(this.guna2Separator2);
            this.guna2Panel1.Controls.Add(this.guna2Separator1);
            this.guna2Panel1.Controls.Add(this.guna2TextBox1);
            this.guna2Panel1.Controls.Add(this.btnAdd);
            this.guna2Panel1.Controls.Add(this.btnFin);
            this.guna2Panel1.Controls.Add(this.btnAcc);
            this.guna2Panel1.Controls.Add(this.btnObs);
            this.guna2Panel1.Controls.Add(this.btnStart);
            this.guna2Panel1.Controls.Add(this.btnScore);
            this.guna2Panel1.Controls.Add(this.btnServer);
            this.guna2Panel1.Controls.Add(this.btnNhapDe);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(187, 720);
            this.guna2Panel1.TabIndex = 0;
            // 
            // modelLabel
            // 
            this.modelLabel.ForeColor = System.Drawing.Color.Gray;
            this.modelLabel.Location = new System.Drawing.Point(2, 695);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(185, 18);
            this.modelLabel.TabIndex = 11;
            this.modelLabel.Text = "PHIÊN BẢN THỬ NGHIỆM NỘI BỘ";
            this.modelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // versionLabel
            // 
            this.versionLabel.ForeColor = System.Drawing.Color.Gray;
            this.versionLabel.Location = new System.Drawing.Point(0, 676);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(185, 23);
            this.versionLabel.TabIndex = 0;
            this.versionLabel.Text = "Số phiên bản: 0.0.15";
            this.versionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitUI
            // 
            this.exitUI.CheckedState.Parent = this.exitUI;
            this.exitUI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitUI.HoverState.Parent = this.exitUI;
            this.exitUI.Image = global::OlympiaCSharp.Properties.Resources.closeIcon;
            this.exitUI.Location = new System.Drawing.Point(0, 3);
            this.exitUI.Name = "exitUI";
            this.exitUI.PressedState.Parent = this.exitUI;
            this.exitUI.Size = new System.Drawing.Size(27, 22);
            this.exitUI.TabIndex = 0;
            this.exitUI.Click += new System.EventHandler(this.exitUI_Click);
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.Location = new System.Drawing.Point(14, 254);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(161, 10);
            this.guna2Separator2.TabIndex = 10;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(14, 91);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(161, 10);
            this.guna2Separator1.TabIndex = 9;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderThickness = 0;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "BẢNG ĐIỀU KHIỂN";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox1.ForeColor = System.Drawing.Color.White;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Location = new System.Drawing.Point(2, 64);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.SelectionStart = 15;
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(184, 37);
            this.guna2TextBox1.TabIndex = 8;
            this.guna2TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAdd
            // 
            this.btnAdd.Animated = true;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.btnAdd.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(69)))), ((int)(((byte)(110)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(0, 469);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(188, 33);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "CÂU HỎI PHỤ";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnFin
            // 
            this.btnFin.Animated = true;
            this.btnFin.CheckedState.Parent = this.btnFin;
            this.btnFin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFin.CustomImages.Parent = this.btnFin;
            this.btnFin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.btnFin.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(69)))), ((int)(((byte)(110)))));
            this.btnFin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFin.ForeColor = System.Drawing.Color.White;
            this.btnFin.HoverState.Parent = this.btnFin;
            this.btnFin.Location = new System.Drawing.Point(0, 421);
            this.btnFin.Name = "btnFin";
            this.btnFin.ShadowDecoration.Parent = this.btnFin;
            this.btnFin.Size = new System.Drawing.Size(188, 33);
            this.btnFin.TabIndex = 6;
            this.btnFin.Text = "VỀ ĐÍCH";
            this.btnFin.Click += new System.EventHandler(this.btnFin_Click);
            // 
            // btnAcc
            // 
            this.btnAcc.Animated = true;
            this.btnAcc.CheckedState.Parent = this.btnAcc;
            this.btnAcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcc.CustomImages.Parent = this.btnAcc;
            this.btnAcc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.btnAcc.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(69)))), ((int)(((byte)(110)))));
            this.btnAcc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAcc.ForeColor = System.Drawing.Color.White;
            this.btnAcc.HoverState.Parent = this.btnAcc;
            this.btnAcc.Location = new System.Drawing.Point(0, 373);
            this.btnAcc.Name = "btnAcc";
            this.btnAcc.ShadowDecoration.Parent = this.btnAcc;
            this.btnAcc.Size = new System.Drawing.Size(188, 33);
            this.btnAcc.TabIndex = 5;
            this.btnAcc.Text = "TĂNG TỐC";
            this.btnAcc.Click += new System.EventHandler(this.btnAcc_Click);
            // 
            // btnObs
            // 
            this.btnObs.Animated = true;
            this.btnObs.CheckedState.Parent = this.btnObs;
            this.btnObs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnObs.CustomImages.Parent = this.btnObs;
            this.btnObs.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.btnObs.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(69)))), ((int)(((byte)(110)))));
            this.btnObs.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnObs.ForeColor = System.Drawing.Color.White;
            this.btnObs.HoverState.Parent = this.btnObs;
            this.btnObs.Location = new System.Drawing.Point(0, 325);
            this.btnObs.Name = "btnObs";
            this.btnObs.ShadowDecoration.Parent = this.btnObs;
            this.btnObs.Size = new System.Drawing.Size(188, 33);
            this.btnObs.TabIndex = 4;
            this.btnObs.Text = "VƯỢT CHƯỚNG NGẠI VẬT";
            this.btnObs.Click += new System.EventHandler(this.btnObs_Click);
            // 
            // btnStart
            // 
            this.btnStart.Animated = true;
            this.btnStart.CheckedState.Parent = this.btnStart;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.CustomImages.Parent = this.btnStart;
            this.btnStart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.btnStart.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(69)))), ((int)(((byte)(110)))));
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.HoverState.Parent = this.btnStart;
            this.btnStart.Location = new System.Drawing.Point(0, 277);
            this.btnStart.Name = "btnStart";
            this.btnStart.ShadowDecoration.Parent = this.btnStart;
            this.btnStart.Size = new System.Drawing.Size(188, 33);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "KHỞI ĐỘNG";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnScore
            // 
            this.btnScore.Animated = true;
            this.btnScore.CheckedState.Parent = this.btnScore;
            this.btnScore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScore.CustomImages.Parent = this.btnScore;
            this.btnScore.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.btnScore.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(69)))), ((int)(((byte)(110)))));
            this.btnScore.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScore.ForeColor = System.Drawing.Color.White;
            this.btnScore.HoverState.Parent = this.btnScore;
            this.btnScore.Image = global::OlympiaCSharp.Properties.Resources.maychu;
            this.btnScore.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnScore.Location = new System.Drawing.Point(0, 210);
            this.btnScore.Name = "btnScore";
            this.btnScore.ShadowDecoration.Parent = this.btnScore;
            this.btnScore.Size = new System.Drawing.Size(188, 33);
            this.btnScore.TabIndex = 3;
            this.btnScore.Text = "Điểm số";
            this.btnScore.Click += new System.EventHandler(this.btnScore_Click);
            // 
            // btnServer
            // 
            this.btnServer.Animated = true;
            this.btnServer.CheckedState.Parent = this.btnServer;
            this.btnServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServer.CustomImages.Parent = this.btnServer;
            this.btnServer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.btnServer.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(69)))), ((int)(((byte)(110)))));
            this.btnServer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServer.ForeColor = System.Drawing.Color.White;
            this.btnServer.HoverState.Parent = this.btnServer;
            this.btnServer.Image = global::OlympiaCSharp.Properties.Resources.maychu;
            this.btnServer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnServer.Location = new System.Drawing.Point(0, 162);
            this.btnServer.Name = "btnServer";
            this.btnServer.ShadowDecoration.Parent = this.btnServer;
            this.btnServer.Size = new System.Drawing.Size(188, 33);
            this.btnServer.TabIndex = 2;
            this.btnServer.Text = "Mở máy chủ";
            this.btnServer.Click += new System.EventHandler(this.btnServer_Click);
            // 
            // btnNhapDe
            // 
            this.btnNhapDe.Animated = true;
            this.btnNhapDe.CheckedState.Parent = this.btnNhapDe;
            this.btnNhapDe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhapDe.CustomImages.Parent = this.btnNhapDe;
            this.btnNhapDe.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.btnNhapDe.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(69)))), ((int)(((byte)(110)))));
            this.btnNhapDe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapDe.ForeColor = System.Drawing.Color.White;
            this.btnNhapDe.HoverState.Parent = this.btnNhapDe;
            this.btnNhapDe.Image = global::OlympiaCSharp.Properties.Resources.maychu;
            this.btnNhapDe.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNhapDe.Location = new System.Drawing.Point(0, 114);
            this.btnNhapDe.Name = "btnNhapDe";
            this.btnNhapDe.ShadowDecoration.Parent = this.btnNhapDe;
            this.btnNhapDe.Size = new System.Drawing.Size(188, 33);
            this.btnNhapDe.TabIndex = 1;
            this.btnNhapDe.Text = "Quản lý đề";
            this.btnNhapDe.Click += new System.EventHandler(this.btnNhapDe_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::OlympiaCSharp.Properties.Resources.LOGO_NGANG_STROKE_AND_SHADOW;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 15);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(185, 49);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // UIPanel
            // 
            this.UIPanel.Controls.Add(this.label3);
            this.UIPanel.Controls.Add(this.label2);
            this.UIPanel.Controls.Add(this.label1);
            this.UIPanel.Controls.Add(this.centreUILogo);
            this.UIPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UIPanel.Location = new System.Drawing.Point(187, 0);
            this.UIPanel.Margin = new System.Windows.Forms.Padding(0);
            this.UIPanel.Name = "UIPanel";
            this.UIPanel.ShadowDecoration.Parent = this.UIPanel;
            this.UIPanel.Size = new System.Drawing.Size(1093, 720);
            this.UIPanel.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 502);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1076, 62);
            this.label3.TabIndex = 14;
            this.label3.Text = "PHIÊN BẢN THỬ NGHIỆM NỘI BỘ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 456);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1076, 62);
            this.label2.TabIndex = 13;
            this.label2.Text = "Số phiên bản: 0.0.15";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1076, 62);
            this.label1.TabIndex = 12;
            this.label1.Text = "Phần mềm điều khiển";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // centreUILogo
            // 
            this.centreUILogo.Image = global::OlympiaCSharp.Properties.Resources.LOGO_NGANG_STROKE_AND_SHADOW;
            this.centreUILogo.Location = new System.Drawing.Point(6, 123);
            this.centreUILogo.Name = "centreUILogo";
            this.centreUILogo.ShadowDecoration.Parent = this.centreUILogo;
            this.centreUILogo.Size = new System.Drawing.Size(1076, 244);
            this.centreUILogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.centreUILogo.TabIndex = 12;
            this.centreUILogo.TabStop = false;
            // 
            // ControlUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(69)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.UIPanel);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ControlUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONTROL";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.UIPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.centreUILogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2GradientButton btnNhapDe;
        private Guna.UI2.WinForms.Guna2GradientButton btnFin;
        private Guna.UI2.WinForms.Guna2GradientButton btnAcc;
        private Guna.UI2.WinForms.Guna2GradientButton btnObs;
        private Guna.UI2.WinForms.Guna2GradientButton btnStart;
        private Guna.UI2.WinForms.Guna2GradientButton btnScore;
        private Guna.UI2.WinForms.Guna2GradientButton btnServer;
        private Guna.UI2.WinForms.Guna2GradientButton btnAdd;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2Panel UIPanel;
        private Guna.UI2.WinForms.Guna2ImageButton exitUI;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label versionLabel;
        private Guna.UI2.WinForms.Guna2PictureBox centreUILogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}