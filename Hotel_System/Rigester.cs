using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Hotel_System
{
    public partial class Rigester : Form
    {
        public Rigester()
        {
            InitializeComponent();
        }

        public void bs()
        {
            SqlConnection cnn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\GAMER\\source\\repos\\Hotel_System\\Hotel_System\\Database.mdf;Integrated Security = True");
            cnn.Open();
            string sql = "UserAdd";
            SqlCommand command = new SqlCommand(sql , cnn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@Name" , UserNameL.Text.Trim());
            command.Parameters.AddWithValue("@Password", Passtxt.Text.Trim());
            command.Parameters.AddWithValue("@MobileNumber", Phonetxt.Text.Trim());
        }
        

        private void Rigester_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (phoneCheck)
            {
                WrongL.Visible = false;
                if (Phonetxt.Text.Length > 7)
                {
                    phoneCheck = true;
                }
                else
                {
                    phoneCheck = false;
                    WrongL.Text = "Mobile Number should be at least 8 numbers";
                    WrongL.Visible = true;
                }
            }
            if (passCheck & nameCheck & phoneCheck)
            {
                MessageBox.Show("Registeration Completed \n There is a problem Idk what it is but it is not adding the values to the database");
                this.Hide();
                bs();
                Form1 frm = new Form1();
                frm.ShowDialog();
            }
        }


        private bool passCheck = false;
        private void Pass2txt_TextChanged(object sender, EventArgs e)
        {
            if (!Passtxt.Text.Equals(Pass2txt.Text))
            {
                WrongL.Text = "The password does not match.";
                WrongL.Visible = true;
            }
            else
            {
                WrongL.Visible = false;
                passCheck = true;
            }
        }

        private bool nameCheck;
        private void Usertxt_TextChanged(object sender, EventArgs e)
        {
            nameCheck = true;
            foreach (char c in Usertxt.Text)
            {
                
                if (!char.IsLetter(c))
                {
                    nameCheck = false;
                    WrongL.Text = "Only letters are acceptable in Name field.";
                    WrongL.Visible = true;
                }
            }
            if (nameCheck)
            {
                WrongL.Visible = false;
            }
        }

        private bool phoneCheck;
        private void Phonetxt_TextChanged(object sender, EventArgs e)
        {
            phoneCheck = true;
            foreach (char c in Phonetxt.Text)
            {
                if (!char.IsDigit(c))
                {
                    phoneCheck = false;
                    WrongL.Text = "Only numbers are acceptable in Mobile Number field.";
                    WrongL.Visible = true;
                }
            }
        }
    }
}
