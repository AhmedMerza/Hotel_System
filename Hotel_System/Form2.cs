using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_System
{
    public partial class Form2 : Form
    {

        private int Id;

        private double totalPrice;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(int id)
        {
            InitializeComponent();
           Id = id;
            getData();
            Menubtn.Enabled = false;
            label1.Select();
        }

        private void getData()
        {
            string connectionString;
            SqlConnection cnn;
            SqlCommand command;
            SqlDataReader dataReader;
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\GAMER\\source\\repos\\Hotel_System\\Hotel_System\\Database.mdf;Integrated Security=True";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string sql = "SELECT Id , Name , MobileNumber FROM INFO WHERE Id = " + Id;
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            dataReader.Read();
            PersonalL.Text = "Id: " +dataReader.GetValue(0).ToString().Trim() + "\n" + "Name: " +dataReader.GetValue(1).ToString().Trim() + "\n" + 
                "Mobile Number: " +dataReader.GetValue(2).ToString().Trim();
        }
        private bool checkDate()
        {
            int price = calculating();
            if ( price> 0)
            {
                
            if (SingleRB.Checked)
            {
                price *= 2;
            }
            else if (DoubleRB.Checked)
            {
                price *= 3;
            }
            else
            {
                price *= 4;
            }
                totalPrice += price;
                return true;
            }
            else
            {
                MessageBox.Show("Check the date that you chose", "Error");
                return false;
            }
        }

        private string RT;
        private string RTName;
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton RB = sender as RadioButton;
            RT = RB.Text;
            if (SingleRB.Checked | DoubleRB.Checked | FamilyRB.Checked)
            {
                Menubtn.Enabled = true;
            }
            RTName = RB.Name;
        }

        private string type;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            btnFinish.Enabled = true;
            if (RT1.Checked | RT2.Checked | RT3.Checked)
            {
                Menubtn.Enabled = true;
            }
            RadioButton RB = sender as RadioButton;
            type = RB.Text;
        }

        private void Menubtn_Click(object sender, EventArgs e)
        {
            if (checkDate())
            {
                Menu frm = new Menu(Id);
                frm.setRT(RTName);
                frm.setAll(type, dateTimePicker1.Text, dateTimePicker2.Text, RT, totalPrice);
                frm.setDays(days);
                this.Hide();
                frm.ShowDialog();
            }
        }

        private int days;

        private int calculating()
        {
            DateTime checkIn = dateTimePicker1.Value.Date;
            DateTime checkOut = dateTimePicker2.Value.Date;
            TimeSpan diff = checkOut - checkIn;
             days = diff.Days;
            return days;
        }


        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (checkDate())
            {
                if (!RT1.Checked & !RT2.Checked & !RT3.Checked)
                {
                    drink = "No Drink";
                    dish = "No Dish";
                    RT = "No";
                    LastForm frm = new LastForm(Id);
                    frm.setAll(type, dateTimePicker1.Text, dateTimePicker2.Text, RT , totalPrice);
                    frm.setRest(dish , drink , totalPrice);
                    this.Hide();
                    frm.ShowDialog();
                }
            }
        }
        
        string drink;
        string dish;

        private void Form2_Load(object sender, EventArgs e)
        {
        }
    }
}
