using System;
/*
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
*/
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;


namespace ConfigureStartPowerShellScript_01
{
    public partial class Form_DisplayProperties : Form
    {
        public Form_DisplayProperties()
        {
            InitializeComponent();
        }

        const string intelDisplayProperties = "C:\\Windows\\System32\\igfxCPL.cpl";
        const string nvidiaControlPanel = "C:\\Program Files\\NVIDIA Corporation\\Control Panel Client\\nvcplui.exe";
        const string atiCatalystControlCenter = "C:\\Program Files (x86)\\AMD\\ATI.ACE\\Core-Static\\CCC.exe";

        private void Form_DisplayProperties_Load(object sender, EventArgs e)
        {
            // Check to see if Intel HD Graphics Control Panel is installed
            if (File.Exists(intelDisplayProperties))
            {
                button_IntelHDGraphicsControlPanel.Enabled = true;
            }
            else
            {
                button_IntelHDGraphicsControlPanel.Enabled = false;
            }

            // Check to see if NVIDIA Control Panel is installed
            if (File.Exists(nvidiaControlPanel))
            {
                button_NVIDIAControlPanel.Enabled = true;
            }
            else
            {
                button_NVIDIAControlPanel.Enabled = false;
            }

            // Check to see if ATI Catalyst Control Center is installed
            if (File.Exists(atiCatalystControlCenter))
            {
                button_ATIControlPanel.Enabled = true;
            }
            else
            {
                button_ATIControlPanel.Enabled = false;
            }
            
        }

        private void button_IntelHDGraphicsControlPanel_Click(object sender, EventArgs e)
        {
            Process.Start(intelDisplayProperties);
            this.Close();
        }

        private void button_NVIDIAControlPanel_Click(object sender, EventArgs e)
        {
            Process.Start(nvidiaControlPanel);
            this.Close();
        }

        private void button_ATIControlPanel_Click(object sender, EventArgs e)
        {
            Process.Start(atiCatalystControlCenter);
            this.Close();
        }

        private void button_CloseDisplayProperties_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
