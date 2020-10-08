using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Quiz
{
    public partial class mathQuiz_Form : Form
    {
        //to generate random numbers
        Random randomizer = new Random();

        //for addition
        int add1;
        int add2;

        int minus1;
        int minus2;

        int multi1;
        int multi2;

        int div1;
        int div2;

        private Color timeLabelColor;

        int timeleft;

       

        public void StartTheQuiz()
        {
            time_Label.BackColor = timeLabelColor;
            // Fill in the addition problem.
            // Generate two random numbers to add.
            // Store the values in the variables 'addend1' and 'addend2'.
            add1 = randomizer.Next(51);
            add2 = randomizer.Next(51);
            plusleft_Label.Text = add1.ToString();
            plusright_Label.Text = add2.ToString();
            sum_NumericUpDown.Value = 0;                                                 // Convert the two randomly generated numbers
                                                                                         // into strings so that they can be displayed in the label controls.
            minus1 = randomizer.Next(1,100);
            minus2 = randomizer.Next(1,minus1);
            minusleft_Label.Text = minus1.ToString();
            minusright_Label.Text = minus2.ToString();
            minus_NumericUpDown.Value = 0;

            multi1 = randomizer.Next(2,9);
            multi2 = randomizer.Next(2,9);
            multileft_Label.Text = multi1.ToString();
            multiright_Label.Text = multi2.ToString();
            multi_NumericUpDown.Value = 0;

           
            div1 = randomizer.Next(51);
            div2 = randomizer.Next(51);
            divideleft_Label.Text = div1.ToString();
            divideright_Label.Text = div2.ToString();
            divide_NumericUpDown.Value = 0;



            // Start the timer.
            timeleft = 15;
            time_Label.Text = "15 seconds";
            timer.Start();
        }


        /// Check the answer to see if the user got everything right.

        private bool CheckTheAnswer()
        {
            if ((add1 + add2 == sum_NumericUpDown.Value) && (minus1 - minus2 == minus_NumericUpDown.Value)
                && (multi1 * multi2 == multi_NumericUpDown.Value) && (div1 / div2 == divide_NumericUpDown.Value))
                return true;

            else
                return false;


        }
        public mathQuiz_Form()
        {
            InitializeComponent();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void start_Button_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            start_Button.Enabled = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {

            if (CheckTheAnswer())
            {
                // If CheckTheAnswer() returns true, then the user 
                // got the answer right. Stop the timer  
                // and show a MessageBox.
                timer.Stop();
                MessageBox.Show("You got all the answers right!",
                                "Congratulations!");
                start_Button.Enabled = true;
            }

            else if (timeleft > 0)
            {
                // Display the new time left
                // by updating the Time Left label.
                timeleft = timeleft - 1;
                time_Label.Text = timeleft + " seconds";
                if (timeleft <= 10)
                {
                    time_Label.BackColor = Color.Red;
                    
                }  
            }
            else 
            {
                // If the user ran out of time, stop the timer, show
               
                timer.Stop();
                time_Label.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");

                sum_NumericUpDown.Value = add1 + add2;
               
                minus_NumericUpDown.Value = minus1 - minus2;
               
                multi_NumericUpDown.Value = multi1 * multi2;
                
                divide_NumericUpDown.Value = div1 / div2;
                
                start_Button.Enabled = true;
                time_Label.BackColor = timeLabelColor;
            }

        }

        private void answer_enter(object sender, EventArgs e)
        {
            // Select the whole answer in the NumericUpDown control.
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

        private void time_Label_Click(object sender,EventArgs e)
        {
            if(timeleft<5)
            time_Label.BackColor = Color.Red;
        }
    }
}
