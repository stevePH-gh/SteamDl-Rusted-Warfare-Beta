using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace steamDLnew
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            panelBar.MouseDown += FrmMain_MouseDown;
            title.MouseDown += FrmMain_MouseDown;
            ico.MouseDown += FrmMain_MouseDown;
        }

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;
        private const int EM_SETCUEBANNER = 0x1501;

        protected override CreateParams CreateParams        // ADDED FOR SOME SHADOW EFFECT
        {
            get
            {
                const int CS_DROPSHADOW = 0x00020000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }


        private void FrmMain_Load(object sender, EventArgs e)
        {
            SendMessage(textBoxLink.Handle, EM_SETCUEBANNER, 0, " eg: https://steamcommunity.com/sharedfiles/filedetails/?id=0123456789");

            FrmChangelogsTips frmChangelogsTips = new FrmChangelogsTips();
            frmChangelogsTips.Show();

        }

        private void FrmMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelBar_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string link = textBoxLink.Text.Trim();
            string pattern = @"id=(\d+)";
            Match match = Regex.Match(link, pattern);

            if (!match.Success)
            {
                MessageBox.Show("Invalid Steam Link\n\t\t\t\t", "Error");
                return;
            }

            string modId = match.Groups[1].Value;
            string appId = "647960";

            string downloadsFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
            string steamDlRoot = Path.Combine(downloadsFolder, "SteamDL");
            Directory.CreateDirectory(steamDlRoot);

            try
            {
                labelStatus.Text = "Starting Download";
                progressBar1.Value = 0;
                listBoxDetails.Items.Clear();

                string steamCmdPath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                    "steamcmd",
                    "steamcmd.exe"
                );

                string args = $"+login anonymous +workshop_download_item {appId} {modId} validate +quit";

                var psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = steamCmdPath,
                    Arguments = args,
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true
                };

                string output = "";
                string modTitle = $"Mod {modId}";

                using (var process = new System.Diagnostics.Process { StartInfo = psi })
                {
                    process.OutputDataReceived += (s, ev) =>
                    {
                        if (!string.IsNullOrEmpty(ev.Data))
                        {
                            output += ev.Data + Environment.NewLine;

                            if (ev.Data.Contains("Downloading item"))
                            {
                                var matchTitle = Regex.Match(ev.Data, @"\d+\s*:\s*(.+)$");
                                if (matchTitle.Success)
                                {
                                    string possibleTitle = matchTitle.Groups[1].Value.Trim();
                                    if (!string.IsNullOrWhiteSpace(possibleTitle))
                                        modTitle = possibleTitle;
                                }
                            }

                            this.Invoke((Action)(() =>
                            {
                                listBoxDetails.Items.Add(ev.Data);
                                listBoxDetails.TopIndex = listBoxDetails.Items.Count - 1;

                                if (            // SOME FIXING, mali ung CODES
                                    ev.Data.IndexOf("type 'quit' to exit", StringComparison.OrdinalIgnoreCase) < 0 &&
                                    ev.Data.IndexOf("Steam Console Client", StringComparison.OrdinalIgnoreCase) < 0 &&
                                    ev.Data.IndexOf("Redirecting stderr", StringComparison.OrdinalIgnoreCase) < 0 &&
                                    ev.Data.IndexOf("Loading Steam API", StringComparison.OrdinalIgnoreCase) < 0
                                    )
                                {
                                    labelStatus.Text = ev.Data;
                                }

                                if (ev.Data.IndexOf("Connecting anonymously", StringComparison.OrdinalIgnoreCase) >= 0)
                                {
                                    progressBar1.Style = ProgressBarStyle.Continuous;
                                    progressBar1.Value = 10;
                                }
                                else if (ev.Data.IndexOf("Waiting for client config", StringComparison.OrdinalIgnoreCase) >= 0)
                                {
                                    progressBar1.Value = 25;
                                }
                                else if (ev.Data.IndexOf("Waiting for user info", StringComparison.OrdinalIgnoreCase) >= 0)
                                {
                                    progressBar1.Value = 40;
                                }
                                else if (ev.Data.IndexOf("Downloading item", StringComparison.OrdinalIgnoreCase) >= 0)
                                {
                                    progressBar1.Style = ProgressBarStyle.Marquee;
                                }
                                else if (ev.Data.IndexOf("Success. Downloaded", StringComparison.OrdinalIgnoreCase) >= 0)
                                {
                                    progressBar1.Style = ProgressBarStyle.Continuous;
                                    progressBar1.Value = 100;
                                }

                            }));
                        }
                    };

                                            // SOME FIXINGS AGAIN HEHEHEHE
                    await Task.Run(() =>
                    {
                        process.Start();
                        process.BeginOutputReadLine();
                        process.WaitForExit();
                    });
                }

                string modFolder = Path.Combine(
                    Path.GetDirectoryName(steamCmdPath),
                    "steamapps", "workshop", "content", appId, modId
                );

                if (Directory.Exists(modFolder))
                {
                    string modSaveFolder = Path.Combine(steamDlRoot, modId);
                    Directory.CreateDirectory(modSaveFolder);

                    string zipPath = Path.Combine(modSaveFolder, $"{modId}.zip");

                    if (File.Exists(zipPath))
                        File.Delete(zipPath);

                    ZipFile.CreateFromDirectory(modFolder, zipPath, CompressionLevel.Optimal, false);

                    try { Directory.Delete(modFolder, true); } catch { }

                    progressBar1.Style = ProgressBarStyle.Blocks;
                    progressBar1.Value = 100;
                    labelStatus.Text = "Download complete";

                    MessageBox.Show($"Saved as:\n{zipPath}\n\t\t\t\t", "Downloaded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Ooops... Error\nMod folder not found after download.\t\t\t\t", "Download Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ooops... Error\n{ex.Message}\t\t\t\t", "Download Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
