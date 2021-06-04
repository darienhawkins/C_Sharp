using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PBOCopier
{
    public partial class FormPBOCopier : Form
    {
        #region Declare and Specify Public Variables

            // Specify the config file for source and destination.
            string configFile = @"\\fileserver05\Share\Batch_Files\PBOCopier\PBOCopy.config";
            string sourceDir = "";
            string destDir = "";
            string fileName = "";
            string destFile = "";
            int countFiles = 0, countSourceFiles = 0, countDown = 5;
            bool breakCopy = false; 

        #endregion

        public FormPBOCopier()
        {
            InitializeComponent();
            ProgressBarInitialze();
            labelResetAttributesNotice.Text = "";
            this.Text = "PBO Copier. Application Version " + Application.ProductVersion.ToString();
        }

        private void ProgressBarInitialze()
        {
            // Progress bar init
            progressBar1.Minimum = 1;
            progressBar1.Step = 1;
            progressBar1.Value = 1;
            return;
        }

        private void copyPBOOperation ()
        {
            
            // Unhide
            labelFileOfFileCopied.Visible = true;
            labelFileBeingCopied.Visible = true;

            // Set breakCopy
            //breakCopy = true;
           
            string[] files = System.IO.Directory.GetFiles(sourceDir);
            
            progressBar1.Maximum = countSourceFiles;
            //buttonCancelCopy.Focus();

            // Reset countfiles counter.
            //countSourceFiles = 0;
            this.Refresh();

            foreach (string f in files)
            {
                Application.DoEvents();

                if (breakCopy == false)
                {
                    countFiles = 0;
                    break;
                }

                fileName = System.IO.Path.GetFileName(f);
                //destFile = System.IO.Path.Combine(destDir, fileName);
                destFile = destDir + "\\" + fileName;

                progressBar1.PerformStep();

               

                System.IO.File.Copy(f, destFile, true);

                countFiles++;

                
                labelFileBeingCopied.Text = "Currently copying . . . " + fileName;
                labelFileOfFileCopied.Text = "Copying " + countFiles.ToString() + " of " + countSourceFiles + " files.";
                this.Refresh();
                }

            if (countFiles == countSourceFiles)
            {
                // Timer stuff to exit app
                // Exit after five seconds
                timer1.Enabled = true;
                timer1.Interval = 1000;
                timer1.Start();
            }

            return;
            
        }

        private void FormPBOCopier_Shown(object sender, EventArgs e)
        {

            string[] lines = System.IO.File.ReadAllLines(configFile);
            sourceDir = lines[1];
            destDir = lines[4];
            
            
            // Set lablel text definitions
            labelSourceDir.Text = sourceDir;
            labelDestDir.Text = destDir;

            button1.Text = "Start Copy";
            

            //Hide
            labelFileOfFileCopied.Visible = false;
            labelFileBeingCopied.Visible = false;

            // Establish the number of files to be copied to provide feedback
            if (System.IO.Directory.Exists(sourceDir))
            {
                string[] files = System.IO.Directory.GetFiles(sourceDir);
                foreach (string s in files)
                {
                    countSourceFiles++;
                }
            }

            

            // Informs total number of files to copy
            labelNumberofFilesToCopy.Text = countSourceFiles.ToString() + " total files to be copied.";

            // Automatically starts app.
            timerStart.Enabled = true;
            timerStart.Interval = 1000;
            timerStart.Start();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!breakCopy)
            {
                breakCopy = true;
                labelNumberofFilesToCopy.Visible = true;
                button1.Text = "Cancel Copy";
            }
            else
            {
                breakCopy = false;
                button1.Text = "Restart Copy";
                labelFileOfFileCopied.Text = "";
                labelNumberofFilesToCopy.Visible = false;
                labelFileBeingCopied.Text = "";
                ProgressBarInitialze();
            }

            // Call main method

            // Reset all file attributes on destination files
            // This prevents access denied errors due to read-only attribute
            if (System.IO.Directory.Exists(destDir))
            {
                string attributeNotice = "Please wait.  Resetting destination file attributes.";
                labelResetAttributesNotice.Text = attributeNotice;
                Application.DoEvents();
                string[] files = System.IO.Directory.GetFiles(destDir);
                foreach (string df in files)
                {
                    System.IO.File.SetAttributes(df, System.IO.FileAttributes.Normal);
                }
            }

            // Call the method to copy PBO files
            labelResetAttributesNotice.Text = "";
            copyPBOOperation();
        }

        private void FormPBOCopier_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Set boolean value to cancel copy after app closes
            // Makes sure app fully closes
            breakCopy = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            countDown--;
            button1.Text = "Copy Operation Done! \n Application will Exit in " + countDown.ToString() + ".";
            if (countDown == 0)
            {
                breakCopy = false;
                Application.Exit();
            }
        }

        private void timerStart_Tick(object sender, EventArgs e)
        {
            countDown--;
            button1.Text = "PBO copy will start in " + countDown.ToString() + ".";
            if (countDown == 0)
            {
                countDown = 5;
                timerStart.Enabled = false;
                button1.PerformClick();
            }
            
        }

    }
}
