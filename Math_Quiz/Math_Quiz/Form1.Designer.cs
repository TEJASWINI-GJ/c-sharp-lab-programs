namespace Math_Quiz
{
    partial class mathQuiz_Form
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
            this.time_Label = new System.Windows.Forms.Label();
            this.timeleft_Label = new System.Windows.Forms.Label();
            this.plusleft_Label = new System.Windows.Forms.Label();
            this.plusright_Label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sum_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.minus_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.minusright_Label = new System.Windows.Forms.Label();
            this.minusleft_Label = new System.Windows.Forms.Label();
            this.multi_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.multiright_Label = new System.Windows.Forms.Label();
            this.multileft_Label = new System.Windows.Forms.Label();
            this.divide_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.divideright_Label = new System.Windows.Forms.Label();
            this.divideleft_Label = new System.Windows.Forms.Label();
            this.start_Button = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sum_NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minus_NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.multi_NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.divide_NumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // time_Label
            // 
            this.time_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.time_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_Label.Location = new System.Drawing.Point(322, 33);
            this.time_Label.Name = "time_Label";
            this.time_Label.Size = new System.Drawing.Size(200, 30);
            this.time_Label.TabIndex = 0;
            this.time_Label.Click += new System.EventHandler(this.time_Label_Click);
            // 
            // timeleft_Label
            // 
            this.timeleft_Label.AutoSize = true;
            this.timeleft_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeleft_Label.Location = new System.Drawing.Point(156, 32);
            this.timeleft_Label.Name = "timeleft_Label";
            this.timeleft_Label.Size = new System.Drawing.Size(127, 31);
            this.timeleft_Label.TabIndex = 1;
            this.timeleft_Label.Text = "Time Left";
            // 
            // plusleft_Label
            // 
            this.plusleft_Label.AutoSize = true;
            this.plusleft_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusleft_Label.Location = new System.Drawing.Point(56, 130);
            this.plusleft_Label.Name = "plusleft_Label";
            this.plusleft_Label.Size = new System.Drawing.Size(25, 29);
            this.plusleft_Label.TabIndex = 2;
            this.plusleft_Label.Text = "?";
            this.plusleft_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusright_Label
            // 
            this.plusright_Label.AutoSize = true;
            this.plusright_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusright_Label.Location = new System.Drawing.Point(189, 130);
            this.plusright_Label.Name = "plusright_Label";
            this.plusright_Label.Size = new System.Drawing.Size(25, 29);
            this.plusright_Label.TabIndex = 3;
            this.plusright_Label.Text = "?";
            this.plusright_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "+";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(257, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "=";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sum_NumericUpDown
            // 
            this.sum_NumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sum_NumericUpDown.Location = new System.Drawing.Point(322, 125);
            this.sum_NumericUpDown.Name = "sum_NumericUpDown";
            this.sum_NumericUpDown.Size = new System.Drawing.Size(117, 34);
            this.sum_NumericUpDown.TabIndex = 2;
            this.sum_NumericUpDown.Enter += new System.EventHandler(this.answer_enter);
            // 
            // minus_NumericUpDown
            // 
            this.minus_NumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus_NumericUpDown.Location = new System.Drawing.Point(322, 193);
            this.minus_NumericUpDown.Name = "minus_NumericUpDown";
            this.minus_NumericUpDown.Size = new System.Drawing.Size(117, 34);
            this.minus_NumericUpDown.TabIndex = 3;
            this.minus_NumericUpDown.Enter += new System.EventHandler(this.answer_enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "=";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(121, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "-";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusright_Label
            // 
            this.minusright_Label.AutoSize = true;
            this.minusright_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusright_Label.Location = new System.Drawing.Point(189, 198);
            this.minusright_Label.Name = "minusright_Label";
            this.minusright_Label.Size = new System.Drawing.Size(25, 29);
            this.minusright_Label.TabIndex = 8;
            this.minusright_Label.Text = "?";
            this.minusright_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusleft_Label
            // 
            this.minusleft_Label.AutoSize = true;
            this.minusleft_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusleft_Label.Location = new System.Drawing.Point(56, 193);
            this.minusleft_Label.Name = "minusleft_Label";
            this.minusleft_Label.Size = new System.Drawing.Size(25, 29);
            this.minusleft_Label.TabIndex = 7;
            this.minusleft_Label.Text = "?";
            this.minusleft_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // multi_NumericUpDown
            // 
            this.multi_NumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multi_NumericUpDown.Location = new System.Drawing.Point(322, 262);
            this.multi_NumericUpDown.Name = "multi_NumericUpDown";
            this.multi_NumericUpDown.Size = new System.Drawing.Size(117, 34);
            this.multi_NumericUpDown.TabIndex = 4;
            this.multi_NumericUpDown.Enter += new System.EventHandler(this.answer_enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(257, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 29);
            this.label7.TabIndex = 15;
            this.label7.Text = "=";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(121, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 29);
            this.label8.TabIndex = 14;
            this.label8.Text = "*";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // multiright_Label
            // 
            this.multiright_Label.AutoSize = true;
            this.multiright_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiright_Label.Location = new System.Drawing.Point(189, 267);
            this.multiright_Label.Name = "multiright_Label";
            this.multiright_Label.Size = new System.Drawing.Size(25, 29);
            this.multiright_Label.TabIndex = 13;
            this.multiright_Label.Text = "?";
            this.multiright_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // multileft_Label
            // 
            this.multileft_Label.AutoSize = true;
            this.multileft_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multileft_Label.Location = new System.Drawing.Point(56, 262);
            this.multileft_Label.Name = "multileft_Label";
            this.multileft_Label.Size = new System.Drawing.Size(25, 29);
            this.multileft_Label.TabIndex = 12;
            this.multileft_Label.Text = "?";
            this.multileft_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // divide_NumericUpDown
            // 
            this.divide_NumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide_NumericUpDown.Location = new System.Drawing.Point(322, 329);
            this.divide_NumericUpDown.Name = "divide_NumericUpDown";
            this.divide_NumericUpDown.Size = new System.Drawing.Size(117, 34);
            this.divide_NumericUpDown.TabIndex = 5;
            this.divide_NumericUpDown.Enter += new System.EventHandler(this.answer_enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(257, 334);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 29);
            this.label11.TabIndex = 20;
            this.label11.Text = "=";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(121, 329);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 29);
            this.label12.TabIndex = 19;
            this.label12.Text = "/";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // divideright_Label
            // 
            this.divideright_Label.AutoSize = true;
            this.divideright_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divideright_Label.Location = new System.Drawing.Point(189, 334);
            this.divideright_Label.Name = "divideright_Label";
            this.divideright_Label.Size = new System.Drawing.Size(25, 29);
            this.divideright_Label.TabIndex = 18;
            this.divideright_Label.Text = "?";
            this.divideright_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // divideleft_Label
            // 
            this.divideleft_Label.AutoSize = true;
            this.divideleft_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divideleft_Label.Location = new System.Drawing.Point(56, 329);
            this.divideleft_Label.Name = "divideleft_Label";
            this.divideleft_Label.Size = new System.Drawing.Size(25, 29);
            this.divideleft_Label.TabIndex = 17;
            this.divideleft_Label.Text = "?";
            this.divideleft_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // start_Button
            // 
            this.start_Button.AutoSize = true;
            this.start_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_Button.Location = new System.Drawing.Point(162, 444);
            this.start_Button.Name = "start_Button";
            this.start_Button.Size = new System.Drawing.Size(200, 39);
            this.start_Button.TabIndex = 1;
            this.start_Button.Text = "Start The Quiz";
            this.start_Button.UseVisualStyleBackColor = true;
            this.start_Button.Click += new System.EventHandler(this.start_Button_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // mathQuiz_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 527);
            this.Controls.Add(this.start_Button);
            this.Controls.Add(this.divide_NumericUpDown);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.divideright_Label);
            this.Controls.Add(this.divideleft_Label);
            this.Controls.Add(this.multi_NumericUpDown);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.multiright_Label);
            this.Controls.Add(this.multileft_Label);
            this.Controls.Add(this.minus_NumericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.minusright_Label);
            this.Controls.Add(this.minusleft_Label);
            this.Controls.Add(this.sum_NumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.plusright_Label);
            this.Controls.Add(this.plusleft_Label);
            this.Controls.Add(this.timeleft_Label);
            this.Controls.Add(this.time_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "mathQuiz_Form";
            this.Text = "Math_Quiz";
            ((System.ComponentModel.ISupportInitialize)(this.sum_NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minus_NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.multi_NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.divide_NumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label time_Label;
        private System.Windows.Forms.Label timeleft_Label;
        private System.Windows.Forms.Label plusleft_Label;
        private System.Windows.Forms.Label plusright_Label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown sum_NumericUpDown;
        private System.Windows.Forms.NumericUpDown minus_NumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label minusright_Label;
        private System.Windows.Forms.Label minusleft_Label;
        private System.Windows.Forms.NumericUpDown multi_NumericUpDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label multiright_Label;
        private System.Windows.Forms.Label multileft_Label;
        private System.Windows.Forms.NumericUpDown divide_NumericUpDown;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label divideright_Label;
        private System.Windows.Forms.Label divideleft_Label;
        private System.Windows.Forms.Button start_Button;
        private System.Windows.Forms.Timer timer;
    }
}

