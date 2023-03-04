namespace OlympiaCSharp
{
    partial class NhapDe
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.readExcel = new Guna.UI2.WinForms.Guna2Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Location = new System.Drawing.Point(39, 17);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1020, 482);
            this.tabControl.TabIndex = 5;
            // 
            // readExcel
            // 
            this.readExcel.Animated = true;
            this.readExcel.AutoRoundedCorners = true;
            this.readExcel.BorderRadius = 21;
            this.readExcel.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.readExcel.CheckedState.Parent = this.readExcel;
            this.readExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.readExcel.CustomImages.Parent = this.readExcel;
            this.readExcel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readExcel.ForeColor = System.Drawing.Color.White;
            this.readExcel.HoverState.Parent = this.readExcel;
            this.readExcel.Location = new System.Drawing.Point(39, 655);
            this.readExcel.Margin = new System.Windows.Forms.Padding(0);
            this.readExcel.Name = "readExcel";
            this.readExcel.ShadowDecoration.Parent = this.readExcel;
            this.readExcel.Size = new System.Drawing.Size(180, 45);
            this.readExcel.TabIndex = 6;
            this.readExcel.Text = "ĐỌC FILE ĐỀ THI";
            this.readExcel.Click += new System.EventHandler(this.readExcel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog1";
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(40, 14);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1020, 482);
            this.tabControl1.TabIndex = 7;
            // 
            // NhapDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(69)))), ((int)(((byte)(110)))));
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.readExcel);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "NhapDe";
            this.Size = new System.Drawing.Size(1100, 710);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private Guna.UI2.WinForms.Guna2Button readExcel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.TabControl tabControl1;
    }
}
