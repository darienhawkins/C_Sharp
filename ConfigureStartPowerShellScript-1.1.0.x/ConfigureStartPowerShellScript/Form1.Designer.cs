namespace ConfigureStartPowerShellScript_01
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox_FirstVMSelection = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Main = new System.Windows.Forms.TabPage();
            this.checkBox_MultiMonVM2 = new System.Windows.Forms.CheckBox();
            this.checkBox_MultiMonVM1 = new System.Windows.Forms.CheckBox();
            this.button_ReopenEstablishedRDPSession_2 = new System.Windows.Forms.Button();
            this.button_ReopenEstablishedRDPSession_1 = new System.Windows.Forms.Button();
            this.checkBox_PersistentDisk = new System.Windows.Forms.CheckBox();
            this.pictureBox_HDD = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_Attribution = new System.Windows.Forms.GroupBox();
            this.radioButton_StandaloneManagedAttribution = new System.Windows.Forms.RadioButton();
            this.radioButton_ServerBasedAttribution = new System.Windows.Forms.RadioButton();
            this.radioButton_StandaloneAttribution = new System.Windows.Forms.RadioButton();
            this.label_VMStartNotification = new System.Windows.Forms.Label();
            this.button_ResetSelection = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button_StartOrKillVMs = new System.Windows.Forms.Button();
            this.comboBox_SecondVMSelection = new System.Windows.Forms.ComboBox();
            this.labelSecondVMSelection = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Troubleshooting = new System.Windows.Forms.TabPage();
            this.button_ChangeDisplayProperties = new System.Windows.Forms.Button();
            this.button_OpenHostAVSoftware = new System.Windows.Forms.Button();
            this.button_DeleteRecreatePersistentDisk = new System.Windows.Forms.Button();
            this.button_RestartLocalMedusa = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_ShutdownComputer = new System.Windows.Forms.Button();
            this.button_RestartComputer = new System.Windows.Forms.Button();
            this.button_OpenFormCheckServerActivationStatus = new System.Windows.Forms.Button();
            this.button_OpenSconfig = new System.Windows.Forms.Button();
            this.button_OpenRDPSession = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button_OpenPowerShell = new System.Windows.Forms.Button();
            this.button_OpenImgBurn = new System.Windows.Forms.Button();
            this.button_OpenDateTime = new System.Windows.Forms.Button();
            this.button_OpenWindowsExplorer = new System.Windows.Forms.Button();
            this.button_OpenHyperVManager = new System.Windows.Forms.Button();
            this.tabPage_Machine1PowerShellScript = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabPage_Machine2PowerShellScript = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label_ApplicationVersionNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_HDD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox_Attribution.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Troubleshooting.SuspendLayout();
            this.tabPage_Machine1PowerShellScript.SuspendLayout();
            this.tabPage_Machine2PowerShellScript.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_FirstVMSelection
            // 
            this.comboBox_FirstVMSelection.FormattingEnabled = true;
            this.comboBox_FirstVMSelection.IntegralHeight = false;
            this.comboBox_FirstVMSelection.ItemHeight = 13;
            this.comboBox_FirstVMSelection.Items.AddRange(new object[] {
            "Windows 7 SP1",
            "Windows 8.1",
            "Windows 10"});
            this.comboBox_FirstVMSelection.Location = new System.Drawing.Point(306, 159);
            this.comboBox_FirstVMSelection.Name = "comboBox_FirstVMSelection";
            this.comboBox_FirstVMSelection.Size = new System.Drawing.Size(176, 21);
            this.comboBox_FirstVMSelection.TabIndex = 4;
            this.comboBox_FirstVMSelection.SelectionChangeCommitted += new System.EventHandler(this.comboBox_FirstVMSelection_SelectedIndexChanged);
            this.comboBox_FirstVMSelection.Click += new System.EventHandler(this.comboBox_FirstVMSelection_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Main);
            this.tabControl1.Controls.Add(this.Troubleshooting);
            this.tabControl1.Controls.Add(this.tabPage_Machine1PowerShellScript);
            this.tabControl1.Controls.Add(this.tabPage_Machine2PowerShellScript);
            this.tabControl1.Location = new System.Drawing.Point(13, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(962, 476);
            this.tabControl1.TabIndex = 9;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // Main
            // 
            this.Main.Controls.Add(this.checkBox_MultiMonVM2);
            this.Main.Controls.Add(this.checkBox_MultiMonVM1);
            this.Main.Controls.Add(this.button_ReopenEstablishedRDPSession_2);
            this.Main.Controls.Add(this.button_ReopenEstablishedRDPSession_1);
            this.Main.Controls.Add(this.checkBox_PersistentDisk);
            this.Main.Controls.Add(this.pictureBox_HDD);
            this.Main.Controls.Add(this.pictureBox2);
            this.Main.Controls.Add(this.label1);
            this.Main.Controls.Add(this.groupBox_Attribution);
            this.Main.Controls.Add(this.label_VMStartNotification);
            this.Main.Controls.Add(this.button_ResetSelection);
            this.Main.Controls.Add(this.label4);
            this.Main.Controls.Add(this.listBox1);
            this.Main.Controls.Add(this.button_StartOrKillVMs);
            this.Main.Controls.Add(this.comboBox_SecondVMSelection);
            this.Main.Controls.Add(this.labelSecondVMSelection);
            this.Main.Controls.Add(this.label2);
            this.Main.Controls.Add(this.pictureBox1);
            this.Main.Controls.Add(this.comboBox_FirstVMSelection);
            this.Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Main.Location = new System.Drawing.Point(4, 22);
            this.Main.Name = "Main";
            this.Main.Padding = new System.Windows.Forms.Padding(3);
            this.Main.Size = new System.Drawing.Size(954, 450);
            this.Main.TabIndex = 0;
            this.Main.Text = "Configure and Launch VMs";
            this.Main.UseVisualStyleBackColor = true;
            // 
            // checkBox_MultiMonVM2
            // 
            this.checkBox_MultiMonVM2.AutoSize = true;
            this.checkBox_MultiMonVM2.Location = new System.Drawing.Point(740, 389);
            this.checkBox_MultiMonVM2.Name = "checkBox_MultiMonVM2";
            this.checkBox_MultiMonVM2.Size = new System.Drawing.Size(86, 17);
            this.checkBox_MultiMonVM2.TabIndex = 107;
            this.checkBox_MultiMonVM2.Text = "Multi-Monitor";
            this.checkBox_MultiMonVM2.UseVisualStyleBackColor = true;
            this.checkBox_MultiMonVM2.Visible = false;
            // 
            // checkBox_MultiMonVM1
            // 
            this.checkBox_MultiMonVM1.AutoSize = true;
            this.checkBox_MultiMonVM1.Location = new System.Drawing.Point(740, 204);
            this.checkBox_MultiMonVM1.Name = "checkBox_MultiMonVM1";
            this.checkBox_MultiMonVM1.Size = new System.Drawing.Size(86, 17);
            this.checkBox_MultiMonVM1.TabIndex = 106;
            this.checkBox_MultiMonVM1.Text = "Multi-Monitor";
            this.checkBox_MultiMonVM1.UseVisualStyleBackColor = true;
            this.checkBox_MultiMonVM1.Visible = false;
            // 
            // button_ReopenEstablishedRDPSession_2
            // 
            this.button_ReopenEstablishedRDPSession_2.Enabled = false;
            this.button_ReopenEstablishedRDPSession_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ReopenEstablishedRDPSession_2.Location = new System.Drawing.Point(740, 332);
            this.button_ReopenEstablishedRDPSession_2.Name = "button_ReopenEstablishedRDPSession_2";
            this.button_ReopenEstablishedRDPSession_2.Size = new System.Drawing.Size(142, 51);
            this.button_ReopenEstablishedRDPSession_2.TabIndex = 105;
            this.button_ReopenEstablishedRDPSession_2.Text = "Reopen Established RDP Session VM #2";
            this.button_ReopenEstablishedRDPSession_2.UseVisualStyleBackColor = true;
            this.button_ReopenEstablishedRDPSession_2.Visible = false;
            this.button_ReopenEstablishedRDPSession_2.Click += new System.EventHandler(this.button_ReopenEstablishedRDPSession_2_Click);
            // 
            // button_ReopenEstablishedRDPSession_1
            // 
            this.button_ReopenEstablishedRDPSession_1.Enabled = false;
            this.button_ReopenEstablishedRDPSession_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ReopenEstablishedRDPSession_1.Location = new System.Drawing.Point(740, 147);
            this.button_ReopenEstablishedRDPSession_1.Name = "button_ReopenEstablishedRDPSession_1";
            this.button_ReopenEstablishedRDPSession_1.Size = new System.Drawing.Size(142, 51);
            this.button_ReopenEstablishedRDPSession_1.TabIndex = 104;
            this.button_ReopenEstablishedRDPSession_1.Text = "Reopen Established RDP Session VM #1";
            this.button_ReopenEstablishedRDPSession_1.UseVisualStyleBackColor = true;
            this.button_ReopenEstablishedRDPSession_1.Visible = false;
            this.button_ReopenEstablishedRDPSession_1.Click += new System.EventHandler(this.button_ReopenEstablishedRDPSession_Click);
            // 
            // checkBox_PersistentDisk
            // 
            this.checkBox_PersistentDisk.AutoSize = true;
            this.checkBox_PersistentDisk.Location = new System.Drawing.Point(68, 236);
            this.checkBox_PersistentDisk.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_PersistentDisk.Name = "checkBox_PersistentDisk";
            this.checkBox_PersistentDisk.Size = new System.Drawing.Size(102, 17);
            this.checkBox_PersistentDisk.TabIndex = 101;
            this.checkBox_PersistentDisk.Text = "Persistent Disk?";
            this.checkBox_PersistentDisk.UseVisualStyleBackColor = true;
            this.checkBox_PersistentDisk.CheckedChanged += new System.EventHandler(this.checkBox_PersistentDisk_CheckedChanged);
            // 
            // pictureBox_HDD
            // 
            this.pictureBox_HDD.Image = global::ConfigureStartPowerShellScript_01.Properties.Resources.hdd_256;
            this.pictureBox_HDD.Location = new System.Drawing.Point(169, 207);
            this.pictureBox_HDD.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_HDD.Name = "pictureBox_HDD";
            this.pictureBox_HDD.Size = new System.Drawing.Size(76, 66);
            this.pictureBox_HDD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_HDD.TabIndex = 103;
            this.pictureBox_HDD.TabStop = false;
            this.pictureBox_HDD.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = global::ConfigureStartPowerShellScript_01.Properties.Resources.Microsoft_logo_m_box_400x400;
            this.pictureBox2.Location = new System.Drawing.Point(539, 276);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(167, 162);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 100;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            this.pictureBox2.Click += new System.EventHandler(this.StartSelectedVMs_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(679, 58);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // groupBox_Attribution
            // 
            this.groupBox_Attribution.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Attribution.Controls.Add(this.radioButton_StandaloneManagedAttribution);
            this.groupBox_Attribution.Controls.Add(this.radioButton_ServerBasedAttribution);
            this.groupBox_Attribution.Controls.Add(this.radioButton_StandaloneAttribution);
            this.groupBox_Attribution.Location = new System.Drawing.Point(45, 92);
            this.groupBox_Attribution.Name = "groupBox_Attribution";
            this.groupBox_Attribution.Size = new System.Drawing.Size(205, 113);
            this.groupBox_Attribution.TabIndex = 13;
            this.groupBox_Attribution.TabStop = false;
            this.groupBox_Attribution.Text = "Attribution";
            // 
            // radioButton_StandaloneManagedAttribution
            // 
            this.radioButton_StandaloneManagedAttribution.AutoSize = true;
            this.radioButton_StandaloneManagedAttribution.Location = new System.Drawing.Point(23, 27);
            this.radioButton_StandaloneManagedAttribution.Name = "radioButton_StandaloneManagedAttribution";
            this.radioButton_StandaloneManagedAttribution.Size = new System.Drawing.Size(177, 17);
            this.radioButton_StandaloneManagedAttribution.TabIndex = 4;
            this.radioButton_StandaloneManagedAttribution.TabStop = true;
            this.radioButton_StandaloneManagedAttribution.Text = "Standalone Managed Attribution";
            this.radioButton_StandaloneManagedAttribution.UseVisualStyleBackColor = true;
            this.radioButton_StandaloneManagedAttribution.CheckedChanged += new System.EventHandler(this.radioButton_StandaloneManagedAttribution_CheckedChanged);
            // 
            // radioButton_ServerBasedAttribution
            // 
            this.radioButton_ServerBasedAttribution.AutoSize = true;
            this.radioButton_ServerBasedAttribution.Location = new System.Drawing.Point(23, 74);
            this.radioButton_ServerBasedAttribution.Name = "radioButton_ServerBasedAttribution";
            this.radioButton_ServerBasedAttribution.Size = new System.Drawing.Size(139, 17);
            this.radioButton_ServerBasedAttribution.TabIndex = 3;
            this.radioButton_ServerBasedAttribution.TabStop = true;
            this.radioButton_ServerBasedAttribution.Text = "Server Based Attribution";
            this.radioButton_ServerBasedAttribution.UseVisualStyleBackColor = true;
            this.radioButton_ServerBasedAttribution.CheckedChanged += new System.EventHandler(this.radioButton_ServerBasedAttribution_CheckedChanged);
            // 
            // radioButton_StandaloneAttribution
            // 
            this.radioButton_StandaloneAttribution.AutoSize = true;
            this.radioButton_StandaloneAttribution.Location = new System.Drawing.Point(23, 50);
            this.radioButton_StandaloneAttribution.Name = "radioButton_StandaloneAttribution";
            this.radioButton_StandaloneAttribution.Size = new System.Drawing.Size(129, 17);
            this.radioButton_StandaloneAttribution.TabIndex = 0;
            this.radioButton_StandaloneAttribution.TabStop = true;
            this.radioButton_StandaloneAttribution.Text = "Standalone Attribution";
            this.radioButton_StandaloneAttribution.UseVisualStyleBackColor = true;
            this.radioButton_StandaloneAttribution.CheckedChanged += new System.EventHandler(this.radioButton_StandaloneAttribution_CheckedChanged);
            // 
            // label_VMStartNotification
            // 
            this.label_VMStartNotification.BackColor = System.Drawing.Color.Transparent;
            this.label_VMStartNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_VMStartNotification.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_VMStartNotification.Location = new System.Drawing.Point(282, 196);
            this.label_VMStartNotification.Name = "label_VMStartNotification";
            this.label_VMStartNotification.Size = new System.Drawing.Size(225, 121);
            this.label_VMStartNotification.TabIndex = 12;
            this.label_VMStartNotification.Text = "label_VMStartNotification";
            this.label_VMStartNotification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_ResetSelection
            // 
            this.button_ResetSelection.Location = new System.Drawing.Point(47, 276);
            this.button_ResetSelection.Name = "button_ResetSelection";
            this.button_ResetSelection.Size = new System.Drawing.Size(174, 33);
            this.button_ResetSelection.TabIndex = 8;
            this.button_ResetSelection.Text = "Reset Selections";
            this.button_ResetSelection.UseVisualStyleBackColor = true;
            this.button_ResetSelection.Click += new System.EventHandler(this.button_ResetSelection_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Select number of VMs -->";
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.DisplayMember = "1";
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.IntegralHeight = false;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Items.AddRange(new object[] {
            "1",
            "2"});
            this.listBox1.Location = new System.Drawing.Point(185, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(47, 62);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button_StartOrKillVMs
            // 
            this.button_StartOrKillVMs.Enabled = false;
            this.button_StartOrKillVMs.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_StartOrKillVMs.FlatAppearance.BorderSize = 2;
            this.button_StartOrKillVMs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_StartOrKillVMs.ForeColor = System.Drawing.Color.Red;
            this.button_StartOrKillVMs.Location = new System.Drawing.Point(45, 334);
            this.button_StartOrKillVMs.Name = "button_StartOrKillVMs";
            this.button_StartOrKillVMs.Size = new System.Drawing.Size(174, 62);
            this.button_StartOrKillVMs.TabIndex = 9;
            this.button_StartOrKillVMs.Text = "Please select options and VMs";
            this.button_StartOrKillVMs.UseVisualStyleBackColor = true;
            // 
            // comboBox_SecondVMSelection
            // 
            this.comboBox_SecondVMSelection.FormattingEnabled = true;
            this.comboBox_SecondVMSelection.IntegralHeight = false;
            this.comboBox_SecondVMSelection.Items.AddRange(new object[] {
            "Windows 7 SP1",
            "Windows 8.1",
            "Windows 10",
            " "});
            this.comboBox_SecondVMSelection.Location = new System.Drawing.Point(306, 347);
            this.comboBox_SecondVMSelection.Name = "comboBox_SecondVMSelection";
            this.comboBox_SecondVMSelection.Size = new System.Drawing.Size(176, 21);
            this.comboBox_SecondVMSelection.TabIndex = 5;
            this.comboBox_SecondVMSelection.SelectionChangeCommitted += new System.EventHandler(this.comboBox_SecondVMSelection_SelectedIndexChanged);
            this.comboBox_SecondVMSelection.Click += new System.EventHandler(this.comboBox_FirstVMSelection_Click);
            // 
            // labelSecondVMSelection
            // 
            this.labelSecondVMSelection.AutoSize = true;
            this.labelSecondVMSelection.Location = new System.Drawing.Point(306, 332);
            this.labelSecondVMSelection.Name = "labelSecondVMSelection";
            this.labelSecondVMSelection.Size = new System.Drawing.Size(174, 13);
            this.labelSecondVMSelection.TabIndex = 7;
            this.labelSecondVMSelection.Text = "Select Second VM from Dropdown.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select VM from Dropdown.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::ConfigureStartPowerShellScript_01.Properties.Resources.Microsoft_logo_m_box_400x400;
            this.pictureBox1.Location = new System.Drawing.Point(539, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.StartSelectedVMs_Click);
            // 
            // Troubleshooting
            // 
            this.Troubleshooting.Controls.Add(this.button_ChangeDisplayProperties);
            this.Troubleshooting.Controls.Add(this.button_OpenHostAVSoftware);
            this.Troubleshooting.Controls.Add(this.button_DeleteRecreatePersistentDisk);
            this.Troubleshooting.Controls.Add(this.button_RestartLocalMedusa);
            this.Troubleshooting.Controls.Add(this.textBox1);
            this.Troubleshooting.Controls.Add(this.button_ShutdownComputer);
            this.Troubleshooting.Controls.Add(this.button_RestartComputer);
            this.Troubleshooting.Controls.Add(this.button_OpenFormCheckServerActivationStatus);
            this.Troubleshooting.Controls.Add(this.button_OpenSconfig);
            this.Troubleshooting.Controls.Add(this.button_OpenRDPSession);
            this.Troubleshooting.Controls.Add(this.button3);
            this.Troubleshooting.Controls.Add(this.button_OpenPowerShell);
            this.Troubleshooting.Controls.Add(this.button_OpenImgBurn);
            this.Troubleshooting.Controls.Add(this.button_OpenDateTime);
            this.Troubleshooting.Controls.Add(this.button_OpenWindowsExplorer);
            this.Troubleshooting.Controls.Add(this.button_OpenHyperVManager);
            this.Troubleshooting.Location = new System.Drawing.Point(4, 22);
            this.Troubleshooting.Name = "Troubleshooting";
            this.Troubleshooting.Padding = new System.Windows.Forms.Padding(3);
            this.Troubleshooting.Size = new System.Drawing.Size(954, 450);
            this.Troubleshooting.TabIndex = 1;
            this.Troubleshooting.Text = "Troubleshooting and Tools";
            this.Troubleshooting.UseVisualStyleBackColor = true;
            // 
            // button_ChangeDisplayProperties
            // 
            this.button_ChangeDisplayProperties.Image = ((System.Drawing.Image)(resources.GetObject("button_ChangeDisplayProperties.Image")));
            this.button_ChangeDisplayProperties.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ChangeDisplayProperties.Location = new System.Drawing.Point(55, 169);
            this.button_ChangeDisplayProperties.Name = "button_ChangeDisplayProperties";
            this.button_ChangeDisplayProperties.Size = new System.Drawing.Size(142, 50);
            this.button_ChangeDisplayProperties.TabIndex = 107;
            this.button_ChangeDisplayProperties.Text = "Change Display Properties";
            this.button_ChangeDisplayProperties.UseVisualStyleBackColor = true;
            this.button_ChangeDisplayProperties.Click += new System.EventHandler(this.button_ChangeDisplayProperties_Click);
            // 
            // button_OpenHostAVSoftware
            // 
            this.button_OpenHostAVSoftware.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_OpenHostAVSoftware.Location = new System.Drawing.Point(411, 25);
            this.button_OpenHostAVSoftware.Name = "button_OpenHostAVSoftware";
            this.button_OpenHostAVSoftware.Size = new System.Drawing.Size(142, 50);
            this.button_OpenHostAVSoftware.TabIndex = 106;
            this.button_OpenHostAVSoftware.Text = "Open Host AntiVirus Software";
            this.button_OpenHostAVSoftware.UseVisualStyleBackColor = true;
            this.button_OpenHostAVSoftware.Click += new System.EventHandler(this.button_OpenSystemCenterEndpointProtection_Click);
            // 
            // button_DeleteRecreatePersistentDisk
            // 
            this.button_DeleteRecreatePersistentDisk.BackColor = System.Drawing.Color.Transparent;
            this.button_DeleteRecreatePersistentDisk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_DeleteRecreatePersistentDisk.Location = new System.Drawing.Point(411, 168);
            this.button_DeleteRecreatePersistentDisk.Margin = new System.Windows.Forms.Padding(2);
            this.button_DeleteRecreatePersistentDisk.Name = "button_DeleteRecreatePersistentDisk";
            this.button_DeleteRecreatePersistentDisk.Size = new System.Drawing.Size(142, 51);
            this.button_DeleteRecreatePersistentDisk.TabIndex = 105;
            this.button_DeleteRecreatePersistentDisk.Text = "Delete, Create Persistent Disk";
            this.button_DeleteRecreatePersistentDisk.UseVisualStyleBackColor = false;
            this.button_DeleteRecreatePersistentDisk.Click += new System.EventHandler(this.button_DeleteRecreatePersistentDisk_Click);
            // 
            // button_RestartLocalMedusa
            // 
            this.button_RestartLocalMedusa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_RestartLocalMedusa.Location = new System.Drawing.Point(589, 25);
            this.button_RestartLocalMedusa.Margin = new System.Windows.Forms.Padding(2);
            this.button_RestartLocalMedusa.Name = "button_RestartLocalMedusa";
            this.button_RestartLocalMedusa.Size = new System.Drawing.Size(142, 51);
            this.button_RestartLocalMedusa.TabIndex = 103;
            this.button_RestartLocalMedusa.Text = "Restart Medusa";
            this.button_RestartLocalMedusa.UseVisualStyleBackColor = true;
            this.button_RestartLocalMedusa.Click += new System.EventHandler(this.button_RestartLocalMedusa_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(835, 25);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 86);
            this.textBox1.TabIndex = 100;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "textBox1 is used for troubleshooting. ";
            this.textBox1.Visible = false;
            // 
            // button_ShutdownComputer
            // 
            this.button_ShutdownComputer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ShutdownComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ShutdownComputer.ForeColor = System.Drawing.Color.Red;
            this.button_ShutdownComputer.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button_ShutdownComputer.Location = new System.Drawing.Point(55, 377);
            this.button_ShutdownComputer.Name = "button_ShutdownComputer";
            this.button_ShutdownComputer.Size = new System.Drawing.Size(142, 51);
            this.button_ShutdownComputer.TabIndex = 14;
            this.button_ShutdownComputer.TabStop = false;
            this.button_ShutdownComputer.Text = "Shutdown Computer!";
            this.button_ShutdownComputer.UseVisualStyleBackColor = true;
            this.button_ShutdownComputer.Click += new System.EventHandler(this.button_ShutdownComputer_Click);
            // 
            // button_RestartComputer
            // 
            this.button_RestartComputer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_RestartComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_RestartComputer.ForeColor = System.Drawing.Color.Red;
            this.button_RestartComputer.Location = new System.Drawing.Point(235, 377);
            this.button_RestartComputer.Name = "button_RestartComputer";
            this.button_RestartComputer.Size = new System.Drawing.Size(142, 51);
            this.button_RestartComputer.TabIndex = 15;
            this.button_RestartComputer.TabStop = false;
            this.button_RestartComputer.Text = "Restart Computer!";
            this.button_RestartComputer.UseVisualStyleBackColor = true;
            this.button_RestartComputer.Click += new System.EventHandler(this.button_RestartComputer_Click);
            // 
            // button_OpenFormCheckServerActivationStatus
            // 
            this.button_OpenFormCheckServerActivationStatus.Location = new System.Drawing.Point(233, 96);
            this.button_OpenFormCheckServerActivationStatus.Name = "button_OpenFormCheckServerActivationStatus";
            this.button_OpenFormCheckServerActivationStatus.Size = new System.Drawing.Size(142, 51);
            this.button_OpenFormCheckServerActivationStatus.TabIndex = 11;
            this.button_OpenFormCheckServerActivationStatus.Text = "Check Windows Activation Status";
            this.button_OpenFormCheckServerActivationStatus.UseVisualStyleBackColor = true;
            this.button_OpenFormCheckServerActivationStatus.Click += new System.EventHandler(this.button_OpenFormCheckServerActivationStatus_Click);
            // 
            // button_OpenSconfig
            // 
            this.button_OpenSconfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_OpenSconfig.Location = new System.Drawing.Point(589, 169);
            this.button_OpenSconfig.Name = "button_OpenSconfig";
            this.button_OpenSconfig.Size = new System.Drawing.Size(142, 51);
            this.button_OpenSconfig.TabIndex = 11;
            this.button_OpenSconfig.Text = "Open Server Configuration TUI";
            this.button_OpenSconfig.UseVisualStyleBackColor = true;
            this.button_OpenSconfig.Click += new System.EventHandler(this.button_OpenSconfig_Click);
            // 
            // button_OpenRDPSession
            // 
            this.button_OpenRDPSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_OpenRDPSession.Location = new System.Drawing.Point(589, 97);
            this.button_OpenRDPSession.Name = "button_OpenRDPSession";
            this.button_OpenRDPSession.Size = new System.Drawing.Size(142, 51);
            this.button_OpenRDPSession.TabIndex = 11;
            this.button_OpenRDPSession.Text = "Open RDP Session";
            this.button_OpenRDPSession.UseVisualStyleBackColor = true;
            this.button_OpenRDPSession.Click += new System.EventHandler(this.button_OpenRDPSession_Click);
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(411, 377);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 51);
            this.button3.TabIndex = 10;
            this.button3.Text = "Kill All Running VMs!";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.KillAllRunngVMs_Click);
            // 
            // button_OpenPowerShell
            // 
            this.button_OpenPowerShell.Location = new System.Drawing.Point(233, 168);
            this.button_OpenPowerShell.Name = "button_OpenPowerShell";
            this.button_OpenPowerShell.Size = new System.Drawing.Size(142, 51);
            this.button_OpenPowerShell.TabIndex = 6;
            this.button_OpenPowerShell.Text = "Open PowerShell";
            this.button_OpenPowerShell.UseVisualStyleBackColor = true;
            this.button_OpenPowerShell.Click += new System.EventHandler(this.button_OpenPowerShell_Click);
            // 
            // button_OpenImgBurn
            // 
            this.button_OpenImgBurn.Image = global::ConfigureStartPowerShellScript_01.Properties.Resources.imgBurn_SMALL;
            this.button_OpenImgBurn.Location = new System.Drawing.Point(233, 25);
            this.button_OpenImgBurn.Margin = new System.Windows.Forms.Padding(2);
            this.button_OpenImgBurn.Name = "button_OpenImgBurn";
            this.button_OpenImgBurn.Size = new System.Drawing.Size(142, 51);
            this.button_OpenImgBurn.TabIndex = 104;
            this.button_OpenImgBurn.UseVisualStyleBackColor = true;
            this.button_OpenImgBurn.Click += new System.EventHandler(this.button_OpenImgBurn_Click);
            // 
            // button_OpenDateTime
            // 
            this.button_OpenDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_OpenDateTime.Image = global::ConfigureStartPowerShellScript_01.Properties.Resources.clockface;
            this.button_OpenDateTime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_OpenDateTime.Location = new System.Drawing.Point(55, 97);
            this.button_OpenDateTime.Margin = new System.Windows.Forms.Padding(2);
            this.button_OpenDateTime.Name = "button_OpenDateTime";
            this.button_OpenDateTime.Size = new System.Drawing.Size(142, 51);
            this.button_OpenDateTime.TabIndex = 101;
            this.button_OpenDateTime.Text = "Open Date/Time";
            this.button_OpenDateTime.UseVisualStyleBackColor = true;
            this.button_OpenDateTime.Click += new System.EventHandler(this.button_OpenDateTime_Click);
            // 
            // button_OpenWindowsExplorer
            // 
            this.button_OpenWindowsExplorer.Image = global::ConfigureStartPowerShellScript_01.Properties.Resources.WindowsExplorer;
            this.button_OpenWindowsExplorer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_OpenWindowsExplorer.Location = new System.Drawing.Point(411, 97);
            this.button_OpenWindowsExplorer.Name = "button_OpenWindowsExplorer";
            this.button_OpenWindowsExplorer.Size = new System.Drawing.Size(142, 51);
            this.button_OpenWindowsExplorer.TabIndex = 3;
            this.button_OpenWindowsExplorer.Text = "Open Windows Explorer";
            this.button_OpenWindowsExplorer.UseVisualStyleBackColor = true;
            this.button_OpenWindowsExplorer.Click += new System.EventHandler(this.button_OpenWindowsExplorer_Click);
            // 
            // button_OpenHyperVManager
            // 
            this.button_OpenHyperVManager.Image = global::ConfigureStartPowerShellScript_01.Properties.Resources.HyperVIcon;
            this.button_OpenHyperVManager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_OpenHyperVManager.Location = new System.Drawing.Point(55, 25);
            this.button_OpenHyperVManager.Name = "button_OpenHyperVManager";
            this.button_OpenHyperVManager.Size = new System.Drawing.Size(142, 51);
            this.button_OpenHyperVManager.TabIndex = 0;
            this.button_OpenHyperVManager.Text = "Open Hyper-V Manager";
            this.button_OpenHyperVManager.UseVisualStyleBackColor = true;
            this.button_OpenHyperVManager.Click += new System.EventHandler(this.button_OpenHyperVManager_Click);
            // 
            // tabPage_Machine1PowerShellScript
            // 
            this.tabPage_Machine1PowerShellScript.Controls.Add(this.textBox2);
            this.tabPage_Machine1PowerShellScript.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Machine1PowerShellScript.Name = "tabPage_Machine1PowerShellScript";
            this.tabPage_Machine1PowerShellScript.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Machine1PowerShellScript.Size = new System.Drawing.Size(954, 450);
            this.tabPage_Machine1PowerShellScript.TabIndex = 2;
            this.tabPage_Machine1PowerShellScript.Text = "Machine1 PowerShell Script";
            this.tabPage_Machine1PowerShellScript.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(23, 23);
            this.textBox2.MaxLength = 2048;
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(861, 417);
            this.textBox2.TabIndex = 5;
            // 
            // tabPage_Machine2PowerShellScript
            // 
            this.tabPage_Machine2PowerShellScript.Controls.Add(this.textBox3);
            this.tabPage_Machine2PowerShellScript.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Machine2PowerShellScript.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_Machine2PowerShellScript.Name = "tabPage_Machine2PowerShellScript";
            this.tabPage_Machine2PowerShellScript.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage_Machine2PowerShellScript.Size = new System.Drawing.Size(954, 450);
            this.tabPage_Machine2PowerShellScript.TabIndex = 3;
            this.tabPage_Machine2PowerShellScript.Text = "Machine2 PowerShell Script";
            this.tabPage_Machine2PowerShellScript.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Ivory;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(23, 23);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(861, 417);
            this.textBox3.TabIndex = 8;
            // 
            // label_ApplicationVersionNumber
            // 
            this.label_ApplicationVersionNumber.BackColor = System.Drawing.SystemColors.Control;
            this.label_ApplicationVersionNumber.Location = new System.Drawing.Point(588, 29);
            this.label_ApplicationVersionNumber.Name = "label_ApplicationVersionNumber";
            this.label_ApplicationVersionNumber.Size = new System.Drawing.Size(380, 19);
            this.label_ApplicationVersionNumber.TabIndex = 8;
            this.label_ApplicationVersionNumber.Text = "label_ApplicationVersionNumber";
            this.label_ApplicationVersionNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(182)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 509);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(962, 47);
            this.label3.TabIndex = 10;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(134)))), ((int)(((byte)(33)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(16, 8);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(959, 18);
            this.label5.TabIndex = 10;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Enabled = false;
            this.pictureBox3.Image = global::ConfigureStartPowerShellScript_01.Properties.Resources.Novetta_45x45_SystemBackground;
            this.pictureBox3.Location = new System.Drawing.Point(123, 509);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(994, 569);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_ApplicationVersionNumber);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 575);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 575);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Main.ResumeLayout(false);
            this.Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_HDD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox_Attribution.ResumeLayout(false);
            this.groupBox_Attribution.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Troubleshooting.ResumeLayout(false);
            this.Troubleshooting.PerformLayout();
            this.tabPage_Machine1PowerShellScript.ResumeLayout(false);
            this.tabPage_Machine1PowerShellScript.PerformLayout();
            this.tabPage_Machine2PowerShellScript.ResumeLayout(false);
            this.tabPage_Machine2PowerShellScript.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox_FirstVMSelection;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Main;
        private System.Windows.Forms.TabPage Troubleshooting;
        private System.Windows.Forms.Button button_OpenHyperVManager;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_SecondVMSelection;
        private System.Windows.Forms.Label labelSecondVMSelection;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabPage tabPage_Machine1PowerShellScript;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_OpenWindowsExplorer;
        private System.Windows.Forms.Button button_OpenPowerShell;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button_OpenRDPSession;
        private System.Windows.Forms.Label label_ApplicationVersionNumber;
        private System.Windows.Forms.Button button_ResetSelection;
        private System.Windows.Forms.Label label_VMStartNotification;
        private System.Windows.Forms.GroupBox groupBox_Attribution;
        private System.Windows.Forms.RadioButton radioButton_ServerBasedAttribution;
        private System.Windows.Forms.RadioButton radioButton_StandaloneAttribution;
        private System.Windows.Forms.Button button_OpenFormCheckServerActivationStatus;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button_ShutdownComputer;
        private System.Windows.Forms.Button button_RestartComputer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_StartOrKillVMs;
        private System.Windows.Forms.TabPage tabPage_Machine2PowerShellScript;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox_PersistentDisk;
        private System.Windows.Forms.PictureBox pictureBox_HDD;
        private System.Windows.Forms.Button button_OpenDateTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button_RestartLocalMedusa;
        private System.Windows.Forms.Button button_OpenImgBurn;
        private System.Windows.Forms.Button button_DeleteRecreatePersistentDisk;
        private System.Windows.Forms.RadioButton radioButton_StandaloneManagedAttribution;
        private System.Windows.Forms.Button button_OpenHostAVSoftware;
        private System.Windows.Forms.Button button_ChangeDisplayProperties;
        private System.Windows.Forms.Button button_ReopenEstablishedRDPSession_1;
        private System.Windows.Forms.Button button_ReopenEstablishedRDPSession_2;
        private System.Windows.Forms.CheckBox checkBox_MultiMonVM2;
        private System.Windows.Forms.CheckBox checkBox_MultiMonVM1;
        private System.Windows.Forms.Button button_OpenSconfig;
        private System.Windows.Forms.PictureBox pictureBox3;

        //
        //array?
        //

    }
}

