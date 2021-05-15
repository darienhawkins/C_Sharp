using System;
using System.Windows.Forms;

namespace ConfigureStartPowerShellScript_01
{
    public partial class Form1 : Form
    {
        
        private void button_ReopenEstablishedRDPSession_2_Click(object sender, EventArgs e)
        {
            multiMonitorSelection(checkBox_MultiMonVM2.Checked, rdp2);
        }

        /// <summary>
        /// Checks for rpd1 status and sets according to logic
        /// </summary>
        /// <param name="passedComputerIPRDPAccessNetworkArgument"></param>
        private void checkForRDPStatus(string passedComputerIPRDPAccessNetworkArgument)
        {
            if (rdp1 == null)
            {
                rdp1 = passedComputerIPRDPAccessNetworkArgument;
            }
            else
            {
                rdp2 = passedComputerIPRDPAccessNetworkArgument;
            }
            
        }

        /// <summary>
        /// Method for multimonitor checkbox
        /// </summary>
        /// <param name="multicheck"></param>
        /// <param name="rdpx"></param>
        private void multiMonitorSelection(bool multicheck, string rdpx)
        {
            string multiMonChecked = "";
            if (multicheck)
            {
                multiMonChecked = "/f /multimon /v:";
            }
            else
            {
                multiMonChecked = "/f /v:";
            }
            
            runProcessMinNormMax("mstsc", multiMonChecked + rdpx, "norm");
            
        }

        private void button_ReopenEstablishedRDPSession_Click(object sender, EventArgs e)
        {
            // medthod located DialogsToClose.cs
            killRunningProcesses("mstsc");
            multiMonitorSelection(checkBox_MultiMonVM1.Checked, rdp1);
        }

    }
}
