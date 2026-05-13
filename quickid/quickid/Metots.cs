using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace quickid
{
    public class Metots
    {

        string name = System.Windows.Forms.SystemInformation.UserName; // bilgisayarın adı

        string mainDisk;

        public string diskler()
        {
            DriveInfo[] diskler = DriveInfo.GetDrives();
            for (int i = 0; i < diskler.Length; i++)
            {
                string disk = diskler[i].ToString();
                if (Directory.Exists(disk[0] + ":\\Windows\\System32"))
                {
                    mainDisk = disk[0].ToString();
                }
            }
            return mainDisk;
        }// ana diski bulur ve string değer döndürür

        // uc Hızlandır

        

        List<string> degerkontrolprivacyT = new List<string>();
        public void control(RJToggleButton rj, Label lbl)
        {
            string[] privacy = { "radios", "chat", "contacts", "email", "location", "phoneCall", "phoneCallHistory", "appDiagnostics", "bluetooth", "bluetoothSync", "humanInterfaceDevice", "userDataTasks", "userAccountInformation" };
            string privacyPath = @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\CapabilityAccessManager\ConsentStore\";
            for (int i = 0; i < privacy.Length; i++)
            {
                if (Registry.GetValue(@privacyPath + privacy[i], "Value", "").ToString() == "Allow")
                {
                    degerkontrolprivacyT.Add(Registry.GetValue(@privacyPath + privacy[i], "Value", "").ToString());
                }
            }
            if (privacy.Length / 2 <= degerkontrolprivacyT.Count)
            {
                rj.Checked = false;
                lbl.Text = "Pasif";
            }
            else
            {
                rj.Checked = true;
                lbl.Text = "Aktif";
            }
        } //gizlilik ayarlarını kontrol eder ve ona göre buton açar kapatır
        public void RunRegFile(string regFilePath)
        {
            Process process = new Process();
            process.StartInfo.FileName = "regedit.exe";
            process.StartInfo.Arguments = "/s " + regFilePath;
            process.Start();
            process.WaitForExit();
        } //regedit dosyalarını çalıştırır

        public void getregeditbackup(string yedekpath)
        {
            try
            {
                Process process = new Process();
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = $"/C regedit.exe /e \"{yedekpath}\"";
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;

                process.Start();
                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                Console.WriteLine("Regedit yedeği başarıyla alındı: " + @yedekpath);
                Console.WriteLine("Çıktı:");
                Console.WriteLine(output);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            Console.ReadLine();

        } //tüm regedit yedeğini almak için

        public bool checkMachineType(string path, string text)
        {
            RegistryKey winLogonKey = Registry.LocalMachine.OpenSubKey(@path, true);
            return (winLogonKey.GetValueNames().Contains(text));
        } // regeditte anahtarın varlığını sorgular :=)

        public bool checkMachineTypecurrent(string path, string text)
        {
            RegistryKey winLogonKey = Registry.CurrentUser.OpenSubKey(@path, true);
            return (winLogonKey.GetValueNames().Contains(text));
        } // regeditte anahtarın varlığını sorgular :=)



        // uc hızlandır finito
        // MB BOX
        public void runbatfiles(string batDosyaYolu)
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = $"/c \"{batDosyaYolu}\"";
            process.StartInfo.Verb = "runas";
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            try
            {
                process.Start();
                process.WaitForExit();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
            }
        }  //bat dosyası çalıştırır

        public void runregfilesbutwithcmd(string regfile)
        {
            string regFilePath = regfile; // .reg dosyasının yolu

            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Verb = "runas"; // Yönetici izniyle çalıştırma
            process.StartInfo.Arguments = "/c regedit.exe /s \"" + regFilePath + "\"";
            process.StartInfo.UseShellExecute = false;
            //process.StartInfo.CreateNoWindow= true;

            try
            {
                process.Start();
                process.WaitForExit();
                Console.WriteLine("Reg dosyası yönetici olarak çalıştırıldı.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Yönetici olarak çalıştırma başarısız oldu: " + ex.Message);
            }

        }

        public void regedityedekalma(string[] yedek, string name)
        {
            Process process = new Process();
            for (int i = 0; i < yedek.Length; i++)
            {
                string regpath = yedek[i];
                string savepaath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\quickid\backup\" + @name + @"\" + (i + 1).ToString() + ".reg";

                process.StartInfo.FileName = "cmd.exe";
                //C:\quickid\backup\RyzenPerfomans
                process.StartInfo.Arguments = $"/C reg export \"{yedek[i]}\"  \"{savepaath}\" ";
                process.StartInfo.Verb = "runas";
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                try
                {
                    process.Start();
                    process.WaitForExit();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hata: " + ex.Message);
                }
            }

        }  //herhangi bir reg dosyası çalıştığında tam çalışmadan önce reg dosyasının etki edeceği yolun yedeğini alır

        public void kontorlv2()
        {
            string[] GizliligiArttirmakIcin = { @"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", @"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\SQMClient\Windows", @"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\HandwritingErrorReports", @"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\DataCollection", @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\DataCollection", @"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\AppCompat" };

            string[] kısmioptimize = {
            @"HKEY_CLASSES_ROOT\AllFilesystemObjects\shellex\ContextMenuHandlers",
            @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer",
            @"HKEY_CURRENT_USER\Control Panel",
            @"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control",
            @"HKEY_CURRENT_USER\Software\Microsoft\Siuf\Rules",
            @"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\DataCollection",
            @"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows Defender",
            @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\DriverSearching",
            @"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Session Manager\Power",
            @"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Power",
        };

            string[] oyunperformans = { @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\PolicyManager\default\ApplicationManagement\AllowGameDVR",
        @"HKEY_CURRENT_USER\System\GameConfigStore",
        @"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\GameDVR",
        @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\GameDVR",
        @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile",
        @"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Power\PowerSettings\54533251-82be-4824-96c1-47b60b740d00\943c8cb6-6f93-4227-ad87-e9a3feec08d1",
        @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games"
        };

            string[] ryzenyedek = { @"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management",
        @"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\FileSystem",
        @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\",
        };

            string[] bildirim = { @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", @"HKEY_CURRENT_USER\Software\Policies\Microsoft\Windows\Explorer" };

            string[] saydamlik = { @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize" };
            //bu işlemlerde manidisk klasöründe oluştduğumuz regedit yedeklerni kontol ediyoruz eğer yok ise oluşturuyoruz

            if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\quickid\backup\Gizliliği Arttırmak İçin\" + 1.ToString() + ".reg"))
            {
                for (int i = 0; i < GizliligiArttirmakIcin.Length; i++)
                {
                    if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\quickid\backup\Gizliliği Arttırmak İçin\" + (1 + i).ToString() + ".reg"))
                    {
                        regedityedekalma(GizliligiArttirmakIcin, "Gizliliği Arttırmak İçin");
                        break;
                    }
                }





                //
                for (int i = 0; i < oyunperformans.Length; i++)
                {
                    if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\quickid\backup\OyunPerformas\" + (1 + i).ToString() + ".reg"))
                    {
                        regedityedekalma(oyunperformans, "OyunPerformas");
                        break;
                    }
                }



                //

                for (int i = 0; i < kısmioptimize.Length; i++)
                {
                    if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\quickid\backup\KısmiOptimize\" + (i + 1).ToString() + ".reg"))
                    {
                        regedityedekalma(kısmioptimize, "KısmiOptimize");
                        break;
                    }
                }



                //

                if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\quickid\backup\RyzenPerfomans\1.reg"))
                {
                    regedityedekalma(ryzenyedek, "RyzenPerfomans");

                }
                //
                if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\quickid\\backup\\All\\All.reg"))
                {
                    getregeditbackup(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\quickid\\backup\\All\\All.reg");
                }
                //
                for (int i = 0; i < bildirim.Length; i++)
                {
                    if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\quickid\backup\Bildirim\" + (i + 1).ToString() + ".reg"))
                    {
                        regedityedekalma(bildirim, "Bildirim");
                        break;
                    }
                }
            }
               
            //

            //

        } //klasörleri kontrol edip reg dosyalarının yedeklerini doğrular

        //MB BOX FİNİTO

        // UCTEMİZLE
        [DllImport("psapi.dll")]
        static extern int EmptyWorkingSet(IntPtr hProcess);
        int a;
        public void RamTemizle(Label lblram)
        {
            try
            {
                // Garbage Collector'ı çağırarak mevcut kullanılmayan nesneleri temizle
                GC.Collect();

                // Mevcut işlemi al
                Process mevcutIslem = Process.GetCurrentProcess();

                // İşlem önbelleğini temizle
                EmptyWorkingSet(mevcutIslem.Handle);

                // Tüm çalışan işlemleri al
                Process[] islemler = Process.GetProcesses();

                // Her bir işlemi döngü ile kontrol et
                foreach (Process islem in islemler)
                {
                    try
                    {
                        a += islem.VirtualMemorySize;
                        a = 0 > a ? a * -1 : a * 1;
                        // İşlem önbelleğini temizle
                        EmptyWorkingSet(islem.Handle);
                    }
                    catch (Exception ex)
                    {
                        // İşlem temizlenirken hata oluştuysa hata mesajını görüntüle
                        lblram.Text = ("İşlem temizlenirken hata oluştu: " + ex.Message);
                    }
                }
                lblram.Text = DateTime.Now.ToLongTimeString() + " Saatinde " + a / (1024 * 1024) + " MB Bellek Boşaltıldı";
                a = 0;
            }
            catch (Exception ex)
            {
                lblram.Text = ("RAM temizleme işlemi sırasında bir hata oluştu: " + ex.Message);
            }
        } // ram temziler 

        public void OptimizeDrive(string driveLetter, Label lbloptimize)
        {
            string driveName = driveLetter + ":"; // Optimize edilecek sürücü adı

            try
            {
                Process defragProcess = new Process();
                defragProcess.StartInfo.FileName = "defrag.exe";
                defragProcess.StartInfo.Arguments = driveName + " /C"; // /C parametresiyle optimize işlemi yapılır
                defragProcess.StartInfo.UseShellExecute = false;
                defragProcess.StartInfo.RedirectStandardOutput = true;
                defragProcess.StartInfo.CreateNoWindow = true;
                defragProcess.Start();

                string output = defragProcess.StandardOutput.ReadToEnd();
                defragProcess.WaitForExit();

                lbloptimize.Text = (output);
                lbloptimize.Text = (driveLetter + " Diskinizin optimize işlemi tamamlandı.");
            }
            catch (Exception ex)
            {
                lbloptimize.Text = (driveLetter + " Diskinizde Hata oluştu: " + ex.Message);
            }
        } //diskileri optimize eder

        public string FormatBoyut(long byteSayisi)
        {
            string[] boyutBirimleri = { "B", "KB", "MB", "GB", "TB" };
            int indeks = 0;
            double boyut = byteSayisi;

            while (boyut >= 1024 && indeks < boyutBirimleri.Length - 1)
            {
                boyut /= 1024;
                indeks++;
            }

            return String.Format("{0:0.##} {1}", boyut, boyutBirimleri[indeks]);
        } // girilen long değerin büyüklüğüne göre türünü değiştiriyor

        public long KlasorBoyutunuGetir(string klasorYolu)
        {
            // Klasör içindeki tüm dosyaların yolunu al
            string[] dosyaYollari = Directory.GetFiles(klasorYolu, "*.*", SearchOption.AllDirectories);

            long toplamBoyut = 0;
            foreach (string dosyaYolu in dosyaYollari)
            {
                try
                {
                    FileInfo dosyaBilgisi = new FileInfo(dosyaYolu);
                    toplamBoyut += dosyaBilgisi.Length;
                }
                catch
                {
                }

            }

            return toplamBoyut;
        } // girilen klasörün boyutunu long cinsinden verir

        long Tempsi, ytempsi, prefecthsi, recent; //klasör boyutlarını belirmek içini
        public void Rtoplam(Chart ch, Label lbltoplam)
        {
            //klasörlerin boyutlarını byte cinsinden getirerek long cinsindeki değişkenlerimize attık 
            //chart1 de ise pasta dilimi grafğimizi şekillendirdik
            ch.Series["Series1"].Points.Clear();
            Tempsi = KlasorBoyutunuGetir(@"" + mainDisk + ":\\Windows\\Temp");
            ytempsi = KlasorBoyutunuGetir(Path.GetTempPath());
            prefecthsi = KlasorBoyutunuGetir(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), "Prefetch"));
            recent = KlasorBoyutunuGetir(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Recent)));
            if (Tempsi > 1024)
            {
                ch.Series["Series1"].Points.AddXY("Temp", Tempsi);
            }
            if (ytempsi > 1024)
            {
                ch.Series["Series1"].Points.AddXY("%Temp%", ytempsi);
            }
            if (prefecthsi > 1024)
            {
                ch.Series["Series1"].Points.AddXY("Prefetch", prefecthsi);
            }
            if (recent > 1024)
            {
                ch.Series["Series1"].Points.AddXY("Recent", recent);
            }

            lbltoplam.Text = "Toplam Boyut: " + (FormatBoyut(ytempsi + Tempsi + prefecthsi + recent));
        } //yüzdeliğe yansıtmak için

        public void cookies()
        {
            //internet çerezelerini temizleme
            string[] Cookies = System.IO.Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Cookies));
            int notDeleted = 0;
            foreach (string CookieFile in Cookies)
            {
                try
                {
                    System.IO.File.Delete(CookieFile);

                }
                catch
                {
                    notDeleted++;
                }

            }


            System.Diagnostics.Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess " + 255);
            System.Diagnostics.Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess " + 2);
            System.Diagnostics.Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess " + 8);
            System.Diagnostics.Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess " + 16);
            System.Diagnostics.Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess " + 32);
            System.Diagnostics.Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess " + 193);
            System.Diagnostics.Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess " + 2048);
            System.Diagnostics.Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess " + 8192);
            System.Diagnostics.Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess " + 16384);
            System.Diagnostics.Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess " + 22783);
            System.Diagnostics.Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess " + 1);
            System.Diagnostics.Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess " + 4351);
        } //çerezleri temizlemek için

        public void gecicitemizle(DirectoryInfo path)
        {
            foreach (FileInfo file in path.GetFiles())
            {
                try
                {
                    file.Delete();
                }
                catch
                {
                }

            }

            foreach (DirectoryInfo file in path.GetDirectories())
            {
                try
                {
                    file.Delete(true);
                }
                catch
                {
                }
            }

        } //seçili klasörleri temizler

        public List<string> command = new List<string>();
        public void ProcessCommandLineArgs()
        {
            string[] args = Environment.GetCommandLineArgs();
            if (args.Length > 1)
            {
                Console.WriteLine("Alınan Parametreler:");
                for (int i = 1; i < args.Length; i++)
                {
                    command.Add(args[i]);
                }
            }
            else
            {
                Console.WriteLine("Parametre yok.");
            }
        }

        public void RunDismCommandWithProgress(string command)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            // Process nesnesini oluşturun ve ProcessStartInfo'yu atayın
            Process process = new Process
            {
                StartInfo = psi
            };

            // dism komutunu çalıştır
            process.Start();
            process.StandardInput.WriteLine(command);
            process.StandardInput.WriteLine("exit");

            // Çıktıyı okuyun ve ekrana yazdırın
            string output = process.StandardOutput.ReadToEnd();
            Console.WriteLine("Komut çıktısı:");
            Console.WriteLine(output);
            

            // Hata durumunu okuyun ve ekrana yazdırın
            string error = process.StandardError.ReadToEnd();
            Console.WriteLine("Hata durumu:");
            Console.WriteLine(error);

            // Process'i kapat
            process.WaitForExit();
            process.Close();
        }
    }
}
