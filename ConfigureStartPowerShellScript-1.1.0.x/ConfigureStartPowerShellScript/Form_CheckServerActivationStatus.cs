using System;
using System.Windows.Forms;

namespace ConfigureStartPowerShellScript_01
{
    public partial class Form_CheckServerActivationStatus : Form
    {
        public Form_CheckServerActivationStatus()
        {
            InitializeComponent();
        }

        private void Form_CheckServerActivationStatus_Load(object sender, EventArgs e)
        {
            this.TopMost = false;
            System.Diagnostics.Process.Start("powershell", "C:\\Windows\\System32\\slmgr.vbs /dlv");
        }

        private void button_RearmWindows_Click(object sender, EventArgs e)
        {
            string runScript = "C:\\Virtual_Machines\\Hyper-V\\Shortcuts\\RestartComputer.PS1";
            System.Diagnostics.Process.Start("powershell", "C:\\Windows\\System32\\slmgr.vbs /rearm");
            System.Threading.Thread.Sleep(5000);
            System.Diagnostics.Process.Start("powershell", runScript);
        }
    }
}
