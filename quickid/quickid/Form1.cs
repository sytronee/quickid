using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace quickid
{
    public partial class Form1 : Form
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

        public Form1()
        {
            InitializeComponent();
            mt.ProcessCommandLineArgs();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        Metots mt = new Metots();
        
        //borderdan suruklemenin importları
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);
        public string mainDisk;
        StreamWriter sr;
        private void panet_top_MouseDown(object sender, MouseEventArgs e)
        {
            //Borderlardan sürüklemek için 
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
            //
        }
        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                
                if (Registry.GetValue("HKEY_CURRENT_USER\\quickid","main",null)==null)
                {
                    Registry.CurrentUser.CreateSubKey("quickid").CreateSubKey("ryzen").SetValue("ryzen", "disabled");
                    Registry.CurrentUser.CreateSubKey("quickid").CreateSubKey("gizlilik").SetValue("gizlilik", "disabled");
                    Registry.CurrentUser.CreateSubKey("quickid").CreateSubKey("cihazlarpaylasim").SetValue("cihazlarpaylasim", "disabled");
                    Registry.CurrentUser.CreateSubKey("quickid").CreateSubKey("garttir").SetValue("garttir", "disabled");
                    Registry.CurrentUser.CreateSubKey("quickid").CreateSubKey("koptimize").SetValue("koptimize", "disabled");
                    Registry.CurrentUser.CreateSubKey("quickid").CreateSubKey("oyunperformans").SetValue("oyunperformans", "disabled");
                    Registry.CurrentUser.CreateSubKey("quickid").CreateSubKey("saydamlik").SetValue("saydamlik", "disabled");
                    Registry.CurrentUser.CreateSubKey("quickid").CreateSubKey("bildirimler").SetValue("bildirimler", "disabled");
                    Registry.CurrentUser.CreateSubKey("quickid").CreateSubKey("ghizmetler").SetValue("ghizmetler", "disabled");
                    Registry.CurrentUser.CreateSubKey("quickid").CreateSubKey("contextmenu").SetValue("contextmenu", "disabled");
                    Registry.CurrentUser.CreateSubKey("quickid").SetValue("main", "false");
                }
            }
            catch
            {
                Registry.CurrentUser.CreateSubKey("quickid").SetValue("main", null);
                throw;
            }
            mainDisk = mt.diskler();
            string[] deger = { Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\quickid", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\quickid\\backup", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\quickid\\Games", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\quickid\\backup\\Bildirim", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\quickid\\backup\\Gizliliği Arttırmak İçin", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\quickid\\backup\\All", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\quickid\\backup\\KısmiOptimize", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\quickid\\backup\\OyunPerformas", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\quickid\\backup\\RyzenPerfomans" };
            if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\quickid"))
            {
                for (int i = 0; i < deger.Length; i++)
                {
                    try
                    {
                        Directory.CreateDirectory(deger[i]);
                        // Klasördeki "ready-only" özelliğini kaldırmak için SetAttributes metodunu kullanın
                        FileAttributes attributes = File.GetAttributes(deger[i]);
                        if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
                        {
                            // "read-only" özelliğini kaldır
                            attributes &= ~FileAttributes.ReadOnly;
                            File.SetAttributes(deger[i], attributes);
                            Console.WriteLine("Klasördeki 'ready-only' özelliği kaldırıldı: " + deger[i]);
                        }
                        else
                        {
                            Console.WriteLine("Klasörde 'ready-only' özelliği zaten devre dışı.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Hata: " + ex.Message);
                    }
                }
                if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\quickid\\Games\\gamespath.txt"))
                {
                    sr = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\quickid\\Games\\gamespath.txt");
                    sr.Close();
                }
                if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\quickid\\Games\\gamesname.txt"))
                {
                    sr = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\quickid\\Games\\gamesname.txt");
                    sr.Close();
                }
            }







            if (mt.command.Count != 0)
            {
                this.Hide();
                if (mt.command.Contains("Ram"))
                {
                    mt.RamTemizle(lblhiclik);
                    Application.Exit();
                }
                if (mt.command.Contains("Temp"))
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
                    Application.Exit();


                }
                if (mt.command.Contains("Optimize"))
                {
                    mt.OptimizeDrive(mainDisk, lblhiclik);
                    MessageBox.Show("Test");
                    Application.Exit();
                }

            }

           


            this.components = new System.ComponentModel.Container();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();

            // Initialize contextMenu1
            this.contextMenu1.MenuItems.AddRange(
            new System.Windows.Forms.MenuItem[] { this.menuItem1 });

            // Initialize menuItem1
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "E&xit";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);

            // Set up how the form should be displayed.

            // Create the NotifyIcon.
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);

            // The Icon property sets the icon that will appear
            // in the systray for this application.

            // The ContextMenu property sets the menu that will
            // appear when the systray icon is right clicked.
            notifyIcon1.ContextMenu = this.contextMenu1;

            // Handle the DoubleClick event to activate the form.
            notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
          //  uC_homepage1.BringToFront();
            //ana diski bulmak ve için (noti için gerekli)
            DriveInfo[] diskler = DriveInfo.GetDrives();
            for (int i = 0; i < diskler.Length; i++)
            {
                string disk = diskler[i].ToString();
                if (Directory.Exists(disk[0] + ":\\Windows\\System32"))
                {
                    mainDisk = disk[0].ToString();
                }
            }
        }

        private void exitButton_1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void miniButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cleanButton1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UC_temizle UC_temizle1 = new UC_temizle();
            UC_temizle1.Show();
            UC_temizle1.Dock = DockStyle.Fill;
            panel1.Controls.Add(UC_temizle1);
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UC_homepage uc_homepage=new UC_homepage();
            uc_homepage.Show();
            uc_homepage.Dock = DockStyle.Fill;
            panel1.Controls.Add(uc_homepage);
        }

        private void btnhizlandir_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UC_hizlandir uc_hizlandir1 = new UC_hizlandir();
            uc_hizlandir1.Show();
            uc_hizlandir1.Dock = DockStyle.Fill;
            panel1.Controls.Add(uc_hizlandir1);
        }


        UC_temizle temizlePage = new UC_temizle();
        long memoryUsagePercent = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //ANLIK RAM KULLANIMI YÜZDELİK OLARAK
            Process proc = Process.GetCurrentProcess();
            ComputerInfo pcInfo = new ComputerInfo();
            memoryUsagePercent = 100 - Convert.ToInt64(pcInfo.AvailablePhysicalMemory / (1024 * 1024)) * 100 / (Convert.ToInt64(pcInfo.TotalPhysicalMemory / (1024 * 1024)));
            temizlePage.memoryUsagePercent = memoryUsagePercent;
            notifyIcon1.Text = "Fast Optimizer\nAnlık Ram Kullanımı: " + memoryUsagePercent + "%";
        }

        private void panet_top_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;

            // Activate the form.
            this.Activate();

        }

        private void diskiOptimizeEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mt.OptimizeDrive(mainDisk, lblhiclik);
            //bildirimler eklenecek
        }
        private void ramiTemizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mt.RamTemizle(lblhiclik);
        }

        private void geçiciDosyalarıTemizleToolStripMenuItem_Click(object sender, EventArgs e)
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
        }

        private void çıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
        }

        private void btnoyunmodu_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UC_oyun oyunuc = new UC_oyun();
            oyunuc.Show();
            oyunuc.Dock = DockStyle.Fill;
            panel1.Controls.Add(oyunuc);
        }

        private void btnayarlar_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UC_ayarlar ayarlaruc=new UC_ayarlar();
            ayarlaruc.Show();
            ayarlaruc.Dock= DockStyle.Fill;
            panel1.Controls.Add( ayarlaruc );
        }
    }
}
