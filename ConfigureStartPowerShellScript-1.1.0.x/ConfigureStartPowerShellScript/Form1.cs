/* 
*******************************************************************************
*                                                                             *
*                                                                             *
*                          Programmed by: Darien Hawkins                      *
*                           email: dhawkins@novetta.com                       *
*                                                                             *
*                          Microsoft Visual Studio 2015                       *
*                                                                             *
*                                                                             *
*******************************************************************************
*/

using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;



namespace ConfigureStartPowerShellScript_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Visible = false;
            label1.Text = "";
            label_ApplicationVersionNumber.Text = "Application version: " + Application.ProductVersion + "; Version date: 26 May 2016";
            label_VMStartNotification.Text = "";
            labelSecondVMSelection.Visible = false;
            comboBox_FirstVMSelection.Visible = false;
            comboBox_FirstVMSelection.Enabled = false;
            comboBox_SecondVMSelection.Visible = false;
            textBox2.Text = "";
            listBox1.SetSelected(0, true);
        }

        // Class scope variables
        
        const string windowsDir = "c:\\windows\\";
        const string system32Dir = "system32\\";
        const string workingDir = "C:\\Virtual_Machines\\Hyper-V\\";
        const string sourceDir = "source\\";
        const string machineDir = "Machines\\";
        const string shortcutDir = "Shortcuts\\";
        const string persistentDiskDir = "Persistent_Disk\\";
        const string persistentDiskSourceName = "PersistentDiskSource.vhdx";
        const string persistentDiskName = "PersistentDisk.vhdx";
        const string medusaPath = "MedusaC\\";
        const string errorActionSilentlyContinue = " -ErrorAction SilentlyContinue";
        const string PS = "powershell";
        
        string[] psCreate = new string[20];
        string[] runPSFile = new string[3];
        string selectedMachine = "";
        string allPSCreate = "";
        string powershellPS1Script = "";
        string vmMemory = "";
        string vmProcessor = "";
        string description = "";
        string startStopRenameMedusa = "";
        string medusaC = "MedusaC";
        string rdp1 = null;
        string rdp2 = null;
        string labelVMStartNotificationText = "";
        
        int selectedDropDown = 0;
        int numberOfVM = 0;
        int processor = 1;
        int vmMem = 1;

        bool duplicatedSelcted;
        bool isVMrunning = false;
        bool isChecked = false;
        bool isChecked2 = false;
        double totalSystemMemoryGB;
        double vmPercentage = .5;
        
        // Gets available physical memory reported in bytes.  Must have a reference to Microsoft.VisualBasic in References
        ulong totalSystemMemory;
        

        private void Form1_Load(object sender, EventArgs e)
        {
            // Stops and deletes any Windows VM during startup; ensures Medusa is running
            stopRemoveDeleteAllVM();
            
            // Sets processors to 4 and VM memory to 75% of physical memory at application start
            processor = 4;
            vmPercentage = .75;

            // Must come before the calculateVMMemory() method
            calculateAvailableMemoryAndDiskSpace();

            //Ensures that the information in Listbox1 is accurate
            listBox1_SelectedIndexChanged(null,null);
            
            // Make standalone based (internal) attribution the default if the file does not exist
            // located in SelectAttribution.cs
            checkIfServerBased();

            // Check to see if Windows Explorer is present (server w/minimal GUI)
            if (File.Exists(windowsDir + "explorer.exe"))
            {
                button_OpenWindowsExplorer.Enabled = true;
            }
            else
            {
                button_OpenWindowsExplorer.Enabled = false;
            }

            // Check to see if sconfig.cmd is present (only on server platforms)
            if (File.Exists(windowsDir + system32Dir + "sconfig.cmd"))
            {
                button_OpenSconfig.Enabled = true;
            }
            else
            {
                button_OpenSconfig.Enabled = false;
            }
            
            // check for persistent drive when application opens
            checkForP_DriveWhenFormOpens();

            // Kill command prompt at start
            //killRunningProcesses("cmd");  //Old way
            string[] closeThese = { "cmd" };
            DialogsToClose(closeThese);
        }


        private void calculateVMMemory()
        {
            totalSystemMemoryGB = ((double)totalSystemMemory / 1024000000) * vmPercentage;
            vmMem = (int)totalSystemMemoryGB;
            vmMemory = (vmMem * 1024).ToString();
            vmProcessor = processor.ToString();
        }


        /// <summary>
        /// Actual launch of VMs using generated .PS1 scripts
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartSelectedVMs_Click(object sender, EventArgs e)
        {
            // Close dialogs prior to starting VMs
            // medthod located DialogsToClose.cs
            string[] closeThese = { "vmconnect", "powershell", "mmc", "rundll32", "cmd", "cscript", "wscript", "mstsc" };
            DialogsToClose(closeThese);

            // Update notification label first
            labelVMStartNotificationText = "Please be patient and allow for the virtual machines to self-configure and start.  When ready, an RDP box will appear allowing interactive login.  If an error appears or the VMs fail to launch properly, click the “Kill All Running VMs” button and start again.";
            label_VMStartNotification.Text = labelVMStartNotificationText;

            //disable all controls
            comboBox_FirstVMSelection.Enabled = false;
            comboBox_SecondVMSelection.Enabled = false;
            listBox1.Enabled = false;
            button_ResetSelection.Enabled = false;
            groupBox_Attribution.Enabled = false;
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            isVMrunning = true;
            button_RestartLocalMedusa.Enabled = false;
            
            // Start the selected VMs 
            if (numberOfVM == 1)
            {
                runProcessMinNormMax(PS, runPSFile[1], "norm");

                button_ReopenEstablishedRDPSession_1.Visible = true;
                button_ReopenEstablishedRDPSession_1.Enabled = true;
                checkBox_MultiMonVM1.Visible = true;
            }
            else if (numberOfVM == 2)
            {
                runProcessMinNormMax(PS, runPSFile[1], "norm");

                // Wait 5 seconds before starting the second VM.
                System.Threading.Thread.Sleep(5000);
                runProcessMinNormMax(PS, runPSFile[2], "norm");

                button_ReopenEstablishedRDPSession_1.Visible = true;
                button_ReopenEstablishedRDPSession_1.Enabled = true;
                button_ReopenEstablishedRDPSession_2.Visible = true;
                button_ReopenEstablishedRDPSession_2.Enabled = true;
                checkBox_MultiMonVM1.Visible = true;
                checkBox_MultiMonVM2.Visible = true;
            }

            // Change info box text to display to user that he or she can reestablish RDP connections
            labelVMStartNotificationText = "Use the \"Reopen Established RDP Session\" button(s) to reconnect to your closed, saved session.";
            label_VMStartNotification.Text = labelVMStartNotificationText;

            // Wait 5 seconds to keep form on top of PS shells.
            System.Threading.Thread.Sleep(5000);

            calculateAvailableMemoryAndDiskSpace();
            button_StartOrKillVMAction();
            checkForSelectedTab();
        }


        /// <summary>
        /// Writes the .PS1 scripts to the C:\Virtual_Machines\Hyper-V\Machines folder
        /// </summary>
        /// <param name="powershellPS1Script"></param>
        /// <param name="allPSCreate"></param>
        /// <returns></returns>
        private string WritePowershellScript(string powershellPS1Script, string allPSCreate)
        {
            // Write the text array to a variable and to a file and display on form
            if (selectedDropDown == 1)
            {
                allPSCreate = "";
                textBox2.Text = "";
                for (int i = 0; i < 17; i++)
                {
                    allPSCreate += psCreate[i] + Environment.NewLine;
                }
                textBox2.Text = allPSCreate;
                File.WriteAllText(powershellPS1Script, allPSCreate);
                runPSFile[1] = powershellPS1Script;
            }
            else if (selectedDropDown == 2)
            {
                allPSCreate = "";
                textBox3.Text = "";
                for (int i = 0; i < 17; i++)
                {
                    allPSCreate += psCreate[i] + Environment.NewLine;
                }
                textBox3.Text = allPSCreate;
                runPSFile[2] = powershellPS1Script;
                File.WriteAllText(powershellPS1Script, allPSCreate);
            }

            // Create the required directories.  If dir is already there, the code will fail silently
            Directory.CreateDirectory(workingDir + machineDir + selectedMachine);

            return allPSCreate;
        }

        private void comboBox_FirstVMSelection_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Reset color back to white if changed
            comboBox_FirstVMSelection.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            CompareSelectedVMforUniqueness();

            //
            if (rdp1==null)
            {
                // Does nothing.  Just logic here since !rdp1 is not allowed on a string object
            }
            else
            {
                rdp1 = null;
            }

            selectedDropDown = 1;
            
            // Change info box text to display to user that he or she can reestablish RDP connections
            labelVMStartNotificationText = "Click the Windows icon to launch your selected VM!";
            label_VMStartNotification.Text = labelVMStartNotificationText;
            
            pictureBox1.Enabled = true;
            pictureBox1.Cursor = Cursors.Hand;
            
            string selectedMachine1 = "Machine1";
            selectedMachine = selectedMachine1;
            psCreate[1] = "Set-Variable -Name virtmachinepath -Value " + workingDir + machineDir + selectedMachine1;
            psCreate[2] = "Set-Variable -Name virtmachine -Value " + selectedMachine1;

            string selectedVMCase = comboBox_FirstVMSelection.SelectedItem.ToString();
            switch (selectedVMCase)
            {
                case "Windows 7 SP1":
                    pictureBox1.Image = Properties.Resources.Windows_7_logo_4001;
                    launchWin7();
                    break;
                case "Windows 8.1":
                    pictureBox1.Image = Properties.Resources.windows_8_logo_4001;
                    launchWin81();
                    break;
                case "Windows 10":
                    pictureBox1.Image = Properties.Resources.Windows_10_logo_4001;
                    launchWin10();
                    break;
            }
            
            readWriteVariables();

            // Update the files for writing
            allPSCreate = WritePowershellScript(powershellPS1Script, allPSCreate);

            button_StartOrKillVMAction();
            
        }

        private void comboBox_SecondVMSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            bool selected = false;

            CompareSelectedVMforUniqueness();
            
            // Change info box text to display to user that he or she can reestablish RDP connections
            labelVMStartNotificationText = "Click either of the Windows icons to launch your selected VMs!";
            label_VMStartNotification.Text = labelVMStartNotificationText;

            // Box will enable until the first is selected
            if (!pictureBox1.Enabled)
            {
                // selected will be false if a fist VM was not selected first
                selected = false;
                comboBox_SecondVMSelection.SelectedItem = " ";
                pictureBox2.Enabled = false;
                pictureBox2.Cursor = Cursors.Default;
            }
            else
            {
                // selcted is true if the fist VM is selected
                selected = true;
                pictureBox2.Enabled = true;
                pictureBox2.Cursor = Cursors.Hand;
            }

            selectedDropDown = 2;
            button_StartOrKillVMs.Enabled = true;
            string selectedMachine2 = "Machine2";
            selectedMachine = selectedMachine2;
            psCreate[1] = "Set-Variable -Name virtmachinepath -Value " + workingDir + machineDir + selectedMachine2;
            psCreate[2] = "Set-Variable -Name virtmachine -Value " + selectedMachine2;

            string selectedVM2Case = comboBox_SecondVMSelection.SelectedItem.ToString();
            switch (selectedVM2Case)
            {
                case "Windows 7 SP1":
                    pictureBox2.Image = Properties.Resources.Windows_7_logo_4001;
                    launchWin7();
                    break;
                case "Windows 8.1":
                    pictureBox2.Image = Properties.Resources.windows_8_logo_4001;
                    launchWin81();
                    break;
                case "Windows 10":
                    pictureBox2.Image = Properties.Resources.Windows_10_logo_4001;
                    launchWin10();
                    break;
                case " ":
                    // *HACK* Work on fixing this
                    if (!selected)
                    {
                        label_VMStartNotification.Text = "";
                        comboBox_FirstVMSelection.Focus();
                        comboBox_FirstVMSelection.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
                        string messageBoxText = "Please select an OS for your first virtual machine.";
                        MessageBox.Show(messageBoxText);
                        button_StartOrKillVMReset();
                    }
                    else
                    {
                        string messageBoxText = "Please select one of the three virtual machines listed.";
                        MessageBox.Show(messageBoxText);
                    }
                    break;
            }
            
            readWriteVariables();

            // Update the files for writing
            allPSCreate = WritePowershellScript(powershellPS1Script, allPSCreate);
        }


        private void CompareSelectedVMforUniqueness()
        {
            if (comboBox_FirstVMSelection.SelectedItem == comboBox_SecondVMSelection.SelectedItem)
            {
                duplicatedSelcted = true;
            }
            else
            {
                duplicatedSelcted = false;
            }

            return;
        }

        

        private void configureWinVM(string computerIPRDPAccessNetwork, string staticMacAddress, string vhdxDisk, string vhdxDiskSource)
        {
            psCreate[0] = "Set-Variable -Name virtmachinedisksource -Value " + workingDir + sourceDir + vhdxDiskSource;
            psCreate[5] = "Set-Variable -Name virtmachinediskpath -Value $virtmachinepath\\\"" + vhdxDisk + "\"";
            psCreate[12] = "Add-VMNetworkAdapter -VMName $virtmachine -SwitchName $RDPNetwork -StaticMacAddress " + staticMacAddress;
            psCreate[15] = "do {Test-Connection -Count 1 -ComputerName " + computerIPRDPAccessNetwork + errorActionSilentlyContinue + "} while ($? -ne \"True\")";
            psCreate[16] = "mstsc /v:" + computerIPRDPAccessNetwork + " /f /multimon";
        }

        private void button_OpenHyperVManager_Click(object sender, EventArgs e)
        {
            string proc = windowsDir + system32Dir + "virtmgmt.msc";
            runProcessMinNormMax(proc, "", "max");
        }
        
        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            resetComboBoxes();
            
            if (listBox1.SelectedItem.ToString() == "1")
            {
                numberOfVM = 1;
                textBox3.Text = "";
                comboBox_FirstVMSelection.Visible = true;
                label2.Visible = true;
                labelSecondVMSelection.Visible = false;
                comboBox_SecondVMSelection.Visible = false;
                pictureBox2.Visible = false;

                label1_updateStatus(listBox1.SelectedItem.ToString());
            }
            else if (listBox1.SelectedItem.ToString() == "2")
            {
                numberOfVM = 2;
                comboBox_FirstVMSelection.Visible = true;
                label2.Visible = true;
                labelSecondVMSelection.Visible = true;
                comboBox_SecondVMSelection.Visible = true;
                pictureBox2.Visible = true;

                label1_updateStatus(listBox1.SelectedItem.ToString());
            }

            label1.Text = description;
        }

        private void resetComboBoxes()
        {
            button_StartOrKillVMReset();

            textBox2.Text = "";
            textBox3.Text = "";

            labelVMStartNotificationText = "";
            label_VMStartNotification.Text = labelVMStartNotificationText;
            comboBox_FirstVMSelection.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));

            listBox1.Enabled = true;

            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;

            checkBox_PersistentDisk.Enabled = true;
            button_DeleteRecreatePersistentDisk.Enabled = true;
            
            pictureBox1.Image = Properties.Resources.Microsoft_logo_m_box_400x400;
            pictureBox2.Image = Properties.Resources.Microsoft_logo_m_box_400x400;

            comboBox_FirstVMSelection.ResetText();
            comboBox_FirstVMSelection.Enabled = true;

            //Forces a "false" match since there is an 'additional' blank line here;
            comboBox_SecondVMSelection.SelectedItem = " ";
            
            comboBox_SecondVMSelection.ResetText();
            comboBox_SecondVMSelection.Enabled = true;

            duplicatedSelcted = false;
            
            rdp1 = null;
            rdp2 = null;

            return;
        }

        private void readWriteVariables()
        {
            // Creates the actual .PS1 file to be run
            powershellPS1Script = workingDir + machineDir + selectedMachine + "launchVM.PS1";

            psCreate[4] = "Set-Variable -Name RDPNetwork -Value RDPAccess";
            psCreate[6] = "Stop-VM -Name $virtmachine -Force -TurnOff " + errorActionSilentlyContinue;
            psCreate[7] = "Remove-VM -Name $virtmachine -Force " + errorActionSilentlyContinue;
            psCreate[8] = "Remove-Item -Path $virtmachinepath -Force -Recurse " + errorActionSilentlyContinue;
            psCreate[9] = "New-Item -Path $virtmachinepath -itemtype directory";
            psCreate[10] = "New-VHD -ParentPath $virtmachinedisksource -Path $virtmachinediskpath";
            psCreate[11] = "New-VM -Name $virtmachine -Path $virtmachinepath -MemoryStartupBytes " + vmMemory + "MB -SwitchName $ExternalNetwork -VHD $virtmachinediskpath";
            psCreate[13] = "Set-VM -Name $virtmachine -ProcessorCount " + vmProcessor;
            psCreate[14] = "Start-VM -Name $virtmachine";
            
            return;
        }

        private void KillAllRunngVMs_Click(object sender, EventArgs e)
        {
            // Display dialog to display warning and to have user confirm and reenable controls
            string messageBoxWaringBody = "Are you sure you want to kill and delete all running VMs?  This action is immediate and irreversible.";
            string messageBoxWaringBanner = "!! VM KILL AND DELETE WARNING !!";
            DialogResult result = messageBoxMethod(messageBoxWaringBody, messageBoxWaringBanner);
            if (result == DialogResult.Yes)
            {

                // Good clean way to check for process and kill if necessary
                // medthod located DialogsToClose.cs
                DialogsToClose();

                isVMrunning = false;
                resetComboBoxes();
                listBox1.SetSelected(0, true);
                listBox1.Focus();
                button_ResetSelection.Enabled = true;
                groupBox_Attribution.Enabled = true;
                label_VMStartNotification.Text = "";
                stopRemoveDeleteAllVM();
                                
                button_ReopenEstablishedRDPSession_1.Visible = false;
                button_ReopenEstablishedRDPSession_1.Enabled = false;
                button_ReopenEstablishedRDPSession_2.Visible = false;
                button_ReopenEstablishedRDPSession_2.Enabled = false;
                checkBox_MultiMonVM1.Checked = false;
                checkBox_MultiMonVM1.Visible = false;
                checkBox_MultiMonVM2.Checked = false;
                checkBox_MultiMonVM2.Visible = false;
                
                checkIfServerBased();
                button_StartOrKillVMReset();
                checkForSelectedTab();

                // After both files are deleted, recalculate memory and update screen fields. 
                while (File.Exists(workingDir + machineDir + "Machine1launchVM.ps1") || File.Exists(workingDir + machineDir + "Machine2launchVM.ps1"))
                {
                    System.Threading.Thread.Sleep(10);
                }
                calculateAvailableMemoryAndDiskSpace();
                label1_updateStatus(listBox1.SelectedItem.ToString());

            }
        }

        /// <summary>
        /// Single method to recalulate processors and memory for VMs and update label1.txt
        /// Changed from if, else if to switch, case
        /// </summary>
        /// <param name="num"></param>
        public void label1_updateStatus(string num)
        {
            switch (num)
            {
                case "1":
                    processor = 4;
                    vmPercentage = .75;
                    calculateVMMemory();
                    description = "A single virtual machine will result in a VM with " + vmProcessor + " processor cores, " + vmMem.ToString() + " GB of RAM, and a 127 GB virtual disk.  This VM is NOT PERSISTENT and will be destroyed when another VM is created or when this application is opened, closed, or otherwise restarted.";
                    break;
                case "2":
                    processor = 2;
                    vmPercentage = .375;
                    calculateVMMemory();
                    description = "Two virtual machines will result in each VM having " + vmProcessor + " processor cores, " + vmMem.ToString() + " GB of RAM, and a 127 GB virtual disk.  The second VM will start 15 seconds after the first.  These VMs are NOT PERSISTENT and will be destroyed when another VM is created or when this application is opened, closed, or otherwise restarted.";
                    break;
                default:
                    goto case "1";
            }
            
            label1.Text = description;
        }

        private static DialogResult messageBoxMethod(string messageBoxWaringBody, string messageBoxWaringBanner)
        {
            return MessageBox.Show(messageBoxWaringBody, messageBoxWaringBanner, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        private void stopRemoveDeleteAllVM()
        {
            string procArgs = workingDir + shortcutDir + "StopRemoveDeleteAllVM.PS1";
            runProcessMinNormMax(PS, procArgs, "norm");
        }

        private void button_OpenWindowsExplorer_Click(object sender, EventArgs e)
        {
            string proc = "explorer";
            runProcessMinNormMax(proc, "", "norm");
        }

        private void button_OpenPowerShell_Click(object sender, EventArgs e)
        {
            runProcessMinNormMax(PS, "", "");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            resetComboBoxes();
            stopRemoveDeleteAllVM();
        }

        private void button_OpenRDPSession_Click(object sender, EventArgs e)
        {
            string proc = "mstsc";
            string procArgs= "/f";
            runProcessMinNormMax(proc, procArgs, "norm");
        }

        private void button_RestartComputer_Click(object sender, EventArgs e)
        {
            bool buttonCheck = false;
            dismountVHD();
            boolCheck(buttonCheck);
        }

        private void button_ShutdownComputer_Click(object sender, EventArgs e)
        {
            bool buttonCheck = true;
            dismountVHD();
            boolCheck(buttonCheck);
        }

        private void boolCheck(bool shutdownRestartClicked)
        {
            //shutdownRestartClicked: True = shutdown, False = Restart

            string messageBoxWaringBody = "";
            string messageBoxWaringBanner = "";
            string runScript = "";

            if (shutdownRestartClicked)
            {
                messageBoxWaringBody = "Are you sure you want to shutdown the computer! This action will kill and delete all running VMs and is mmediate and irreversible.";
                messageBoxWaringBanner = "!! SHUTDOWN COMPUTER WARNING !!";
                runScript = workingDir + shortcutDir + "ShutdownComputer.PS1";

            }
            else
            {
                messageBoxWaringBody = "Are you sure you want to restart the computer! This action will kill and delete all running VMs and is mmediate and irreversible.";
                messageBoxWaringBanner = "!! RESTART COMPUTER WARNING !!";
                runScript = workingDir + shortcutDir + "RestartComputer.PS1";
            }

            DialogResult result = messageBoxMethod(messageBoxWaringBody, messageBoxWaringBanner);
            if (result == DialogResult.Yes)
            {
                // medthod located DialogsToClose.cs
                killRunningProcesses("imgburn");
                runProcessMinNormMax(PS, runScript, "norm");
            }
        }
        /// <summary>
        /// Resets Windows and certain other selections to defaults
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_ResetSelection_Click(object sender, EventArgs e)
        {
            // medthod located DialogsToClose.cs
            DialogsToClose();
            resetComboBoxes();
            listBox1.SetSelected(0, true);
            resetPersistentDiskCheckBox();
            calculateAvailableMemoryAndDiskSpace();
        }

        private void radioButton_StandaloneManagedAttribution_CheckedChanged(object sender, EventArgs e)
        {
            // located in SelectAttribution.cs
            selectAttribution();
        }
        
        private void radioButton_StandaloneAttribution_CheckedChanged(object sender, EventArgs e)
        {
            // located in SelectAttribution.cs
            selectAttribution();
        }

        private void radioButton_ServerBasedAttribution_CheckedChanged(object sender, EventArgs e)
        {
            // located in SelectAttribution.cs
            selectAttribution();
        }

        private void button_OpenFormCheckServerActivationStatus_Click(object sender, EventArgs e)
        {
            string proc = windowsDir + system32Dir + "slmgr.vbs";
            string procArg = "/dlv";
            runProcessMinNormMax(proc, procArg, "norm");
        }



        private void comboBox_FirstVMSelection_Click(object sender, EventArgs e)
        {
            calculateVMMemory();
            label1.Text = description;
        }

        private void checkBox_PersistentDisk_CheckedChanged(object sender, EventArgs e)
        {
            checkForPersistentDisk();
        }

        private void button_OpenDateTime_Click(object sender, EventArgs e)
        {
            string proc = "control";
            string procArg= "timedate.cpl";
            runProcessMinNormMax(proc, procArg, "norm");
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            string todaysDateAndTime = DateTime.Now.ToLongTimeString() + Environment.NewLine + DateTime.Now.ToLongDateString();
            label3.Text = todaysDateAndTime;
        }

        private void calculateAvailableMemoryAndDiskSpace()
        {
            // Calculate remaining HDD/SSD space
            String folder = "c:\\";
            DriveInfo drive = new DriveInfo(folder);
            DriveInfo a = new DriveInfo(drive.Name);
            string availableFreeDiskSpace = ((Int32)((a.AvailableFreeSpace * 0.9765625) / 1024000000)).ToString();

            // Calculate available memory (RAM)
            totalSystemMemory = new Microsoft.VisualBasic.Devices.ComputerInfo().AvailablePhysicalMemory;

            label5.Text = "Total available physical memory (RAM) is " + (totalSystemMemory / 1024000000).ToString() + " GB.  " + "Remaining  disk space is " + availableFreeDiskSpace + " GB.";
            calculateVMMemory();
        }

        private void button_RestartLocalMedusa_Click(object sender, EventArgs e)
        {
            string messageBoxWaringBody = "Are you sure you want to restart the local instance of Medusa? This will forcefully terminate any existing tunnels and possibly leave orphaned AWS instances.";
            string messageBoxWaringBanner = "!! RESTART MEDUSA !!";
            DialogResult result = messageBoxMethod(messageBoxWaringBody, messageBoxWaringBanner);
            if (result == DialogResult.Yes)
            {
                string procVmconnect = "vmconnect";
                string PSStopArgument = "Stop-VM -Name Medusa* -Force";
                string PSStartArgument = "Start-VM -Name Medusa*";
                string vMconnectArg = "localhost MedusaC";

                // Kill the VM Connect screen if running
                checkForProcessAndKill("vmconnect");
                
                runProcessMinNormMax(PS, PSStopArgument, "norm");

                // Ghetto method of restarting since I don't know how to check for VM state.  Sucky hack
                System.Threading.Thread.Sleep(5000);
                runProcessMinNormMax(PS, PSStartArgument, "norm");

                // Connect to VM to see if Medusa starts correctly
                runProcessMinNormMax(procVmconnect, vMconnectArg, "norm");
            }
            
        }

        private void button_OpenImgBurn_Click(object sender, EventArgs e)
        {
            string imgBurnApplication = "C:\\Program Files (x86)\\ImgBurn\\ImgBurn.exe";
            string imgBurnArgument = "/mode build";

            if (Directory.Exists("p:\\"))
            {
                if (File.Exists(imgBurnApplication))
                {
                    runProcessMinNormMax(imgBurnApplication, imgBurnArgument, "norm");
                }
                else
                {
                    string noImgBurnInstalled = "imgBurn not installed. Install imgBurn and reboot system. Button will be disabled until the next session.";
                    MessageBox.Show(noImgBurnInstalled);
                    button_OpenImgBurn.Enabled = false;
                }
            }
            else
            {
                string noPDriveMounted = "Persistent (P:) drive not mounted. Mount P: drive prior to launch of imgBurn.";
                MessageBox.Show(noPDriveMounted);
            }
        }

        private void resetPersistentDiskCheckBox()
        {
            if (checkBox_PersistentDisk.Checked)
            {
                checkBox_PersistentDisk.CheckState = CheckState.Unchecked;
                pictureBox_HDD.Visible = false;
                string procArg = "dismount-vhd -path " + workingDir + persistentDiskDir + persistentDiskName + errorActionSilentlyContinue;
                runProcessMinNormMax(PS, procArg, "min");
            }
        }

        private void dismountVHD()
        {
            string procArg = "dismount-vhd -path " + workingDir + persistentDiskDir + persistentDiskName + errorActionSilentlyContinue;
            runProcessMinNormMax(PS, procArg, "min");
        }

        /// <summary>
        /// Opens System Center Endpoint Protection application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_OpenSystemCenterEndpointProtection_Click(object sender, EventArgs e)
        {
            const string openSCEP = "C:\\Program Files\\Microsoft Security Client\\msseces.exe";
            const string openWinDefender = "C:\\Program Files\\Windows Defender\\MSASCui.exe";

            if (File.Exists(openSCEP))
            {
                //Process.Start(openSCEP);
                runProcessMinNormMax(openSCEP, "", "norm");
            }
            else if (File.Exists(openWinDefender))
            {
                //Process.Start(openWinDefender);
                runProcessMinNormMax(openWinDefender, "", "norm");
            }
            else
            {
                string noHostAVInstalled = "Host AntiVirus software is not installed. Please install an authorized Host AntiVirus solution. Button will be disabled until the next session.";
                MessageBox.Show(noHostAVInstalled);
                button_OpenHostAVSoftware.Enabled = false;
            }
        }

        /// <summary>
        /// Calculates available memory and remaining diskspace for display on form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl1_Click(object sender, EventArgs e)
        {

            //calculateVMMemory();
            calculateAvailableMemoryAndDiskSpace();
            label1.Text = description;
            checkForSelectedTab();
        }

        private void checkForSelectedTab()
        {
            string vmConnectProcess = "mstsc";
            if (tabControl1.SelectedTab == Troubleshooting || isVMrunning || Process.GetProcessesByName(vmConnectProcess).Length > 0)
            {
                TopMost = false;
            }
            else
            {
                TopMost = true;
            }
        }

        private void setRestartMedusaDenaliTextbox(string textBoxMedusaDenaliText)
        {
            button_RestartLocalMedusa.Enabled = true;
            button_RestartLocalMedusa.Text = textBoxMedusaDenaliText;
        }

        private void button_ChangeDisplayProperties_Click(object sender, EventArgs e)
        {
            // Opens form modally  
            using (Form_DisplayProperties form_DisplayProperties = new Form_DisplayProperties())
            {
                form_DisplayProperties.ShowDialog(this);
            }
        }
        
        private void button_OpenSconfig_Click(object sender, EventArgs e)
        {
            string procToStart = "sconfig";
            runProcessMinNormMax(procToStart,"","max");
        }
    }
}