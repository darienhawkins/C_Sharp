using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ConfigureStartPowerShellScript_01
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 
        /// </summary>
        private void selectAttribution()
        {
            setRestartMedusaDenaliTextbox("Medusa");

            if (radioButton_StandaloneAttribution.Checked || radioButton_StandaloneManagedAttribution.Checked)
            {
                startMedusaC();
                button_RestartLocalMedusa.Enabled = true;

                if (radioButton_StandaloneAttribution.Checked)
                {
                    label5.BackColor = Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(171)))), ((int)(((byte)(76)))));
                    label3.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(182)))));
                    setRestartMedusaDenaliTextbox("Restart Medusa");
                }
                else
                {
                    label5.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                    label3.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                    setRestartMedusaDenaliTextbox("Restart Denali");
                }

            }
            else
            {
                button_RestartLocalMedusa.Enabled = false;
                stopMedusaC();
                label5.BackColor = Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(134)))), ((int)(((byte)(33)))));
                label3.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(182)))));
                setRestartMedusaDenaliTextbox("Server Based Misattribution");

                button_RestartLocalMedusa.Enabled = false;
            }

            resetComboBoxes();

            runProcessMinNormMax(PS, startStopRenameMedusa, "min");
        }

        private void checkIfServerBased()
        {
            if (File.Exists(workingDir + shortcutDir + "ServerBasedAttribution.txt"))
            {
                radioButton_ServerBasedAttribution.Checked = true;
                radioButton_ServerBasedAttribution.Enabled = false;
                radioButton_StandaloneAttribution.Enabled = false;
                radioButton_StandaloneManagedAttribution.Enabled = false;
                button_RestartLocalMedusa.Enabled = false;
            }
            else if (File.Exists(workingDir + shortcutDir + "!ServerBasedAttribution.txt"))
            {
                radioButton_StandaloneAttribution.Checked = true;
                radioButton_StandaloneAttribution.Enabled = false;
                radioButton_ServerBasedAttribution.Enabled = false;
                radioButton_StandaloneManagedAttribution.Enabled = false;
                startMedusaC();
            }
            else if (File.Exists(workingDir + shortcutDir + "MServerBasedAttribution.txt"))
            {
                radioButton_StandaloneManagedAttribution.Checked = true;
                radioButton_StandaloneManagedAttribution.Enabled = false;
                radioButton_StandaloneAttribution.Enabled = false;
                radioButton_ServerBasedAttribution.Enabled = false;
                setRestartMedusaDenaliTextbox("Denali");
                startMedusaC();
            }
            else
            {
                radioButton_StandaloneAttribution.Checked = true;
                radioButton_StandaloneManagedAttribution.Enabled = true;
                radioButton_StandaloneAttribution.Enabled = true;
                radioButton_ServerBasedAttribution.Enabled = true;
                button_RestartLocalMedusa.Enabled = true;
            }

            // Run method after all checks have been made
            selectAttribution();
        }


    }
}
