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
    public partial class add_books : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-HSLGN5V9\\SQLEXPRESS;Initial Catalog=Library_Management;Integrated Security=True");
        public add_books()
        {
            InitializeComponent();
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into Books_info values('"+ Name_textBox.Text +"','"+Author_TextBox.Text+"','"+dateTimePicker1.Text+"',"+Price_TextBox.Text+","+Quantity_TextBox.Text+","+ Quantity_TextBox.Text +")";
            cmd.ExecuteNonQuery();
            con.Close();

            Name_textBox.Text = "";
            Author_TextBox.Text = "";
            Price_TextBox.Text = "";
            Quantity_TextBox.Text = "";
            MessageBox.Show("Insertion Successfull");
        }
    }
}
