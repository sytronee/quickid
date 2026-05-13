using System.IO;
using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Security.AccessControl;

namespace quickid
{
    public partial class UC_homepage : UserControl
    {
        // Windows API çağrıları için gerekli olan kernel32.dll'yi içe aktarıyoruz.
        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetFileAttributes(string lpFileName, FileAttributes dwFileAttributes);
        public UC_homepage()
        {

            InitializeComponent();

        }

        StreamWriter sr;


        private void UC_homepage_Load(object sender, System.EventArgs e)
        {

        }
    }
}
