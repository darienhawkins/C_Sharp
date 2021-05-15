using System.Windows.Forms;
using System.Diagnostics;

namespace ConfigureStartPowerShellScript_01
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Centrel method to start all external processes regardless of windowed mode
        /// Default mode is "Normal"
        /// </summary>
        /// <param name="processName"></param>
        /// <param name="processArguments"></param>
        /// <param name="processWindowState_Hidden_Min_Norm_Max"></param>
        private void runProcessMinNormMax(string processName, string processArguments, string processWindowState_Hidden_Min_Norm_Max)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(processName);
            startInfo.Arguments = processArguments;
            
            switch (processWindowState_Hidden_Min_Norm_Max)
            {
                case "min":
                case "Min":
                case "minimized":
                case "Minimized":
                    startInfo.WindowStyle = ProcessWindowStyle.Minimized;
                    break;
                case "max":
                case "Max":
                case "maximized":
                case "Maximized":
                    startInfo.WindowStyle = ProcessWindowStyle.Maximized;
                    break;
                case "hid":
                case "Hid":
                case "hide":
                case "Hide":
                case "hidden":
                case "Hidden":
                    startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    break;
                default:
                    startInfo.WindowStyle = ProcessWindowStyle.Normal;
                    break;
            }
            
            Process.Start(startInfo);
        }
    }
}