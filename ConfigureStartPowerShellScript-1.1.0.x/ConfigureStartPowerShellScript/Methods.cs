using System;
using System.Windows.Forms;

namespace ConfigureStartPowerShellScript_01
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Dynamic assignment of the start button to start of stop VMs
        /// </summary>
        private void button_StartOrKillVMAction()
        {
            clear_StartOrKillButtonActions();

            if (isVMrunning)
            {
                button_StartOrKillVMs.Text = "Kill All Running VMs!";
                button_StartOrKillVMs.Click += new EventHandler(KillAllRunngVMs_Click);
                return;
            } else if (!isVMrunning)
            {
                button_StartOrKillVMs.Enabled = true;
                button_StartOrKillVMs.Text = "Click to start selected VMs.";
                button_StartOrKillVMs.Click += new EventHandler(StartSelectedVMs_Click);
                return;
            }
        }
        
        /// <summary>
        /// Reset button to "default" state
        /// </summary>
        private void button_StartOrKillVMReset()
        {
            clear_StartOrKillButtonActions();

            button_StartOrKillVMs.Enabled = false;
            button_StartOrKillVMs.Text = "Please select options and VMs.";
        }

        /// <summary>
        /// Clear all assigned button actions
        /// </summary>
        private void clear_StartOrKillButtonActions()
        {
            button_StartOrKillVMs.Click -= new EventHandler(StartSelectedVMs_Click);
            button_StartOrKillVMs.Click -= new EventHandler(KillAllRunngVMs_Click);
        }

        private void startMedusaC()
        {
            psCreate[3] = "Set-Variable -Name ExternalNetwork -Value \"Privnet\"";
            startStopRenameMedusa = "start-vm -name " + medusaC;
            
        }

        private void stopMedusaC()
        {
            psCreate[3] = "Set-Variable -Name ExternalNetwork -Value \"ExternalAccess\"";
            startStopRenameMedusa = "stop-vm " + medusaC + " -Force -TurnOff";
        }

    }
}
