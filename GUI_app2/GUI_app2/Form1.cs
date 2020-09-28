using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_app2
{
    public partial class Login_application : Form
    {
        public Login_application()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Button_Click(object sender, EventArgs e)
        {
            string userName = this.user_Name_textBox.Text;
            string password = this.password_textBox.Text;
            if (userName.Equals("sunil") && password.Equals("sunil"))
            {
                Selection mySelection = new Selection();
                this.Hide();
                mySelection.Show();

                //MessageBox.Show("login successful","Important Note",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("invalid credentials", "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void password_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
