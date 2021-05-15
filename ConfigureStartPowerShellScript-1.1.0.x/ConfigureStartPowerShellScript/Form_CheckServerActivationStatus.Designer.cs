namespace ConfigureStartPowerShellScript_01
{
    partial class Form_CheckServerActivationStatus
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_RearmWindows = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ConfigureStartPowerShellScript_01.Properties.Resources.activationstatus;
            this.pictureBox1.Location = new System.Drawing.Point(389, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 289);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button_RearmWindows
            // 
            this.button_RearmWindows.Location = new System.Drawing.Point(389, 340);
            this.button_RearmWindows.Name = "button_RearmWindows";
            this.button_RearmWindows.Size = new System.Drawing.Size(302, 44);
            this.button_RearmWindows.TabIndex = 1;
            this.button_RearmWindows.Text = "Rearm and Restart Windows";
            this.button_RearmWindows.UseVisualStyleBackColor = true;
            this.button_RearmWindows.Click += new System.EventHandler(this.button_RearmWindows_Click);
            // 
            // Form_CheckServerActivationStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 451);
            this.Controls.Add(this.button_RearmWindows);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form_CheckServerActivationStatus";
            this.Text = "Check Server Activation Status";
            this.Load += new System.EventHandler(this.Form_CheckServerActivationStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_RearmWindows;
    }
}