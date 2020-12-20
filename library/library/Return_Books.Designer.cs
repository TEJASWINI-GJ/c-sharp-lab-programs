namespace library
{
    partial class Return_Books
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
            this.label1 = new System.Windows.Forms.Label();
            this.Enrolment_textBox = new System.Windows.Forms.TextBox();
            this.Search_button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Bookname_label = new System.Windows.Forms.Label();
            this.Return_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Issuedate_label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Return_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Search_button);
            this.panel1.Controls.Add(this.Enrolment_textBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(14, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 119);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Enrolment Number";
            // 
            // Enrolment_textBox
            // 
            this.Enrolment_textBox.Location = new System.Drawing.Point(225, 8);
            this.Enrolment_textBox.Name = "Enrolment_textBox";
            this.Enrolment_textBox.Size = new System.Drawing.Size(185, 22);
            this.Enrolment_textBox.TabIndex = 1;
            // 
            // Search_button
            // 
            this.Search_button.Location = new System.Drawing.Point(127, 73);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(164, 23);
            this.Search_button.TabIndex = 2;
            this.Search_button.Text = "Search_Books";
            this.Search_button.UseVisualStyleBackColor = true;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(440, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1099, 270);
            this.panel2.TabIndex = 3;
            this.panel2.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1071, 230);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Return_button);
            this.panel3.Controls.Add(this.Bookname_label);
            this.panel3.Controls.Add(this.Return_label);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.Issuedate_label);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Location = new System.Drawing.Point(223, 333);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1042, 187);
            this.panel3.TabIndex = 4;
            this.panel3.Visible = false;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Bookname_label
            // 
            this.Bookname_label.AutoSize = true;
            this.Bookname_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bookname_label.Location = new System.Drawing.Point(65, 23);
            this.Bookname_label.Name = "Bookname_label";
            this.Bookname_label.Size = new System.Drawing.Size(90, 17);
            this.Bookname_label.TabIndex = 5;
            this.Bookname_label.Text = "Book Name";
            // 
            // Return_label
            // 
            this.Return_label.AutoSize = true;
            this.Return_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Return_label.Location = new System.Drawing.Point(65, 101);
            this.Return_label.Name = "Return_label";
            this.Return_label.Size = new System.Drawing.Size(146, 17);
            this.Return_label.TabIndex = 6;
            this.Return_label.Text = "Select Return Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 7;
            // 
            // Issuedate_label
            // 
            this.Issuedate_label.AutoSize = true;
            this.Issuedate_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Issuedate_label.Location = new System.Drawing.Point(421, 23);
            this.Issuedate_label.Name = "Issuedate_label";
            this.Issuedate_label.Size = new System.Drawing.Size(85, 17);
            this.Issuedate_label.TabIndex = 8;
            this.Issuedate_label.Text = "Issue Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(603, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(240, 101);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(224, 22);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // Return_button
            // 
            this.Return_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Return_button.Location = new System.Drawing.Point(606, 136);
            this.Return_button.Name = "Return_button";
            this.Return_button.Size = new System.Drawing.Size(209, 35);
            this.Return_button.TabIndex = 11;
            this.Return_button.Text = "Return Book";
            this.Return_button.UseVisualStyleBackColor = true;
            this.Return_button.Click += new System.EventHandler(this.Return_button_Click);
            // 
            // Return_Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1551, 532);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Return_Books";
            this.Text = "Return_Books";
            this.Load += new System.EventHandler(this.Return_Books_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.TextBox Enrolment_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Return_button;
        private System.Windows.Forms.Label Bookname_label;
        private System.Windows.Forms.Label Return_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Issuedate_label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}