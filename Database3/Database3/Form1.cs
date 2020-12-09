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
            // call insert method 
            bool retvalue = myStudent.InsertStudent_Details(myStudent);
            if (retvalue)
            {
                MessageBox.Show("Insertion Successfull");
                Student_dataGridView.DataSource = myStudent.GetStudent_Details();
                ClearControls();
            }
            else
                MessageBox.Show("error");
        }
        private void ClearControls()
        {
            StudentId_textBox.Text = "";
            StudentName_textBox.Text = "";
            Age_numericUpDown.Value = 18;
            Contact_textBox.Text = "";
            Gender_comboBox.SelectedItem = "";

        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            myStudent.StudentId = StudentId_textBox.Text;
            bool retvalue = myStudent.DeleteStudent_Details(myStudent);
            if (retvalue)
            {
                MessageBox.Show("Successfull");
                ClearControls();

            }
            else
                MessageBox.Show("Error:Unsuccefull");
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            myStudent.StudentId = Search_textBox.Text;
           bool retvalue= myStudent.SearchStudent_Details(myStudent);
            if (retvalue)
                MessageBox.Show("Search Successfull");
            else
                MessageBox.Show("Search Unccessfull");

        }

        

        private void Update_button_Click(object sender, EventArgs e)
        {
            myStudent.StudentId = StudentId_textBox.Text;
            myStudent.StudentName = StudentName_textBox.Text;
            myStudent.StudentAge = Age_numericUpDown.Value.ToString();
            myStudent.StudentContact = Contact_textBox.Text;
            myStudent.StudentGender = Gender_comboBox.SelectedItem.ToString();

            bool retValue = myStudent.UpdateStudent_Details(myStudent);
            if (retValue)
            {
                MessageBox.Show("updation is successful");
                ClearControls();
                Student_dataGridView.DataSource = myStudent.GetStudent_Details();
            }
            else
            {
                MessageBox.Show("Error:Updation Unsuccessful");
            }
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            ClearControls();
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
        private const string deleteQuery = "Delete from Student_Details where StudentId=@StudentId";
        private const string updateQuery = "Update Student_Details set StudentName=@StudentName, StudentAge=@StudentAge, StudentContact=@StudentContact, StudentGender=@StudentGender where StudentId=@StudentId";
        private const string searchQuery = "Select * from Student_Details where StudentId = @StudentId ";
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
            com.Parameters.AddWithValue("@StudentName", myStudent.StudentName);
            com.Parameters.AddWithValue("@StudentAge", myStudent.StudentAge);
            com.Parameters.AddWithValue("@StudentContact", myStudent.StudentContact);
            com.Parameters.AddWithValue("@StudentGender", myStudent.StudentGender);
            rows = com.ExecuteNonQuery();
            myConnection.Close();
            if (rows > 0)
                return true;
            else
                return false;
        }

        public bool DeleteStudent_Details(Student myStudent)
        {
            int rows;
            SqlConnection myConnection = new SqlConnection(ConString);
            myConnection.Open();
            SqlCommand com = new SqlCommand(deleteQuery, myConnection);
            com.Parameters.AddWithValue("@StudentID", myStudent.StudentId);
            rows = com.ExecuteNonQuery();
            if (rows > 0)
                return true;
            else
                return false;
        }

        public bool UpdateStudent_Details(Student myStudent)
        {
            int rows;
            SqlConnection myConnection = new SqlConnection(ConString);
            myConnection.Open();
            SqlCommand com = new SqlCommand(updateQuery, myConnection);
            com.Parameters.AddWithValue("@StudentName", myStudent.StudentName);
            com.Parameters.AddWithValue("@StudentAge", myStudent.StudentAge);
            com.Parameters.AddWithValue("@StudentContact", myStudent.StudentContact);
            com.Parameters.AddWithValue("@StudentGender", myStudent.StudentGender);
            com.Parameters.AddWithValue("@StudentId", myStudent.StudentId);
            rows = com.ExecuteNonQuery();
            myConnection.Close();
            if (rows > 0)
                return true;
            else
                return false;
        }


        public bool SearchStudent_Details(Student myStudent)
        {
            int rows;
            var datatable = new DataTable();
            SqlConnection myConnection = new SqlConnection(ConString);
            myConnection.Open();
            SqlCommand com = new SqlCommand(searchQuery, myConnection);
            com.Parameters.AddWithValue("@StudentId", myStudent.StudentId);
            SqlDataAdapter myAdapter = new SqlDataAdapter(com);
            rows = myAdapter.Fill(datatable);
            myConnection.Close();
            if(rows>0)
            {
                return true;

            }
            else
                return false;
        }

    }
    }


