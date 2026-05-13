namespace quickid
{
    partial class UC_ayarlar
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
            this.lblayarlartag = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblserial = new System.Windows.Forms.Label();
            this.msktextserial = new System.Windows.Forms.MaskedTextBox();
            this.cstcombobox1 = new quickid.CustomTools.cstcombobox();
            this.toggleSagtik = new quickid.RJToggleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lblsagtikmenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblayarlartag
            // 
            this.lblayarlartag.AutoSize = true;
            this.lblayarlartag.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblayarlartag.ForeColor = System.Drawing.Color.White;
            this.lblayarlartag.Location = new System.Drawing.Point(35, 17);
            this.lblayarlartag.Name = "lblayarlartag";
            this.lblayarlartag.Size = new System.Drawing.Size(125, 39);
            this.lblayarlartag.TabIndex = 0;
            this.lblayarlartag.Text = "Ayarlar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(127, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Uygulama Dili";
            // 
            // lblserial
            // 
            this.lblserial.AutoSize = true;
            this.lblserial.ForeColor = System.Drawing.Color.White;
            this.lblserial.Location = new System.Drawing.Point(77, 205);
            this.lblserial.Name = "lblserial";
            this.lblserial.Size = new System.Drawing.Size(195, 17);
            this.lblserial.TabIndex = 6;
            this.lblserial.Text = "Lütfen Ürün Anahtarınızı Girin";
            // 
            // msktextserial
            // 
            this.msktextserial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.msktextserial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.msktextserial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msktextserial.ForeColor = System.Drawing.Color.White;
            this.msktextserial.Location = new System.Drawing.Point(72, 239);
            this.msktextserial.Mask = "AAAAA-AAAAA-AAAAA";
            this.msktextserial.Name = "msktextserial";
            this.msktextserial.Size = new System.Drawing.Size(233, 30);
            this.msktextserial.TabIndex = 7;
            this.msktextserial.TextChanged += new System.EventHandler(this.msktextserial_TextChanged);
            // 
            // cstcombobox1
            // 
            this.cstcombobox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.cstcombobox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.cstcombobox1.BorderSize = 1;
            this.cstcombobox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cstcombobox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cstcombobox1.ForeColor = System.Drawing.Color.White;
            this.cstcombobox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.cstcombobox1.Items.AddRange(new object[] {
            "English",
            "Türkçe"});
            this.cstcombobox1.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.cstcombobox1.ListTextColor = System.Drawing.Color.White;
            this.cstcombobox1.Location = new System.Drawing.Point(72, 121);
            this.cstcombobox1.MinimumSize = new System.Drawing.Size(200, 30);
            this.cstcombobox1.Name = "cstcombobox1";
            this.cstcombobox1.Padding = new System.Windows.Forms.Padding(1);
            this.cstcombobox1.Size = new System.Drawing.Size(233, 30);
            this.cstcombobox1.TabIndex = 4;
            this.cstcombobox1.Texts = "Dil Seçin";
            // 
            // toggleSagtik
            // 
            this.toggleSagtik.AutoSize = true;
            this.toggleSagtik.Location = new System.Drawing.Point(172, 348);
            this.toggleSagtik.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleSagtik.Name = "toggleSagtik";
            this.toggleSagtik.OffBackColor = System.Drawing.Color.Gray;
            this.toggleSagtik.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleSagtik.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.toggleSagtik.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleSagtik.Size = new System.Drawing.Size(45, 22);
            this.toggleSagtik.TabIndex = 8;
            this.toggleSagtik.UseVisualStyleBackColor = true;
            this.toggleSagtik.CheckedChanged += new System.EventHandler(this.toggleSagtik_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(77, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sağ Tık Menüsüne Kısayol Oluşturun";
            // 
            // lblsagtikmenu
            // 
            this.lblsagtikmenu.AutoSize = true;
            this.lblsagtikmenu.ForeColor = System.Drawing.Color.White;
            this.lblsagtikmenu.Location = new System.Drawing.Point(125, 350);
            this.lblsagtikmenu.Name = "lblsagtikmenu";
            this.lblsagtikmenu.Size = new System.Drawing.Size(35, 17);
            this.lblsagtikmenu.TabIndex = 10;
            this.lblsagtikmenu.Text = "Aktif";
            // 
            // UC_ayarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.Controls.Add(this.lblsagtikmenu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toggleSagtik);
            this.Controls.Add(this.msktextserial);
            this.Controls.Add(this.lblserial);
            this.Controls.Add(this.cstcombobox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblayarlartag);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_ayarlar";
            this.Size = new System.Drawing.Size(1178, 675);
            this.Load += new System.EventHandler(this.UC_ayarlar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblayarlartag;
        private System.Windows.Forms.Label label1;
        private CustomTools.cstcombobox cstcombobox1;
        private System.Windows.Forms.Label lblserial;
        private System.Windows.Forms.MaskedTextBox msktextserial;
        private RJToggleButton toggleSagtik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblsagtikmenu;
    }
}
