namespace quickid
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diskiOptimizeEtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ramiTemizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geçiciDosyalarıTemizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panet_top = new System.Windows.Forms.Panel();
            this.miniButton = new quickid.RJButton();
            this.exitButton_1 = new quickid.RJButton();
            this.leftpanel = new System.Windows.Forms.Panel();
            this.btnayarlar = new quickid.RJButton();
            this.btnoyunmodu = new quickid.RJButton();
            this.homepagebtn = new quickid.RJButton();
            this.btnhizlandir = new quickid.RJButton();
            this.cleanButton1 = new quickid.RJButton();
            this.lblhiclik = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.panet_top.SuspendLayout();
            this.leftpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "Fast Optimizer Text";
            this.notifyIcon1.BalloonTipTitle = "Fast Optimizer Title";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Fast Optimizer";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(78)))), ((int)(((byte)(83)))));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.açToolStripMenuItem,
            this.diskiOptimizeEtToolStripMenuItem,
            this.ramiTemizleToolStripMenuItem,
            this.geçiciDosyalarıTemizleToolStripMenuItem,
            this.çıkToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(175, 114);
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.açToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.açToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.açToolStripMenuItem.ImageTransparentColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.açToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.açToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.açToolStripMenuItem.Tag = "Sizi Uygulama Ekranına Götürür";
            this.açToolStripMenuItem.Text = "Aç";
            this.açToolStripMenuItem.Click += new System.EventHandler(this.açToolStripMenuItem_Click);
            // 
            // diskiOptimizeEtToolStripMenuItem
            // 
            this.diskiOptimizeEtToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.diskiOptimizeEtToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.diskiOptimizeEtToolStripMenuItem.ImageTransparentColor = System.Drawing.SystemColors.ControlDarkDark;
            this.diskiOptimizeEtToolStripMenuItem.Name = "diskiOptimizeEtToolStripMenuItem";
            this.diskiOptimizeEtToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.diskiOptimizeEtToolStripMenuItem.Text = "Diski Optimize Et";
            this.diskiOptimizeEtToolStripMenuItem.Click += new System.EventHandler(this.diskiOptimizeEtToolStripMenuItem_Click);
            // 
            // ramiTemizleToolStripMenuItem
            // 
            this.ramiTemizleToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.ramiTemizleToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ramiTemizleToolStripMenuItem.Name = "ramiTemizleToolStripMenuItem";
            this.ramiTemizleToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.ramiTemizleToolStripMenuItem.Text = "Rami Temizle";
            this.ramiTemizleToolStripMenuItem.Click += new System.EventHandler(this.ramiTemizleToolStripMenuItem_Click);
            // 
            // geçiciDosyalarıTemizleToolStripMenuItem
            // 
            this.geçiciDosyalarıTemizleToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.geçiciDosyalarıTemizleToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.geçiciDosyalarıTemizleToolStripMenuItem.Name = "geçiciDosyalarıTemizleToolStripMenuItem";
            this.geçiciDosyalarıTemizleToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.geçiciDosyalarıTemizleToolStripMenuItem.Text = "Geçici Dosyaları Temizle";
            this.geçiciDosyalarıTemizleToolStripMenuItem.Click += new System.EventHandler(this.geçiciDosyalarıTemizleToolStripMenuItem_Click);
            // 
            // çıkToolStripMenuItem
            // 
            this.çıkToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.çıkToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.çıkToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.çıkToolStripMenuItem.Name = "çıkToolStripMenuItem";
            this.çıkToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.çıkToolStripMenuItem.Text = "Çık";
            this.çıkToolStripMenuItem.Click += new System.EventHandler(this.çıkToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(102, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1178, 675);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(155)))), ((int)(((byte)(163)))));
            this.label1.Location = new System.Drawing.Point(3, 654);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Version: 0.0.1";
            // 
            // panet_top
            // 
            this.panet_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(78)))), ((int)(((byte)(83)))));
            this.panet_top.Controls.Add(this.miniButton);
            this.panet_top.Controls.Add(this.exitButton_1);
            this.panet_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panet_top.Location = new System.Drawing.Point(0, 0);
            this.panet_top.Margin = new System.Windows.Forms.Padding(4);
            this.panet_top.Name = "panet_top";
            this.panet_top.Size = new System.Drawing.Size(1280, 45);
            this.panet_top.TabIndex = 0;
            this.panet_top.Paint += new System.Windows.Forms.PaintEventHandler(this.panet_top_Paint);
            this.panet_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panet_top_MouseDown);
            // 
            // miniButton
            // 
            this.miniButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.miniButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.miniButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.miniButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.miniButton.BorderRadius = 20;
            this.miniButton.BorderSize = 1;
            this.miniButton.FlatAppearance.BorderSize = 0;
            this.miniButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.miniButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(155)))), ((int)(((byte)(163)))));
            this.miniButton.Location = new System.Drawing.Point(1188, 1);
            this.miniButton.Margin = new System.Windows.Forms.Padding(4);
            this.miniButton.Name = "miniButton";
            this.miniButton.Size = new System.Drawing.Size(40, 40);
            this.miniButton.TabIndex = 1;
            this.miniButton.Text = " _";
            this.miniButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(155)))), ((int)(((byte)(163)))));
            this.miniButton.UseVisualStyleBackColor = false;
            this.miniButton.Click += new System.EventHandler(this.miniButton_Click);
            // 
            // exitButton_1
            // 
            this.exitButton_1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.exitButton_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.exitButton_1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.exitButton_1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.exitButton_1.BorderRadius = 20;
            this.exitButton_1.BorderSize = 1;
            this.exitButton_1.FlatAppearance.BorderSize = 0;
            this.exitButton_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(155)))), ((int)(((byte)(163)))));
            this.exitButton_1.Location = new System.Drawing.Point(1236, 1);
            this.exitButton_1.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton_1.Name = "exitButton_1";
            this.exitButton_1.Size = new System.Drawing.Size(40, 40);
            this.exitButton_1.TabIndex = 1;
            this.exitButton_1.Text = " X";
            this.exitButton_1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(155)))), ((int)(((byte)(163)))));
            this.exitButton_1.UseVisualStyleBackColor = false;
            this.exitButton_1.Click += new System.EventHandler(this.exitButton_1_Click);
            // 
            // leftpanel
            // 
            this.leftpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(78)))), ((int)(((byte)(83)))));
            this.leftpanel.Controls.Add(this.btnayarlar);
            this.leftpanel.Controls.Add(this.btnoyunmodu);
            this.leftpanel.Controls.Add(this.homepagebtn);
            this.leftpanel.Controls.Add(this.btnhizlandir);
            this.leftpanel.Controls.Add(this.cleanButton1);
            this.leftpanel.Controls.Add(this.label1);
            this.leftpanel.Controls.Add(this.lblhiclik);
            this.leftpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftpanel.Location = new System.Drawing.Point(0, 45);
            this.leftpanel.Name = "leftpanel";
            this.leftpanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.leftpanel.Size = new System.Drawing.Size(102, 675);
            this.leftpanel.TabIndex = 1;
            // 
            // btnayarlar
            // 
            this.btnayarlar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.btnayarlar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.btnayarlar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnayarlar.BorderRadius = 20;
            this.btnayarlar.BorderSize = 0;
            this.btnayarlar.FlatAppearance.BorderSize = 0;
            this.btnayarlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnayarlar.ForeColor = System.Drawing.Color.White;
            this.btnayarlar.Location = new System.Drawing.Point(0, 407);
            this.btnayarlar.Name = "btnayarlar";
            this.btnayarlar.Size = new System.Drawing.Size(100, 54);
            this.btnayarlar.TabIndex = 6;
            this.btnayarlar.Text = "Ayarlar";
            this.btnayarlar.TextColor = System.Drawing.Color.White;
            this.btnayarlar.UseVisualStyleBackColor = false;
            this.btnayarlar.Click += new System.EventHandler(this.btnayarlar_Click);
            // 
            // btnoyunmodu
            // 
            this.btnoyunmodu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.btnoyunmodu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.btnoyunmodu.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnoyunmodu.BorderRadius = 20;
            this.btnoyunmodu.BorderSize = 0;
            this.btnoyunmodu.FlatAppearance.BorderSize = 0;
            this.btnoyunmodu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnoyunmodu.ForeColor = System.Drawing.Color.White;
            this.btnoyunmodu.Location = new System.Drawing.Point(0, 307);
            this.btnoyunmodu.Name = "btnoyunmodu";
            this.btnoyunmodu.Size = new System.Drawing.Size(100, 54);
            this.btnoyunmodu.TabIndex = 4;
            this.btnoyunmodu.Text = "Oyun Modu";
            this.btnoyunmodu.TextColor = System.Drawing.Color.White;
            this.btnoyunmodu.UseVisualStyleBackColor = false;
            this.btnoyunmodu.Click += new System.EventHandler(this.btnoyunmodu_Click);
            // 
            // homepagebtn
            // 
            this.homepagebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.homepagebtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.homepagebtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.homepagebtn.BorderRadius = 20;
            this.homepagebtn.BorderSize = 0;
            this.homepagebtn.FlatAppearance.BorderSize = 0;
            this.homepagebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homepagebtn.ForeColor = System.Drawing.Color.White;
            this.homepagebtn.Location = new System.Drawing.Point(0, 7);
            this.homepagebtn.Name = "homepagebtn";
            this.homepagebtn.Size = new System.Drawing.Size(100, 54);
            this.homepagebtn.TabIndex = 2;
            this.homepagebtn.Text = "Ana Sayfa";
            this.homepagebtn.TextColor = System.Drawing.Color.White;
            this.homepagebtn.UseVisualStyleBackColor = false;
            this.homepagebtn.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // btnhizlandir
            // 
            this.btnhizlandir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.btnhizlandir.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.btnhizlandir.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnhizlandir.BorderRadius = 20;
            this.btnhizlandir.BorderSize = 0;
            this.btnhizlandir.FlatAppearance.BorderSize = 0;
            this.btnhizlandir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhizlandir.ForeColor = System.Drawing.Color.White;
            this.btnhizlandir.Location = new System.Drawing.Point(0, 207);
            this.btnhizlandir.Name = "btnhizlandir";
            this.btnhizlandir.Size = new System.Drawing.Size(100, 54);
            this.btnhizlandir.TabIndex = 1;
            this.btnhizlandir.Text = "Hızlandır";
            this.btnhizlandir.TextColor = System.Drawing.Color.White;
            this.btnhizlandir.UseVisualStyleBackColor = false;
            this.btnhizlandir.Click += new System.EventHandler(this.btnhizlandir_Click);
            // 
            // cleanButton1
            // 
            this.cleanButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.cleanButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.cleanButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cleanButton1.BorderRadius = 20;
            this.cleanButton1.BorderSize = 0;
            this.cleanButton1.FlatAppearance.BorderSize = 0;
            this.cleanButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cleanButton1.ForeColor = System.Drawing.Color.White;
            this.cleanButton1.Location = new System.Drawing.Point(0, 107);
            this.cleanButton1.Name = "cleanButton1";
            this.cleanButton1.Size = new System.Drawing.Size(100, 54);
            this.cleanButton1.TabIndex = 1;
            this.cleanButton1.Text = "Temzile";
            this.cleanButton1.TextColor = System.Drawing.Color.White;
            this.cleanButton1.UseVisualStyleBackColor = false;
            this.cleanButton1.Click += new System.EventHandler(this.cleanButton1_Click);
            // 
            // lblhiclik
            // 
            this.lblhiclik.AutoSize = true;
            this.lblhiclik.Location = new System.Drawing.Point(40, 234);
            this.lblhiclik.Name = "lblhiclik";
            this.lblhiclik.Size = new System.Drawing.Size(0, 17);
            this.lblhiclik.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.leftpanel);
            this.Controls.Add(this.panet_top);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panet_top.ResumeLayout(false);
            this.leftpanel.ResumeLayout(false);
            this.leftpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private RJButton exitButton_1;
        private RJButton cleanButton1;
        private RJButton miniButton;
        private RJButton homepagebtn;
        private System.Windows.Forms.Panel panet_top;
        private System.Windows.Forms.Panel leftpanel;
        private RJButton btnhizlandir;
        public System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diskiOptimizeEtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ramiTemizleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geçiciDosyalarıTemizleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkToolStripMenuItem;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblhiclik;
        private RJButton btnoyunmodu;
        private RJButton btnayarlar;
    }
}

