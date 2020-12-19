namespace library
{
    partial class Add_Student_Info
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Name_label = new System.Windows.Forms.Label();
            this.Enrollment_label = new System.Windows.Forms.Label();
            this.Dept_label = new System.Windows.Forms.Label();
            this.Sem_label = new System.Windows.Forms.Label();
            this.Email_label = new System.Windows.Forms.Label();
            this.Contact_label = new System.Windows.Forms.Label();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.Enrollment_textBox = new System.Windows.Forms.TextBox();
            this.Dept_textBox = new System.Windows.Forms.TextBox();
            this.Sem_textBox = new System.Windows.Forms.TextBox();
            this.Email_textBox = new System.Windows.Forms.TextBox();
            this.Contact_textBox = new System.Windows.Forms.TextBox();
            this.Save_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Save_button);
            this.panel1.Controls.Add(this.Contact_textBox);
            this.panel1.Controls.Add(this.Email_textBox);
            this.panel1.Controls.Add(this.Sem_textBox);
            this.panel1.Controls.Add(this.Dept_textBox);
            this.panel1.Controls.Add(this.Enrollment_textBox);
            this.panel1.Controls.Add(this.Name_textBox);
            this.panel1.Controls.Add(this.Contact_label);
            this.panel1.Controls.Add(this.Email_label);
            this.panel1.Controls.Add(this.Sem_label);
            this.panel1.Controls.Add(this.Dept_label);
            this.panel1.Controls.Add(this.Enrollment_label);
            this.panel1.Controls.Add(this.Name_label);
            this.panel1.Location = new System.Drawing.Point(29, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 416);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Name_label
            // 
            this.Name_label.AutoSize = true;
            this.Name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_label.Location = new System.Drawing.Point(54, 71);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(114, 17);
            this.Name_label.TabIndex = 0;
            this.Name_label.Text = "Student_Name";
            // 
            // Enrollment_label
            // 
            this.Enrollment_label.AutoSize = true;
            this.Enrollment_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enrollment_label.Location = new System.Drawing.Point(54, 117);
            this.Enrollment_label.Name = "Enrollment_label";
            this.Enrollment_label.Size = new System.Drawing.Size(150, 17);
            this.Enrollment_label.TabIndex = 1;
            this.Enrollment_label.Text = "Enrollment_Number";
            // 
            // Dept_label
            // 
            this.Dept_label.AutoSize = true;
            this.Dept_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dept_label.Location = new System.Drawing.Point(54, 163);
            this.Dept_label.Name = "Dept_label";
            this.Dept_label.Size = new System.Drawing.Size(92, 17);
            this.Dept_label.TabIndex = 2;
            this.Dept_label.Text = "Department";
            // 
            // Sem_label
            // 
            this.Sem_label.AutoSize = true;
            this.Sem_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sem_label.Location = new System.Drawing.Point(54, 205);
            this.Sem_label.Name = "Sem_label";
            this.Sem_label.Size = new System.Drawing.Size(76, 17);
            this.Sem_label.TabIndex = 3;
            this.Sem_label.Text = "Semester";
            // 
            // Email_label
            // 
            this.Email_label.AutoSize = true;
            this.Email_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_label.Location = new System.Drawing.Point(54, 252);
            this.Email_label.Name = "Email_label";
            this.Email_label.Size = new System.Drawing.Size(71, 17);
            this.Email_label.TabIndex = 4;
            this.Email_label.Text = "Email_ID";
            // 
            // Contact_label
            // 
            this.Contact_label.AutoSize = true;
            this.Contact_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contact_label.Location = new System.Drawing.Point(54, 296);
            this.Contact_label.Name = "Contact_label";
            this.Contact_label.Size = new System.Drawing.Size(128, 17);
            this.Contact_label.TabIndex = 5;
            this.Contact_label.Text = "Contact_Number";
            // 
            // Name_textBox
            // 
            this.Name_textBox.Location = new System.Drawing.Point(245, 68);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(227, 22);
            this.Name_textBox.TabIndex = 6;
            // 
            // Enrollment_textBox
            // 
            this.Enrollment_textBox.Location = new System.Drawing.Point(245, 112);
            this.Enrollment_textBox.Name = "Enrollment_textBox";
            this.Enrollment_textBox.Size = new System.Drawing.Size(227, 22);
            this.Enrollment_textBox.TabIndex = 7;
            // 
            // Dept_textBox
            // 
            this.Dept_textBox.Location = new System.Drawing.Point(245, 158);
            this.Dept_textBox.Name = "Dept_textBox";
            this.Dept_textBox.Size = new System.Drawing.Size(227, 22);
            this.Dept_textBox.TabIndex = 8;
            // 
            // Sem_textBox
            // 
            this.Sem_textBox.Location = new System.Drawing.Point(245, 205);
            this.Sem_textBox.Name = "Sem_textBox";
            this.Sem_textBox.Size = new System.Drawing.Size(227, 22);
            this.Sem_textBox.TabIndex = 9;
            // 
            // Email_textBox
            // 
            this.Email_textBox.Location = new System.Drawing.Point(245, 252);
            this.Email_textBox.Name = "Email_textBox";
            this.Email_textBox.Size = new System.Drawing.Size(227, 22);
            this.Email_textBox.TabIndex = 10;
            // 
            // Contact_textBox
            // 
            this.Contact_textBox.Location = new System.Drawing.Point(245, 296);
            this.Contact_textBox.Name = "Contact_textBox";
            this.Contact_textBox.Size = new System.Drawing.Size(227, 22);
            this.Contact_textBox.TabIndex = 11;
            // 
            // Save_button
            // 
            this.Save_button.Location = new System.Drawing.Point(158, 347);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(112, 35);
            this.Save_button.TabIndex = 12;
            this.Save_button.Text = "Save Info";
            this.Save_button.UseVisualStyleBackColor = true;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // Add_Student_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Add_Student_Info";
            this.Text = "Add_Student_Info";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Contact_textBox;
        private System.Windows.Forms.TextBox Email_textBox;
        private System.Windows.Forms.TextBox Sem_textBox;
        private System.Windows.Forms.TextBox Dept_textBox;
        private System.Windows.Forms.TextBox Enrollment_textBox;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.Label Contact_label;
        private System.Windows.Forms.Label Email_label;
        private System.Windows.Forms.Label Sem_label;
        private System.Windows.Forms.Label Dept_label;
        private System.Windows.Forms.Label Enrollment_label;
        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.Button Save_button;
    }
}