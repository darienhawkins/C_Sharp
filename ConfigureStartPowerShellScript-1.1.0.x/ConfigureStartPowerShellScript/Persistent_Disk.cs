using System;
using System.Windows.Forms;
using System.IO;

namespace ConfigureStartPowerShellScript_01
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// check for persistent drive when application opens
        /// </summary>
        private void checkForP_DriveWhenFormOpens()
        {
            if (Directory.Exists("P:\\"))
            {
                // boolean isChecked2 only used for when the form is loaded to help with logic
                isChecked = true;
                isChecked2 = true;
                pictureBox_HDD.Visible = true;
                checkBox_PersistentDisk.CheckState = CheckState.Checked;
            }

            return;
        }

        private void checkForPersistentDisk()
        {
            string persistentDiskArgument = "";

            if (isChecked && isChecked2)
            {
                isChecked2 = false;
                return;
            }
            else
            {
                if (!Directory.Exists("p:\\") && !isChecked)
                {

                    persistentDiskArgument = "mount-vhd -path " + workingDir + persistentDiskDir + persistentDiskName + errorActionSilentlyContinue;
                    runProcessMinNormMax(PS, persistentDiskArgument, "min");

                    int count = 0;
                    while (!Directory.Exists("p:\\") && count < 41)
                    {
                        System.Threading.Thread.Sleep(100);
                        count++;
                    }

                    if (Directory.Exists("p:\\"))
                    {
                        pictureBox_HDD.Visible = true;
                        checkBox_PersistentDisk.Checked = true;
                        isChecked = true;
                        return;
                    }
                    else
                    {
                        displayNoPersistentDriveErrorMessage();
                    }

                    return;
                }
                else

                {
                    persistentDiskArgument = "dismount-vhd -path " + workingDir + persistentDiskDir + persistentDiskName + errorActionSilentlyContinue;
                    runProcessMinNormMax(PS, persistentDiskArgument, "min");

                    int count = 0;
                    while (Directory.Exists("p:\\") && count < 49)
                    {
                        // Provides 1 second for the disk to dismount.  Does nothing.
                    }

                    pictureBox_HDD.Visible = false;
                    checkBox_PersistentDisk.CheckState = CheckState.Unchecked;
                    isChecked = false;
                    return;
                }
            }

        }

        private void displayNoPersistentDriveErrorMessage()
        {
            checkBox_PersistentDisk.CheckState = CheckState.Unchecked;
            TopMost = true;
            string messageBoxWaringBody = "There is no persistent (P:) drive to mount.  Do you want to open Disk Management to troubleshoot?";
            string messageBoxWaringBanner = "Persistent Drive Mount Error Message";
            DialogResult result = messageBoxMethod(messageBoxWaringBody, messageBoxWaringBanner);
            if (result == DialogResult.Yes)
            {
                string proc = windowsDir + system32Dir + "diskmgmt.msc";
                runProcessMinNormMax(proc, "", "norm");
                return;
            }
        }

        private void button_DeleteRecreatePersistentDisk_Click(object sender, EventArgs e)
        {
            string procArgNewVHD = "New-VHD -ParentPath " + workingDir + sourceDir + persistentDiskSourceName + " -Path " + workingDir + persistentDiskDir + persistentDiskName;

            // Check to see if disk is present
            if (File.Exists(workingDir + persistentDiskDir + persistentDiskName))
            {
                string messageBoxWaringBody = "Are you sure you want to delete the persistent disk?  Selecting “yes” will delete the current persistent disk—and all data contained therein—and create a new, clean, blank persistent disk.  This action is immediate and irreversible.";
                string messageBoxWaringBanner = "!! DELETE PERSISTENT DISK WARNING !!";

                DialogResult result = messageBoxMethod(messageBoxWaringBody, messageBoxWaringBanner);
                if (result == DialogResult.Yes)
                {
                    // detatch and delete disk
                    checkBox_PersistentDisk.Checked = false;
                    pictureBox_HDD.Visible = false;

                    string procArgDismountVHD = "dismount-vhd -path " + workingDir + persistentDiskDir + persistentDiskName + errorActionSilentlyContinue +
                     ";" + "Remove-Item -Path " + workingDir + persistentDiskDir + " -Force -Recurse " + errorActionSilentlyContinue;

                    runProcessMinNormMax(PS, procArgDismountVHD, "min");

                    while (File.Exists(workingDir + persistentDiskDir + persistentDiskName))
                    {
                        // Nothing here. A while loop to "wait" untils file is really deleted
                    }

                    runProcessMinNormMax(PS, procArgNewVHD, "norm");
                }
            }
            else
            {
                string messageBoxWaringBody = "No persistent disk present to delete.  Do you want to create one?";
                string messageBoxWaringBanner = "!! PERSISTENT DISK INFORMATION !!";
                DialogResult result = messageBoxMethod(messageBoxWaringBody, messageBoxWaringBanner);
                if (result == DialogResult.Yes)
                {
                    runProcessMinNormMax(PS, procArgNewVHD, "norm");
                }
            }
        }
        
    }
}
