namespace Database3
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
            this.Id_label = new System.Windows.Forms.Label();
            this.Name_label = new System.Windows.Forms.Label();
            this.Age_label = new System.Windows.Forms.Label();
            this.Contact_label = new System.Windows.Forms.Label();
            this.Gender_label = new System.Windows.Forms.Label();
            this.StudentId_textBox = new System.Windows.Forms.TextBox();
            this.StudentName_textBox = new System.Windows.Forms.TextBox();
            this.Contact_textBox = new System.Windows.Forms.TextBox();
            this.Age_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Gender_comboBox = new System.Windows.Forms.ComboBox();
            this.Student_dataGridView = new System.Windows.Forms.DataGridView();
            this.Insert_button = new System.Windows.Forms.Button();
            this.Update_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Clear_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Age_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Student_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(437, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student_Details";
            // 
            // Id_label
            // 
            this.Id_label.AutoSize = true;
            this.Id_label.Location = new System.Drawing.Point(110, 124);
            this.Id_label.Name = "Id_label";
            this.Id_label.Size = new System.Drawing.Size(76, 17);
            this.Id_label.TabIndex = 1;
            this.Id_label.Text = "Student_Id";
            this.Id_label.Click += new System.EventHandler(this.label2_Click);
            // 
            // Name_label
            // 
            this.Name_label.AutoSize = true;
            this.Name_label.Location = new System.Drawing.Point(110, 169);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(102, 17);
            this.Name_label.TabIndex = 2;
            this.Name_label.Text = "Student_Name";
            // 
            // Age_label
            // 
            this.Age_label.AutoSize = true;
            this.Age_label.Location = new System.Drawing.Point(110, 217);
            this.Age_label.Name = "Age_label";
            this.Age_label.Size = new System.Drawing.Size(90, 17);
            this.Age_label.TabIndex = 3;
            this.Age_label.Text = "Student_Age";
            this.Age_label.Click += new System.EventHandler(this.label4_Click);
            // 
            // Contact_label
            // 
            this.Contact_label.AutoSize = true;
            this.Contact_label.Location = new System.Drawing.Point(110, 256);
            this.Contact_label.Name = "Contact_label";
            this.Contact_label.Size = new System.Drawing.Size(114, 17);
            this.Contact_label.TabIndex = 4;
            this.Contact_label.Text = "Contact_Number";
            // 
            // Gender_label
            // 
            this.Gender_label.AutoSize = true;
            this.Gender_label.Location = new System.Drawing.Point(110, 296);
            this.Gender_label.Name = "Gender_label";
            this.Gender_label.Size = new System.Drawing.Size(56, 17);
            this.Gender_label.TabIndex = 5;
            this.Gender_label.Text = "Gender";
            // 
            // StudentId_textBox
            // 
            this.StudentId_textBox.Location = new System.Drawing.Point(307, 119);
            this.StudentId_textBox.Name = "StudentId_textBox";
            this.StudentId_textBox.Size = new System.Drawing.Size(120, 22);
            this.StudentId_textBox.TabIndex = 6;
            // 
            // StudentName_textBox
            // 
            this.StudentName_textBox.Location = new System.Drawing.Point(307, 169);
            this.StudentName_textBox.Name = "StudentName_textBox";
            this.StudentName_textBox.Size = new System.Drawing.Size(120, 22);
            this.StudentName_textBox.TabIndex = 7;
            // 
            // Contact_textBox
            // 
            this.Contact_textBox.Location = new System.Drawing.Point(307, 256);
            this.Contact_textBox.Name = "Contact_textBox";
            this.Contact_textBox.Size = new System.Drawing.Size(120, 22);
            this.Contact_textBox.TabIndex = 8;
            // 
            // Age_numericUpDown
            // 
            this.Age_numericUpDown.Location = new System.Drawing.Point(307, 215);
            this.Age_numericUpDown.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.Age_numericUpDown.Name = "Age_numericUpDown";
            this.Age_numericUpDown.Size = new System.Drawing.Size(120, 22);
            this.Age_numericUpDown.TabIndex = 9;
            this.Age_numericUpDown.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // Gender_comboBox
            // 
            this.Gender_comboBox.FormattingEnabled = true;
            this.Gender_comboBox.Items.AddRange(new object[] {
            "M",
            "F"});
            this.Gender_comboBox.Location = new System.Drawing.Point(306, 296);
            this.Gender_comboBox.Name = "Gender_comboBox";
            this.Gender_comboBox.Size = new System.Drawing.Size(121, 24);
            this.Gender_comboBox.TabIndex = 10;
            // 
            // Student_dataGridView
            // 
            this.Student_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Student_dataGridView.Location = new System.Drawing.Point(551, 119);
            this.Student_dataGridView.Name = "Student_dataGridView";
            this.Student_dataGridView.RowHeadersWidth = 51;
            this.Student_dataGridView.RowTemplate.Height = 24;
            this.Student_dataGridView.Size = new System.Drawing.Size(685, 201);
            this.Student_dataGridView.TabIndex = 11;
            // 
            // Insert_button
            // 
            this.Insert_button.Location = new System.Drawing.Point(551, 347);
            this.Insert_button.Name = "Insert_button";
            this.Insert_button.Size = new System.Drawing.Size(125, 30);
            this.Insert_button.TabIndex = 12;
            this.Insert_button.Text = "Insert";
            this.Insert_button.UseVisualStyleBackColor = true;
            this.Insert_button.Click += new System.EventHandler(this.Insert_button_Click);
            // 
            // Update_button
            // 
            this.Update_button.Location = new System.Drawing.Point(733, 347);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(125, 30);
            this.Update_button.TabIndex = 13;
            this.Update_button.Text = "Update";
            this.Update_button.UseVisualStyleBackColor = true;
            // 
            // Delete_button
            // 
            this.Delete_button.Location = new System.Drawing.Point(921, 347);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(125, 30);
            this.Delete_button.TabIndex = 14;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = true;
            // 
            // Clear_button
            // 
            this.Clear_button.Location = new System.Drawing.Point(1111, 347);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(125, 30);
            this.Clear_button.TabIndex = 15;
            this.Clear_button.Text = "Clear";
            this.Clear_button.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 450);
            this.Controls.Add(this.Clear_button);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Update_button);
            this.Controls.Add(this.Insert_button);
            this.Controls.Add(this.Student_dataGridView);
            this.Controls.Add(this.Gender_comboBox);
            this.Controls.Add(this.Age_numericUpDown);
            this.Controls.Add(this.Contact_textBox);
            this.Controls.Add(this.StudentName_textBox);
            this.Controls.Add(this.StudentId_textBox);
            this.Controls.Add(this.Gender_label);
            this.Controls.Add(this.Contact_label);
            this.Controls.Add(this.Age_label);
            this.Controls.Add(this.Name_label);
            this.Controls.Add(this.Id_label);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Age_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Student_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Id_label;
        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.Label Age_label;
        private System.Windows.Forms.Label Contact_label;
        private System.Windows.Forms.Label Gender_label;
        private System.Windows.Forms.TextBox StudentId_textBox;
        private System.Windows.Forms.TextBox StudentName_textBox;
        private System.Windows.Forms.TextBox Contact_textBox;
        private System.Windows.Forms.NumericUpDown Age_numericUpDown;
        private System.Windows.Forms.ComboBox Gender_comboBox;
        private System.Windows.Forms.DataGridView Student_dataGridView;
        private System.Windows.Forms.Button Insert_button;
        private System.Windows.Forms.Button Update_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Clear_button;
    }
}

