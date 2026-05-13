namespace quickid
{
    partial class UC_oyun
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbltag = new System.Windows.Forms.Label();
            this.oyuneklebtn = new quickid.RJButton();
            this.btnoyna = new quickid.RJButton();
            this.lbloyunadi = new System.Windows.Forms.Label();
            this.lblneleroluyor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(60, 70);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1067, 521);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lbltag
            // 
            this.lbltag.AutoSize = true;
            this.lbltag.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltag.ForeColor = System.Drawing.Color.White;
            this.lbltag.Location = new System.Drawing.Point(53, 14);
            this.lbltag.Name = "lbltag";
            this.lbltag.Size = new System.Drawing.Size(192, 39);
            this.lbltag.TabIndex = 2;
            this.lbltag.Text = "Oyun Modu";
            // 
            // oyuneklebtn
            // 
            this.oyuneklebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.oyuneklebtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.oyuneklebtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.oyuneklebtn.BorderRadius = 20;
            this.oyuneklebtn.BorderSize = 0;
            this.oyuneklebtn.FlatAppearance.BorderSize = 0;
            this.oyuneklebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oyuneklebtn.ForeColor = System.Drawing.Color.White;
            this.oyuneklebtn.Location = new System.Drawing.Point(977, 612);
            this.oyuneklebtn.Name = "oyuneklebtn";
            this.oyuneklebtn.Size = new System.Drawing.Size(150, 40);
            this.oyuneklebtn.TabIndex = 1;
            this.oyuneklebtn.Text = "Oyun Ekle";
            this.oyuneklebtn.TextColor = System.Drawing.Color.White;
            this.oyuneklebtn.UseVisualStyleBackColor = false;
            this.oyuneklebtn.Click += new System.EventHandler(this.oyuneklebtn_Click);
            // 
            // btnoyna
            // 
            this.btnoyna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.btnoyna.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.btnoyna.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnoyna.BorderRadius = 20;
            this.btnoyna.BorderSize = 0;
            this.btnoyna.Enabled = false;
            this.btnoyna.FlatAppearance.BorderSize = 0;
            this.btnoyna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnoyna.ForeColor = System.Drawing.Color.White;
            this.btnoyna.Location = new System.Drawing.Point(796, 612);
            this.btnoyna.Name = "btnoyna";
            this.btnoyna.Size = new System.Drawing.Size(150, 40);
            this.btnoyna.TabIndex = 3;
            this.btnoyna.Text = "Oyna";
            this.btnoyna.TextColor = System.Drawing.Color.White;
            this.btnoyna.UseVisualStyleBackColor = false;
            this.btnoyna.Click += new System.EventHandler(this.btnoyna_Click);
            // 
            // lbloyunadi
            // 
            this.lbloyunadi.AutoSize = true;
            this.lbloyunadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloyunadi.ForeColor = System.Drawing.Color.White;
            this.lbloyunadi.Location = new System.Drawing.Point(55, 617);
            this.lbloyunadi.Name = "lbloyunadi";
            this.lbloyunadi.Size = new System.Drawing.Size(0, 25);
            this.lbloyunadi.TabIndex = 4;
            // 
            // lblneleroluyor
            // 
            this.lblneleroluyor.AutoSize = true;
            this.lblneleroluyor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblneleroluyor.ForeColor = System.Drawing.Color.White;
            this.lblneleroluyor.Location = new System.Drawing.Point(367, 617);
            this.lblneleroluyor.Name = "lblneleroluyor";
            this.lblneleroluyor.Size = new System.Drawing.Size(0, 25);
            this.lblneleroluyor.TabIndex = 5;
            // 
            // UC_oyun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.Controls.Add(this.lblneleroluyor);
            this.Controls.Add(this.lbloyunadi);
            this.Controls.Add(this.btnoyna);
            this.Controls.Add(this.lbltag);
            this.Controls.Add(this.oyuneklebtn);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_oyun";
            this.Size = new System.Drawing.Size(1178, 675);
            this.Load += new System.EventHandler(this.UC_oyun_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private RJButton oyuneklebtn;
        private System.Windows.Forms.Label lbltag;
        private RJButton btnoyna;
        private System.Windows.Forms.Label lbloyunadi;
        private System.Windows.Forms.Label lblneleroluyor;
    }
}
