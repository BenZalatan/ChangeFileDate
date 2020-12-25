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

namespace ChangeFileDate
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                tboxSelectedFile.Text = ofd.FileName;
                try
                {
                    dtpDate.Value = File.GetCreationTime(ofd.FileName);
                }
                catch { dtpDate.Value = DateTime.Now; }
            }
        }

        private void btnNow_Click(object sender, EventArgs e)
        {
            dtpDate.Value = DateTime.Now;
        }

        private void tboxSelectedFile_TextChanged(object sender, EventArgs e)
        {
            btnSet.Enabled = tboxSelectedFile.Text.Length > 0;
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboxCreationTime.Checked)
                {
                    File.SetCreationTime(tboxSelectedFile.Text, dtpDate.Value);
                }
                if (cboxLastWriteTime.Checked)
                {
                    File.SetLastWriteTime(tboxSelectedFile.Text, dtpDate.Value);
                }
                if (cboxLastAccessTime.Checked)
                {
                    File.SetLastAccessTime(tboxSelectedFile.Text, dtpDate.Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
