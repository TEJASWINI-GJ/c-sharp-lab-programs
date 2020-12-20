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
    public partial class Return_Books : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-HSLGN5V9\\SQLEXPRESS;Initial Catalog=Library_Management;Integrated Security=True");
        public Return_Books()
        {
            InitializeComponent();
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            fill_grid(Enrolment_textBox.Text);
        }

        private void Return_Books_Load(object sender, EventArgs e)
        {
            if(con.State==ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }
        public void fill_grid(String Enrolment)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from Issue_book where Student_Enrolment='"+Enrolment.ToString()+"' and Books_Return_Date=''";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel3.Visible = true;
            int i;
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from Issue_book where Id='"+i+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                label4.Text = dr["Books_Name"].ToString();
                label6.Text = dr["Books_Issue_Date"].ToString();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void Return_button_Click(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Issue_book set Books_Return_Date='"+dateTimePicker1.Value.ToString()+"' where Id='"+i+"'";
            cmd.ExecuteNonQuery();


            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "update Books_info set Available_Quantity=Available_Quantity+1 where Books_Name='"+label4.Text+"'";
            cmd1.ExecuteNonQuery();

            MessageBox.Show("Books Returned Successfully");
           
            panel3.Visible = true;

            fill_grid(Enrolment_textBox.Text);
        }
    }
}
