namespace wiswitch
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageSwitch;
        private System.Windows.Forms.TabPage tabPageCekWifi;

        private System.Windows.Forms.TextBox txtWifiName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox listBoxWifi;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelHotkey;

        private System.Windows.Forms.Button btnLoadWifi;
        private System.Windows.Forms.Label labelDoubleClickInfo;
        private System.Windows.Forms.ListBox listBoxAvailableWifi;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageSwitch = new System.Windows.Forms.TabPage();
            this.tabPageCekWifi = new System.Windows.Forms.TabPage();

            this.txtWifiName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.listBoxWifi = new System.Windows.Forms.ListBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelHotkey = new System.Windows.Forms.Label();

            this.btnLoadWifi = new System.Windows.Forms.Button();
            this.labelDoubleClickInfo = new System.Windows.Forms.Label();
            this.listBoxAvailableWifi = new System.Windows.Forms.ListBox();

            this.tabControlMain.SuspendLayout();
            this.tabPageSwitch.SuspendLayout();
            this.tabPageCekWifi.SuspendLayout();
            this.SuspendLayout();

            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageSwitch);
            this.tabControlMain.Controls.Add(this.tabPageCekWifi);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(400, 270);

            // 
            // tabPageSwitch
            // 
            this.tabPageSwitch.Controls.Add(this.txtWifiName);
            this.tabPageSwitch.Controls.Add(this.btnAdd);
            this.tabPageSwitch.Controls.Add(this.btnRemove);
            this.tabPageSwitch.Controls.Add(this.listBoxWifi);
            this.tabPageSwitch.Controls.Add(this.labelStatus);
            this.tabPageSwitch.Controls.Add(this.labelHotkey);
            this.tabPageSwitch.Location = new System.Drawing.Point(4, 24);
            this.tabPageSwitch.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSwitch.Size = new System.Drawing.Size(392, 242);
            this.tabPageSwitch.Text = "WiSwitch";
            this.tabPageSwitch.UseVisualStyleBackColor = true;

            // 
            // txtWifiName
            // 
            this.txtWifiName.Location = new System.Drawing.Point(12, 12);
            this.txtWifiName.Size = new System.Drawing.Size(200, 23);

            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(220, 12);
            this.btnAdd.Size = new System.Drawing.Size(75, 25);
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(300, 12);
            this.btnRemove.Size = new System.Drawing.Size(75, 25);
            this.btnRemove.Text = "Remove";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);

            // 
            // listBoxWifi
            // 
            this.listBoxWifi.Location = new System.Drawing.Point(12, 45);
            this.listBoxWifi.Size = new System.Drawing.Size(363, 150);

            // 
            // labelStatus
            // 
            this.labelStatus.Location = new System.Drawing.Point(12, 205);
            this.labelStatus.Size = new System.Drawing.Size(235, 23); // FIX: Lebar ditambah
            this.labelStatus.AutoEllipsis = true; // FIX: Mencegah text turun ke baris bawah yang tidak terlihat
            this.labelStatus.Text = "Status: Idle";

            // 
            // labelHotkey
            // 
            this.labelHotkey.Location = new System.Drawing.Point(250, 205); // FIX: Posisi digeser sedikit menyesuaikan pelebaran labelStatus
            this.labelHotkey.Size = new System.Drawing.Size(125, 23);
            this.labelHotkey.Text = "Hint: Use CTRL + /";
            this.labelHotkey.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelHotkey.ForeColor = System.Drawing.SystemColors.ControlDarkDark;

            // 
            // tabPageCekWifi
            // 
            this.tabPageCekWifi.Controls.Add(this.btnLoadWifi);
            this.tabPageCekWifi.Controls.Add(this.labelDoubleClickInfo);
            this.tabPageCekWifi.Controls.Add(this.listBoxAvailableWifi);
            this.tabPageCekWifi.Location = new System.Drawing.Point(4, 24);
            this.tabPageCekWifi.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCekWifi.Size = new System.Drawing.Size(392, 242);
            this.tabPageCekWifi.Text = "Check WiFi";
            this.tabPageCekWifi.UseVisualStyleBackColor = true;

            // 
            // btnLoadWifi
            // 
            this.btnLoadWifi.Location = new System.Drawing.Point(12, 12);
            this.btnLoadWifi.Size = new System.Drawing.Size(363, 30);
            this.btnLoadWifi.Text = "Check / Reload Available WiFi";
            this.btnLoadWifi.Click += new System.EventHandler(this.BtnLoadWifi_Click);

            // 
            // labelDoubleClickInfo
            // 
            this.labelDoubleClickInfo.Location = new System.Drawing.Point(12, 48);
            this.labelDoubleClickInfo.Size = new System.Drawing.Size(363, 20);
            this.labelDoubleClickInfo.Text = "Double click on a network to add it to your switch list.";
            this.labelDoubleClickInfo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;

            // 
            // listBoxAvailableWifi
            // 
            this.listBoxAvailableWifi.Location = new System.Drawing.Point(12, 68);
            this.listBoxAvailableWifi.Size = new System.Drawing.Size(363, 160);
            this.listBoxAvailableWifi.DoubleClick += new System.EventHandler(this.ListBoxAvailableWifi_DoubleClick);

            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 270);
            this.Controls.Add(this.tabControlMain);
            this.Text = "WiSwitch";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);

            this.tabControlMain.ResumeLayout(false);
            this.tabPageSwitch.ResumeLayout(false);
            this.tabPageSwitch.PerformLayout();
            this.tabPageCekWifi.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}