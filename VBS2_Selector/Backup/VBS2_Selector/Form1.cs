using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace VBS2_Selector
{
    public partial class Form1 : Form
    {
    
        //Declare variables

        int vbs2count = 0;
        // int selectedRadioButtonCounter = 0;
        bool modTracker = true;

        
        string v132toolspath = "C:\\Bohemia Interactive\\VBS2 Developer Suite v1.32\\tools\\mountDrive.bat";
        string v140toolspath = "C:\\Bohemia Interactive\\VBS2 Developer Suite v1.40\\tools\\mountDrive.bat";
        string v150toolspath = "C:\\Bohemia Interactive\\VBS2 Developer Suite v1.50\\tools\\mountDrive.bat";

        string pdrivev132 = "P:\\VBS2 v1.32 Tools";
        string pdrivev140 = "P:\\VBS2 v1.40 Tools";
        string pdrivev150 = "P:\\VBS2 v1.50 Tools";

        string launchVBS2ToolsButton = "";
        
        string defaultVBS2path = "C:\\Bohemia Interactive\\VBS2\\";
        string v132apppath = "C:\\Bohemia Interactive\\VBS2 v1.32\\";
        string v140apppath = "C:\\Bohemia Interactive\\VBS2 v1.40\\";

        // VBS v150apppath changed from v1.50.0.31 to v1.50
        // on June 27, 2011
        string v150apppath = "C:\\Bohemia Interactive\\VBS2 v1.50\\";
        string vbs2executable = "vbs2.exe";
        string vbs2launchpath = "";
        string vbs2notinstallednotice = "VBS2 is not installed or configured for use with this tool.";
        // string modSelectedPath = "";
        
        string toolsbuttonclick = "";
        string args = "";
        
        //Declare array
        string[] argparams = new string[8];
        string[] switcharguments =
        {
            /* 0 */ "Start VBS2 in admin mode (will default to user mode if omitted).",
            /* 1 */ "Run in window (default - Full Screen).",
            /* 2 */ "VBS2 will continue to draw the scene and run the simulation even if the VBS2 window has lost focus. This can be very useful if GUI plugins are used or multiple instances of VBS are executed on the same PC.",
            /* 3 */ "Skip initial screens.",
            /* 4 */ "Will use the windows file caching instead of VBS2 built in one. Useful for developers that restart VBS2 often. VBS2 does its own caching so when the program is terminated, all cached data is lost and the next start-up takes the same amount of time. Using the -oscache command-line option will call the standard file access functions (simple Win32 ReadFile) and leaves caching on the operating system. This means that cached data can survive VBS2 restarts and subsequent start-ups only take about 12 seconds.",
            /* 5 */ "Mods directories (bin and dta subdirectories are searched in). Seperate mod directories with a semi-colon \";\" ",
            /* 6 */ "Starts LVC Game version of VBS2. (Note: there is no separate VBS2_LVC.exe available anymore, since version 1.19 5630.).",
            /* 7 */ "Create dedicated server.",
            /* 8 */ "To run VBS2 in full screen, deselect the -window option"

        };
    

        public Form1()
        {
            InitializeComponent();

            // Timer
            timer1.Interval = 10000;
            timer1.Enabled = true;

            /*****************************************************
                Check to see what version of VBS2 Tools is installed and
                confiigured for use with this  tool
            */

            checkVBS2ToolsVersion();

            /*****************************************************
                Show application and operating system version
                information in the lower left corner
            */

            string appVersion = "Application Version " + Application.ProductVersion.ToString() +  ". For internal use only!";
            string osVersion = System.Environment.OSVersion.ToString();
            
            label2.Text = appVersion + " ... " + osVersion;
            labelVBS2FileVersion.Text = "";
            label_switchdescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            label_switchdescription.Text = switcharguments[8];


            /********************************************************
                Check to see what version of VBS2 is installed and
                confiigured for use with this  tool
            */

            chechVBS2AppVersion();


            //Disable launch button if VBS2 is not installed
            if (vbs2count == 3)
            {
                button_launchvbs2.Enabled = false;
                label1.Text = vbs2notinstallednotice;
            }
            
            
            /******************************************************** 
                Check to see which version of tools is already selected
            */
            if (System.IO.File.Exists(pdrivev132))
                this.button_v132.BackColor = System.Drawing.SystemColors.Highlight;
            else if (System.IO.File.Exists(pdrivev140))
                this.button_v140.BackColor = System.Drawing.SystemColors.Highlight;
            else if (System.IO.File.Exists(pdrivev150))
                this.button_v150.BackColor = System.Drawing.SystemColors.Highlight;

        }

        private void chechVBS2AppVersion()
        {
            if (System.IO.File.Exists(v132apppath + vbs2executable))
            {
                this.radioButton_v132.Enabled = true;
                this.buttonOpenVBS2132Docs.Enabled = true;
            }
            else
            {
                this.buttonOpenVBS2132Docs.Enabled = false;
                this.radioButton_v132.Enabled = false;
                vbs2count++;
            }

            if (System.IO.File.Exists(v140apppath + vbs2executable))
            {
                this.radioButton_v140.Enabled = true;
                this.buttonOpenVBS2140Docs.Enabled = true;
            }
            else
            {
                this.buttonOpenVBS2140Docs.Enabled = false;
                this.radioButton_v140.Enabled = false;
                vbs2count++;
            }

            if (System.IO.File.Exists(v150apppath + vbs2executable))
            {
                this.radioButton_v150.Enabled = true;
                this.buttonOpenVBS2150Docs.Enabled = true;
            }
            else
            {
                this.buttonOpenVBS2150Docs.Enabled = false;
                this.radioButton_v150.Enabled = false;
                vbs2count++;
            }
        }

        private void checkVBS2ToolsVersion()
        {
            if (System.IO.File.Exists(v132toolspath))
            {
                this.button_v132.Enabled = true;
                buttonVBS132ToolsDocFolder.Enabled = true;
                
            }
            else
            {
                this.button_v132.Enabled = false;
                buttonVBS132ToolsDocFolder.Enabled = false;
            }

            if (System.IO.File.Exists(v140toolspath))
            {
                this.button_v140.Enabled = true;
                buttonVBS140ToolsDocFolder.Enabled = true;
            }
            else
            {
                this.button_v140.Enabled = false;
                buttonVBS140ToolsDocFolder.Enabled = false;
            }

            if (System.IO.File.Exists(v150toolspath))
            {
                this.button_v150.Enabled = true;
                buttonVBS150ToolsDocFolder.Enabled = true;
            }
            else
            {
                this.button_v150.Enabled = false;
                buttonVBS150ToolsDocFolder.Enabled = false;
            }

            this.Refresh();
        }

        

        private void buttonv132_Click(object sender, EventArgs e)
        {
            toolsbuttonclick = v132toolspath;
            ButtonHighlight();
        }

        private void buttonv140_Click(object sender, EventArgs e)
        {
            toolsbuttonclick = v140toolspath;
            ButtonHighlight();
        }

        private void buttonv150_Click(object sender, EventArgs e)
        {
            toolsbuttonclick = v150toolspath;
            ButtonHighlight();            
        }

        private void button_launchvbs2_Click(object sender, EventArgs e)
        {

            radioCheckButtons();

            // End Checkboxes
            
            oscachstate();
            args = argparams[0] + argparams[1] + argparams[2] + argparams[3] + argparams[4] + argparams[5] + argparams[6] + argparams[7];

            // Checks to see if the -mod switch is selected w/no listed mod directories
            if (!radioButton_v132.Checked && !radioButton_v140.Checked && !radioButton_v150.Checked)
            {
                MessageBox.Show("Please select a version of VBS2 to launch!","Hey You!");
            }
            else if (checkBox_mod.Checked == true && textBoxModSwitches.Text == "")
                MessageBox.Show("No parameters given for -mod.  Either uncheck or enter mod directories");
            else
            {
                //MessageBox.Show(vbs2launchpath + args);
                launchApplications(@vbs2launchpath, args);
            }
        }

        private void radioCheckButtons()
        {
            // Radio buttons
            if (radioButton_v132.Checked)
                vbs2launchpath = v132apppath + vbs2executable;
            else if (radioButton_v140.Checked)
                vbs2launchpath = v140apppath + vbs2executable;
            else if (radioButton_v150.Checked)
            {
                vbs2launchpath = v150apppath + vbs2executable;
            }


            //*********************************

            // Checkboxes
            if (checkBox_admin.Checked)
                argparams[0] = checkBox_admin.Text;
            else
                argparams[0] = "";

            if (checkBox_window.Checked)
                argparams[1] = checkBox_window.Text;
            else
                argparams[1] = "";

            if (checkBox_forcesimul.Checked)
                argparams[2] = checkBox_forcesimul.Text;
            else
                argparams[2] = "";

            if (checkBox_nosplash.Checked)
                argparams[3] = checkBox_nosplash.Text;
            else
                argparams[3] = "";

            if (checkBox_oscache.Checked & modTracker==true)
                argparams[4] = checkBox_oscache.Text;
            else
                argparams[4] = "";

            if (checkBox_mod.Checked & modTracker == true)
            {
                checkBox_mod.Text = checkBox_mod.Text;
                argparams[5] = checkBox_mod.Text + textBoxModSwitches.Text;
            }
            else
                argparams[5] = "";

            if (checkBox_lvc.Checked)
                argparams[6] = checkBox_lvc.Text;
            else
                argparams[6] = "";

            if (checkBox_server.Checked)
                argparams[7] = checkBox_server.Text;
            else
                argparams[7] = "";

            
        }

        private void radioButton_v150_CheckedChanged(object sender, EventArgs e)
        {
            FileVersionInfo myFileVersionInfo = FileVersionInfo.GetVersionInfo(v150apppath + vbs2executable);
            labelVBS2FileVersion.Text = "VBS2.exe file version: " + myFileVersionInfo.FileVersion;
            oscachstate();
        }

        private void radioButton_v140_CheckedChanged(object sender, EventArgs e)
        {
            FileVersionInfo myFileVersionInfo = FileVersionInfo.GetVersionInfo(v140apppath + vbs2executable);
            labelVBS2FileVersion.Text = "VBS2.exe file version: " + myFileVersionInfo.FileVersion;
            oscachstate();                
        }

        private void radioButton_v132_CheckedChanged(object sender, EventArgs e)
        {
            FileVersionInfo myFileVersionInfo = FileVersionInfo.GetVersionInfo(v132apppath + vbs2executable);
            labelVBS2FileVersion.Text = "VBS2.exe file version: " + myFileVersionInfo.FileVersion;
            oscachstate();
        }

        // ******************************************************
        //Declare my methods

        void oscachstate()
        {
            if (radioButton_v150.Checked == true)
            {
                checkBox_oscache.Checked = true;
                checkBox_oscache.Enabled = false;
                argparams[4] = "";                
            }
            else if (checkBox_oscache.Enabled == false)
            {
                this.checkBox_oscache.Checked = false;
                this.checkBox_oscache.Enabled = true;
            }
        }

        void ButtonHighlight()
        {
            if (toolsbuttonclick == v132toolspath)
            {
                button_v132.BackColor = System.Drawing.SystemColors.Highlight;
                button_v140.BackColor = System.Drawing.SystemColors.Control;
                button_v150.BackColor = System.Drawing.SystemColors.Control;
                System.Diagnostics.Process.Start(v132toolspath);
            }

            if (toolsbuttonclick == v140toolspath)
            {
                button_v132.BackColor = System.Drawing.SystemColors.Control;
                button_v140.BackColor = System.Drawing.SystemColors.Highlight;
                button_v150.BackColor = System.Drawing.SystemColors.Control;
                System.Diagnostics.Process.Start(v140toolspath);
            }

            if (toolsbuttonclick == v150toolspath)
            {
                button_v132.BackColor = System.Drawing.SystemColors.Control;
                button_v140.BackColor = System.Drawing.SystemColors.Control;
                button_v150.BackColor = System.Drawing.SystemColors.Highlight;
                System.Diagnostics.Process.Start(v150toolspath);
            }
        }

        void mouseOverActions(string aa )
        {
            label_switchdescription.Text = aa;
        }

        void checkBox_server_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_server.Checked)
            {
                checkBox_window.Checked = false;
                checkBox_window.Enabled = false;
                checkBox_admin.Checked = true;
                checkBox_admin.Enabled = false;
                checkBox_forcesimul.Checked = false;
                checkBox_forcesimul.Enabled = false;
                checkBox_nosplash.Checked = false;
                checkBox_nosplash.Enabled = false;
            }
            else
            {
                checkBox_window.Checked = true;
                checkBox_window.Enabled = true;
                checkBox_forcesimul.Enabled = true;
                checkBox_nosplash.Enabled = true;
                checkBox_admin.Enabled = true;
            }

        }

        void clear_richTextBox_onMouseLeave(object sender, EventArgs e)
        {
            label_switchdescription.Text = "";
        }

        private void checkBox_admin_MouseHover(object sender, EventArgs e)
        {
            mouseOverActions(switcharguments[0]);
        }

        private void checkBox_window_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_window.Checked == false)
            {
                checkBox_forcesimul.Checked = false;
                checkBox_forcesimul.Enabled = false;
                argparams[2] = "";
            }
            else
            {
                checkBox_forcesimul.Enabled = true;

            }

        }

        private void checkBox_window_MouseHover(object sender, EventArgs e)
        {
            mouseOverActions(switcharguments[1]);
        }

        private void checkBox_forcesimul_MouseHover(object sender, EventArgs e)
        {
            mouseOverActions(switcharguments[2]);
        }

        private void checkBox_mod_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_mod.Checked == false)
            {
                textBoxModSwitches.Visible = false;
                textBoxModSwitches.Enabled = false;
                radioCheckButtons();
            }
            else
            {
                textBoxModSwitches.Text = "";
                textBoxModSwitches.Visible = true;
                textBoxModSwitches.Enabled = true;
                textBoxModSwitches.Focus();
                
                
                /* Remove later
                
                 //radioCheckButtons();
                
                if (folderBrowserDialog_selectModDir.ShowDialog() == DialogResult.OK)
                {
                    modSelectedPath = folderBrowserDialog_selectModDir.SelectedPath;
                    //argparams[5] += modSelectedPath;
                    //label_switchdescription.Text = selectedPath;
                    modTracker = true;
                    //string modText = checkBox_mod.Text + '\u0022' + modSelectedPath + '\u0022';
                    string modText = checkBox_mod.Text + modSelectedPath;
                    string returnedPath = System.IO.Path.GetDirectoryName(modText);
                    MessageBox.Show(returnedPath);
                    //checkBox_mod.Text = modText;


                }
                 */
               
            }

        }
                
        private void launchVBS2Tools()
        {
            string toolPath = "";
            string toolArg = "";

            ////// EDIT BETWEEN HERE

            if (launchVBS2ToolsButton == "oxygen2")
            {
                toolPath = @"P:\tools\oxygen\Objektiv2.exe";
                toolArg = "";
            }
            else if (launchVBS2ToolsButton == "visitor3")
            {
                toolPath = @"P:\tools\visitor3\Visitor3.exe";
                toolArg = "";
            }
            else if (launchVBS2ToolsButton == "visitor4")
            {
                toolPath = @"P:\tools\Visitor4\visitor4.exe";
                toolArg = "";
            }
            else if (launchVBS2ToolsButton == "visuallandbuilder")
            {
                toolPath = @"P:\tools\LandBuilder\VisualLandBuilder.exe";
                toolArg = "";
            }
            else if (launchVBS2ToolsButton == "pbopacker")
            {
                toolPath = @"P:\tools\PBOPacker.bat";
                toolArg = "";
            }
            else if (launchVBS2ToolsButton == "faceeditor")
            {
                toolPath = @"P:\tools\faceEditor\faceedit.exe";
                toolArg = "";
            }
            else if (launchVBS2ToolsButton == "fsmeditor")
            {
                toolPath = @"P:\tools\fsmEditor\FSMEditor.exe";
                toolArg = "";
            }
            else if (launchVBS2ToolsButton == "TexView")
            {
                toolPath = @"P:\tools\tex\TexView.exe";
                toolArg = "";
            }
            else if (launchVBS2ToolsButton == "ConfigEditor")
            {
                toolPath = @"P:\tools\cme\CfgEditorVBS.exe";
                toolArg = "";
            }


            ///// EDIT BETWEEN HERE

            launchApplications(toolPath, toolArg);
        }

        private void launchApplications(string path,string arguments)
        {

            if (path == @"P:\tools\faceEditor\faceedit.exe")
            {
                Process process = new Process();
                process.StartInfo.FileName = path;
                process.StartInfo.WorkingDirectory = @"P:\tools\faceEditor\";
                process.Start();
            }
            else if (arguments == "dxdiag")
            {
                Process process = new Process();
                process.StartInfo.FileName = path;
                process.StartInfo.WorkingDirectory = @"C:\Windows\System32";
                process.Start();
            }
            else
            {
                System.Diagnostics.Process.Start(path, arguments);
            }
            
            return;
        }

        private void button_Oxygen2_Launch_Click(object sender, EventArgs e)
        {
            launchVBS2ToolsButton = "oxygen2";
            launchVBS2Tools();
        }

        private void button_Visitor3_Launch_Click(object sender, EventArgs e)
        {
            launchVBS2ToolsButton = "visitor3";
            launchVBS2Tools();
        }

        private void button_Visitor4_Launch_Click(object sender, EventArgs e)
        {
            launchVBS2ToolsButton = "visitor4";
            launchVBS2Tools();
        }

        private void button_VisualLandBuilder_Launch_Click(object sender, EventArgs e)
        {
            launchVBS2ToolsButton = "visuallandbuilder";
            launchVBS2Tools();
        }

        private void button_PBOPacker_Launch_Click(object sender, EventArgs e)
        {
            launchVBS2ToolsButton = "pbopacker";
            launchVBS2Tools();
        }

        private void button_FaceEditor_Launch_Click(object sender, EventArgs e)
        {
            launchVBS2ToolsButton = "faceeditor";
            launchVBS2Tools();
        }

        private void button_FSMEditor_Launch_Click(object sender, EventArgs e)
        {
            launchVBS2ToolsButton = "fsmeditor";
            launchVBS2Tools();
        }

        private void checkBox_nosplash_MouseHover(object sender, EventArgs e)
        {
            mouseOverActions(switcharguments[3]);
        }

        private void checkBox_oscache_MouseHover(object sender, EventArgs e)
        {
            mouseOverActions(switcharguments[4]);
        }

        private void checkBox_mod_MouseHover(object sender, EventArgs e)
        {
            mouseOverActions(switcharguments[5]);
        }

        private void checkBox_lvc_MouseHover(object sender, EventArgs e)
        {
            mouseOverActions(switcharguments[6]);
        }

        private void checkBox_server_MouseHover(object sender, EventArgs e)
        {
            mouseOverActions(switcharguments[7]);
        }

        private void buttonViewRPTFile_Click(object sender, EventArgs e)
        {
            
            string textEditor = "Notepad.exe";
            string currentUserProfile = Environment.GetEnvironmentVariable("USERPROFILE");
            string[] fileNameToOpen = 
            {
                /* 0 */ @"\AppData\Local\VBS2\VBS2.RPT",
                /* 1 */ @"\Documents\VBS2\VBS2.cfg",
                /* 2 */ @"\Documents\VBS2\onesaf.VBS2Profile",
                /* 3 */ @"\Documents\VBS2\",
                /* 4 */ @"mpreport.txt",
                /* 5 */ @"net.log",
                /* 6 */ @" /k pushd "+ defaultVBS2path,
                /* 7 */ @"http://localhost:1947",
                /* 8 */ "dxdiag"

            };
            int arrayIndex = -1;

            if (radioButtonOpenRPTFile.Checked)
                arrayIndex = 0;
            else if (radioButtonOpenVBS2CFG.Checked)
                arrayIndex = 1;
            else if (radioButtonOpenUserVBS2Profile.Checked)
                arrayIndex = 2;
            else if (radioButtonOpenUserVBS2Folder.Checked)
            {
                textEditor = "Explorer.exe"; //Opens Windows Explorer
                arrayIndex = 3;
            }
            else if (radioButtonOpenMpreportTxt.Checked)
                if (radioButton_v132.Checked)
                {
                    currentUserProfile = v132apppath;
                    arrayIndex = 4;
                }
                else if (radioButton_v140.Checked)
                {
                    currentUserProfile = v140apppath;
                    arrayIndex = 4;
                }
                else if (radioButton_v150.Checked)
                {
                    currentUserProfile = v150apppath;
                    arrayIndex = 4;
                }
                else
                {
                    currentUserProfile = defaultVBS2path;
                    arrayIndex = 4;
                }
            else if (radioButtonOpenNetLog.Checked)
                if (radioButton_v132.Checked)
                {
                    currentUserProfile = v132apppath;
                    arrayIndex = 5;
                }
                else if (radioButton_v140.Checked)
                {
                    currentUserProfile = v140apppath;
                    arrayIndex = 5;
                }
                else if (radioButton_v150.Checked)
                {
                    currentUserProfile = v150apppath;
                    arrayIndex = 5;
                }
                else
                {
                    currentUserProfile = defaultVBS2path;
                    arrayIndex = 5;
                }
            else if (radioButtonOpenCMD.Checked)
            {
                textEditor = "CMD.EXE"; //Opens Command Prompt
                arrayIndex = 6;
            }
            else if (radioButtonHASPPage.Checked)
            {
                textEditor = "iexplore.exe"; //Open IE
                currentUserProfile = ""; //Blanks profile path
                arrayIndex = 7;
            }
            else if (radioButtonOpenDXDiag.Checked)
            {
                textEditor = "dxdiag.exe";
                currentUserProfile = "";
                arrayIndex = 8;
            }

                

                launchApplications(textEditor, currentUserProfile + fileNameToOpen[arrayIndex]);
            
            
        }

        private void button_TexView_Launch_Click(object sender, EventArgs e)
        {
            launchVBS2ToolsButton = "TexView";
            launchVBS2Tools();
        }

        private void button_ConfigEditor_Launch_Click(object sender, EventArgs e)
        {
            launchVBS2ToolsButton = "ConfigEditor";
            launchVBS2Tools();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            checkVBS2ToolsVersion();
            //MessageBox.Show("timerworkie");
        }

        private void radioButtonLaunchButtonChange(object sender, EventArgs e)
        {
            // Changes the text in the radio button to reflect current selection
            if (radioButtonOpenCMD.Checked == true)
                buttonOpenSelectedFile.Text = "Open Command Prompt.";
            else if (radioButtonHASPPage.Checked==true)
                buttonOpenSelectedFile.Text = "Open Sentinel HASP Page.";
            else if (radioButtonOpenUserVBS2Folder.Checked==true)
                buttonOpenSelectedFile.Text = "Open User's VBS2 folder via Explorer.";
            else if (radioButtonOpenDXDiag.Checked==true)
                buttonOpenSelectedFile.Text = "Open DirectX Diagnostic Tool.";
            else
                buttonOpenSelectedFile.Text = "Open Selected File";
        }

        private void buttonOpenVBS2132Docs_Click(object sender, EventArgs e)
        {

            // Bad hack; Calling paths by absolute methods
            string WinExplorer = "explorer.exe";
            string docPath = @" C:\Bohemia Interactive\VBS2 Developer Suite v1.32\docs";

            launchApplications(WinExplorer, docPath);

        }

        private void buttonOpenVBS2140Docs_Click(object sender, EventArgs e)
        {
            string WinExplorer = "explorer.exe";
            string docPath = @" C:\Bohemia Interactive\VBS2 Developer Suite v1.40\tools\docs";

            launchApplications(WinExplorer, docPath);
        }

        private void buttonOpenVBS2150Docs_Click(object sender, EventArgs e)
        {
            string WinExplorer = "explorer.exe";
            string docPath = @" C:\Bohemia Interactive\VBS2 Developer Suite v1.50\tools\docs";

            launchApplications(WinExplorer, docPath);
        }




    }
}