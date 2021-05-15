namespace PBOCopier
{
    partial class FormPBOCopier
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
            this.labelSourceDir = new System.Windows.Forms.Label();
            this.labelDestDir = new System.Windows.Forms.Label();
            this.labelNumberofFilesToCopy = new System.Windows.Forms.Label();
            this.labelFileOfFileCopied = new System.Windows.Forms.Label();
            this.labelFileBeingCopied = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timerStart = new System.Windows.Forms.Timer(this.components);
            this.labelResetAttributesNotice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSourceDir
            // 
            this.labelSourceDir.AutoSize = true;
            this.labelSourceDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSourceDir.Location = new System.Drawing.Point(23, 53);
            this.labelSourceDir.Name = "labelSourceDir";
            this.labelSourceDir.Size = new System.Drawing.Size(89, 15);
            this.labelSourceDir.TabIndex = 0;
            this.labelSourceDir.Text = "labelSourceDir";
            // 
            // labelDestDir
            // 
            this.labelDestDir.AutoSize = true;
            this.labelDestDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDestDir.Location = new System.Drawing.Point(23, 106);
            this.labelDestDir.Name = "labelDestDir";
            this.labelDestDir.Size = new System.Drawing.Size(75, 15);
            this.labelDestDir.TabIndex = 0;
            this.labelDestDir.Text = "labelDestDir";
            // 
            // labelNumberofFilesToCopy
            // 
            this.labelNumberofFilesToCopy.AutoSize = true;
            this.labelNumberofFilesToCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberofFilesToCopy.Location = new System.Drawing.Point(23, 144);
            this.labelNumberofFilesToCopy.Name = "labelNumberofFilesToCopy";
            this.labelNumberofFilesToCopy.Size = new System.Drawing.Size(156, 15);
            this.labelNumberofFilesToCopy.TabIndex = 0;
            this.labelNumberofFilesToCopy.Text = "labelNumberofFilesToCopy";
            // 
            // labelFileOfFileCopied
            // 
            this.labelFileOfFileCopied.AutoSize = true;
            this.labelFileOfFileCopied.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFileOfFileCopied.Location = new System.Drawing.Point(23, 164);
            this.labelFileOfFileCopied.Name = "labelFileOfFileCopied";
            this.labelFileOfFileCopied.Size = new System.Drawing.Size(125, 15);
            this.labelFileOfFileCopied.TabIndex = 0;
            this.labelFileOfFileCopied.Text = "labelFileOfFileCopied";
            // 
            // labelFileBeingCopied
            // 
            this.labelFileBeingCopied.AutoSize = true;
            this.labelFileBeingCopied.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFileBeingCopied.Location = new System.Drawing.Point(23, 249);
            this.labelFileBeingCopied.Name = "labelFileBeingCopied";
            this.labelFileBeingCopied.Size = new System.Drawing.Size(125, 15);
            this.labelFileBeingCopied.TabIndex = 0;
            this.labelFileBeingCopied.Text = "labelFileBeingCopied";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(23, 203);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(166, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source Directory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Destination Directory";
            // 
            // timerStart
            // 
            this.timerStart.Tick += new System.EventHandler(this.timerStart_Tick);
            // 
            // labelResetAttributesNotice
            // 
            this.labelResetAttributesNotice.AutoSize = true;
            this.labelResetAttributesNotice.Location = new System.Drawing.Point(23, 347);
            this.labelResetAttributesNotice.Name = "labelResetAttributesNotice";
            this.labelResetAttributesNotice.Size = new System.Drawing.Size(132, 13);
            this.labelResetAttributesNotice.TabIndex = 3;
            this.labelResetAttributesNotice.Text = "labelResetAttributesNotice";
            // 
            // FormPBOCopier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 402);
            this.Controls.Add(this.labelResetAttributesNotice);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelFileBeingCopied);
            this.Controls.Add(this.labelFileOfFileCopied);
            this.Controls.Add(this.labelNumberofFilesToCopy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelDestDir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSourceDir);
            this.Name = "FormPBOCopier";
            this.Text = "PBO Copier";
            this.Load += new System.EventHandler(this.FormPBOCopier_Shown);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPBOCopier_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSourceDir;
        private System.Windows.Forms.Label labelDestDir;
        private System.Windows.Forms.Label labelNumberofFilesToCopy;
        private System.Windows.Forms.Label labelFileOfFileCopied;
        private System.Windows.Forms.Label labelFileBeingCopied;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timerStart;
        private System.Windows.Forms.Label labelResetAttributesNotice;
    }
}

