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

namespace UniqueText
{
    public partial class frmMain : Form
    {
        static AppDataAccess apaccess_;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            ProcessUniqueText(txtDBPath.Text, txtFileFolderPath.Text);
        }

        private void btnDBPath_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtDBPath.Text = openFileDialog1.FileName;   
            }
        }

        private void btnSelectFilePath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFileFolderPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }


        private void ProcessUniqueText(string db_file_path,string file_folder_path)
        {
            StreamReader sr;
            apaccess_ = new AppDataAccess(txtDBPath.Text);
            CheckForIllegalCrossThreadCalls = false;

            string[] text_files_ = Directory.GetFiles(file_folder_path, "*.txt", SearchOption.AllDirectories);
            foreach (var text_file_ in text_files_)
            {
                using (FileStream fs = new FileStream(text_file_, FileMode.Open, FileAccess.Read))
                {
                    using (BufferedStream bfs = new BufferedStream(fs))
                    {
                        sr = new StreamReader(bfs,Encoding.UTF8);
                        int i = 0;
                        while (!sr.EndOfStream)
                        {
                            ++i;
                            if (i % 1 == 0) 
                            { 
                                lblCounter.Text = string.Format("Processing Line Number--{0}", i);
                                lblCounter.Refresh();
                            }
                            string line_ = sr.ReadLine();
                            var d = apaccess_.InsertLine(line_);
                        }
                        i = 0;
                    }
                }
            }




        }






    }
}
