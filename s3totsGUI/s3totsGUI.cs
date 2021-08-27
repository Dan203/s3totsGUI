using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace s3totsGUI
{
    public partial class s2totsGUI : System.Windows.Forms.Form
    {
        static bool IsWorking { get; set; }

        public s2totsGUI()
        {
            InitializeComponent();
        }

        private void addFilesButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "TiVo Ty Files (*.ty)|*.ty|All files (*.*)|*.*";
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.Multiselect = true;
            openFileDialog.Title = "Select TiVo Files";

            DialogResult dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                foreach (String file in openFileDialog.FileNames)
                {
                    bool addFile = true;
                    foreach (String fileName in tyFilesList.Items)
                    {
                        if (fileName.CompareTo(file) == 0)
                        {
                            addFile = false;
                            break;
                        }
                    }

                    if (addFile)
                    {
                        tyFilesList.Items.Add(file);
                    }
                }

                if (tyFilesList.Items.Count > 0 && tyFilesList.SelectedIndex == -1)
                {
                    tyFilesList.SelectedIndex = 0;
                }
            }
        }

        private void removeFilesButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = tyFilesList.SelectedIndex;

            for (int i = tyFilesList.SelectedItems.Count - 1; i >= 0; i--)
            {
                tyFilesList.Items.Remove(tyFilesList.SelectedItems[i]);
            }

            if (selectedIndex > tyFilesList.Items.Count - 1)
            {
                selectedIndex = tyFilesList.Items.Count - 1;
            }

            tyFilesList.SelectedIndex = selectedIndex;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            IsWorking = !IsWorking;
            if (IsWorking)
            {
                backgroundWorker1.RunWorkerAsync();
            }
            else
            {
                backgroundWorker1.CancelAsync();
            }

            UpdateUserInterface();
        }

        private void tyFilesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUserInterface();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            // Create output file name
            String sourceFile = tyFilesList.Items[0].ToString();
            String outputFolder = outputFolderBox.Text;
            String outputFile = Path.Combine(outputFolder, Path.GetFileNameWithoutExtension(sourceFile)+".ts");

            // Only allow unique file names
            int count = 1;
            while (File.Exists(outputFile))
            {
                outputFile = Path.Combine(outputFolder, Path.GetFileNameWithoutExtension(sourceFile) + $" ({count}).ts");
                count++;
            }

            // Launch s3tots
            Process process = new Process();
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.FileName = "s3tots.exe";
            process.StartInfo.Arguments = $"-y -i \"{sourceFile}\" -o \"{outputFile}\"";
            process.Start();

            // Report progress
            while (!process.WaitForExit(100))
            {
                if (backgroundWorker1.CancellationPending)
                {
                    process.Kill();
                    e.Cancel = true;
                    break;
                }

                FileInfo sourceFileInfo = new FileInfo(sourceFile);
                FileInfo outputFileInfo = new FileInfo(outputFile);

                double percentComplete = (((double)outputFileInfo.Length*1.4) / (double)sourceFileInfo.Length)*100.0;
                if (percentComplete > 100)
                {
                    percentComplete = 100;
                }

                backgroundWorker1.ReportProgress((int)percentComplete);
            }
        }

        private void outputFolderBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowseDialog = new FolderBrowserDialog();
            folderBrowseDialog.SelectedPath = outputFolderBox.Text;
            folderBrowseDialog.Description = "Select Output Folder";           

            DialogResult dialogResult = folderBrowseDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                outputFolderBox.Text = folderBrowseDialog.SelectedPath;
                UpdateUserInterface();
            }
        }

        private void outputFolderBox_TextChanged(object sender, EventArgs e)
        {
            UpdateUserInterface();
        }

        private void UpdateUserInterface()
        {
            if (tyFilesList.Items.Count > 0 && Directory.Exists(outputFolderBox.Text))
            {
                startButton.Enabled = true;
            }
            else
            {
                startButton.Enabled = false;
            }


            if (IsWorking)
            {
                startButton.Text = "Stop";
                removeFilesButton.Enabled = false;
            }
            else
            {
                startButton.Text = "Start";
            }

            if (tyFilesList.SelectedItems.Count > 0)
            {
                removeFilesButton.Enabled = true;
            }
            else
            {
                removeFilesButton.Enabled = false;
            }           
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                tyFilesList.Items.RemoveAt(0);
                if (tyFilesList.Items.Count > 0)
                {
                    progressBar.Value = 0;
                    backgroundWorker1.RunWorkerAsync();
                }
                else
                {
                    IsWorking = false;
                    progressBar.Value = 0;
                    UpdateUserInterface();
                }
            }
            else
            {
                IsWorking = false;
                progressBar.Value = 0;
                UpdateUserInterface();
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }
    }
}
