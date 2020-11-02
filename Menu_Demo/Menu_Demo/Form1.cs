using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_Demo
{
    public partial class Form1 : Form
    {
        private readonly string fileFilter = "Rich Text Format (.rtf)|*.rtf|Plain Text Format (.txt)|*.txt";
        private readonly string intialDirectory = @"C:\Users\Tejaswini\Desktop\menu c#";
        public Form1()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

      

       
       

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void newToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ToolStripMenuItem newMenuitem = sender as ToolStripMenuItem;
            toolStripStatusLabel1.Text = newMenuitem.Text;
            richTextBox1.Clear();
        }

        private void saveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = intialDirectory;
            saveFileDialog1.Filter = fileFilter;
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk_1(object sender, CancelEventArgs e)
        {
            if (saveFileDialog1.FileName != null)
            {
                if (saveFileDialog1.Filter.Contains(".txt"))
                {

                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                }
                else

                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {
            toolStripStatusLabel1.Text = e.ClickedItem.ToString();
        }

        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.Filter = fileFilter;
            openFileDialog1.InitialDirectory = intialDirectory;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.FileName != null)
                {
                    if (openFileDialog1.FileName.Contains(".txt"))
                        richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                    else
                        richTextBox1.LoadFile(openFileDialog1.FileName);
                }
                else
                {
                    MessageBox.Show("Empty file name", "Error");
                }
            }
        }
    }
}

