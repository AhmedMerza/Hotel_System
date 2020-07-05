namespace Hotel_System
{
    partial class Form2
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
            this.PersonalL = new System.Windows.Forms.Label();
            this.SingleRB = new System.Windows.Forms.RadioButton();
            this.DoubleRB = new System.Windows.Forms.RadioButton();
            this.FamilyRB = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.RT1 = new System.Windows.Forms.RadioButton();
            this.RT2 = new System.Windows.Forms.RadioButton();
            this.RT3 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Menubtn = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PersonalL
            // 
            this.PersonalL.AutoSize = true;
            this.PersonalL.Location = new System.Drawing.Point(12, 9);
            this.PersonalL.Name = "PersonalL";
            this.PersonalL.Size = new System.Drawing.Size(41, 13);
            this.PersonalL.TabIndex = 0;
            this.PersonalL.Text = "Name: ";
            // 
            // SingleRB
            // 
            this.SingleRB.AutoSize = true;
            this.SingleRB.Location = new System.Drawing.Point(3, 3);
            this.SingleRB.Name = "SingleRB";
            this.SingleRB.Size = new System.Drawing.Size(54, 17);
            this.SingleRB.TabIndex = 1;
            this.SingleRB.TabStop = true;
            this.SingleRB.Text = "Single";
            this.SingleRB.UseVisualStyleBackColor = true;
            this.SingleRB.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // DoubleRB
            // 
            this.DoubleRB.AutoSize = true;
            this.DoubleRB.Location = new System.Drawing.Point(57, 3);
            this.DoubleRB.Name = "DoubleRB";
            this.DoubleRB.Size = new System.Drawing.Size(59, 17);
            this.DoubleRB.TabIndex = 2;
            this.DoubleRB.TabStop = true;
            this.DoubleRB.Text = "Double";
            this.DoubleRB.UseVisualStyleBackColor = true;
            this.DoubleRB.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // FamilyRB
            // 
            this.FamilyRB.AutoSize = true;
            this.FamilyRB.Location = new System.Drawing.Point(117, 3);
            this.FamilyRB.Name = "FamilyRB";
            this.FamilyRB.Size = new System.Drawing.Size(54, 17);
            this.FamilyRB.TabIndex = 3;
            this.FamilyRB.TabStop = true;
            this.FamilyRB.Text = "Family";
            this.FamilyRB.UseVisualStyleBackColor = true;
            this.FamilyRB.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Room Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Check in Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Check in Date:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(15, 251);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 8;
            this.dateTimePicker2.Value = new System.DateTime(2020, 6, 30, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Restaurant Type:";
            // 
            // RT1
            // 
            this.RT1.AutoSize = true;
            this.RT1.Location = new System.Drawing.Point(0, 3);
            this.RT1.Name = "RT1";
            this.RT1.Size = new System.Drawing.Size(55, 17);
            this.RT1.TabIndex = 10;
            this.RT1.TabStop = true;
            this.RT1.Text = "Arabic";
            this.RT1.UseVisualStyleBackColor = true;
            this.RT1.Click += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // RT2
            // 
            this.RT2.AutoSize = true;
            this.RT2.Location = new System.Drawing.Point(61, 3);
            this.RT2.Name = "RT2";
            this.RT2.Size = new System.Drawing.Size(54, 17);
            this.RT2.TabIndex = 11;
            this.RT2.TabStop = true;
            this.RT2.Text = "Indian";
            this.RT2.UseVisualStyleBackColor = true;
            this.RT2.Click += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // RT3
            // 
            this.RT3.AutoSize = true;
            this.RT3.Location = new System.Drawing.Point(117, 3);
            this.RT3.Name = "RT3";
            this.RT3.Size = new System.Drawing.Size(53, 17);
            this.RT3.TabIndex = 12;
            this.RT3.TabStop = true;
            this.RT3.Text = "Italian";
            this.RT3.UseVisualStyleBackColor = true;
            this.RT3.Click += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RT1);
            this.panel1.Controls.Add(this.RT3);
            this.panel1.Controls.Add(this.RT2);
            this.panel1.Location = new System.Drawing.Point(15, 332);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 27);
            this.panel1.TabIndex = 13;
            // 
            // Menubtn
            // 
            this.Menubtn.Location = new System.Drawing.Point(15, 367);
            this.Menubtn.Name = "Menubtn";
            this.Menubtn.Size = new System.Drawing.Size(75, 23);
            this.Menubtn.TabIndex = 14;
            this.Menubtn.Text = "Menu";
            this.Menubtn.UseVisualStyleBackColor = true;
            this.Menubtn.Click += new System.EventHandler(this.Menubtn_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Enabled = false;
            this.btnFinish.Location = new System.Drawing.Point(72, 439);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(75, 23);
            this.btnFinish.TabIndex = 15;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SingleRB);
            this.panel2.Controls.Add(this.DoubleRB);
            this.panel2.Controls.Add(this.FamilyRB);
            this.panel2.Location = new System.Drawing.Point(11, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 29);
            this.panel2.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 172);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.Value = new System.DateTime(2020, 6, 30, 0, 0, 0, 0);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 474);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.Menubtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PersonalL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PersonalL;
        private System.Windows.Forms.RadioButton SingleRB;
        private System.Windows.Forms.RadioButton DoubleRB;
        private System.Windows.Forms.RadioButton FamilyRB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton RT1;
        private System.Windows.Forms.RadioButton RT2;
        private System.Windows.Forms.RadioButton RT3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Menubtn;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}