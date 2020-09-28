namespace GUI_app2
{
    partial class Selection
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
            this.engg_radioButton = new System.Windows.Forms.RadioButton();
            this.law_radioButton = new System.Windows.Forms.RadioButton();
            this.mba_radioButton = new System.Windows.Forms.RadioButton();
            this.bca_radioButton = new System.Windows.Forms.RadioButton();
            this.stream_groupBox1 = new System.Windows.Forms.GroupBox();
            this.selection_Label = new System.Windows.Forms.Label();
            this.engg_groupBox = new System.Windows.Forms.GroupBox();
            this.cse_radioButton = new System.Windows.Forms.RadioButton();
            this.civil_radioButton = new System.Windows.Forms.RadioButton();
            this.mech_radioButton = new System.Windows.Forms.RadioButton();
            this.comm_radioButton = new System.Windows.Forms.RadioButton();
            this.petro_radioButton = new System.Windows.Forms.RadioButton();
            this.submit_Button = new System.Windows.Forms.Button();
            this.law_groupBox = new System.Windows.Forms.GroupBox();
            this.llb_radioButton = new System.Windows.Forms.RadioButton();
            this.llm_radioButton = new System.Windows.Forms.RadioButton();
            this.mbl_radioButton = new System.Windows.Forms.RadioButton();
            this.dtl_radioButton = new System.Windows.Forms.RadioButton();
            this.mba_groupBox = new System.Windows.Forms.GroupBox();
            this.finance_radioButton = new System.Windows.Forms.RadioButton();
            this.hrm_radioButton = new System.Windows.Forms.RadioButton();
            this.it_radioButton = new System.Windows.Forms.RadioButton();
            this.mm_radioButton = new System.Windows.Forms.RadioButton();
            this.bca_groupBox = new System.Windows.Forms.GroupBox();
            this.c_radioButton = new System.Windows.Forms.RadioButton();
            this.ds_radioButton = new System.Windows.Forms.RadioButton();
            this.dbms_radioButton = new System.Windows.Forms.RadioButton();
            this.unix_radioButton = new System.Windows.Forms.RadioButton();
            this.pm_radioButton = new System.Windows.Forms.RadioButton();
            this.stream_groupBox1.SuspendLayout();
            this.engg_groupBox.SuspendLayout();
            this.law_groupBox.SuspendLayout();
            this.mba_groupBox.SuspendLayout();
            this.bca_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // engg_radioButton
            // 
            this.engg_radioButton.AutoSize = true;
            this.engg_radioButton.Location = new System.Drawing.Point(75, 36);
            this.engg_radioButton.Name = "engg_radioButton";
            this.engg_radioButton.Size = new System.Drawing.Size(105, 21);
            this.engg_radioButton.TabIndex = 0;
            this.engg_radioButton.TabStop = true;
            this.engg_radioButton.Text = "Engineering";
            this.engg_radioButton.UseVisualStyleBackColor = true;
            this.engg_radioButton.CheckedChanged += new System.EventHandler(this.engg_radioButton_CheckedChanged);
            // 
            // law_radioButton
            // 
            this.law_radioButton.AutoSize = true;
            this.law_radioButton.Location = new System.Drawing.Point(231, 36);
            this.law_radioButton.Name = "law_radioButton";
            this.law_radioButton.Size = new System.Drawing.Size(54, 21);
            this.law_radioButton.TabIndex = 1;
            this.law_radioButton.TabStop = true;
            this.law_radioButton.Text = "Law";
            this.law_radioButton.UseVisualStyleBackColor = true;
            this.law_radioButton.CheckedChanged += new System.EventHandler(this.law_radioButton_CheckedChanged);
            // 
            // mba_radioButton
            // 
            this.mba_radioButton.AutoSize = true;
            this.mba_radioButton.Location = new System.Drawing.Point(345, 36);
            this.mba_radioButton.Name = "mba_radioButton";
            this.mba_radioButton.Size = new System.Drawing.Size(58, 21);
            this.mba_radioButton.TabIndex = 2;
            this.mba_radioButton.TabStop = true;
            this.mba_radioButton.Text = "MBA";
            this.mba_radioButton.UseVisualStyleBackColor = true;
            this.mba_radioButton.CheckedChanged += new System.EventHandler(this.mba_radioButton_CheckedChanged);
            // 
            // bca_radioButton
            // 
            this.bca_radioButton.AutoSize = true;
            this.bca_radioButton.Location = new System.Drawing.Point(474, 36);
            this.bca_radioButton.Name = "bca_radioButton";
            this.bca_radioButton.Size = new System.Drawing.Size(56, 21);
            this.bca_radioButton.TabIndex = 3;
            this.bca_radioButton.TabStop = true;
            this.bca_radioButton.Text = "BCA";
            this.bca_radioButton.UseVisualStyleBackColor = true;
            this.bca_radioButton.CheckedChanged += new System.EventHandler(this.bca_radioButton_CheckedChanged);
            // 
            // stream_groupBox1
            // 
            this.stream_groupBox1.Controls.Add(this.mba_radioButton);
            this.stream_groupBox1.Controls.Add(this.engg_radioButton);
            this.stream_groupBox1.Controls.Add(this.law_radioButton);
            this.stream_groupBox1.Controls.Add(this.bca_radioButton);
            this.stream_groupBox1.Location = new System.Drawing.Point(264, 84);
            this.stream_groupBox1.Name = "stream_groupBox1";
            this.stream_groupBox1.Size = new System.Drawing.Size(565, 67);
            this.stream_groupBox1.TabIndex = 7;
            this.stream_groupBox1.TabStop = false;
            this.stream_groupBox1.Text = "Choose the stream";
            this.stream_groupBox1.Enter += new System.EventHandler(this.stream_groupBox1_Enter);
            // 
            // selection_Label
            // 
            this.selection_Label.AutoSize = true;
            this.selection_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selection_Label.Location = new System.Drawing.Point(404, 25);
            this.selection_Label.Name = "selection_Label";
            this.selection_Label.Size = new System.Drawing.Size(378, 39);
            this.selection_Label.TabIndex = 8;
            this.selection_Label.Text = "Select Appropriate Data";
            // 
            // engg_groupBox
            // 
            this.engg_groupBox.Controls.Add(this.petro_radioButton);
            this.engg_groupBox.Controls.Add(this.comm_radioButton);
            this.engg_groupBox.Controls.Add(this.mech_radioButton);
            this.engg_groupBox.Controls.Add(this.civil_radioButton);
            this.engg_groupBox.Controls.Add(this.cse_radioButton);
            this.engg_groupBox.Location = new System.Drawing.Point(29, 157);
            this.engg_groupBox.Name = "engg_groupBox";
            this.engg_groupBox.Size = new System.Drawing.Size(1098, 85);
            this.engg_groupBox.TabIndex = 9;
            this.engg_groupBox.TabStop = false;
            this.engg_groupBox.Text = "Choose the branch in engineering";
            this.engg_groupBox.Visible = false;
            // 
            // cse_radioButton
            // 
            this.cse_radioButton.AutoSize = true;
            this.cse_radioButton.Location = new System.Drawing.Point(30, 46);
            this.cse_radioButton.Name = "cse_radioButton";
            this.cse_radioButton.Size = new System.Drawing.Size(144, 21);
            this.cse_radioButton.TabIndex = 0;
            this.cse_radioButton.TabStop = true;
            this.cse_radioButton.Text = "Computer Science";
            this.cse_radioButton.UseVisualStyleBackColor = true;
            this.cse_radioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // civil_radioButton
            // 
            this.civil_radioButton.AutoSize = true;
            this.civil_radioButton.Location = new System.Drawing.Point(180, 46);
            this.civil_radioButton.Name = "civil_radioButton";
            this.civil_radioButton.Size = new System.Drawing.Size(91, 21);
            this.civil_radioButton.TabIndex = 1;
            this.civil_radioButton.TabStop = true;
            this.civil_radioButton.Text = "Civil Engg";
            this.civil_radioButton.UseVisualStyleBackColor = true;
            this.civil_radioButton.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // mech_radioButton
            // 
            this.mech_radioButton.AutoSize = true;
            this.mech_radioButton.Location = new System.Drawing.Point(288, 46);
            this.mech_radioButton.Name = "mech_radioButton";
            this.mech_radioButton.Size = new System.Drawing.Size(137, 21);
            this.mech_radioButton.TabIndex = 2;
            this.mech_radioButton.TabStop = true;
            this.mech_radioButton.Text = "Mechanical Engg";
            this.mech_radioButton.UseVisualStyleBackColor = true;
            this.mech_radioButton.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // comm_radioButton
            // 
            this.comm_radioButton.AutoSize = true;
            this.comm_radioButton.Location = new System.Drawing.Point(442, 46);
            this.comm_radioButton.Name = "comm_radioButton";
            this.comm_radioButton.Size = new System.Drawing.Size(162, 21);
            this.comm_radioButton.TabIndex = 3;
            this.comm_radioButton.TabStop = true;
            this.comm_radioButton.Text = "Communication Engg";
            this.comm_radioButton.UseVisualStyleBackColor = true;
            this.comm_radioButton.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // petro_radioButton
            // 
            this.petro_radioButton.AutoSize = true;
            this.petro_radioButton.Location = new System.Drawing.Point(609, 46);
            this.petro_radioButton.Name = "petro_radioButton";
            this.petro_radioButton.Size = new System.Drawing.Size(129, 21);
            this.petro_radioButton.TabIndex = 4;
            this.petro_radioButton.TabStop = true;
            this.petro_radioButton.Text = "petroleum Engg";
            this.petro_radioButton.UseVisualStyleBackColor = true;
            this.petro_radioButton.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // submit_Button
            // 
            this.submit_Button.Location = new System.Drawing.Point(558, 623);
            this.submit_Button.Name = "submit_Button";
            this.submit_Button.Size = new System.Drawing.Size(75, 23);
            this.submit_Button.TabIndex = 5;
            this.submit_Button.Text = "Submit";
            this.submit_Button.UseVisualStyleBackColor = true;
            this.submit_Button.Click += new System.EventHandler(this.submit_Button_Click);
            // 
            // law_groupBox
            // 
            this.law_groupBox.Controls.Add(this.llb_radioButton);
            this.law_groupBox.Controls.Add(this.llm_radioButton);
            this.law_groupBox.Controls.Add(this.mbl_radioButton);
            this.law_groupBox.Controls.Add(this.dtl_radioButton);
            this.law_groupBox.Location = new System.Drawing.Point(29, 257);
            this.law_groupBox.Name = "law_groupBox";
            this.law_groupBox.Size = new System.Drawing.Size(1098, 100);
            this.law_groupBox.TabIndex = 10;
            this.law_groupBox.TabStop = false;
            this.law_groupBox.Text = "Choose the branch in law";
            this.law_groupBox.Visible = false;
            this.law_groupBox.Enter += new System.EventHandler(this.law_groupBox_Enter);
            // 
            // llb_radioButton
            // 
            this.llb_radioButton.AutoSize = true;
            this.llb_radioButton.Location = new System.Drawing.Point(30, 37);
            this.llb_radioButton.Name = "llb_radioButton";
            this.llb_radioButton.Size = new System.Drawing.Size(58, 21);
            this.llb_radioButton.TabIndex = 11;
            this.llb_radioButton.TabStop = true;
            this.llb_radioButton.Text = "LL.B";
            this.llb_radioButton.UseVisualStyleBackColor = true;
            // 
            // llm_radioButton
            // 
            this.llm_radioButton.AutoSize = true;
            this.llm_radioButton.Location = new System.Drawing.Point(149, 37);
            this.llm_radioButton.Name = "llm_radioButton";
            this.llm_radioButton.Size = new System.Drawing.Size(60, 21);
            this.llm_radioButton.TabIndex = 12;
            this.llm_radioButton.TabStop = true;
            this.llm_radioButton.Text = "LL.M";
            this.llm_radioButton.UseVisualStyleBackColor = true;
            this.llm_radioButton.CheckedChanged += new System.EventHandler(this.llm_radioButton_CheckedChanged);
            // 
            // mbl_radioButton
            // 
            this.mbl_radioButton.AutoSize = true;
            this.mbl_radioButton.Location = new System.Drawing.Point(261, 37);
            this.mbl_radioButton.Name = "mbl_radioButton";
            this.mbl_radioButton.Size = new System.Drawing.Size(137, 21);
            this.mbl_radioButton.TabIndex = 13;
            this.mbl_radioButton.TabStop = true;
            this.mbl_radioButton.Text = "M.Bussiness Law";
            this.mbl_radioButton.UseVisualStyleBackColor = true;
            this.mbl_radioButton.CheckedChanged += new System.EventHandler(this.mbl_radioButton_CheckedChanged);
            // 
            // dtl_radioButton
            // 
            this.dtl_radioButton.AutoSize = true;
            this.dtl_radioButton.Location = new System.Drawing.Point(442, 37);
            this.dtl_radioButton.Name = "dtl_radioButton";
            this.dtl_radioButton.Size = new System.Drawing.Size(56, 21);
            this.dtl_radioButton.TabIndex = 14;
            this.dtl_radioButton.TabStop = true;
            this.dtl_radioButton.Text = "DTL";
            this.dtl_radioButton.UseVisualStyleBackColor = true;
            this.dtl_radioButton.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged_1);
            // 
            // mba_groupBox
            // 
            this.mba_groupBox.Controls.Add(this.finance_radioButton);
            this.mba_groupBox.Controls.Add(this.hrm_radioButton);
            this.mba_groupBox.Controls.Add(this.it_radioButton);
            this.mba_groupBox.Controls.Add(this.mm_radioButton);
            this.mba_groupBox.Location = new System.Drawing.Point(29, 373);
            this.mba_groupBox.Name = "mba_groupBox";
            this.mba_groupBox.Size = new System.Drawing.Size(1098, 100);
            this.mba_groupBox.TabIndex = 11;
            this.mba_groupBox.TabStop = false;
            this.mba_groupBox.Text = "Choose the branch in mba";
            this.mba_groupBox.Visible = false;
            // 
            // finance_radioButton
            // 
            this.finance_radioButton.AutoSize = true;
            this.finance_radioButton.Location = new System.Drawing.Point(30, 42);
            this.finance_radioButton.Name = "finance_radioButton";
            this.finance_radioButton.Size = new System.Drawing.Size(79, 21);
            this.finance_radioButton.TabIndex = 12;
            this.finance_radioButton.TabStop = true;
            this.finance_radioButton.Text = "Finance";
            this.finance_radioButton.UseVisualStyleBackColor = true;
            // 
            // hrm_radioButton
            // 
            this.hrm_radioButton.AutoSize = true;
            this.hrm_radioButton.Location = new System.Drawing.Point(149, 42);
            this.hrm_radioButton.Name = "hrm_radioButton";
            this.hrm_radioButton.Size = new System.Drawing.Size(60, 21);
            this.hrm_radioButton.TabIndex = 13;
            this.hrm_radioButton.TabStop = true;
            this.hrm_radioButton.Text = "HRM";
            this.hrm_radioButton.UseVisualStyleBackColor = true;
            // 
            // it_radioButton
            // 
            this.it_radioButton.AutoSize = true;
            this.it_radioButton.Location = new System.Drawing.Point(261, 42);
            this.it_radioButton.Name = "it_radioButton";
            this.it_radioButton.Size = new System.Drawing.Size(41, 21);
            this.it_radioButton.TabIndex = 14;
            this.it_radioButton.TabStop = true;
            this.it_radioButton.Text = "IT";
            this.it_radioButton.UseVisualStyleBackColor = true;
            // 
            // mm_radioButton
            // 
            this.mm_radioButton.AutoSize = true;
            this.mm_radioButton.Location = new System.Drawing.Point(355, 42);
            this.mm_radioButton.Name = "mm_radioButton";
            this.mm_radioButton.Size = new System.Drawing.Size(158, 21);
            this.mm_radioButton.TabIndex = 15;
            this.mm_radioButton.TabStop = true;
            this.mm_radioButton.Text = "Market management";
            this.mm_radioButton.UseVisualStyleBackColor = true;
            // 
            // bca_groupBox
            // 
            this.bca_groupBox.Controls.Add(this.pm_radioButton);
            this.bca_groupBox.Controls.Add(this.unix_radioButton);
            this.bca_groupBox.Controls.Add(this.dbms_radioButton);
            this.bca_groupBox.Controls.Add(this.ds_radioButton);
            this.bca_groupBox.Controls.Add(this.c_radioButton);
            this.bca_groupBox.Location = new System.Drawing.Point(29, 491);
            this.bca_groupBox.Name = "bca_groupBox";
            this.bca_groupBox.Size = new System.Drawing.Size(1098, 100);
            this.bca_groupBox.TabIndex = 12;
            this.bca_groupBox.TabStop = false;
            this.bca_groupBox.Text = "Choose the branch in bca";
            this.bca_groupBox.Visible = false;
            // 
            // c_radioButton
            // 
            this.c_radioButton.AutoSize = true;
            this.c_radioButton.Location = new System.Drawing.Point(30, 47);
            this.c_radioButton.Name = "c_radioButton";
            this.c_radioButton.Size = new System.Drawing.Size(78, 21);
            this.c_radioButton.TabIndex = 0;
            this.c_radioButton.TabStop = true;
            this.c_radioButton.Text = "C_Lang";
            this.c_radioButton.UseVisualStyleBackColor = true;
            // 
            // ds_radioButton
            // 
            this.ds_radioButton.AutoSize = true;
            this.ds_radioButton.Location = new System.Drawing.Point(149, 47);
            this.ds_radioButton.Name = "ds_radioButton";
            this.ds_radioButton.Size = new System.Drawing.Size(48, 21);
            this.ds_radioButton.TabIndex = 1;
            this.ds_radioButton.TabStop = true;
            this.ds_radioButton.Text = "DS";
            this.ds_radioButton.UseVisualStyleBackColor = true;
            // 
            // dbms_radioButton
            // 
            this.dbms_radioButton.AutoSize = true;
            this.dbms_radioButton.Location = new System.Drawing.Point(261, 47);
            this.dbms_radioButton.Name = "dbms_radioButton";
            this.dbms_radioButton.Size = new System.Drawing.Size(68, 21);
            this.dbms_radioButton.TabIndex = 2;
            this.dbms_radioButton.TabStop = true;
            this.dbms_radioButton.Text = "DBMS";
            this.dbms_radioButton.UseVisualStyleBackColor = true;
            // 
            // unix_radioButton
            // 
            this.unix_radioButton.AutoSize = true;
            this.unix_radioButton.Location = new System.Drawing.Point(364, 47);
            this.unix_radioButton.Name = "unix_radioButton";
            this.unix_radioButton.Size = new System.Drawing.Size(61, 21);
            this.unix_radioButton.TabIndex = 3;
            this.unix_radioButton.TabStop = true;
            this.unix_radioButton.Text = "UNIX";
            this.unix_radioButton.UseVisualStyleBackColor = true;
            // 
            // pm_radioButton
            // 
            this.pm_radioButton.AutoSize = true;
            this.pm_radioButton.Location = new System.Drawing.Point(466, 47);
            this.pm_radioButton.Name = "pm_radioButton";
            this.pm_radioButton.Size = new System.Drawing.Size(49, 21);
            this.pm_radioButton.TabIndex = 4;
            this.pm_radioButton.TabStop = true;
            this.pm_radioButton.Text = "PM";
            this.pm_radioButton.UseVisualStyleBackColor = true;
            this.pm_radioButton.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged_1);
            // 
            // Selection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 658);
            this.Controls.Add(this.bca_groupBox);
            this.Controls.Add(this.mba_groupBox);
            this.Controls.Add(this.law_groupBox);
            this.Controls.Add(this.submit_Button);
            this.Controls.Add(this.engg_groupBox);
            this.Controls.Add(this.selection_Label);
            this.Controls.Add(this.stream_groupBox1);
            this.Name = "Selection";
            this.Text = "Selection";
            this.stream_groupBox1.ResumeLayout(false);
            this.stream_groupBox1.PerformLayout();
            this.engg_groupBox.ResumeLayout(false);
            this.engg_groupBox.PerformLayout();
            this.law_groupBox.ResumeLayout(false);
            this.law_groupBox.PerformLayout();
            this.mba_groupBox.ResumeLayout(false);
            this.mba_groupBox.PerformLayout();
            this.bca_groupBox.ResumeLayout(false);
            this.bca_groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton engg_radioButton;
        private System.Windows.Forms.RadioButton law_radioButton;
        private System.Windows.Forms.RadioButton mba_radioButton;
        private System.Windows.Forms.RadioButton bca_radioButton;
        private System.Windows.Forms.GroupBox stream_groupBox1;
        private System.Windows.Forms.Label selection_Label;
        private System.Windows.Forms.GroupBox engg_groupBox;
        private System.Windows.Forms.RadioButton petro_radioButton;
        private System.Windows.Forms.RadioButton comm_radioButton;
        private System.Windows.Forms.RadioButton mech_radioButton;
        private System.Windows.Forms.RadioButton civil_radioButton;
        private System.Windows.Forms.RadioButton cse_radioButton;
        private System.Windows.Forms.Button submit_Button;
        private System.Windows.Forms.GroupBox law_groupBox;
        private System.Windows.Forms.RadioButton llb_radioButton;
        private System.Windows.Forms.RadioButton llm_radioButton;
        private System.Windows.Forms.RadioButton mbl_radioButton;
        private System.Windows.Forms.RadioButton dtl_radioButton;
        private System.Windows.Forms.GroupBox mba_groupBox;
        private System.Windows.Forms.RadioButton it_radioButton;
        private System.Windows.Forms.RadioButton mm_radioButton;
        private System.Windows.Forms.RadioButton finance_radioButton;
        private System.Windows.Forms.RadioButton hrm_radioButton;
        private System.Windows.Forms.GroupBox bca_groupBox;
        private System.Windows.Forms.RadioButton pm_radioButton;
        private System.Windows.Forms.RadioButton unix_radioButton;
        private System.Windows.Forms.RadioButton dbms_radioButton;
        private System.Windows.Forms.RadioButton ds_radioButton;
        private System.Windows.Forms.RadioButton c_radioButton;
    }
}