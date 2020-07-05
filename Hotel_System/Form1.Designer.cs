namespace Hotel_System
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
            this.UserNameL = new System.Windows.Forms.Label();
            this.PasswordL = new System.Windows.Forms.Label();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.Usertxt = new System.Windows.Forms.TextBox();
            this.Passtxt = new System.Windows.Forms.TextBox();
            this.WrongL = new System.Windows.Forms.Label();
            this.LoginPic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPic)).BeginInit();
            this.SuspendLayout();
            // 
            // UserNameL
            // 
            this.UserNameL.AutoSize = true;
            this.UserNameL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameL.Location = new System.Drawing.Point(12, 225);
            this.UserNameL.Name = "UserNameL";
            this.UserNameL.Size = new System.Drawing.Size(47, 13);
            this.UserNameL.TabIndex = 0;
            this.UserNameL.Text = "Name: ";
            // 
            // PasswordL
            // 
            this.PasswordL.AutoSize = true;
            this.PasswordL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordL.Location = new System.Drawing.Point(12, 261);
            this.PasswordL.Name = "PasswordL";
            this.PasswordL.Size = new System.Drawing.Size(65, 13);
            this.PasswordL.TabIndex = 1;
            this.PasswordL.Text = "Password:";
            // 
            // Loginbtn
            // 
            this.Loginbtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Loginbtn.Location = new System.Drawing.Point(87, 321);
            this.Loginbtn.Margin = new System.Windows.Forms.Padding(0);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(75, 23);
            this.Loginbtn.TabIndex = 3;
            this.Loginbtn.Text = "Login";
            this.Loginbtn.UseVisualStyleBackColor = false;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // Usertxt
            // 
            this.Usertxt.Location = new System.Drawing.Point(87, 222);
            this.Usertxt.Name = "Usertxt";
            this.Usertxt.Size = new System.Drawing.Size(123, 20);
            this.Usertxt.TabIndex = 4;
            this.Usertxt.Tag = "";
            // 
            // Passtxt
            // 
            this.Passtxt.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Passtxt.Location = new System.Drawing.Point(87, 258);
            this.Passtxt.Name = "Passtxt";
            this.Passtxt.PasswordChar = '*';
            this.Passtxt.Size = new System.Drawing.Size(123, 20);
            this.Passtxt.TabIndex = 5;
            // 
            // WrongL
            // 
            this.WrongL.AutoSize = true;
            this.WrongL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WrongL.ForeColor = System.Drawing.Color.Red;
            this.WrongL.Location = new System.Drawing.Point(5, 299);
            this.WrongL.Name = "WrongL";
            this.WrongL.Size = new System.Drawing.Size(254, 13);
            this.WrongL.TabIndex = 6;
            this.WrongL.Text = "You entered wrong Username or Passpowrd";
            // 
            // LoginPic
            // 
            this.LoginPic.BackColor = System.Drawing.Color.LightSlateGray;
            this.LoginPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoginPic.Image = global::Hotel_System.Properties.Resources.Login_Pic;
            this.LoginPic.Location = new System.Drawing.Point(50, 12);
            this.LoginPic.Name = "LoginPic";
            this.LoginPic.Size = new System.Drawing.Size(160, 160);
            this.LoginPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LoginPic.TabIndex = 2;
            this.LoginPic.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SlateGray;
            this.label1.Location = new System.Drawing.Point(73, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Create new Profile";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(264, 378);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WrongL);
            this.Controls.Add(this.LoginPic);
            this.Controls.Add(this.Passtxt);
            this.Controls.Add(this.Usertxt);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.PasswordL);
            this.Controls.Add(this.UserNameL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LoginPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserNameL;
        private System.Windows.Forms.Label PasswordL;
        private System.Windows.Forms.PictureBox LoginPic;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.TextBox Usertxt;
        private System.Windows.Forms.TextBox Passtxt;
        private System.Windows.Forms.Label WrongL;
        private System.Windows.Forms.Label label1;
    }
}

