using System.Windows.Forms;

namespace ConfigureStartPowerShellScript_01
{
    public partial class Form1 : Form
    {
        private void launchWin7()
        {
            string computerIPRDPAccessNetwork = "";
            string staticMacAddress = "";
            string vhdxDiskSource = "Win7source.vhdx";
            string vhdxDisk = "NewWin7VM.vhdx";

            if (duplicatedSelcted)
            {
                computerIPRDPAccessNetwork = "192.168.222.17";
                rdp2 = computerIPRDPAccessNetwork;
                staticMacAddress = "AA-AA-AA-AA-AA-17";
                configureWinVM(computerIPRDPAccessNetwork, staticMacAddress, vhdxDisk, vhdxDiskSource);
            }
            else
            {
                computerIPRDPAccessNetwork = "192.168.222.7";
                checkForRDPStatus(computerIPRDPAccessNetwork);
                staticMacAddress = "AA-AA-AA-AA-AA-07";
                configureWinVM(computerIPRDPAccessNetwork, staticMacAddress, vhdxDisk, vhdxDiskSource);
            }

            return;
        }

        private void launchWin81()
        {
            string computerIPRDPAccessNetwork = "";
            string staticMacAddress = "";
            string vhdxDiskSource = "Win8source.vhdx";
            string vhdxDisk = "NewWin8VM.vhdx";

            if (duplicatedSelcted)
            {
                computerIPRDPAccessNetwork = "192.168.222.18";
                rdp2 = computerIPRDPAccessNetwork;
                staticMacAddress = "AA-AA-AA-AA-AA-18";
                configureWinVM(computerIPRDPAccessNetwork, staticMacAddress, vhdxDisk, vhdxDiskSource);
            }
            else
            {
                computerIPRDPAccessNetwork = "192.168.222.8";
                checkForRDPStatus(computerIPRDPAccessNetwork);
                staticMacAddress = "AA-AA-AA-AA-AA-08";
                configureWinVM(computerIPRDPAccessNetwork, staticMacAddress, vhdxDisk, vhdxDiskSource);
            }

            return;
        }

        private void launchWin10()
        {
            string computerIPRDPAccessNetwork = "";
            string staticMacAddress = "";
            string vhdxDiskSource = "Win10source.vhdx";
            string vhdxDisk = "NewWin10VM.vhdx";

            if (duplicatedSelcted)
            {
                computerIPRDPAccessNetwork = "192.168.222.20";
                rdp2 = computerIPRDPAccessNetwork;
                staticMacAddress = "AA-AA-AA-AA-AA-20";
                configureWinVM(computerIPRDPAccessNetwork, staticMacAddress, vhdxDisk, vhdxDiskSource);
            }
            else
            {
                computerIPRDPAccessNetwork = "192.168.222.10";
                checkForRDPStatus(computerIPRDPAccessNetwork);
                staticMacAddress = "AA-AA-AA-AA-AA-10";
                configureWinVM(computerIPRDPAccessNetwork, staticMacAddress, vhdxDisk, vhdxDiskSource);
            }

            return;
        }
    }
}
