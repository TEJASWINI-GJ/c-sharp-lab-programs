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
    public partial class Issue_Books : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-HSLGN5V9\\SQLEXPRESS;Initial Catalog=Library_Management;Integrated Security=True");
        public Issue_Books()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            int i;
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from Student_info where Student_Enrolment='" + Enrolment_textBox.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            if (i == 0)
            {
                MessageBox.Show("This Enrolment Not Found");
            }
            else
            {
                foreach (DataRow dr in dt.Rows)
                {
                    Sname_textBox.Text = dr["Student_Name"].ToString();
                    Dept_textBox.Text = dr["Student_Dept"].ToString();
                    Sem_textBox.Text = dr["Student_Semester"].ToString();
                    Contact_textBox.Text = dr["Student_Contact"].ToString();
                    Email_textBox.Text = dr["Student_Email"].ToString();

                }

            }
        }

        private void Issue_Books_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        private void Isuue_button_Click(object sender, EventArgs e)
        {
            int book_qty=0;
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select * from Books_info where Books_Name='"+Bname_textBox.Text+"'";
            cmd2.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);
            foreach(DataRow dr2 in dt2.Rows)
            {
                book_qty = Convert.ToInt32(dr2["Available_Quantity"].ToString());
            }
            if (book_qty > 0)
            {

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Issue_book values('" + Enrolment_textBox.Text + "','" + Sname_textBox.Text + "','" + Dept_textBox.Text + "','" + Sem_textBox.Text + "','" + Contact_textBox.Text + "','" + Email_textBox.Text + "','" + Bname_textBox.Text + "','" + dateTimePicker1.Value.ToString() + "','')";
                cmd.ExecuteNonQuery();


                SqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "update Books_info set Available_Quantity=Available_Quantity-1 where Books_Name= '" + Bname_textBox.Text + "' ";
                cmd1.ExecuteNonQuery();

                MessageBox.Show("Book Issue Successfull");
            }
            else
            {
                MessageBox.Show("No Books Available");
            }

        }

        private void Bname_textBox_KeyUp(object sender, KeyEventArgs e)
        {
            int count = 0;
            if (e.KeyCode != Keys.Enter)
            {
                listBox1.Items.Clear();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from Books_info where Books_Name like('%" + Bname_textBox.Text + "%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                count = Convert.ToInt32(dt.Rows.Count.ToString());

                if (count > 0)
                {
                    listBox1.Visible = true;
                    foreach (DataRow dr in dt.Rows)
                    {
                        listBox1.Items.Add(dr["Books_Name"].ToString());
                    }
                }
            }
        }

        private void Bname_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                listBox1.Focus();
                listBox1.SelectedIndex = 0;
            }
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Bname_textBox.Text = listBox1.SelectedItem.ToString();
                listBox1.Visible = false;
            }
        }
    }
}