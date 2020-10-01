namespace Mypictureview
{
    partial class mypictureview_Form
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.stretch_checkBox = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.showPicture_button = new System.Windows.Forms.Button();
            this.clearPicture_button = new System.Windows.Forms.Button();
            this.backgroundColor_button = new System.Windows.Forms.Button();
            this.close_Button = new System.Windows.Forms.Button();
            this.previous_button = new System.Windows.Forms.Button();
            this.next_button = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.stretch_checkBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.72643F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.27357F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1277, 681);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1271, 581);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // stretch_checkBox
            // 
            this.stretch_checkBox.AutoSize = true;
            this.stretch_checkBox.Location = new System.Drawing.Point(3, 590);
            this.stretch_checkBox.Name = "stretch_checkBox";
            this.stretch_checkBox.Size = new System.Drawing.Size(73, 21);
            this.stretch_checkBox.TabIndex = 1;
            this.stretch_checkBox.Text = "stretch";
            this.stretch_checkBox.UseVisualStyleBackColor = true;
            this.stretch_checkBox.CheckedChanged += new System.EventHandler(this.stretch_checkBox_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.showPicture_button);
            this.flowLayoutPanel1.Controls.Add(this.clearPicture_button);
            this.flowLayoutPanel1.Controls.Add(this.backgroundColor_button);
            this.flowLayoutPanel1.Controls.Add(this.close_Button);
            this.flowLayoutPanel1.Controls.Add(this.previous_button);
            this.flowLayoutPanel1.Controls.Add(this.next_button);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(194, 590);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1080, 54);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // showPicture_button
            // 
            this.showPicture_button.AutoSize = true;
            this.showPicture_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.showPicture_button.Location = new System.Drawing.Point(921, 3);
            this.showPicture_button.Name = "showPicture_button";
            this.showPicture_button.Size = new System.Drawing.Size(156, 27);
            this.showPicture_button.TabIndex = 0;
            this.showPicture_button.Text = "show a picture";
            this.showPicture_button.UseVisualStyleBackColor = true;
            this.showPicture_button.Click += new System.EventHandler(this.showPicture_button_Click);
            // 
            // clearPicture_button
            // 
            this.clearPicture_button.AutoSize = true;
            this.clearPicture_button.Location = new System.Drawing.Point(759, 3);
            this.clearPicture_button.Name = "clearPicture_button";
            this.clearPicture_button.Size = new System.Drawing.Size(156, 27);
            this.clearPicture_button.TabIndex = 1;
            this.clearPicture_button.Text = "clear the picture";
            this.clearPicture_button.UseVisualStyleBackColor = true;
            this.clearPicture_button.Click += new System.EventHandler(this.clearPicture_button_Click);
            // 
            // backgroundColor_button
            // 
            this.backgroundColor_button.AutoSize = true;
            this.backgroundColor_button.Location = new System.Drawing.Point(578, 3);
            this.backgroundColor_button.Name = "backgroundColor_button";
            this.backgroundColor_button.Size = new System.Drawing.Size(175, 27);
            this.backgroundColor_button.TabIndex = 2;
            this.backgroundColor_button.Text = "set the background color";
            this.backgroundColor_button.UseVisualStyleBackColor = true;
            this.backgroundColor_button.Click += new System.EventHandler(this.backgroundColor_button_Click);
            // 
            // close_Button
            // 
            this.close_Button.AutoSize = true;
            this.close_Button.Location = new System.Drawing.Point(416, 3);
            this.close_Button.Name = "close_Button";
            this.close_Button.Size = new System.Drawing.Size(156, 27);
            this.close_Button.TabIndex = 3;
            this.close_Button.Text = "close";
            this.close_Button.UseVisualStyleBackColor = true;
            this.close_Button.Click += new System.EventHandler(this.button4_Click);
            // 
            // previous_button
            // 
            this.previous_button.Location = new System.Drawing.Point(254, 3);
            this.previous_button.Name = "previous_button";
            this.previous_button.Size = new System.Drawing.Size(156, 27);
            this.previous_button.TabIndex = 4;
            this.previous_button.Text = "previous";
            this.previous_button.UseVisualStyleBackColor = true;
            this.previous_button.Click += new System.EventHandler(this.previous_button_Click);
            // 
            // next_button
            // 
            this.next_button.Location = new System.Drawing.Point(92, 3);
            this.next_button.Name = "next_button";
            this.next_button.Size = new System.Drawing.Size(156, 27);
            this.next_button.TabIndex = 3;
            this.next_button.Text = "next";
            this.next_button.UseVisualStyleBackColor = true;
            this.next_button.Click += new System.EventHandler(this.next_button_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*";
            this.openFileDialog1.Title = "Select a picture file";
            // 
            // mypictureview_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 681);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "mypictureview_Form";
            this.Text = "my Picture view";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox stretch_checkBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button showPicture_button;
        private System.Windows.Forms.Button clearPicture_button;
        private System.Windows.Forms.Button backgroundColor_button;
        private System.Windows.Forms.Button close_Button;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button previous_button;
        private System.Windows.Forms.Button next_button;
    }
}

