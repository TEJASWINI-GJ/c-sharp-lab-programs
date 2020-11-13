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
namespace searching
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }



        private void Search_button_Click(object sender, EventArgs e)
        {
            listBox1.SelectedItems.Clear();
            for (int i = listBox1.Items.Count - 1; i >= 0; i--)
            {
                if (listBox1.Items[i].ToString().ToLower().Contains(Search_textBox.Text.ToLower()))
              // if(listBox1.Items[i].ToString().Contains(Search_textBox.Text))

                {
                    listBox1.SetSelected(i, true);

                }
            }
      

        }
    
    }
}
