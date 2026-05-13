using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Windows.Forms;

namespace quickid
{
    public partial class UC_hizlandir : UserControl
    {
        public UC_hizlandir()
        {
            InitializeComponent();
        }
        //

        string mainDisk;
        Metots mt = new Metots();

        /// ////
   
        string processorName;



        private void UC_hizlandir_Load(object sender, EventArgs e)
        {
            
            mainDisk = mt.diskler();
            mt.kontorlv2();

            ////işlemci markası öğrenmek için
            {
                using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor"))
                {
                    foreach (ManagementObject obj in searcher.Get())
                    {
                        processorName = obj["Name"].ToString();
                    }
                }
            }

            //EcMenu_x64.exe /Admin /ReduceMemory
            



            ////// 
            ///ryzen performans arttırma kontrol

            {
                if (processorName.ToLower().Contains("ryzen"))
                {
                    ryzentoggle.Enabled = true;
                    if (Registry.CurrentUser.OpenSubKey("quickid").OpenSubKey("ryzen").GetValue("ryzen").ToString() == "disabled")
                    {
                        lblryzenonoff.Text = "Pasif";
                        ryzentoggle.Checked = false;
                    }
                    else
                    {
                        lblryzenonoff.Text = "Aktif";
                        ryzentoggle.Checked = true;
                    }
                }
            }
            //////////////////////////


            {

                if (Registry.CurrentUser.OpenSubKey("quickid").OpenSubKey("koptimize").GetValue("koptimize").ToString() == "disabled")
                {
                    toggleoptimize.Checked = false;
                    lbloptimizeonoff.Text = "Pasif";
                }
                else
                {
                    toggleoptimize.Checked = true;
                    lbloptimizeonoff.Text = "Aktif";
                }
            }

            /////////////////////
            {
                if (Registry.CurrentUser.OpenSubKey("quickid").OpenSubKey("oyunperformans").GetValue("oyunperformans").ToString() == "disabled")
                {
                    toggleoyun.Checked = false;
                    lbloynonoff.Text = "Pasif";
                }
                else
                {
                    toggleoyun.Checked = true;
                    lbloynonoff.Text = "Aktif";
                }
            }

            //////////////////////////////
            {
                if (Registry.CurrentUser.OpenSubKey("quickid").OpenSubKey("garttir").GetValue("garttir").ToString() == "disabled")
                {
                    togglegarttir.Checked = false;
                    lblgarttironoff.Text = "Pasif";
                }
                else
                {
                    togglegarttir.Checked = true;
                    lblgarttironoff.Text = "Aktif";
                }

                ///////////////////////////
                if (Registry.CurrentUser.OpenSubKey("quickid").OpenSubKey("bildirimler").GetValue("bildirimler").ToString() == "disabled")
                {
                    togglebildirim.Checked = false;
                    lblbildirimonoff.Text = "Pasif";
                }
                else
                {
                    togglebildirim.Checked = true;
                    lblbildirimonoff.Text = "Aktif";
                }
                ///
                if (Registry.CurrentUser.OpenSubKey("quickid").OpenSubKey("saydamlik").GetValue("saydamlik").ToString() == "disabled")
                {
                    togglesaydamlik.Checked = false;
                    lblsaydamlikonoff.Text = "Pasif";
                }
                else
                {
                    togglesaydamlik.Checked = true;
                    lblsaydamlikonoff.Text = "Aktif";
                }
                ///
                if (Registry.CurrentUser.OpenSubKey("quickid").OpenSubKey("ghizmetler").GetValue("ghizmetler").ToString() == "disabled")
                {
                    togglehizmet.Checked = false;
                    lblhizmetonoff.Text = "Pasif";
                }
                else
                {
                    togglehizmet.Checked = true;
                    lblhizmetonoff.Text = "Aktif";
                }
                //
                if (Registry.CurrentUser.OpenSubKey("quickid").OpenSubKey("gizlilik").GetValue("gizlilik").ToString() == "disabled")
                {
                    gizliliktoggle.Checked = false;
                    gizlilikLblonoff.Text = "Pasif";
                }
                else
                {
                    gizliliktoggle.Checked = true;
                    gizlilikLblonoff.Text = "Aktif";
                }
                //
                if (Registry.CurrentUser.OpenSubKey("quickid").OpenSubKey("cihazlarpaylasim").GetValue("cihazlarpaylasim").ToString() == "disabled")
                {
                    togglecihazlararasi.Checked = false;
                    lblcihazlararasionoff.Text = "Pasif";
                }
                else
                {
                    togglecihazlararasi.Checked = true;
                    lblcihazlararasionoff.Text = "Aktif";
                }
            }



          
        }

