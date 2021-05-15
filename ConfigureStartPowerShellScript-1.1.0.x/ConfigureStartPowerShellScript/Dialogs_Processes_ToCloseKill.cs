using System.Windows.Forms;
using System.Diagnostics;

namespace ConfigureStartPowerShellScript_01
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Kills all instances, if running, of the ones listed in the array
        /// </summary>
        private void DialogsToClose()
        {
            // vmconnect must come before mmc.  Otherwise an execption will occur
            string[] dialogsToClose = { "vmconnect", "powershell", "mmc", "rundll32", "servermanager", "cmd", "cscript", "wscript" };
            foreach (string dtc in dialogsToClose)
            {
                checkForProcessAndKill(dtc);
            }
        }

        private void DialogsToClose(string[] passedArgs)
        {
            foreach (string dtc in passedArgs)
            {
                checkForProcessAndKill(dtc);
            }
        }

        /// <summary>
        /// Kills any processes that are passed as the argument 
        /// </summary>
        /// <param name="runningProcessName"></param>
        private static void killRunningProcesses(string runningProcessName)
        {
            foreach (Process proc in Process.GetProcessesByName(runningProcessName))
            {
                proc.Kill();
            }
        }
        
        /// <summary>
        /// Check for the existance of a running process and kills it.
        /// Method added 20150513
        /// </summary>
        /// <param name="processToKill"></param>
        private void checkForProcessAndKill(string processToKill)
        {
            // Kill the VM Connect screen if running
            Process[] localByName = Process.GetProcessesByName(processToKill);
            if (localByName.Length > 0)
            {
                // medthod located DialogsToClose.cs
                killRunningProcesses(processToKill);
            }

            //return;
        }
        
    }
}
