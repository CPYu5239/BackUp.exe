using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace BackUp
{
    public partial class MainForm : Form
    {
        FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
        OpenFileDialog openFile = new OpenFileDialog();
        List<string> logInfo = new List<string>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (File.Exists("Log.txt"))
            {
                IEnumerable<string> logTxt = File.ReadLines("Log.txt");
                logInfo = logTxt.ToList();
            }
        }

        private void bt_From_Click(object sender, EventArgs e)
        {
            tB_From.Text = "";
            tB_To.Text = "";

            if (cB_folder.Checked)
            {
                if (folderBrowser.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
                {
                    tB_From.Text = folderBrowser.SelectedPath;
                }
            }
            else
            {
                if (openFile.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(openFile.FileName))
                {
                    tB_From.Text = openFile.FileName;
                }
            }

            if (File.Exists("Log.txt") && tB_From.Text != "")
            {
                IEnumerable<string> logTxt = File.ReadLines("Log.txt"); //get information from log.txt
                logInfo = logTxt.ToList();

                var lastDataTime = logInfo.FindLast(x => x.Contains(tB_From.Text)); //find the same file or folder to get time information
                if (!string.IsNullOrWhiteSpace(lastDataTime))
                {
                    lastDataTime = lastDataTime.Substring(tB_From.Text.Length + 5);
                    label_LastTime.Text = lastDataTime;
                }
                else
                    label_LastTime.Text = "None";
            }
            else if(tB_From.Text == "")
                label_LastTime.Text = "Please select folder or file";
        }

        private void bt_To_Click(object sender, EventArgs e)
        {
            if (folderBrowser.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
            {
                tB_To.Text = folderBrowser.SelectedPath;
            }
        }

        private void bt_BackUp_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tB_From.Text) && !string.IsNullOrWhiteSpace(tB_To.Text))
            {
                BackUp();
                using (StreamWriter w = File.AppendText("Log.txt")) //create log file to record backup information
                {
                    w.WriteLine(tB_From.Text + " --- " + DateTime.Now.ToString("yyyy-M-d H:m:s")); 
                }
            }
            else
            {
                MessageBox.Show("Please select backup information!");
            }
        }
        /// <summary>
        /// BackUp function
        /// </summary>
        private void BackUp()
        {
            string fileName, destFile;

            if (cB_folder.Checked) //backup folder
            {
                string[] files = Directory.GetFiles(tB_From.Text);

                foreach (string file in files)
                {
                    fileName = Path.GetFileName(file);
                    destFile = Path.Combine(tB_To.Text, fileName);
                    File.Copy(file, destFile, true);
                }

                MessageBox.Show("Backup folder succes!");
            }
            else //backup file
            {
                fileName = Path.GetFileName(tB_From.Text);
                destFile = Path.Combine(tB_To.Text, fileName);
                File.Copy(tB_From.Text, destFile, true);

                MessageBox.Show("Backup succes!");
            }
        }
    }
}