namespace ConfigureStartPowerShellScript_01
{
    partial class Form_DisplayProperties
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DisplayProperties));
            this.button_IntelHDGraphicsControlPanel = new System.Windows.Forms.Button();
            this.button_NVIDIAControlPanel = new System.Windows.Forms.Button();
            this.button_ATIControlPanel = new System.Windows.Forms.Button();
            this.button_CloseDisplayProperties = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_IntelHDGraphicsControlPanel
            // 
            this.button_IntelHDGraphicsControlPanel.Location = new System.Drawing.Point(28, 35);
            this.button_IntelHDGraphicsControlPanel.Name = "button_IntelHDGraphicsControlPanel";
            this.button_IntelHDGraphicsControlPanel.Size = new System.Drawing.Size(142, 50);
            this.button_IntelHDGraphicsControlPanel.TabIndex = 0;
            this.button_IntelHDGraphicsControlPanel.Text = "Intel HD Graphics Control Panel";
            this.button_IntelHDGraphicsControlPanel.UseVisualStyleBackColor = true;
            this.button_IntelHDGraphicsControlPanel.Click += new System.EventHandler(this.button_IntelHDGraphicsControlPanel_Click);
            // 
            // button_NVIDIAControlPanel
            // 
            this.button_NVIDIAControlPanel.Location = new System.Drawing.Point(28, 104);
            this.button_NVIDIAControlPanel.Name = "button_NVIDIAControlPanel";
            this.button_NVIDIAControlPanel.Size = new System.Drawing.Size(142, 50);
            this.button_NVIDIAControlPanel.TabIndex = 1;
            this.button_NVIDIAControlPanel.Text = "NVIDIA Control Panel";
            this.button_NVIDIAControlPanel.UseVisualStyleBackColor = true;
            this.button_NVIDIAControlPanel.Click += new System.EventHandler(this.button_NVIDIAControlPanel_Click);
            // 
            // button_ATIControlPanel
            // 
            this.button_ATIControlPanel.Location = new System.Drawing.Point(28, 173);
            this.button_ATIControlPanel.Name = "button_ATIControlPanel";
            this.button_ATIControlPanel.Size = new System.Drawing.Size(142, 50);
            this.button_ATIControlPanel.TabIndex = 2;
            this.button_ATIControlPanel.Text = "ATI Control Panel";
            this.button_ATIControlPanel.UseVisualStyleBackColor = true;
            this.button_ATIControlPanel.Click += new System.EventHandler(this.button_ATIControlPanel_Click);
            // 
            // button_CloseDisplayProperties
            // 
            this.button_CloseDisplayProperties.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_CloseDisplayProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CloseDisplayProperties.Location = new System.Drawing.Point(28, 392);
            this.button_CloseDisplayProperties.Name = "button_CloseDisplayProperties";
            this.button_CloseDisplayProperties.Size = new System.Drawing.Size(142, 50);
            this.button_CloseDisplayProperties.TabIndex = 3;
            this.button_CloseDisplayProperties.Text = "Close Display Properties";
            this.button_CloseDisplayProperties.UseVisualStyleBackColor = true;
            this.button_CloseDisplayProperties.Click += new System.EventHandler(this.button_CloseDisplayProperties_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 242);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form_DisplayProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 474);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_CloseDisplayProperties);
            this.Controls.Add(this.button_ATIControlPanel);
            this.Controls.Add(this.button_NVIDIAControlPanel);
            this.Controls.Add(this.button_IntelHDGraphicsControlPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form_DisplayProperties";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Display Properties";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form_DisplayProperties_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_IntelHDGraphicsControlPanel;
        private System.Windows.Forms.Button button_NVIDIAControlPanel;
        private System.Windows.Forms.Button button_ATIControlPanel;
        private System.Windows.Forms.Button button_CloseDisplayProperties;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}