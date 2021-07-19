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

namespace CSE9008
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection (@"Data Source=LAPTOP-HSLGN5V9\SQLEXPRESS;Initial Catalog=Tailor;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            display_data();
          
        }

        private void I_button_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Tailor values('" + Name_textBox.Text + "','" + Add_textBox.Text + "','" + Contact_textBox.Text + "','" + Ot_comboBox.SelectedItem.ToString() + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "','" + Assgn_comboBox.SelectedItem.ToString() + "','" + Remarks_textBox.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            Name_textBox.Text = "";
            Add_textBox.Text = "";
            Contact_textBox.Text = "";
            Ot_comboBox.SelectedItem = "";
            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";
            Assgn_comboBox.SelectedItem = "";
            Remarks_textBox.Text = "";
            display_data();
            MessageBox.Show("Insertion Successfull");
          }
        public void display_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from Tailor";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void S_button_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from Tailor where name='" + Name_textBox.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
