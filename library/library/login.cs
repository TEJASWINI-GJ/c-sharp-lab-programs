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
    public partial class login : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-HSLGN5V9\\SQLEXPRESS;Initial Catalog=Library_Management;Integrated Security=True");
        int count = 0;
        public login()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from library_person where Username='"+ textBox1.Text +"' and  Password='"+ textBox2.Text +"'" ;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            count = Convert.ToInt32( dt.Rows.Count.ToString());
            if(count==0)
            {
                MessageBox.Show("Password does not match");
            }
            else
            {
                this.Hide();
                MDI_User mu = new MDI_User();
                mu.Show();
              
            }

        }

        private void login_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }
    }
}
