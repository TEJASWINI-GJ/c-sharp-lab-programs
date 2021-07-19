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


//Tejaswini.G.J
//2018CSE0746
namespace Endterm0746
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tejaswini\Documents\testing.mdf;Integrated Security=True;Connect Timeout=30");

        public Form1()
        {
            InitializeComponent();
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Employee values('"+id_textBox.Text+"','" + Name_textBox.Text + "','" + Address_textBox.Text + "','" + Contact_textBox.Text + "','" + Type_comboBox.ToString() + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "','" + Assigned_comboBox.ToString() + "','"+Remarks_textBox.Text+"')";
            cmd.ExecuteNonQuery();
            con.Close();
            id_textBox.Text = "";
            Name_textBox.Text = "";
            Address_textBox.Text = "";
            Contact_textBox.Text = "";
            Type_comboBox.ToString();
            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";
            Assigned_comboBox.ToString();
            Remarks_textBox.Text = "";
            display_data();
            MessageBox.Show("Information Saved");
        }

        public void display_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from Employee";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Type_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Assigned_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            display_data();
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from Employee";
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    Type_comboBox.Items.Add(reader);
                }
                con.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void Search_button_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from Employee where name='"+Name_textBox.Text+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
