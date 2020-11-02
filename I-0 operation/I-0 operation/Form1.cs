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

/* Read a text file
Write a text file
View file information
List disk drives
List folders
List files*/

namespace I_0_operation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Select_button_Click(object sender, EventArgs e)
        {
            const double oneKB = 1024.0;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //clear the items
                listBox1.Items.Clear();
               
                //Add the properties of the selected file to the list box
                string filename = openFileDialog1.FileName;

                //MessageBox.Show(filename);
                FileInfo fInfo = new FileInfo(filename);
                listBox1.Items.Add("Full Name" + fInfo.FullName);
                listBox1.Items.Add("Parent Directory" + fInfo.Directory);
                listBox1.Items.Add("Creation Time" + fInfo.CreationTime);
                listBox1.Items.Add("Size in KB" + fInfo.Length / 1024);
                //FileAttributes fAttributes = fInfo.Attributes;
                listBox1.Items.Add("ReadOnly:" + fInfo.IsReadOnly);
            }
        }

        private void Drive_button_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            //list of disk drives.
            foreach (string drive in Directory.GetLogicalDrives())
            {
                listBox1.Items.Add(drive);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(listBox1.SelectedItem.ToString());
                String selectedItem=listBox1.SelectedItem.ToString();

                  if (listBox1.SelectedItem.ToString() == @"C:\")
                  {
                      listBox1.Items.Clear();
                      foreach (String directory in Directory.GetDirectories(@"C:\"))
                      {
                          listBox1.Items.Add(directory);
                      }
                  }

               

            else
            {
                if (selectedItem != null)
                {
                    listBox1.Items.Clear();
                    DirectoryInfo dInfo = null;
                   dInfo = new DirectoryInfo(selectedItem);
                    foreach (FileInfo fInfo in dInfo.GetFiles())
                    {
                        listBox1.Items.Add(fInfo.Name);
                    }
                    foreach (FileInfo fInfo in dInfo.GetFiles())
                    {
                        listBox1.Items.Add(fInfo.Name);
                    }
                }
                else
                {
                    MessageBox.Show("ntg is present");
                }
            }
        }
     }
  }
           





