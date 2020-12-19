namespace library
{
    partial class View_Student_Info
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Search_textBox = new System.Windows.Forms.TextBox();
            this.Search_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, -2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1056, 398);
            this.dataGridView1.TabIndex = 0;
            // 
            // Search_textBox
            // 
            this.Search_textBox.Location = new System.Drawing.Point(357, 422);
            this.Search_textBox.Name = "Search_textBox";
            this.Search_textBox.Size = new System.Drawing.Size(257, 22);
            this.Search_textBox.TabIndex = 1;
            this.Search_textBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // Search_label
            // 
            this.Search_label.AutoSize = true;
            this.Search_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_label.Location = new System.Drawing.Point(181, 425);
            this.Search_label.Name = "Search_label";
            this.Search_label.Size = new System.Drawing.Size(154, 17);
            this.Search_label.TabIndex = 2;
            this.Search_label.Text = "Enter Student Name";
            // 
            // View_Student_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 471);
            this.Controls.Add(this.Search_label);
            this.Controls.Add(this.Search_textBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "View_Student_Info";
            this.Text = "View_Student_Info";
            this.Load += new System.EventHandler(this.View_Student_Info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Search_textBox;
        private System.Windows.Forms.Label Search_label;
    }
}