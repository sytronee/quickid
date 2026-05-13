using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace quickid
{
    public partial class loading : Form
    {
        //koseleri yuvarlama
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        public loading()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        //borderdan suruklemenin importları
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        Metots mt = new Metots();
        String mainDisk;
        public List<string> aktif = new List<string>();
        public List<string> pasif = new List<string>();

        //UC_hizlandir  uC_Hizlandir=new UC_hizlandir();


        private void mbboxfrm_Load(object sender, EventArgs e)
        {
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            //Borderlardan sürüklemek için 
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
            //
        }

        private void mbexitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


       

   


    }
}
