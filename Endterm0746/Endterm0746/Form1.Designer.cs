namespace Endterm0746
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
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.Address_textBox = new System.Windows.Forms.TextBox();
            this.Contact_textBox = new System.Windows.Forms.TextBox();
            this.Name_label = new System.Windows.Forms.Label();
            this.Address_label = new System.Windows.Forms.Label();
            this.Contact_label = new System.Windows.Forms.Label();
            this.Order_label = new System.Windows.Forms.Label();
            this.Save_button = new System.Windows.Forms.Button();
            this.Search_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Type_comboBox = new System.Windows.Forms.ComboBox();
            this.Otime_label = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Etime_label = new System.Windows.Forms.Label();
            this.Assigned_label = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.Assigned_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Id_label = new System.Windows.Forms.Label();
            this.id_textBox = new System.Windows.Forms.TextBox();
            this.Remarks_label = new System.Windows.Forms.Label();
            this.Remarks_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Name_textBox
            // 
            this.Name_textBox.Location = new System.Drawing.Point(235, 111);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(100, 22);
            this.Name_textBox.TabIndex = 0;
            // 
            // Address_textBox
            // 
            this.Address_textBox.Location = new System.Drawing.Point(235, 171);
            this.Address_textBox.Name = "Address_textBox";
            this.Address_textBox.Size = new System.Drawing.Size(100, 22);
            this.Address_textBox.TabIndex = 1;
            // 
            // Contact_textBox
            // 
            this.Contact_textBox.Location = new System.Drawing.Point(235, 232);
            this.Contact_textBox.Name = "Contact_textBox";
            this.Contact_textBox.Size = new System.Drawing.Size(100, 22);
            this.Contact_textBox.TabIndex = 2;
            // 
            // Name_label
            // 
            this.Name_label.AutoSize = true;
            this.Name_label.Location = new System.Drawing.Point(32, 111);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(157, 17);
            this.Name_label.TabIndex = 4;
            this.Name_label.Text = "Name Of The Costomer";
            // 
            // Address_label
            // 
            this.Address_label.AutoSize = true;
            this.Address_label.Location = new System.Drawing.Point(32, 171);
            this.Address_label.Name = "Address_label";
            this.Address_label.Size = new System.Drawing.Size(60, 17);
            this.Address_label.TabIndex = 5;
            this.Address_label.Text = "Address";
            // 
            // Contact_label
            // 
            this.Contact_label.AutoSize = true;
            this.Contact_label.Location = new System.Drawing.Point(32, 232);
            this.Contact_label.Name = "Contact_label";
            this.Contact_label.Size = new System.Drawing.Size(56, 17);
            this.Contact_label.TabIndex = 6;
            this.Contact_label.Text = "Contact";
            // 
            // Order_label
            // 
            this.Order_label.AutoSize = true;
            this.Order_label.Location = new System.Drawing.Point(32, 293);
            this.Order_label.Name = "Order_label";
            this.Order_label.Size = new System.Drawing.Size(100, 17);
            this.Order_label.TabIndex = 7;
            this.Order_label.Text = "Type Of Order";
            // 
            // Save_button
            // 
            this.Save_button.Location = new System.Drawing.Point(617, 395);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(75, 23);
            this.Save_button.TabIndex = 8;
            this.Save_button.Text = "Save Info";
            this.Save_button.UseVisualStyleBackColor = true;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // Search_button
            // 
            this.Search_button.Location = new System.Drawing.Point(790, 395);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(75, 23);
            this.Search_button.TabIndex = 9;
            this.Search_button.Text = "Search";
            this.Search_button.UseVisualStyleBackColor = true;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(423, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1131, 222);
            this.dataGridView1.TabIndex = 10;
            // 
            // Type_comboBox
            // 
            this.Type_comboBox.FormattingEnabled = true;
            this.Type_comboBox.Items.AddRange(new object[] {
            "Salvar",
            "Saree blouse",
            "Gagra",
            "Pant and Shirt",
            "School Uniform",
            "Crop Top"});
            this.Type_comboBox.Location = new System.Drawing.Point(235, 286);
            this.Type_comboBox.Name = "Type_comboBox";
            this.Type_comboBox.Size = new System.Drawing.Size(121, 24);
            this.Type_comboBox.TabIndex = 11;
            this.Type_comboBox.SelectedIndexChanged += new System.EventHandler(this.Type_comboBox_SelectedIndexChanged);
            // 
            // Otime_label
            // 
            this.Otime_label.AutoSize = true;
            this.Otime_label.Location = new System.Drawing.Point(32, 357);
            this.Otime_label.Name = "Otime_label";
            this.Otime_label.Size = new System.Drawing.Size(142, 17);
            this.Otime_label.TabIndex = 12;
            this.Otime_label.Text = "Order Date and Time";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(235, 355);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // Etime_label
            // 
            this.Etime_label.AutoSize = true;
            this.Etime_label.Location = new System.Drawing.Point(32, 427);
            this.Etime_label.Name = "Etime_label";
            this.Etime_label.Size = new System.Drawing.Size(163, 17);
            this.Etime_label.TabIndex = 14;
            this.Etime_label.Text = "Expected Date and Time";
            // 
            // Assigned_label
            // 
            this.Assigned_label.AutoSize = true;
            this.Assigned_label.Location = new System.Drawing.Point(32, 492);
            this.Assigned_label.Name = "Assigned_label";
            this.Assigned_label.Size = new System.Drawing.Size(70, 17);
            this.Assigned_label.TabIndex = 15;
            this.Assigned_label.Text = "Assigned ";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(235, 427);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 16;
            // 
            // Assigned_comboBox
            // 
            this.Assigned_comboBox.FormattingEnabled = true;
            this.Assigned_comboBox.Items.AddRange(new object[] {
            "Ravi",
            "Shashikala",
            "Sandeep",
            "Bharath",
            "Beema"});
            this.Assigned_comboBox.Location = new System.Drawing.Point(235, 489);
            this.Assigned_comboBox.Name = "Assigned_comboBox";
            this.Assigned_comboBox.Size = new System.Drawing.Size(121, 24);
            this.Assigned_comboBox.TabIndex = 17;
            this.Assigned_comboBox.SelectedIndexChanged += new System.EventHandler(this.Assigned_comboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(418, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tailor Shop Management";
            // 
            // Id_label
            // 
            this.Id_label.AutoSize = true;
            this.Id_label.Location = new System.Drawing.Point(32, 49);
            this.Id_label.Name = "Id_label";
            this.Id_label.Size = new System.Drawing.Size(19, 17);
            this.Id_label.TabIndex = 19;
            this.Id_label.Text = "id";
            // 
            // id_textBox
            // 
            this.id_textBox.Location = new System.Drawing.Point(235, 49);
            this.id_textBox.Name = "id_textBox";
            this.id_textBox.Size = new System.Drawing.Size(100, 22);
            this.id_textBox.TabIndex = 20;
            // 
            // Remarks_label
            // 
            this.Remarks_label.AutoSize = true;
            this.Remarks_label.Location = new System.Drawing.Point(487, 496);
            this.Remarks_label.Name = "Remarks_label";
            this.Remarks_label.Size = new System.Drawing.Size(64, 17);
            this.Remarks_label.TabIndex = 21;
            this.Remarks_label.Text = "Remarks";
            // 
            // Remarks_textBox
            // 
            this.Remarks_textBox.Location = new System.Drawing.Point(574, 496);
            this.Remarks_textBox.Name = "Remarks_textBox";
            this.Remarks_textBox.Size = new System.Drawing.Size(328, 22);
            this.Remarks_textBox.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1555, 539);
            this.Controls.Add(this.Remarks_textBox);
            this.Controls.Add(this.Remarks_label);
            this.Controls.Add(this.id_textBox);
            this.Controls.Add(this.Id_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Assigned_comboBox);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.Assigned_label);
            this.Controls.Add(this.Etime_label);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Otime_label);
            this.Controls.Add(this.Type_comboBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Search_button);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.Order_label);
            this.Controls.Add(this.Contact_label);
            this.Controls.Add(this.Address_label);
            this.Controls.Add(this.Name_label);
            this.Controls.Add(this.Contact_textBox);
            this.Controls.Add(this.Address_textBox);
            this.Controls.Add(this.Name_textBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.TextBox Address_textBox;
        private System.Windows.Forms.TextBox Contact_textBox;
        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.Label Address_label;
        private System.Windows.Forms.Label Contact_label;
        private System.Windows.Forms.Label Order_label;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox Type_comboBox;
        private System.Windows.Forms.Label Otime_label;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label Etime_label;
        private System.Windows.Forms.Label Assigned_label;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox Assigned_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Id_label;
        private System.Windows.Forms.TextBox id_textBox;
        private System.Windows.Forms.Label Remarks_label;
        private System.Windows.Forms.TextBox Remarks_textBox;
    }
}

