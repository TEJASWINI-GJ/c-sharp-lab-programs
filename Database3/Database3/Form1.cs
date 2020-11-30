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

namespace Database3
{
    public partial class Form1 : Form
    {
        private string ConString = Database3.Properties.Settings.Default.StudentDatabaseConnectionString;
        Student myStudent = new Student();
        public Form1()
        {
            InitializeComponent();
            Student_dataGridView.DataSource = myStudent.GetStudent_Details();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Insert_button_Click(object sender, EventArgs e)
        {
            myStudent.StudentId = StudentId_textBox.Text;
            myStudent.StudentName = StudentName_textBox.Text;
            myStudent.StudentAge = Age_numericUpDown.Value.ToString();
            myStudent.StudentContact = Contact_textBox.Text;
            myStudent.StudentGender = Gender_comboBox.SelectedItem.ToString();
        }
    }
    class Student
    {
        private string ConString = Database3.Properties.Settings.Default.StudentDatabaseConnectionString;
        public string StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentAge { get; set; }
        public string StudentContact { get; set; }
        public string StudentGender { get; set; }

        private const string selectQuery = " Select * from Student_Details";
        private const string insertQuery= "Insert Into Student_Details(StudentId, StudentName, StudentAge, StudentContact, StudentGender) values(@StudentId, @StudentName, @StudentAge, @StudentContact, @StudentGender)";
        
        //Methods

        public DataTable GetStudent_Details()
        {
            var datatable = new DataTable();
            SqlConnection myConnection = new SqlConnection(ConString);
            myConnection.Open();
            SqlCommand com = new SqlCommand(selectQuery, myConnection);
            SqlDataAdapter myAdapter = new SqlDataAdapter(com);
            myAdapter.Fill(datatable);
            myConnection.Close();
            return datatable;
        }

        public bool InsertStudent_Details(Student myStudent)
        {
            int rows;
            SqlConnection myConnection = new SqlConnection(ConString);
            myConnection.Open();
            SqlCommand com = new SqlCommand(insertQuery, myConnection);
            com.Parameters.AddWithValue("@StudentId", myStudent.StudentId);
            com.Parameters.AddWithValue("@StudentId", myStudent.StudentName);
            com.Parameters.AddWithValue("@StudentId", myStudent.StudentAge);
            com.Parameters.AddWithValue("@StudentId", myStudent.StudentContact);
            com.Parameters.AddWithValue("@StudentId", myStudent.StudentGender);
            rows = com.ExecuteNonQuery();
            if (rows > 0)
                return true;
            else
                return false;
        }
    }

}
