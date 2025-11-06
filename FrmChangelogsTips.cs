using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace steamDLnew
{
    public partial class FrmChangelogsTips : Form
    {
        public FrmChangelogsTips()
        {
            InitializeComponent();
            panelBar.MouseDown += FrmChangelogsTips_MouseDown;
            title.MouseDown += FrmChangelogsTips_MouseDown;

        }

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmChangelogsTips_Load(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count > 0)
            {
                var main = Application.OpenForms[0];
                this.Location = new System.Drawing.Point(main.Right + 10, main.Top);
            }
            richTextBox1.ReadOnly = true;

        }

        private void FrmChangelogsTips_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);

            }
        }

        private void btnDownloadcmd_Click(object sender, EventArgs e)
        {
            string url = "https://steamcdn-a.akamaihd.net/client/installer/steamcmd.zip";
            try
            {
                // Use this workaround for Windows 7 compatibility
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch
            {
                try
                {
                    // Fallback for very old systems
                    System.Diagnostics.Process.Start("explorer.exe", url);
                }
                catch
                {
                    MessageBox.Show("Unable to open your browser.\nPlease visit:\n" + url,
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
