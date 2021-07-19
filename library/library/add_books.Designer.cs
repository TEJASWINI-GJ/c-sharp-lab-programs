namespace library
{
    partial class add_books
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
            this.Author_TextBox = new System.Windows.Forms.MaskedTextBox();
            this.Price_TextBox = new System.Windows.Forms.MaskedTextBox();
            this.Quantity_TextBox = new System.Windows.Forms.MaskedTextBox();
            this.BooksName_label = new System.Windows.Forms.Label();
            this.Author_label = new System.Windows.Forms.Label();
            this.Purchase_label = new System.Windows.Forms.Label();
            this.Price_label = new System.Windows.Forms.Label();
            this.Quantity_label = new System.Windows.Forms.Label();
            this.Save_button = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // Name_textBox
            // 
            this.Name_textBox.Location = new System.Drawing.Point(219, 68);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(226, 22);
            this.Name_textBox.TabIndex = 0;
            // 
            // Author_TextBox
            // 
            this.Author_TextBox.Location = new System.Drawing.Point(219, 119);
            this.Author_TextBox.Name = "Author_TextBox";
            this.Author_TextBox.Size = new System.Drawing.Size(226, 22);
            this.Author_TextBox.TabIndex = 1;
            this.Author_TextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Author_TextBox_MaskInputRejected);
            // 
            // Price_TextBox
            // 
            this.Price_TextBox.Location = new System.Drawing.Point(219, 243);
            this.Price_TextBox.Name = "Price_TextBox";
            this.Price_TextBox.Size = new System.Drawing.Size(226, 22);
            this.Price_TextBox.TabIndex = 3;
            // 
            // Quantity_TextBox
            // 
            this.Quantity_TextBox.Location = new System.Drawing.Point(219, 304);
            this.Quantity_TextBox.Name = "Quantity_TextBox";
            this.Quantity_TextBox.Size = new System.Drawing.Size(226, 22);
            this.Quantity_TextBox.TabIndex = 4;
            // 
            // BooksName_label
            // 
            this.BooksName_label.AutoSize = true;
            this.BooksName_label.Location = new System.Drawing.Point(18, 68);
            this.BooksName_label.Name = "BooksName_label";
            this.BooksName_label.Size = new System.Drawing.Size(92, 17);
            this.BooksName_label.TabIndex = 5;
            this.BooksName_label.Text = "Books_Name";
            // 
            // Author_label
            // 
            this.Author_label.AutoSize = true;
            this.Author_label.Location = new System.Drawing.Point(18, 121);
            this.Author_label.Name = "Author_label";
            this.Author_label.Size = new System.Drawing.Size(97, 17);
            this.Author_label.TabIndex = 6;
            this.Author_label.Text = "Books_Author";
            // 
            // Purchase_label
            // 
            this.Purchase_label.AutoSize = true;
            this.Purchase_label.Location = new System.Drawing.Point(18, 177);
            this.Purchase_label.Name = "Purchase_label";
            this.Purchase_label.Size = new System.Drawing.Size(153, 17);
            this.Purchase_label.TabIndex = 7;
            this.Purchase_label.Text = "Books_Purchase_Date";
            // 
            // Price_label
            // 
            this.Price_label.AutoSize = true;
            this.Price_label.Location = new System.Drawing.Point(18, 245);
            this.Price_label.Name = "Price_label";
            this.Price_label.Size = new System.Drawing.Size(87, 17);
            this.Price_label.TabIndex = 8;
            this.Price_label.Text = "Books_Price";
            // 
            // Quantity_label
            // 
            this.Quantity_label.AutoSize = true;
            this.Quantity_label.Location = new System.Drawing.Point(18, 306);
            this.Quantity_label.Name = "Quantity_label";
            this.Quantity_label.Size = new System.Drawing.Size(108, 17);
            this.Quantity_label.TabIndex = 9;
            this.Quantity_label.Text = "Books_Quantity";
            // 
            // Save_button
            // 
            this.Save_button.Location = new System.Drawing.Point(95, 394);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(129, 34);
            this.Save_button.TabIndex = 10;
            this.Save_button.Text = "Save";
            this.Save_button.UseVisualStyleBackColor = true;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(219, 187);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // add_books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 521);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.Quantity_label);
            this.Controls.Add(this.Price_label);
            this.Controls.Add(this.Purchase_label);
            this.Controls.Add(this.Author_label);
            this.Controls.Add(this.BooksName_label);
            this.Controls.Add(this.Quantity_TextBox);
            this.Controls.Add(this.Price_TextBox);
            this.Controls.Add(this.Author_TextBox);
            this.Controls.Add(this.Name_textBox);
            this.Name = "add_books";
            this.Text = "add_books";
            this.Load += new System.EventHandler(this.add_books_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.MaskedTextBox Author_TextBox;
        private System.Windows.Forms.MaskedTextBox Price_TextBox;
        private System.Windows.Forms.MaskedTextBox Quantity_TextBox;
        private System.Windows.Forms.Label BooksName_label;
        private System.Windows.Forms.Label Author_label;
        private System.Windows.Forms.Label Purchase_label;
        private System.Windows.Forms.Label Price_label;
        private System.Windows.Forms.Label Quantity_label;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}