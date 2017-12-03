namespace UniqueText
{
    partial class frmMain
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
            this.lblDBPath = new System.Windows.Forms.Label();
            this.txtDBPath = new System.Windows.Forms.TextBox();
            this.btnDBPath = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblInputFile = new System.Windows.Forms.Label();
            this.txtFileFolderPath = new System.Windows.Forms.TextBox();
            this.btnSelectFilePath = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lblCounter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDBPath
            // 
            this.lblDBPath.AutoSize = true;
            this.lblDBPath.Location = new System.Drawing.Point(12, 20);
            this.lblDBPath.Name = "lblDBPath";
            this.lblDBPath.Size = new System.Drawing.Size(78, 13);
            this.lblDBPath.TabIndex = 0;
            this.lblDBPath.Text = "Database Path";
            // 
            // txtDBPath
            // 
            this.txtDBPath.Location = new System.Drawing.Point(96, 17);
            this.txtDBPath.Name = "txtDBPath";
            this.txtDBPath.Size = new System.Drawing.Size(399, 20);
            this.txtDBPath.TabIndex = 1;
            // 
            // btnDBPath
            // 
            this.btnDBPath.Location = new System.Drawing.Point(501, 15);
            this.btnDBPath.Name = "btnDBPath";
            this.btnDBPath.Size = new System.Drawing.Size(75, 23);
            this.btnDBPath.TabIndex = 2;
            this.btnDBPath.Text = "Select Path";
            this.btnDBPath.UseVisualStyleBackColor = true;
            this.btnDBPath.Click += new System.EventHandler(this.btnDBPath_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(502, 104);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(75, 38);
            this.btnProcess.TabIndex = 3;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblInputFile
            // 
            this.lblInputFile.AutoSize = true;
            this.lblInputFile.Location = new System.Drawing.Point(12, 56);
            this.lblInputFile.Name = "lblInputFile";
            this.lblInputFile.Size = new System.Drawing.Size(48, 13);
            this.lblInputFile.TabIndex = 4;
            this.lblInputFile.Text = "File Path";
            // 
            // txtFileFolderPath
            // 
            this.txtFileFolderPath.Location = new System.Drawing.Point(96, 56);
            this.txtFileFolderPath.Name = "txtFileFolderPath";
            this.txtFileFolderPath.Size = new System.Drawing.Size(399, 20);
            this.txtFileFolderPath.TabIndex = 5;
            // 
            // btnSelectFilePath
            // 
            this.btnSelectFilePath.Location = new System.Drawing.Point(502, 54);
            this.btnSelectFilePath.Name = "btnSelectFilePath";
            this.btnSelectFilePath.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFilePath.TabIndex = 6;
            this.btnSelectFilePath.Text = "Select Path";
            this.btnSelectFilePath.UseVisualStyleBackColor = true;
            this.btnSelectFilePath.Click += new System.EventHandler(this.btnSelectFilePath_Click);
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounter.Location = new System.Drawing.Point(12, 104);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(65, 17);
            this.lblCounter.TabIndex = 7;
            this.lblCounter.Text = "Counter";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 154);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.btnSelectFilePath);
            this.Controls.Add(this.txtFileFolderPath);
            this.Controls.Add(this.lblInputFile);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.btnDBPath);
            this.Controls.Add(this.txtDBPath);
            this.Controls.Add(this.lblDBPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "UniqueIT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDBPath;
        private System.Windows.Forms.TextBox txtDBPath;
        private System.Windows.Forms.Button btnDBPath;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblInputFile;
        private System.Windows.Forms.TextBox txtFileFolderPath;
        private System.Windows.Forms.Button btnSelectFilePath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label lblCounter;
    }
}

