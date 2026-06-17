using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace wiswitch
{
    public partial class MainForm : Form
    {
        private List<string> wifiSlots = new List<string>();
        private int currentIndex = 0;
        private const int HOTKEY_ID = 9000;
        private const uint MOD_CONTROL = 0x0002;
        private const uint VK_OEM_2 = 0xBF;

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        public MainForm()
        {
            InitializeComponent();
            this.Icon = new System.Drawing.Icon("assets/Icon.ico");
        }

        private List<string> GetWifiProfiles()
        {
            List<string> profiles = new List<string>();

            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/c chcp 65001 > nul & netsh wlan show profiles";
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.StandardOutputEncoding = Encoding.UTF8;

            process.Start();

            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            var lines = output.Split('\n');

            foreach (var line in lines)
            {
                if (line.Contains("All User Profile"))
                {
                    var parts = line.Split(':');
                    if (parts.Length > 1)
                    {
                        string wifiName = parts[1].Trim();
                        profiles.Add(wifiName);
                    }
                }
            }

            return profiles;
        }

        private void BtnLoadWifi_Click(object sender, EventArgs e)
        {
            listBoxAvailableWifi.Items.Clear();

            var profiles = GetWifiProfiles();

            foreach (var wifi in profiles)
            {
                listBoxAvailableWifi.Items.Add(wifi);
            }
        }

        private void ListBoxAvailableWifi_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxAvailableWifi.SelectedItem != null)
            {
                string wifiName = listBoxAvailableWifi.SelectedItem.ToString();
                txtWifiName.Text = wifiName;
                wifiSlots.Add(wifiName);
                listBoxWifi.Items.Add(wifiName);

                labelStatus.Text = $"Added: {wifiName}";

                tabControlMain.SelectedIndex = 0;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            labelStatus.Font = new System.Drawing.Font("Segoe UI Emoji", 9F);

            this.StartPosition = FormStartPosition.Manual;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            var screen = Screen.PrimaryScreen.WorkingArea;
            this.Location = new System.Drawing.Point(
                screen.Width - this.Width - 10,
                10
            );

            this.TopMost = true;

            RegisterHotKey(this.Handle, HOTKEY_ID, MOD_CONTROL, VK_OEM_2);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == HOTKEY_ID)
            {
                SwitchWifi();
            }
            base.WndProc(ref m);
        }

        private void SwitchWifi()
        {
            if (wifiSlots.Count == 0)
            {
                MessageBox.Show("No WiFi networks in the list!");
                return;
            }

            string wifiName = wifiSlots[currentIndex];

            if (string.IsNullOrWhiteSpace(wifiName) || wifiName.Contains("\"") || wifiName.Contains("&") || wifiName.Contains("|"))
            {
                MessageBox.Show("Invalid WiFi name!");
                return;
            }

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "netsh",
                    Arguments = $"wlan connect name=\"{wifiName}\"",
                    CreateNoWindow = true,
                    UseShellExecute = false
                });

                labelStatus.Text = $"Switched to: {wifiName}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            currentIndex = (currentIndex + 1) % wifiSlots.Count;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtWifiName.Text))
            {
                wifiSlots.Add(txtWifiName.Text);
                listBoxWifi.Items.Add(txtWifiName.Text);
                txtWifiName.Clear();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listBoxWifi.SelectedIndex >= 0)
            {
                int index = listBoxWifi.SelectedIndex;
                wifiSlots.RemoveAt(index);
                listBoxWifi.Items.RemoveAt(index);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnregisterHotKey(this.Handle, HOTKEY_ID);
        }
    }
}