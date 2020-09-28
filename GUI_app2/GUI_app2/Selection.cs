﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_app2
{
    public partial class Selection : Form
    {
        public Selection()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void stream_groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void engg_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (engg_radioButton.Checked)
            {
                engg_groupBox.Visible = true;
            }
            else
                engg_groupBox.Visible = false;

        }

        private void law_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (law_radioButton.Checked)
            {
                law_groupBox.Visible = true;
            }
            else
                law_groupBox.Visible = false;

        }

        private void mba_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (mba_radioButton.Checked)
            {
                mba_groupBox.Visible = true;
            }
            else
                mba_groupBox.Visible = false;

        }

        private void bca_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (bca_radioButton.Checked)
            {
                bca_groupBox.Visible = true;
            }
            else
                bca_groupBox.Visible = false;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void submit_Button_Click(object sender, EventArgs e)
        {

            string selectedCourse = GetSelection();
            MessageBox.Show("you have applied/choosen " + selectedCourse, "Congragulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string GetSelection()
        {

            if (engg_radioButton.Checked)
            {
                {
                    if (cse_radioButton.Checked)
                        return "CSE";
                    else if (civil_radioButton.Checked)
                        return "Civil";
                    else if (mech_radioButton.Checked)
                        return "Mechanical";
                    else if (comm_radioButton.Checked)
                        return "Communication";
                    else if (petro_radioButton.Checked)
                        return "Petroleum";



                    else
                        return "No branch is selected";
                }
            }
            else
                return "null";





        }
          

               /* if (law_radioButton.Checked)
                {

                    if (llb_radioButton.Checked)
                        return "LL.B";
                    else if (llm_radioButton.Checked)
                        return "LL.M";
                    else if (mbl_radioButton.Checked)
                        return "M.Bussiness Law";
                    else if (dtl_radioButton.Checked)
                        return "DTL";*/


                 

           

        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void mbl_radioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void llm_radioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void law_groupBox_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }

}


















