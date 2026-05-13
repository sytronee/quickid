using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace quickid
{
    public partial class UC_oyun : UserControl
    {


        public UC_oyun()
        {
            InitializeComponent();
        }
        Metots mt = new Metots();
        string maindisk;
        int cname = 0;
        List<string> paths = new List<string>();
        StreamWriter sr;
        OpenFileDialog ofd;
        Icon fileicon;

        private void oyuneklebtn_Click(object sender, EventArgs e)
        {

            ofd = new OpenFileDialog();
            ofd.InitialDirectory = maindisk + ":\\";
            ofd.Filter = "Executable Files |*.exe";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileicon = Icon.ExtractAssociatedIcon(ofd.FileName);
                if (fileicon != null)
                {
                    if (!oyunlarpath.Contains(ofd.FileName))
                    {
                        Panel pnl = new Panel();
                        pnl.Name = cname.ToString();
                        pnl.Size = new Size(80, 80);

                        PictureBox picturebox = new PictureBox();
                        picturebox.Name = cname.ToString();

                        Label lbl = new Label();
                        lbl.Name = cname.ToString();

                        lbl.AutoSize = false;
                        lbl.ForeColor = Color.White;
                        lbl.Dock = DockStyle.Bottom;
                        lbl.Text = ofd.SafeFileName;
                        pnl.Controls.Add(lbl);

                        picturebox.Dock = DockStyle.Fill;
                        picturebox.Image = fileicon.ToBitmap();
                        picturebox.Size = new Size(40, 40);
                        picturebox.SizeMode = PictureBoxSizeMode.CenterImage;
                        pnl.Controls.Add(picturebox);
                        flowLayoutPanel1.Controls.Add(pnl);

                        using (sr = File.AppendText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\quickid\\Games\\gamespath.txt"))
                        {
                            sr.WriteLine(ofd.FileName);
                            sr.Close();
                        }
                        using (sr = File.AppendText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\quickid\\Games\\gamesname.txt"))
                        {
                            sr.WriteLine(ofd.SafeFileName);
                            sr.Close();
                        }
                        Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\DirectX\UserGpuPreferences", ofd.FileName, "GpuPreference=2;");
                        cname++;
                    }
                    else
                    {
                       
                    }
                }
            }
        }
        string[] oyunlarpath;
        string[] oyunlarname;
        int satir_sayisi;
        static List<string> FindInstalledGames()
        {
            List<string> gamesList = new List<string>();

            // Program Files klasörleri (x86 ve x64) taranıyor.
            string[] programFilesFolders = { Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles),
                                         Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) };

            foreach (string programFilesFolder in programFilesFolders)
            {
                // Program Files klasörlerindeki alt klasörlerin içerikleri taranıyor.
                foreach (string subFolder in Directory.GetDirectories(programFilesFolder))
                {
                    // Oyun klasörlerinin adlarını belirleyebileceğiniz bazı genel kavramlar kullanabilirsiniz.
                    // Örneğin, "game", "games", "steam", "ubisoft" gibi kavramlar içeren klasörleri oyun olarak kabul edebilirsiniz.
                    if (subFolder.ToLower().Contains("game") ||
                        subFolder.ToLower().Contains("games") ||
                        subFolder.ToLower().Contains("steam") ||
                        subFolder.ToLower().Contains("ubisoft"))
                    {
                        gamesList.Add(subFolder);
                    }
                }
            }

            return gamesList;
        }


        private void UC_oyun_Load(object sender, EventArgs e)
        {
            List<string> oyunlar = FindInstalledGames();
            for (int i = 0; i < oyunlar.Count; i++)
            {
                Console.Write(oyunlar[i]);
            }
            maindisk = mt.diskler();
            
            using (StreamReader rd = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\quickid\\Games\\gamespath.txt"))
            {
                while (rd.ReadLine() != null)
                {
                    satir_sayisi++;
                }
                rd.Close();
                oyunlarpath = File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\quickid\\Games\\gamespath.txt");
                oyunlarname = File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\quickid\\Games\\gamesname.txt");


                for (int i = 0; i < satir_sayisi; i++)
                {
                    fileicon = Icon.ExtractAssociatedIcon(oyunlarpath[i]);
                    Panel pnl = new Panel();
                    pnl.Name = cname.ToString();
                    pnl.Size = new Size(80, 80);

                    PictureBox picturebox = new PictureBox();
                    picturebox.Name = cname.ToString();

                    Label lbl = new Label();
                    lbl.Name = i.ToString();

                    lbl.AutoSize = false;
                    lbl.ForeColor = Color.White;
                    lbl.Dock = DockStyle.Bottom;
                    lbl.Text = oyunlarname[i];
                    pnl.Controls.Add(lbl);

                    picturebox.Dock = DockStyle.Fill;
                    picturebox.Image = fileicon.ToBitmap();
                    picturebox.Size = new Size(40, 40);
                    picturebox.SizeMode = PictureBoxSizeMode.CenterImage;
                    picturebox.Click += Picturebox_Click;
                    pnl.Controls.Add(picturebox);

                    flowLayoutPanel1.Controls.Add(pnl);
                    cname++;
                }
            }
        }


        int hangioyun;
        private void Picturebox_Click(object sender, EventArgs e)
        {
            PictureBox pctr_tiklanan = (PictureBox)sender;
            hangioyun = Convert.ToInt16(pctr_tiklanan.Name);
            btnoyna.Enabled = true;
            lbloyunadi.Text = oyunlarname[hangioyun];

        }

        private void btnoyna_Click(object sender, EventArgs e)
        {
            mt.RamTemizle(lblneleroluyor);
            mt.OptimizeDrive(maindisk, lblneleroluyor);

            Process pros = new Process();
            pros.StartInfo.FileName = oyunlarpath[hangioyun];
            pros.Start();
            pros.PriorityClass = ProcessPriorityClass.High;
            btnoyna.Enabled = false;
        }
    }
}
