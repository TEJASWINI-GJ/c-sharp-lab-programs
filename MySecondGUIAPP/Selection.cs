using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySecondGUIAPP
{
    public partial class Selection : Form
    {
        public Selection()
        {
            InitializeComponent();
        }

        private void engg_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (engg_RadioButton.Checked)
            {
                engg_GroupBox.Visible = true;
            }
            else
                engg_GroupBox.Visible = false;
        }

        private void submit_Button_Click(object sender, EventArgs e)
        {
            string selectedCourse = GetSelection();
            MessageBox.Show("you have applied/choosen " + selectedCourse,"Congragulations",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private string GetSelection()
        {
            if (engg_RadioButton.Checked)
            {
                if (cse_RadioButton1.Checked)
                    return "CSE";
                else if (electr_RadioButton4.Checked)
                    return "Electronics";
                else if (elec_RadioButton5.Checked)
                    return "Electrical";
                else if (civ_RadioButton6.Checked)
                    return "CIVIL";
                else if (mec_RadioButton3.Checked)
                    return "Mechanical";
                else if (pet_RadioButton7.Checked)
                    return "Petroleum";
                else
                    return "No branch is selected";
            }
            else
                return "null";
        }
    }
}
