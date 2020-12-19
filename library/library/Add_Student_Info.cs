using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace library
{
    public partial class Add_Student_Info : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-HSLGN5V9\\SQLEXPRESS;Initial Catalog=Library_Management;Integrated Security=True");
        public Add_Student_Info()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Student_info values('" + Name_textBox.Text + "','" + Enrollment_textBox.Text + "','" + Dept_textBox.Text + "','" + Sem_textBox.Text + "','" + Email_textBox.Text + "','" + Contact_textBox.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Insertion Successfull");
            }
            catch(Exception ex)
            {
                MessageBox.Show("ex.Message.ToString()"); 
            }
        }
    }
}
