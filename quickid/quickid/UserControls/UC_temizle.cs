using Microsoft.VisualBasic.Devices;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;



namespace quickid
{
    public partial class UC_temizle : UserControl
    {
        /// //////////////////////////////////Bilgisayarın ismi ///////////////////////////////

        /// ////////////////////////////////// ///////////////////////////////

        /// /////////////ram temizlemek için//////////////////
        public long memoryUsagePercent;
        public UC_temizle()
        {
            InitializeComponent();
        }


        Metots mt = new Metots();


        Process proc = Process.GetCurrentProcess();
        ComputerInfo pcInfo = new ComputerInfo();

        string mainDisk;



        /// //////////////Geri Dönüşümü Temizlemek için/////////////////
        enum RecycleFlags : uint
        {
            SHERB_NOCONFIRMATION = 0x00000001,
            SHERB_NOPROGRESSUI = 0x00000002,
            SHERB_NOSOUND = 0x00000004
        }
        [DllImport("Shell32.dll", CharSet = CharSet.Unicode)]
        static extern uint SHEmptyRecycleBin(IntPtr hwnd, string pszRootPath, RecycleFlags dwFlags);

        //


        string optimizedisk;

        private void optimizebtn_Click(object sender, EventArgs e)
        {
            foreach (var item in panel1.Controls.OfType<RJToggleButton>())
            {
                if (item.Checked)
                {
                    optimizedisk = item.Tag.ToString();
                    mt.OptimizeDrive(optimizedisk, lbl_optimize);
                    item.Checked = false;
                }
            }

        }

        private void ramTemizleBtn_Click(object sender, EventArgs e)
        {
            mt.RamTemizle(lbl_ram);
        }

        private void yenilebtn_Click(object sender, EventArgs e)
        {
            mt.Rtoplam(chart1, lbl_toplamBoyut);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            memoryUsagePercent = 100 - Convert.ToInt64(pcInfo.AvailablePhysicalMemory / (1024 * 1024)) * 100 / (Convert.ToInt64(pcInfo.TotalPhysicalMemory / (1024 * 1024)));
            circularProgressBar1.Value = Convert.ToInt32(memoryUsagePercent);
            circularProgressBar1.Text = memoryUsagePercent.ToString("00") + "%";
            if (memoryUsagePercent >= 80)
            {
                circularProgressBar1.InnerColor = Color.Red;
            }
            else if (memoryUsagePercent < 80 && memoryUsagePercent > 50)
            {
                circularProgressBar1.InnerColor = Color.Orange;
            }
            else
            {
                circularProgressBar1.InnerColor = Color.Green;
            }
        }

        private void UC_temizle_Load(object sender, EventArgs e)
        {
            totalRam.Text = "Toplam Bellek: " + (pcInfo.TotalPhysicalMemory / (1024 * 1024)).ToString() + " MB";
            //disklerden system32 olanı bulur ve yazar
            mainDisk = mt.diskler();
            //diskleri optimize etmek için nesne üretttim
            DriveInfo[] sabitdiskler = DriveInfo.GetDrives();
            for (int a = 0; a < sabitdiskler.Length; a++)
            {
                Label lbl = new Label();
                RJToggleButton toogle = new RJToggleButton();

                lbl.Name = "lbl" + a.ToString();
                toogle.Name = a.ToString();

                toogle.OnBackColor = Color.FromArgb(54, 25, 63);
                toogle.Size = new Size(45, 22);
                string disk = sabitdiskler[a].ToString();
                lbl.Text = disk[0].ToString();
                lbl.ForeColor = Color.FromArgb(239, 248, 251);
                toogle.Tag = disk[0];

                lbl.Location = new Point(toogle.Width + 8, (toogle.Size.Height + 10) * a);
                toogle.Location = new Point(0, (toogle.Size.Height + 10) * a);

                panel1.Controls.Add(toogle);
                panel1.Controls.Add(lbl);
            }
            //////////
            mt.Rtoplam(chart1, lbl_toplamBoyut);
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            string prefetchFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), "Prefetch");
            DirectoryInfo prefetchDirectory = new DirectoryInfo(prefetchFolderPath);
            mt.gecicitemizle(prefetchDirectory);


            string recentFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Recent));
            DirectoryInfo recentDirectory = new DirectoryInfo(recentFolderPath);
            mt.gecicitemizle(recentDirectory);

            string tempFolderPath = Path.GetTempPath();
            DirectoryInfo tempDirectory = new DirectoryInfo(tempFolderPath);
            mt.gecicitemizle(tempDirectory);


            string ytempFolderPath = @"" + mainDisk + ":\\Windows\\Temp";
            DirectoryInfo ytempDirectory = new DirectoryInfo(ytempFolderPath);
            mt.gecicitemizle(ytempDirectory);

            if (tooglebtn_cerz.Checked)
            {
                mt.cookies();
                tooglebtn_cerz.Checked = false;
            }
            if (tooglebtn_cop.Checked)
            {
                uint result = SHEmptyRecycleBin(IntPtr.Zero, null, RecycleFlags.SHERB_NOCONFIRMATION | RecycleFlags.SHERB_NOPROGRESSUI | RecycleFlags.SHERB_NOSOUND);
                tooglebtn_cop.Checked = false;
            }
            if (toggledownlonds.Checked)
            {
                string downloadsFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";
                DirectoryInfo downlodadsDirectory = new DirectoryInfo(downloadsFolderPath);
                mt.gecicitemizle(downlodadsDirectory);
                toggledownlonds.Checked = false;
            }
            mt.Rtoplam(chart1, lbl_toplamBoyut);
        }

        private void cleanupbtn_Click(object sender, EventArgs e)
        {
            lbl_toplamBoyut.Text = "Lütfen işlemin bitmesini bekleyin";
            mt.RunDismCommandWithProgress("dism /Online /Cleanup-Image /StartComponentCleanup");
        }
    }
}