        loading frm = new loading();
        private void hizlandironaylabtn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "shutdown", // shutdown komutunu çalıştırın
                Arguments = "/r /t 0", // /r argümanı bilgisayarı yeniden başlatır, /t 0 argümanı zaman gecikmesini 0 saniye olarak ayarlar
                CreateNoWindow = true, // Yeni pencere oluşturma
                UseShellExecute = false, // Shell'i kullanmayı devre dışı bırak
                RedirectStandardOutput = true, // Standart çıktıyı yönlendir (isteğe bağlı)
                RedirectStandardError = true // Standart hata çıktısını yönlendir (isteğe bağlı)
            };

            // ProcessStartInfo nesnesini kullanarak süreci başlatın
            Process process = new Process
            {
                StartInfo = startInfo
            };

            // Süreci başlatın
            process.Start();

            // Opsiyonel olarak, sürecin çıktısını ve hata çıktısını okuyabilirsiniz
            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();

            // Sürecin bitmesini bekleyin (opsiyonel)
            process.WaitForExit();
        }

       

        private void geriyuklebtn_Click(object sender, EventArgs e)
        {
         

        }

       

       

        private void lbltelemetri_Click(object sender, EventArgs e)
        {
            mt.runbatfiles(Application.StartupPath + "\\regfiles\\bat\\TelemetriKaldirma.bat");
            lbltelemetri.ForeColor = Color.Green;
        }

       

        

        private void togglesaydamlik_Click(object sender, EventArgs e)
        {
            if (togglesaydamlik.Checked)
            {

                mt.RunRegFile(Application.StartupPath + "\\regfiles\\saydamlikefekti.reg");
                Registry.CurrentUser.CreateSubKey("quickid").CreateSubKey("saydamlik").SetValue("saydamlik", "enabled");
                lblsaydamlikonoff.Text = "Aktif";


            }
            else
            {

                mt.RunRegFile(Application.StartupPath + "\\regfiles\\saydamlikefektiac.reg");
                Registry.CurrentUser.CreateSubKey("quickid").CreateSubKey("saydamlik").SetValue("saydamlik", "disabled");
                lblsaydamlikonoff.Text = "Pasif";


            }
        }

        private void gizliliktoggle_Click(object sender, EventArgs e)
        {
            if (gizliliktoggle.Checked)
            {
                mt.RunRegFile(@Application.StartupPath + "\\regfiles\\GizlilikKapa.reg");
                Registry.CurrentUser.CreateSubKey("quickid").CreateSubKey("gizlilik").SetValue("gizlilik", "enabled");
                gizlilikLblonoff.Text = "Aktif";
            }
            else
            {
                mt.runregfilesbutwithcmd(@Application.StartupPath + "\\regfiles\\GizlilikKapa.reg");
                Registry.CurrentUser.CreateSubKey("quickid").CreateSubKey("gizlilik").SetValue("gizlilik", "disabled");
                gizlilikLblonoff.Text = "Pasif";
            }
        }

        private void toggleoyun_Click(object sender, EventArgs e)
        {
            if (toggleoyun.Checked)
            {
                mt.RunRegFile(@Application.StartupPath + "\\regfiles\\OyunPerformansınıArttırmakicin.reg");
                Registry.CurrentUser.CreateSubKey("quickid").CreateSubKey("oyunperformans").SetValue("oyunperformans", "enabled");
                lbloynonoff.Text = "Aktif";
            }
            else
            {
                string[] OyunPerformas = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\quickid\backup\OyunPerformas");
                for (int i = 0; i < OyunPerformas.Length; i++)
                {
                    mt.runregfilesbutwithcmd(OyunPerformas[i]);
                }
                Registry.CurrentUser.CreateSubKey("quickid").CreateSubKey("oyunperformans").SetValue("oyunperformans", "disabled");
                lbloynonoff.Text = "Pasif";
            }
        }

        private void toggleoptimize_Click(object sender, EventArgs e)
        {
            if (toggleoptimize.Checked)
            {
                mt.RunRegFile(@Application.StartupPath + "\\regfiles\\WindowsKısmiOptimize.reg");
                Registry.CurrentUser.CreateSubKey("quickid").CreateSubKey("koptimize").SetValue("koptimize", "enabled");
                lbloptimizeonoff.Text = "Aktif";
            }
            else
            {
                string[] KısmiOptimize = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\quickid\backup\KısmiOptimize");
                for (int i = 0; i < KısmiOptimize.Length; i++)
                {
                    mt.runregfilesbutwithcmd(KısmiOptimize[i]);
                }
                Registry.CurrentUser.CreateSubKey("quickid").CreateSubKey("koptimize").SetValue("koptimize", "disabled");
                lbloptimizeonoff.Text = "Pasif";
            }
        }

        private void togglegarttir_Click(object sender, EventArgs e)
        {
            if (togglegarttir.Checked)
            {
                mt.RunRegFile(@Application.StartupPath + "\\regfiles\\GizliligiArttirmakicin.reg");
                Registry.CurrentUser.CreateSubKey("quickid").CreateSubKey("garttir").SetValue("garttir", "enabled");
                lblgarttironoff.Text = "Aktif";
            }
            else
            {
                string[] togglegarttir = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\quickid\backup\Gizliliği Arttırmak İçin");
                for (int i = 0; i < togglegarttir.Length; i++)
                {
                    mt.runregfilesbutwithcmd(togglegarttir[i]);
                }
                Registry.CurrentUser.CreateSubKey("quickid").CreateSubKey("garttir").SetValue("garttir", "disabled");

                lblgarttironoff.Text = "Pasif";
            }
        }

        private void togglehizmet_Click(object sender, EventArgs e)
        {
            if (togglehizmet.Checked)
            {
                mt.RunRegFile(Application.StartupPath + "\\regfliles\\GereksizHizmetlerreg.reg");
                mt.runbatfiles(Application.StartupPath + "\\regfiles\\bat\\GereksizHizmetler.bat");
                Registry.CurrentUser.CreateSubKey("quickid").CreateSubKey("ghizmetler").SetValue("ghizmetler", "enabled");
                lblhizmetonoff.Text = "Aktif";
            }
            else
            {
                mt.runregfilesbutwithcmd(Application.StartupPath + "\\regfliles\\GereksizHizmetlerregoff.reg");
                mt.runregfilesbutwithcmd(Application.StartupPath + "\\regfiles\\bat\\GereksizHizmetleriAc.bat");
                Registry.CurrentUser.CreateSubKey("quickid").CreateSubKey("ghizmetler").SetValue("ghizmetler", "disabled");
                lblhizmetonoff.Text = "Pasif";
            }
        }

        private void ryzentoggle_Click(object sender, EventArgs e)
        {
            if (ryzentoggle.Checked)
            {

                mt.RunRegFile(@Application.StartupPath + "\\regfiles\\RyzenPerformansArttirma.reg");
                Registry.CurrentUser.CreateSubKey("quickid").CreateSubKey("ryzen").SetValue("ryzen", "enabled");
                lblryzenonoff.Text = "Aktif";

            }
            else
            {

                string[] RyzenPerfomans = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\quickid\backup\RyzenPerfomans");
                for (int i = 0; i < RyzenPerfomans.Length; i++)
                {
                    mt.runregfilesbutwithcmd(RyzenPerfomans[i]);
                }
                Registry.CurrentUser.CreateSubKey("quickid").CreateSubKey("ryzen").SetValue("ryzen", "disabled");
                lblryzenonoff.Text = "Pasif";


            }
        }

        private void togglebildirim_Click(object sender, EventArgs e)
        {
            if (togglebildirim.Checked)
            {
                mt.RunRegFile(Application.StartupPath + "\\regfiles\\BildirimleriKapat.reg");
                Registry.CurrentUser.CreateSubKey("quickid").CreateSubKey("bildirimler").SetValue("bildirimler", "enabled");
                lblbildirimonoff.Text = "Aktif";
            }
            else
            {
                string[] bildirim = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\quickid\backup\Bildirim");
                for (int i = 0; i < bildirim.Length; i++)
                {
                    mt.runregfilesbutwithcmd(bildirim[i]);
                }
                Registry.CurrentUser.CreateSubKey("quickid").CreateSubKey("bildirimler").SetValue("bildirimler", "disabled");
                lblbildirimonoff.Text = "Pasif";
            }
        }

        private void togglecihazlararasi_Click(object sender, EventArgs e)
        {
            if (togglecihazlararasi.Checked)
            {
                mt.RunRegFile(@Application.StartupPath + "\\regfiles\\cihazlarrasipaylasimkapa.reg");
                Registry.CurrentUser.CreateSubKey("quickid").CreateSubKey("cihazlarpaylasim").SetValue("cihazlarpaylasim", "enabled");
                lblcihazlararasionoff.Text = "Aktif";
            }
            else
            {
                mt.RunRegFile(@Application.StartupPath + "\\regfiles\\cihazlarrasipaylasimac.reg");
                Registry.CurrentUser.CreateSubKey("quickid").CreateSubKey("cihazlarpaylasim").SetValue("cihazlarpaylasim", "disabled");
                lblcihazlararasionoff.Text = "Pasif";
            }
        }

       
    }
}
