namespace s3totsGUI
{
    partial class s2totsGUI
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
            this.tyFilesList = new System.Windows.Forms.ListBox();
            this.addFilesButton = new System.Windows.Forms.Button();
            this.removeFilesButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.startButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.outputFolder = new System.Windows.Forms.Label();
            this.outputFolderBox = new System.Windows.Forms.TextBox();
            this.outputFolderBrowse = new System.Windows.Forms.Button();
            this.sourceFiles = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tyFilesList
            // 
            this.tyFilesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tyFilesList.FormattingEnabled = true;
            this.tyFilesList.Location = new System.Drawing.Point(15, 25);
            this.tyFilesList.Name = "tyFilesList";
            this.tyFilesList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.tyFilesList.Size = new System.Drawing.Size(565, 251);
            this.tyFilesList.TabIndex = 0;
            this.tyFilesList.SelectedIndexChanged += new System.EventHandler(this.tyFilesList_SelectedIndexChanged);
            // 
            // addFilesButton
            // 
            this.addFilesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addFilesButton.Location = new System.Drawing.Point(586, 25);
            this.addFilesButton.Name = "addFilesButton";
            this.addFilesButton.Size = new System.Drawing.Size(26, 23);
            this.addFilesButton.TabIndex = 1;
            this.addFilesButton.Text = "+";
            this.addFilesButton.UseVisualStyleBackColor = true;
            this.addFilesButton.Click += new System.EventHandler(this.addFilesButton_Click);
            // 
            // removeFilesButton
            // 
            this.removeFilesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeFilesButton.Enabled = false;
            this.removeFilesButton.Location = new System.Drawing.Point(586, 54);
            this.removeFilesButton.Name = "removeFilesButton";
            this.removeFilesButton.Size = new System.Drawing.Size(26, 23);
            this.removeFilesButton.TabIndex = 2;
            this.removeFilesButton.Text = "-";
            this.removeFilesButton.UseVisualStyleBackColor = true;
            this.removeFilesButton.Click += new System.EventHandler(this.removeFilesButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(12, 332);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(568, 23);
            this.progressBar.Step = 1;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 3;
            // 
            // startButton
            // 
            this.startButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.startButton.Enabled = false;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(222, 380);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(149, 49);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // outputFolder
            // 
            this.outputFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.outputFolder.AutoSize = true;
            this.outputFolder.Location = new System.Drawing.Point(12, 298);
            this.outputFolder.Name = "outputFolder";
            this.outputFolder.Size = new System.Drawing.Size(74, 13);
            this.outputFolder.TabIndex = 5;
            this.outputFolder.Text = "Output Folder:";
            // 
            // outputFolderBox
            // 
            this.outputFolderBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputFolderBox.Location = new System.Drawing.Point(92, 295);
            this.outputFolderBox.Name = "outputFolderBox";
            this.outputFolderBox.Size = new System.Drawing.Size(456, 20);
            this.outputFolderBox.TabIndex = 6;
            this.outputFolderBox.TextChanged += new System.EventHandler(this.outputFolderBox_TextChanged);
            // 
            // outputFolderBrowse
            // 
            this.outputFolderBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.outputFolderBrowse.Location = new System.Drawing.Point(554, 295);
            this.outputFolderBrowse.Name = "outputFolderBrowse";
            this.outputFolderBrowse.Size = new System.Drawing.Size(26, 21);
            this.outputFolderBrowse.TabIndex = 7;
            this.outputFolderBrowse.Text = "...";
            this.outputFolderBrowse.UseVisualStyleBackColor = true;
            this.outputFolderBrowse.Click += new System.EventHandler(this.outputFolderBrowse_Click);
            // 
            // sourceFiles
            // 
            this.sourceFiles.AutoSize = true;
            this.sourceFiles.Location = new System.Drawing.Point(12, 9);
            this.sourceFiles.Name = "sourceFiles";
            this.sourceFiles.Size = new System.Drawing.Size(68, 13);
            this.sourceFiles.TabIndex = 8;
            this.sourceFiles.Text = "Source Files:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(510, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "© Dan Haddix 2016";
            // 
            // s2totsGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sourceFiles);
            this.Controls.Add(this.outputFolderBrowse);
            this.Controls.Add(this.outputFolderBox);
            this.Controls.Add(this.outputFolder);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.removeFilesButton);
            this.Controls.Add(this.addFilesButton);
            this.Controls.Add(this.tyFilesList);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "s2totsGUI";
            this.ShowIcon = false;
            this.Text = "s3totsGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox tyFilesList;
        private System.Windows.Forms.Button addFilesButton;
        private System.Windows.Forms.Button removeFilesButton;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button startButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label outputFolder;
        private System.Windows.Forms.TextBox outputFolderBox;
        private System.Windows.Forms.Button outputFolderBrowse;
        private System.Windows.Forms.Label sourceFiles;
        private System.Windows.Forms.Label label1;
    }
}

