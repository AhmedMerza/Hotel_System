using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Hotel_System
{
    public partial class Form1 : Form
    {

        private int id;
        public Form1()
        {
            InitializeComponent();
            Usertxt.Select();
            WrongL.Visible = false;
        }





        private void Loginbtn_Click(object sender, EventArgs e)
        {
                if (check())
            {
                this.Hide();
                Form2 frm = new Form2(id);
                frm.ShowDialog();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private bool check()
        {
            string connectionString;
            SqlConnection cnn;
            SqlCommand command;
            SqlDataReader dataReader;
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\GAMER\\source\\repos\\Hotel_System\\Hotel_System\\Database.mdf;Integrated Security=True";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string sql = "SELECT Id ,Name , Password FROM INFO";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            while(dataReader.Read()){
                if (Usertxt.Text.Equals(dataReader.GetValue(1).ToString().Trim())&& Passtxt.Text.Equals(dataReader.GetValue(2).ToString().Trim()))
                {
                    id = int.Parse(dataReader.GetValue(0).ToString());
                    return true;
                }
            }
            cnn.Close();
            WrongL.Visible = true;
            return false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rigester frm = new Rigester();
            frm.ShowDialog();
        }

    }
}
