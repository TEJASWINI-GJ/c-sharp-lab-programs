namespace CSE9008
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.Add_textBox = new System.Windows.Forms.TextBox();
            this.Contact_textBox = new System.Windows.Forms.TextBox();
            this.Ot_comboBox = new System.Windows.Forms.ComboBox();
            this.Assgn_comboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.Remarks_textBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.I_button = new System.Windows.Forms.Button();
            this.S_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contact";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Type of order";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Order date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Delivery";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 449);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Assigned";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(66, 513);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Remarks";
            // 
            // Name_textBox
            // 
            this.Name_textBox.Location = new System.Drawing.Point(246, 59);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(200, 22);
            this.Name_textBox.TabIndex = 8;
            // 
            // Add_textBox
            // 
            this.Add_textBox.Location = new System.Drawing.Point(246, 117);
            this.Add_textBox.Name = "Add_textBox";
            this.Add_textBox.Size = new System.Drawing.Size(200, 22);
            this.Add_textBox.TabIndex = 9;
            // 
            // Contact_textBox
            // 
            this.Contact_textBox.Location = new System.Drawing.Point(246, 180);
            this.Contact_textBox.Name = "Contact_textBox";
            this.Contact_textBox.Size = new System.Drawing.Size(200, 22);
            this.Contact_textBox.TabIndex = 10;
            // 
            // Ot_comboBox
            // 
            this.Ot_comboBox.FormattingEnabled = true;
            this.Ot_comboBox.Items.AddRange(new object[] {
            "Pyjam",
            "Uniform",
            "Office shirt",
            "Skrit",
            "Salvar"});
            this.Ot_comboBox.Location = new System.Drawing.Point(246, 243);
            this.Ot_comboBox.Name = "Ot_comboBox";
            this.Ot_comboBox.Size = new System.Drawing.Size(200, 24);
            this.Ot_comboBox.TabIndex = 11;
            // 
            // Assgn_comboBox
            // 
            this.Assgn_comboBox.FormattingEnabled = true;
            this.Assgn_comboBox.Items.AddRange(new object[] {
            "Sushma",
            "Karthik",
            "Sam",
            "Hari",
            "Devi"});
            this.Assgn_comboBox.Location = new System.Drawing.Point(246, 442);
            this.Assgn_comboBox.Name = "Assgn_comboBox";
            this.Assgn_comboBox.Size = new System.Drawing.Size(200, 24);
            this.Assgn_comboBox.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(246, 317);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(246, 387);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 14;
            // 
            // Remarks_textBox
            // 
            this.Remarks_textBox.Location = new System.Drawing.Point(236, 513);
            this.Remarks_textBox.Name = "Remarks_textBox";
            this.Remarks_textBox.Size = new System.Drawing.Size(210, 22);
            this.Remarks_textBox.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(518, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(944, 407);
            this.dataGridView1.TabIndex = 16;
            // 
            // I_button
            // 
            this.I_button.Location = new System.Drawing.Point(138, 577);
            this.I_button.Name = "I_button";
            this.I_button.Size = new System.Drawing.Size(113, 42);
            this.I_button.TabIndex = 17;
            this.I_button.Text = "Insert";
            this.I_button.UseVisualStyleBackColor = true;
            this.I_button.Click += new System.EventHandler(this.I_button_Click);
            // 
            // S_button
            // 
            this.S_button.Location = new System.Drawing.Point(844, 513);
            this.S_button.Name = "S_button";
            this.S_button.Size = new System.Drawing.Size(166, 42);
            this.S_button.TabIndex = 18;
            this.S_button.Text = "Search";
            this.S_button.UseVisualStyleBackColor = true;
            this.S_button.Click += new System.EventHandler(this.S_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 631);
            this.Controls.Add(this.S_button);
            this.Controls.Add(this.I_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Remarks_textBox);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Assgn_comboBox);
            this.Controls.Add(this.Ot_comboBox);
            this.Controls.Add(this.Contact_textBox);
            this.Controls.Add(this.Add_textBox);
            this.Controls.Add(this.Name_textBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.TextBox Add_textBox;
        private System.Windows.Forms.TextBox Contact_textBox;
        private System.Windows.Forms.ComboBox Ot_comboBox;
        private System.Windows.Forms.ComboBox Assgn_comboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox Remarks_textBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button I_button;
        private System.Windows.Forms.Button S_button;
    }
}

