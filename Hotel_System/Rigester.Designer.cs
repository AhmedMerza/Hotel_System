namespace Hotel_System
{
    partial class Rigester
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
            this.Passtxt = new System.Windows.Forms.TextBox();
            this.Usertxt = new System.Windows.Forms.TextBox();
            this.PasswordL = new System.Windows.Forms.Label();
            this.UserNameL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Pass2txt = new System.Windows.Forms.TextBox();
            this.Phonetxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.WrongL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Passtxt
            // 
            this.Passtxt.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Passtxt.Location = new System.Drawing.Point(133, 108);
            this.Passtxt.Name = "Passtxt";
            this.Passtxt.PasswordChar = '*';
            this.Passtxt.Size = new System.Drawing.Size(155, 20);
            this.Passtxt.TabIndex = 9;
            this.Passtxt.TextChanged += new System.EventHandler(this.Pass2txt_TextChanged);
            // 
            // Usertxt
            // 
            this.Usertxt.Location = new System.Drawing.Point(133, 82);
            this.Usertxt.Name = "Usertxt";
            this.Usertxt.Size = new System.Drawing.Size(155, 20);
            this.Usertxt.TabIndex = 8;
            this.Usertxt.Tag = "";
            this.Usertxt.TextChanged += new System.EventHandler(this.Usertxt_TextChanged);
            // 
            // PasswordL
            // 
            this.PasswordL.AutoSize = true;
            this.PasswordL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordL.Location = new System.Drawing.Point(12, 115);
            this.PasswordL.Name = "PasswordL";
            this.PasswordL.Size = new System.Drawing.Size(65, 13);
            this.PasswordL.TabIndex = 7;
            this.PasswordL.Text = "Password:";
            // 
            // UserNameL
            // 
            this.UserNameL.AutoSize = true;
            this.UserNameL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameL.Location = new System.Drawing.Point(12, 82);
            this.UserNameL.Name = "UserNameL";
            this.UserNameL.Size = new System.Drawing.Size(71, 13);
            this.UserNameL.TabIndex = 6;
            this.UserNameL.Text = "First Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mobile Number: ";
            // 
            // Pass2txt
            // 
            this.Pass2txt.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Pass2txt.Location = new System.Drawing.Point(133, 138);
            this.Pass2txt.Name = "Pass2txt";
            this.Pass2txt.PasswordChar = '*';
            this.Pass2txt.Size = new System.Drawing.Size(155, 20);
            this.Pass2txt.TabIndex = 11;
            this.Pass2txt.TextChanged += new System.EventHandler(this.Pass2txt_TextChanged);
            // 
            // Phonetxt
            // 
            this.Phonetxt.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Phonetxt.Location = new System.Drawing.Point(133, 169);
            this.Phonetxt.Name = "Phonetxt";
            this.Phonetxt.Size = new System.Drawing.Size(155, 20);
            this.Phonetxt.TabIndex = 13;
            this.Phonetxt.TextChanged += new System.EventHandler(this.Phonetxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "ReEnter Password:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Sign Up";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WrongL
            // 
            this.WrongL.AutoSize = true;
            this.WrongL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WrongL.ForeColor = System.Drawing.Color.Red;
            this.WrongL.Location = new System.Drawing.Point(12, 216);
            this.WrongL.Name = "WrongL";
            this.WrongL.Size = new System.Drawing.Size(181, 13);
            this.WrongL.TabIndex = 15;
            this.WrongL.Text = "The password does not match.";
            this.WrongL.Visible = false;
            // 
            // Rigester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 282);
            this.Controls.Add(this.WrongL);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Phonetxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Pass2txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Passtxt);
            this.Controls.Add(this.Usertxt);
            this.Controls.Add(this.PasswordL);
            this.Controls.Add(this.UserNameL);
            this.Name = "Rigester";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rigester";
            this.Load += new System.EventHandler(this.Rigester_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Passtxt;
        private System.Windows.Forms.TextBox Usertxt;
        private System.Windows.Forms.Label PasswordL;
        private System.Windows.Forms.Label UserNameL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Pass2txt;
        private System.Windows.Forms.TextBox Phonetxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label WrongL;
    }
}