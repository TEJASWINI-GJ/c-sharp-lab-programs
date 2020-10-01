using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mypictureview
{
    public partial class mypictureview_Form : Form
    {
        string dirpath;
        static int i = 0;
        public mypictureview_Form()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showPicture_button_Click(object sender, EventArgs e)
        {
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                dirpath = openFileDialog1.FileName;
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void clearPicture_button_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void backgroundColor_button_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void stretch_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (stretch_checkBox.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }


        private void next_button_Click_1(object sender, EventArgs e)
        {
            //MessageBox.Show(dirpath);
            FileInfo fInfo = new FileInfo(dirpath);
            DirectoryInfo dInfo = fInfo.Directory;
            FileInfo[] lfiles = dInfo.GetFiles("*.png");
          //  MessageBox.Show(lfiles.Length.ToString());
            if (i < lfiles.Length)
                pictureBox1.Load(lfiles[i++].FullName);
            else
            {
                i = 0;
                pictureBox1.Load(lfiles[i++].FullName);
            }

        }

        private void previous_button_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dirpath);
            FileInfo fInfo = new FileInfo(dirpath);
            DirectoryInfo dInfo = fInfo.Directory;
            FileInfo[] lfiles = dInfo.GetFiles("*.png");
            //  MessageBox.Show(lfiles.Length.ToString());
            if (i < lfiles.Length)
                pictureBox1.Load(lfiles[i--].FullName);
            else
            {
               i = 0;
                pictureBox1.Load(lfiles[i--].FullName);
            }

        }
    }
}
