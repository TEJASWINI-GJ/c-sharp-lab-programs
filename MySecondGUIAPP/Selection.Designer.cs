namespace MySecondGUIAPP
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
            this.engg_RadioButton = new System.Windows.Forms.RadioButton();
            this.law_RadioButton = new System.Windows.Forms.RadioButton();
            this.mba_RadioButton = new System.Windows.Forms.RadioButton();
            this.bca_RadioButton = new System.Windows.Forms.RadioButton();
            this.stream_groupBox = new System.Windows.Forms.GroupBox();
            this.selection_Label = new System.Windows.Forms.Label();
            this.engg_GroupBox = new System.Windows.Forms.GroupBox();
            this.cse_RadioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.mec_RadioButton3 = new System.Windows.Forms.RadioButton();
            this.electr_RadioButton4 = new System.Windows.Forms.RadioButton();
            this.elec_RadioButton5 = new System.Windows.Forms.RadioButton();
            this.civ_RadioButton6 = new System.Windows.Forms.RadioButton();
            this.pet_RadioButton7 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.submit_Button = new System.Windows.Forms.Button();
            this.stream_groupBox.SuspendLayout();
            this.engg_GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // engg_RadioButton
            // 
            this.engg_RadioButton.AutoSize = true;
            this.engg_RadioButton.Location = new System.Drawing.Point(57, 19);
            this.engg_RadioButton.Name = "engg_RadioButton";
            this.engg_RadioButton.Size = new System.Drawing.Size(81, 17);
            this.engg_RadioButton.TabIndex = 0;
            this.engg_RadioButton.TabStop = true;
            this.engg_RadioButton.Text = "Engineering";
            this.engg_RadioButton.UseVisualStyleBackColor = true;
            this.engg_RadioButton.CheckedChanged += new System.EventHandler(this.engg_RadioButton_CheckedChanged);
            // 
            // law_RadioButton
            // 
            this.law_RadioButton.AutoSize = true;
            this.law_RadioButton.Location = new System.Drawing.Point(165, 19);
            this.law_RadioButton.Name = "law_RadioButton";
            this.law_RadioButton.Size = new System.Drawing.Size(45, 17);
            this.law_RadioButton.TabIndex = 1;
            this.law_RadioButton.TabStop = true;
            this.law_RadioButton.Text = "Law";
            this.law_RadioButton.UseVisualStyleBackColor = true;
            // 
            // mba_RadioButton
            // 
            this.mba_RadioButton.AutoSize = true;
            this.mba_RadioButton.Location = new System.Drawing.Point(249, 19);
            this.mba_RadioButton.Name = "mba_RadioButton";
            this.mba_RadioButton.Size = new System.Drawing.Size(48, 17);
            this.mba_RadioButton.TabIndex = 2;
            this.mba_RadioButton.TabStop = true;
            this.mba_RadioButton.Text = "MBA";
            this.mba_RadioButton.UseVisualStyleBackColor = true;
            // 
            // bca_RadioButton
            // 
            this.bca_RadioButton.AutoSize = true;
            this.bca_RadioButton.Location = new System.Drawing.Point(328, 19);
            this.bca_RadioButton.Name = "bca_RadioButton";
            this.bca_RadioButton.Size = new System.Drawing.Size(46, 17);
            this.bca_RadioButton.TabIndex = 3;
            this.bca_RadioButton.TabStop = true;
            this.bca_RadioButton.Text = "BCA";
            this.bca_RadioButton.UseVisualStyleBackColor = true;
            // 
            // stream_groupBox
            // 
            this.stream_groupBox.Controls.Add(this.engg_RadioButton);
            this.stream_groupBox.Controls.Add(this.bca_RadioButton);
            this.stream_groupBox.Controls.Add(this.law_RadioButton);
            this.stream_groupBox.Controls.Add(this.mba_RadioButton);
            this.stream_groupBox.Location = new System.Drawing.Point(187, 52);
            this.stream_groupBox.Name = "stream_groupBox";
            this.stream_groupBox.Size = new System.Drawing.Size(398, 59);
            this.stream_groupBox.TabIndex = 4;
            this.stream_groupBox.TabStop = false;
            this.stream_groupBox.Text = "Choose the stream";
            // 
            // selection_Label
            // 
            this.selection_Label.AutoSize = true;
            this.selection_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selection_Label.Location = new System.Drawing.Point(224, 9);
            this.selection_Label.Name = "selection_Label";
            this.selection_Label.Size = new System.Drawing.Size(302, 31);
            this.selection_Label.TabIndex = 5;
            this.selection_Label.Text = "Select Appropriate Data";
            // 
            // engg_GroupBox
            // 
            this.engg_GroupBox.Controls.Add(this.pet_RadioButton7);
            this.engg_GroupBox.Controls.Add(this.civ_RadioButton6);
            this.engg_GroupBox.Controls.Add(this.elec_RadioButton5);
            this.engg_GroupBox.Controls.Add(this.electr_RadioButton4);
            this.engg_GroupBox.Controls.Add(this.mec_RadioButton3);
            this.engg_GroupBox.Controls.Add(this.radioButton2);
            this.engg_GroupBox.Controls.Add(this.cse_RadioButton1);
            this.engg_GroupBox.Location = new System.Drawing.Point(12, 117);
            this.engg_GroupBox.Name = "engg_GroupBox";
            this.engg_GroupBox.Size = new System.Drawing.Size(775, 65);
            this.engg_GroupBox.TabIndex = 6;
            this.engg_GroupBox.TabStop = false;
            this.engg_GroupBox.Text = "Choose the branch in Engineering";
            this.engg_GroupBox.Visible = false;
            // 
            // cse_RadioButton1
            // 
            this.cse_RadioButton1.AutoSize = true;
            this.cse_RadioButton1.Location = new System.Drawing.Point(6, 19);
            this.cse_RadioButton1.Name = "cse_RadioButton1";
            this.cse_RadioButton1.Size = new System.Drawing.Size(112, 17);
            this.cse_RadioButton1.TabIndex = 0;
            this.cse_RadioButton1.TabStop = true;
            this.cse_RadioButton1.Text = "Computer Science";
            this.cse_RadioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(143, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(119, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Information Science";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // mec_RadioButton3
            // 
            this.mec_RadioButton3.AutoSize = true;
            this.mec_RadioButton3.Location = new System.Drawing.Point(291, 19);
            this.mec_RadioButton3.Name = "mec_RadioButton3";
            this.mec_RadioButton3.Size = new System.Drawing.Size(80, 17);
            this.mec_RadioButton3.TabIndex = 2;
            this.mec_RadioButton3.TabStop = true;
            this.mec_RadioButton3.Text = "Mechanical";
            this.mec_RadioButton3.UseVisualStyleBackColor = true;
            // 
            // electr_RadioButton4
            // 
            this.electr_RadioButton4.AutoSize = true;
            this.electr_RadioButton4.Location = new System.Drawing.Point(396, 19);
            this.electr_RadioButton4.Name = "electr_RadioButton4";
            this.electr_RadioButton4.Size = new System.Drawing.Size(77, 17);
            this.electr_RadioButton4.TabIndex = 3;
            this.electr_RadioButton4.TabStop = true;
            this.electr_RadioButton4.Text = "Electronics";
            this.electr_RadioButton4.UseVisualStyleBackColor = true;
            // 
            // elec_RadioButton5
            // 
            this.elec_RadioButton5.AutoSize = true;
            this.elec_RadioButton5.Location = new System.Drawing.Point(503, 19);
            this.elec_RadioButton5.Name = "elec_RadioButton5";
            this.elec_RadioButton5.Size = new System.Drawing.Size(68, 17);
            this.elec_RadioButton5.TabIndex = 4;
            this.elec_RadioButton5.TabStop = true;
            this.elec_RadioButton5.Text = "Electrical";
            this.elec_RadioButton5.UseVisualStyleBackColor = true;
            // 
            // civ_RadioButton6
            // 
            this.civ_RadioButton6.AutoSize = true;
            this.civ_RadioButton6.Location = new System.Drawing.Point(590, 19);
            this.civ_RadioButton6.Name = "civ_RadioButton6";
            this.civ_RadioButton6.Size = new System.Drawing.Size(44, 17);
            this.civ_RadioButton6.TabIndex = 5;
            this.civ_RadioButton6.TabStop = true;
            this.civ_RadioButton6.Text = "Civil";
            this.civ_RadioButton6.UseVisualStyleBackColor = true;
            // 
            // pet_RadioButton7
            // 
            this.pet_RadioButton7.AutoSize = true;
            this.pet_RadioButton7.Location = new System.Drawing.Point(663, 19);
            this.pet_RadioButton7.Name = "pet_RadioButton7";
            this.pet_RadioButton7.Size = new System.Drawing.Size(72, 17);
            this.pet_RadioButton7.TabIndex = 6;
            this.pet_RadioButton7.TabStop = true;
            this.pet_RadioButton7.Text = "Petroleum";
            this.pet_RadioButton7.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // submit_Button
            // 
            this.submit_Button.Location = new System.Drawing.Point(352, 208);
            this.submit_Button.Name = "submit_Button";
            this.submit_Button.Size = new System.Drawing.Size(75, 23);
            this.submit_Button.TabIndex = 9;
            this.submit_Button.Text = "Submit";
            this.submit_Button.UseVisualStyleBackColor = true;
            this.submit_Button.Click += new System.EventHandler(this.submit_Button_Click);
            // 
            // Selection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.engg_GroupBox);
            this.Controls.Add(this.submit_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selection_Label);
            this.Controls.Add(this.stream_groupBox);
            this.Name = "Selection";
            this.Text = "Selection";
            this.stream_groupBox.ResumeLayout(false);
            this.stream_groupBox.PerformLayout();
            this.engg_GroupBox.ResumeLayout(false);
            this.engg_GroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton engg_RadioButton;
        private System.Windows.Forms.RadioButton law_RadioButton;
        private System.Windows.Forms.RadioButton mba_RadioButton;
        private System.Windows.Forms.RadioButton bca_RadioButton;
        private System.Windows.Forms.GroupBox stream_groupBox;
        private System.Windows.Forms.Label selection_Label;
        private System.Windows.Forms.GroupBox engg_GroupBox;
        private System.Windows.Forms.RadioButton pet_RadioButton7;
        private System.Windows.Forms.RadioButton civ_RadioButton6;
        private System.Windows.Forms.RadioButton elec_RadioButton5;
        private System.Windows.Forms.RadioButton electr_RadioButton4;
        private System.Windows.Forms.RadioButton mec_RadioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton cse_RadioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submit_Button;
    }
}