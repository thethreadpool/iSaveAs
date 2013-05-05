using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace iSaveAs
{
    public partial class iSaveAs : Form
    {
        string[] _filesToConvert;
        ImageFormat _targetFormat = ImageFormat.Jpeg;

        public iSaveAs()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void cmdBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.Multiselect = true;
            openFileDialog1.Title = "Select files to convert";
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                _filesToConvert = openFileDialog1.FileNames;
                txtFilestoConvert.Text = string.Empty;
                foreach (string pathName in openFileDialog1.FileNames)
                {
                    string fileName = pathName.Substring(pathName.LastIndexOf(@"\") + 1);
                    txtFilestoConvert.Text += fileName + "; ";
                }
            }
        }

        private void cmdConvert_Click(object sender, EventArgs e)
        {
            try
            {
                string errMsg = null;
                ImageFormat targetFormat = ImageFormat.Jpeg;
                iSave saver = new iSave();
                if (rdBmp.Checked)
                    targetFormat = ImageFormat.Bmp;
                else if (rdGif.Checked)
                    targetFormat = ImageFormat.Gif;
                else if (rdPng.Checked)
                    targetFormat = ImageFormat.Png;

                bool bypass = false;
                foreach (string fname in openFileDialog1.FileNames)
                {
                    string targetFile = saver.GetTargetFileName(fname, targetFormat);
                    //make sure it's ok to override the file if it already exists
                    if (File.Exists(targetFile))
                    {
                        DialogResult result = MessageBox.Show(string.Format("File {0} already exist. Overwrite?", targetFile), "Overwrite exiting file?", MessageBoxButtons.YesNoCancel);
                        if (result == DialogResult.No)
                            bypass = true;
                        if (result == DialogResult.Cancel)
                            break;
                    }
                    if (!bypass)
                    {
                        errMsg = saver.SaveAs(fname, _targetFormat);
                        if (errMsg != null)
                        {
                            MessageBox.Show(errMsg);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


    }
}