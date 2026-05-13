namespace quickid
{
    partial class UC_temizle
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl_toplamBoyut = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.optimizebtn = new quickid.RJButton();
            this.lbl_optimize = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tooltiptemizle = new System.Windows.Forms.ToolTip(this.components);
            this.yenilebtn = new quickid.RJButton();
            this.btn_temizle = new quickid.RJButton();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_ram = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.totalRam = new System.Windows.Forms.Label();
            this.ramTemizleBtn = new quickid.RJButton();
            this.tooglebtn_cerz = new quickid.RJToggleButton();
            this.tooglebtn_cop = new quickid.RJToggleButton();
            this.lbl_indirilenker = new System.Windows.Forms.Label();
            this.toggledownlonds = new quickid.RJToggleButton();
            this.cleanupbtn = new quickid.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label1.Location = new System.Drawing.Point(41, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Geçici Dosyalar";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(55, 54);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(460, 394);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // lbl_toplamBoyut
            // 
            this.lbl_toplamBoyut.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.lbl_toplamBoyut.AutoSize = true;
            this.lbl_toplamBoyut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_toplamBoyut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_toplamBoyut.Location = new System.Drawing.Point(44, 620);
            this.lbl_toplamBoyut.Name = "lbl_toplamBoyut";
            this.lbl_toplamBoyut.Size = new System.Drawing.Size(131, 24);
            this.lbl_toplamBoyut.TabIndex = 2;
            this.lbl_toplamBoyut.Text = "Toplam Boyut:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label2.Location = new System.Drawing.Point(129, 441);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Çöp Kutusunu Temizle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label3.Location = new System.Drawing.Point(129, 479);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "İnternet Çerezleri Temizle";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.optimizebtn);
            this.panel1.Location = new System.Drawing.Point(739, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 128);
            this.panel1.TabIndex = 9;
            // 
            // optimizebtn
            // 
            this.optimizebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.optimizebtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.optimizebtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.optimizebtn.BorderRadius = 20;
            this.optimizebtn.BorderSize = 0;
            this.optimizebtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.optimizebtn.FlatAppearance.BorderSize = 0;
            this.optimizebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optimizebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.optimizebtn.Location = new System.Drawing.Point(0, 88);
            this.optimizebtn.Name = "optimizebtn";
            this.optimizebtn.Size = new System.Drawing.Size(369, 40);
            this.optimizebtn.TabIndex = 8;
            this.optimizebtn.Text = "Diski Optimize Et";
            this.optimizebtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.tooltiptemizle.SetToolTip(this.optimizebtn, "Seçtiğiniz diski optimize ederek programların açılmasını hızlandırır.");
            this.optimizebtn.UseVisualStyleBackColor = false;
            this.optimizebtn.Click += new System.EventHandler(this.optimizebtn_Click);
            // 
            // lbl_optimize
            // 
            this.lbl_optimize.AutoSize = true;
            this.lbl_optimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_optimize.Location = new System.Drawing.Point(743, 210);
            this.lbl_optimize.Name = "lbl_optimize";
            this.lbl_optimize.Size = new System.Drawing.Size(0, 17);
            this.lbl_optimize.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label4.Location = new System.Drawing.Point(723, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 39);
            this.label4.TabIndex = 11;
            this.label4.Text = "Optimize Et";
            // 
            // tooltiptemizle
            // 
            this.tooltiptemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            // 
            // yenilebtn
            // 
            this.yenilebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.yenilebtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.yenilebtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.yenilebtn.BorderRadius = 20;
            this.yenilebtn.BorderSize = 0;
            this.yenilebtn.FlatAppearance.BorderSize = 0;
            this.yenilebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yenilebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.yenilebtn.Location = new System.Drawing.Point(243, 564);
            this.yenilebtn.Name = "yenilebtn";
            this.yenilebtn.Size = new System.Drawing.Size(96, 40);
            this.yenilebtn.TabIndex = 8;
            this.yenilebtn.Text = "Yenile";
            this.yenilebtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.tooltiptemizle.SetToolTip(this.yenilebtn, "Geçici dosyaların boyutuu hesaplar ve yazar.\r\n");
            this.yenilebtn.UseVisualStyleBackColor = false;
            this.yenilebtn.Click += new System.EventHandler(this.yenilebtn_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.btn_temizle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.btn_temizle.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_temizle.BorderRadius = 20;
            this.btn_temizle.BorderSize = 0;
            this.btn_temizle.FlatAppearance.BorderSize = 0;
            this.btn_temizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_temizle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_temizle.Location = new System.Drawing.Point(49, 564);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(173, 40);
            this.btn_temizle.TabIndex = 3;
            this.btn_temizle.Text = "Geçici Dosyaları Temizle";
            this.btn_temizle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.tooltiptemizle.SetToolTip(this.btn_temizle, "Geçici dosyaları temizler.");
            this.btn_temizle.UseVisualStyleBackColor = false;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label5.Location = new System.Drawing.Point(723, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 39);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ram Temizle";
            // 
            // lbl_ram
            // 
            this.lbl_ram.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_ram.Location = new System.Drawing.Point(746, 569);
            this.lbl_ram.Name = "lbl_ram";
            this.lbl_ram.Size = new System.Drawing.Size(286, 17);
            this.lbl_ram.TabIndex = 13;
            this.lbl_ram.Text = "kaybetmemek icin furkaninki kadar text";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AccessibleDescription = "";
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.circularProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.circularProgressBar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(78)))), ((int)(((byte)(83)))));
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(749, 281);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(1)))), ((int)(((byte)(63)))));
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 26;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(45)))), ((int)(((byte)(63)))));
            this.circularProgressBar1.ProgressWidth = 25;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar1.Size = new System.Drawing.Size(285, 285);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = "";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "";
            this.circularProgressBar1.TabIndex = 17;
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar1.Value = 68;
            // 
            // totalRam
            // 
            this.totalRam.AutoSize = true;
            this.totalRam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.totalRam.Location = new System.Drawing.Point(958, 647);
            this.totalRam.Name = "totalRam";
            this.totalRam.Size = new System.Drawing.Size(146, 17);
            this.totalRam.TabIndex = 13;
            this.totalRam.Text = "kaybetmemek icin text";
            // 
            // ramTemizleBtn
            // 
            this.ramTemizleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.ramTemizleBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.ramTemizleBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ramTemizleBtn.BorderRadius = 20;
            this.ramTemizleBtn.BorderSize = 0;
            this.ramTemizleBtn.FlatAppearance.BorderSize = 0;
            this.ramTemizleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ramTemizleBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.ramTemizleBtn.Location = new System.Drawing.Point(730, 604);
            this.ramTemizleBtn.Name = "ramTemizleBtn";
            this.ramTemizleBtn.Size = new System.Drawing.Size(374, 40);
            this.ramTemizleBtn.TabIndex = 14;
            this.ramTemizleBtn.Text = "Temizle";
            this.ramTemizleBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.ramTemizleBtn.UseVisualStyleBackColor = false;
            this.ramTemizleBtn.Click += new System.EventHandler(this.ramTemizleBtn_Click);
            // 
            // tooglebtn_cerz
            // 
            this.tooglebtn_cerz.AutoSize = true;
            this.tooglebtn_cerz.Location = new System.Drawing.Point(78, 479);
            this.tooglebtn_cerz.MinimumSize = new System.Drawing.Size(45, 22);
            this.tooglebtn_cerz.Name = "tooglebtn_cerz";
            this.tooglebtn_cerz.OffBackColor = System.Drawing.Color.Gray;
            this.tooglebtn_cerz.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tooglebtn_cerz.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.tooglebtn_cerz.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tooglebtn_cerz.Size = new System.Drawing.Size(45, 22);
            this.tooglebtn_cerz.TabIndex = 6;
            this.tooglebtn_cerz.UseVisualStyleBackColor = true;
            // 
            // tooglebtn_cop
            // 
            this.tooglebtn_cop.AutoSize = true;
            this.tooglebtn_cop.Location = new System.Drawing.Point(78, 441);
            this.tooglebtn_cop.MinimumSize = new System.Drawing.Size(45, 22);
            this.tooglebtn_cop.Name = "tooglebtn_cop";
            this.tooglebtn_cop.OffBackColor = System.Drawing.Color.Gray;
            this.tooglebtn_cop.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tooglebtn_cop.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.tooglebtn_cop.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tooglebtn_cop.Size = new System.Drawing.Size(45, 22);
            this.tooglebtn_cop.TabIndex = 4;
            this.tooglebtn_cop.UseVisualStyleBackColor = true;
            // 
            // lbl_indirilenker
            // 
            this.lbl_indirilenker.AutoSize = true;
            this.lbl_indirilenker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_indirilenker.Location = new System.Drawing.Point(129, 516);
            this.lbl_indirilenker.Name = "lbl_indirilenker";
            this.lbl_indirilenker.Size = new System.Drawing.Size(194, 17);
            this.lbl_indirilenker.TabIndex = 19;
            this.lbl_indirilenker.Text = "İndirilenler Klasörünü Temizle";
            // 
            // toggledownlonds
            // 
            this.toggledownlonds.AutoSize = true;
            this.toggledownlonds.Location = new System.Drawing.Point(78, 516);
            this.toggledownlonds.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggledownlonds.Name = "toggledownlonds";
            this.toggledownlonds.OffBackColor = System.Drawing.Color.Gray;
            this.toggledownlonds.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggledownlonds.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.toggledownlonds.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggledownlonds.Size = new System.Drawing.Size(45, 22);
            this.toggledownlonds.TabIndex = 18;
            this.toggledownlonds.UseVisualStyleBackColor = true;
            // 
            // cleanupbtn
            // 
            this.cleanupbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.cleanupbtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.cleanupbtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cleanupbtn.BorderRadius = 20;
            this.cleanupbtn.BorderSize = 0;
            this.cleanupbtn.FlatAppearance.BorderSize = 0;
            this.cleanupbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cleanupbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.cleanupbtn.Location = new System.Drawing.Point(360, 552);
            this.cleanupbtn.Name = "cleanupbtn";
            this.cleanupbtn.Size = new System.Drawing.Size(96, 66);
            this.cleanupbtn.TabIndex = 20;
            this.cleanupbtn.Text = "DISM Komutu ile Temizlik";
            this.cleanupbtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.tooltiptemizle.SetToolTip(this.cleanupbtn, "Geçici dosyaların boyutuu hesaplar ve yazar.\r\n");
            this.cleanupbtn.UseVisualStyleBackColor = false;
            this.cleanupbtn.Click += new System.EventHandler(this.cleanupbtn_Click);
            // 
            // UC_temizle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.Controls.Add(this.cleanupbtn);
            this.Controls.Add(this.lbl_indirilenker);
            this.Controls.Add(this.toggledownlonds);
            this.Controls.Add(this.circularProgressBar1);
            this.Controls.Add(this.ramTemizleBtn);
            this.Controls.Add(this.totalRam);
            this.Controls.Add(this.lbl_ram);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_optimize);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.yenilebtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tooglebtn_cerz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tooglebtn_cop);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.lbl_toplamBoyut);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_temizle";
            this.Size = new System.Drawing.Size(1178, 675);
            this.Load += new System.EventHandler(this.UC_temizle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lbl_toplamBoyut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private RJButton yenilebtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_optimize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip tooltiptemizle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_ram;
        private System.Windows.Forms.Timer timer1;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.Label totalRam;
        public RJButton optimizebtn;
        public RJButton ramTemizleBtn;
        public RJButton btn_temizle;
        public RJToggleButton tooglebtn_cop;
        public RJToggleButton tooglebtn_cerz;
        private System.Windows.Forms.Label lbl_indirilenker;
        public RJToggleButton toggledownlonds;
        private RJButton cleanupbtn;
    }
}
