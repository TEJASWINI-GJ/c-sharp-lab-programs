using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Digital_clock
{
    public partial class Form1 : Form
    {
        int seconds, minutes, hours;
        System.Timers.Timer timer;
        Timer t = new Timer();
        public Form1()
        {
            seconds = minutes = hours = 0;
            InitializeComponent();

        }

        private void Time_label_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            Time_label.BackColor = colorDialog1.Color;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            t.Interval = 1000;
            t.Tick += new EventHandler(this.timer1_Tick);
            t.Start();
            timer = new System.Timers.Timer();
            timer.Elapsed += Timer_Elapsed;
           
        }

        private void Timer_Elapsed(Object sender , System.Timers.ElapsedEventArgs e)
        {
            DateTime currenttime = DateTime.Now;
            DateTime usertime = dateTimePicker.Value;
            if(currenttime.Hour==usertime.Hour && usertime.Minute==usertime.Minute && currenttime.Second==usertime.Second)
            {
                timer.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            string time = "";

          
            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";

            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";

            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }

            //update label
            Time_label.Text = time;

        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Start_button_Click(object sender, EventArgs e)
        {
            timer.Start();
            MessageBox.Show("running");
        }

        private void Str_button_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void Stp_button_Click(object sender, EventArgs e)
        {
          timer2.Stop();
       
        }

       

        private void Stop_button_Click(object sender, EventArgs e)
        {
            timer.Stop();
            MessageBox.Show("Stoped");

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            seconds++;
            if(seconds>59)
            {
                minutes++;
                seconds = 0;
            }
            if(minutes>59)
            {
                hours++;
                minutes = 0;
            }
            Hrs_label.Text = hours.ToString();
            Min_label.Text = minutes.ToString();
            Sec_label.Text = seconds.ToString();
        }
    }
}
