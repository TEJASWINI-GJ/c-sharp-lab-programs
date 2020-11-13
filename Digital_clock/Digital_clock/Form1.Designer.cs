namespace Digital_clock
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Time_label = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Start_button = new System.Windows.Forms.Button();
            this.Stop_button = new System.Windows.Forms.Button();
            this.Hrs_label = new System.Windows.Forms.Label();
            this.Min_label = new System.Windows.Forms.Label();
            this.Sec_label = new System.Windows.Forms.Label();
            this.Str_button = new System.Windows.Forms.Button();
            this.Stp_button = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Time_label
            // 
            this.Time_label.AutoSize = true;
            this.Time_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time_label.Location = new System.Drawing.Point(224, 32);
            this.Time_label.Name = "Time_label";
            this.Time_label.Size = new System.Drawing.Size(0, 48);
            this.Time_label.TabIndex = 0;
            this.Time_label.Click += new System.EventHandler(this.Time_label_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(35, 32);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 38);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Current time";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker.Location = new System.Drawing.Point(273, 139);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(99, 22);
            this.dateTimePicker.TabIndex = 2;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(35, 130);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(183, 38);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Set Alarm";
            // 
            // Start_button
            // 
            this.Start_button.Location = new System.Drawing.Point(244, 195);
            this.Start_button.Name = "Start_button";
            this.Start_button.Size = new System.Drawing.Size(75, 32);
            this.Start_button.TabIndex = 4;
            this.Start_button.Text = "Start";
            this.Start_button.UseVisualStyleBackColor = true;
            this.Start_button.Click += new System.EventHandler(this.Start_button_Click);
            // 
            // Stop_button
            // 
            this.Stop_button.Location = new System.Drawing.Point(353, 195);
            this.Stop_button.Name = "Stop_button";
            this.Stop_button.Size = new System.Drawing.Size(75, 32);
            this.Stop_button.TabIndex = 5;
            this.Stop_button.Text = "Stop";
            this.Stop_button.UseVisualStyleBackColor = true;
            this.Stop_button.Click += new System.EventHandler(this.Stop_button_Click);
            // 
            // Hrs_label
            // 
            this.Hrs_label.AutoSize = true;
            this.Hrs_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hrs_label.Location = new System.Drawing.Point(295, 281);
            this.Hrs_label.Name = "Hrs_label";
            this.Hrs_label.Size = new System.Drawing.Size(27, 20);
            this.Hrs_label.TabIndex = 6;
            this.Hrs_label.Text = "00";
            // 
            // Min_label
            // 
            this.Min_label.AutoSize = true;
            this.Min_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Min_label.Location = new System.Drawing.Point(361, 281);
            this.Min_label.Name = "Min_label";
            this.Min_label.Size = new System.Drawing.Size(27, 20);
            this.Min_label.TabIndex = 7;
            this.Min_label.Text = "00";
            // 
            // Sec_label
            // 
            this.Sec_label.AutoSize = true;
            this.Sec_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sec_label.Location = new System.Drawing.Point(418, 281);
            this.Sec_label.Name = "Sec_label";
            this.Sec_label.Size = new System.Drawing.Size(27, 20);
            this.Sec_label.TabIndex = 8;
            this.Sec_label.Text = "00";
            // 
            // Str_button
            // 
            this.Str_button.Location = new System.Drawing.Point(273, 332);
            this.Str_button.Name = "Str_button";
            this.Str_button.Size = new System.Drawing.Size(75, 32);
            this.Str_button.TabIndex = 9;
            this.Str_button.Text = "Start";
            this.Str_button.UseVisualStyleBackColor = true;
            this.Str_button.Click += new System.EventHandler(this.Str_button_Click);
            // 
            // Stp_button
            // 
            this.Stp_button.Location = new System.Drawing.Point(408, 332);
            this.Stp_button.Name = "Stp_button";
            this.Stp_button.Size = new System.Drawing.Size(75, 32);
            this.Stp_button.TabIndex = 10;
            this.Stp_button.Text = "Stop";
            this.Stp_button.UseVisualStyleBackColor = true;
            this.Stp_button.Click += new System.EventHandler(this.Stp_button_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(35, 268);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(183, 43);
            this.textBox3.TabIndex = 12;
            this.textBox3.Text = "Timer";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Stp_button);
            this.Controls.Add(this.Str_button);
            this.Controls.Add(this.Sec_label);
            this.Controls.Add(this.Min_label);
            this.Controls.Add(this.Hrs_label);
            this.Controls.Add(this.Stop_button);
            this.Controls.Add(this.Start_button);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Time_label);
            this.Name = "Form1";
            this.Text = "Digital_Clock";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Time_label;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Start_button;
        private System.Windows.Forms.Button Stop_button;
        private System.Windows.Forms.Label Hrs_label;
        private System.Windows.Forms.Label Min_label;
        private System.Windows.Forms.Label Sec_label;
        private System.Windows.Forms.Button Str_button;
        private System.Windows.Forms.Button Stp_button;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Timer timer2;
    }
}

