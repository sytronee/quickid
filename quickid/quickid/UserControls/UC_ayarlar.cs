using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace quickid
{
    public partial class UC_ayarlar : UserControl
    {
        public UC_ayarlar()
        {
            InitializeComponent();
        }
        Metots mt=new Metots();
        private void msktextserial_TextChanged(object sender, EventArgs e)
        {
            if (msktextserial.Text.Length == msktextserial.TextLength)
            {
                MessageBox.Show("Test");
            }
        }

        private void toggleSagtik_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleSagtik.Checked)
            {
                if (Registry.CurrentUser.OpenSubKey("quickid").OpenSubKey("contextmenu").GetValue("contextmenu").ToString() == "disabled")
                {
                    mt.runregfilesbutwithcmd(Application.StartupPath + "\\icons\\context\\regedit\\A.reg");
                    Registry.LocalMachine.CreateSubKey("SOFTWARE\\Classes\\DesktopBackground\\Shell\\quickmode").SetValue("Icon", Application.StartupPath + "\\icons\\context\\quick.ico");
                    Registry.LocalMachine.CreateSubKey("SOFTWARE\\Classes\\DesktopBackground\\Shell\\quickmode\\Shell\\01").SetValue("Icon", Application.StartupPath + "\\icons\\context\\Power.ico");
                    Registry.LocalMachine.CreateSubKey("SOFTWARE\\Classes\\DesktopBackground\\Shell\\quickmode\\Shell\\04").SetValue("Icon", Application.StartupPath + "\\icons\\context\\ram.ico");
                    Registry.LocalMachine.CreateSubKey("SOFTWARE\\Classes\\DesktopBackground\\Shell\\quickmode\\Shell\\04\\command").SetValue("", Application.StartupPath + "\\quickid.exe Admin Ram");
                    Registry.LocalMachine.CreateSubKey("SOFTWARE\\Classes\\DesktopBackground\\Shell\\quickmode\\Shell\\05").SetValue("Icon", Application.StartupPath + "\\icons\\context\\Setting3.ico");
                    Registry.LocalMachine.CreateSubKey("SOFTWARE\\Classes\\DesktopBackground\\Shell\\quickmode\\Shell\\07").SetValue("Icon", Application.StartupPath + "\\icons\\context\\ping.ico");
                    Registry.LocalMachine.CreateSubKey("SOFTWARE\\Classes\\DesktopBackground\\Shell\\quickmode\\Shell\\08").SetValue("Icon", Application.StartupPath + "\\icons\\context\\clean.ico");
                    Registry.LocalMachine.CreateSubKey("SOFTWARE\\Classes\\DesktopBackground\\Shell\\quickmode\\Shell\\08\\command").SetValue("", Application.StartupPath + "\\quickid.exe Admin Temp");
                    Registry.LocalMachine.CreateSubKey("SOFTWARE\\Classes\\DesktopBackground\\Shell\\quickmode\\Shell\\09").SetValue("MUIVerb", "Optimize Drive");
                    Registry.LocalMachine.CreateSubKey("SOFTWARE\\Classes\\DesktopBackground\\Shell\\quickmode\\Shell\\09").SetValue("Icon", Application.StartupPath + "\\icons\\context\\drive.ico");
                    Registry.LocalMachine.CreateSubKey("SOFTWARE\\Classes\\DesktopBackground\\Shell\\quickmode\\Shell\\09\\command").SetValue("", Application.StartupPath + "\\quickid.exe Admin Optimize");
                    Registry.LocalMachine.CreateSubKey("SOFTWARE\\Classes\\DesktopBackground\\Shell\\quickmode\\Shell\\01\\Shell\\01menu").SetValue("Icon", Application.StartupPath + "\\icons\\context\\quick.ico");
                    Registry.LocalMachine.CreateSubKey("SOFTWARE\\Classes\\DesktopBackground\\Shell\\quickmode\\Shell\\01\\Shell\\02menu").SetValue("Icon", Application.StartupPath + "\\icons\\context\\quick.ico");
                    Registry.LocalMachine.CreateSubKey("SOFTWARE\\Classes\\DesktopBackground\\Shell\\quickmode\\Shell\\01\\Shell\\03menu").SetValue("Icon", Application.StartupPath + "\\icons\\context\\quick.ico");
                    Registry.LocalMachine.CreateSubKey("SOFTWARE\\Classes\\DesktopBackground\\Shell\\quickmode\\Shell\\01\\Shell\\04menu").SetValue("Icon", Application.StartupPath + "\\icons\\context\\Controller.ico");
                    Registry.LocalMachine.CreateSubKey("SOFTWARE\\Classes\\DesktopBackground\\Shell\\quickmode\\Shell\\01\\Shell\\06menu").SetValue("Icon", Application.StartupPath + "\\icons\\context\\Cpu.ico");
                    Registry.CurrentUser.CreateSubKey("quickid").CreateSubKey("contextmenu").SetValue("contextmenu", "enabled");
                }
            }
            else
            {
                Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\Classes\\DesktopBackground\\Shell\\quickmode");
                Registry.CurrentUser.CreateSubKey("quickid").CreateSubKey("contextmenu").SetValue("contextmenu", "disabled");

            }
        }

        private void UC_ayarlar_Load(object sender, EventArgs e)
        {
            if (Registry.CurrentUser.OpenSubKey("quickid").OpenSubKey("contextmenu").GetValue("contextmenu").ToString() == "disabled")
            {
                toggleSagtik.Checked = false;
                lblsagtikmenu.Text = "Pasif";
            }
            else
            {
                toggleSagtik.Checked = true;
                lblsagtikmenu.Text = "Aktif";
            }
        }
    }
}
