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

namespace I_O_operation1
{
    public partial class Form1 : Form
    {
        private readonly String initialDirectory = @"C:\\Users\\Tejaswini\\Desktop\\c#";
        private readonly String fileFilter = "plain Text Format (*.txt)|*.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Open_button_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = fileFilter;
            openFileDialog1.InitialDirectory = initialDirectory;
            StreamReader reader = null;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    reader = new StreamReader(openFileDialog1.FileName);
                    textBox1.Text = reader.ReadToEnd();
                }

                catch (FileNotFoundException)
                {
                    MessageBox.Show("file not found");
                }
                catch (Exception e2)
                {
                    MessageBox.Show(e2.Message, "Error");
                }
                finally
                {
                    if (reader != null)
                        reader.Close();
                }

            }
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = initialDirectory;
            saveFileDialog1.Filter = fileFilter;
            saveFileDialog1.ShowDialog();
            StreamWriter writer = null;

            try
            {
                writer = new StreamWriter(saveFileDialog1.FileName);
                writer.Write(textBox1.Text);
            }
            catch (DirectoryNotFoundException e1)
            {
                MessageBox.Show("check the specified directory." + e1.Message, "error");
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message, "Error Occured");
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }
    }
}
