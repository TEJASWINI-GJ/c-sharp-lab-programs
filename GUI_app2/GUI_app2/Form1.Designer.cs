namespace GUI_app2
{
    partial class Login_application
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
            this.login_Button = new System.Windows.Forms.Button();
            this.user_Name_label = new System.Windows.Forms.Label();
            this.password_Label = new System.Windows.Forms.Label();
            this.user_Name_textBox = new System.Windows.Forms.TextBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.Login_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login_Button
            // 
            this.login_Button.Location = new System.Drawing.Point(342, 275);
            this.login_Button.Name = "login_Button";
            this.login_Button.Size = new System.Drawing.Size(75, 23);
            this.login_Button.TabIndex = 0;
            this.login_Button.Text = "Login";
            this.login_Button.UseVisualStyleBackColor = true;
            this.login_Button.Click += new System.EventHandler(this.login_Button_Click);
            // 
            // user_Name_label
            // 
            this.user_Name_label.AutoSize = true;
            this.user_Name_label.Location = new System.Drawing.Point(223, 100);
            this.user_Name_label.Name = "user_Name_label";
            this.user_Name_label.Size = new System.Drawing.Size(79, 17);
            this.user_Name_label.TabIndex = 1;
            this.user_Name_label.Text = "User Name";
            this.user_Name_label.Click += new System.EventHandler(this.user_Name_label_Click);
            // 
            // password_Label
            // 
            this.password_Label.AutoSize = true;
            this.password_Label.Location = new System.Drawing.Point(233, 152);
            this.password_Label.Name = "password_Label";
            this.password_Label.Size = new System.Drawing.Size(69, 17);
            this.password_Label.TabIndex = 2;
            this.password_Label.Text = "Password";
            // 
            // user_Name_textBox
            // 
            this.user_Name_textBox.Location = new System.Drawing.Point(371, 97);
            this.user_Name_textBox.Name = "user_Name_textBox";
            this.user_Name_textBox.Size = new System.Drawing.Size(196, 22);
            this.user_Name_textBox.TabIndex = 3;
            this.user_Name_textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // password_textBox
            // 
            this.password_textBox.Location = new System.Drawing.Point(371, 152);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(196, 22);
            this.password_textBox.TabIndex = 4;
            this.password_textBox.TextChanged += new System.EventHandler(this.password_textBox_TextChanged);
            // 
            // Login_label
            // 
            this.Login_label.AutoSize = true;
            this.Login_label.Location = new System.Drawing.Point(324, 36);
            this.Login_label.Name = "Login_label";
            this.Login_label.Size = new System.Drawing.Size(51, 17);
            this.Login_label.TabIndex = 5;
            this.Login_label.Text = "LOGIN";
            // 
            // Login_application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Login_label);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.user_Name_textBox);
            this.Controls.Add(this.password_Label);
            this.Controls.Add(this.user_Name_label);
            this.Controls.Add(this.login_Button);
            this.Name = "Login_application";
            this.Text = "Home Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_Button;
        private System.Windows.Forms.Label user_Name_label;
        private System.Windows.Forms.Label password_Label;
        private System.Windows.Forms.TextBox user_Name_textBox;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.Label Login_label;
    }
}

