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
using System.Data.Sql;


namespace DB_demo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Fetch_button_Click(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database2.mdf;"+"Integrated Security=True");
            myConnection.Open();
            SqlCommand myCommand = new SqlCommand("Select * from Student", myConnection);
           SqlDataReader myReader =  myCommand.ExecuteReader();
            while (myReader.Read())
            {
                dataGridView1.Rows.Add(myReader.GetInt32(0), myReader.GetString(1), myReader.GetString(2), myReader.GetInt32(3));
            }
        }
    }
}
