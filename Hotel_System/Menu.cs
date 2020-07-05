using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_System
{
    public partial class Menu : Form
    {
        string RT = "RT1";
        private int Id;
        private int days;
        public Menu(int id)
        {
            InitializeComponent();
            Id = id;
        }

        private string Type;
        private string CheckIn;
        private string CheckOut;
        private string rt;
        private double ttlPrice;

        public void setAll(string type, string checkIn, string checkOut, string RT, double totalPrice)
        {
            Type= type;
            CheckIn = checkIn;
            CheckOut = checkOut;
            rt = RT;
            ttlPrice = totalPrice;
        }

        public void setDays(int Days)
        {
            days = Days;
        }

        public void setRT(string RTName)
        {
            RT = RTName;
        }

        private void initRT()
        {
            string connectionstring;
            SqlConnection cnn;
            SqlCommand command;
            SqlDataReader dataReader;
            connectionstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\GAMER\\source\\repos\\Hotel_System\\Hotel_System\\Database.mdf;Integrated Security=True";
            cnn = new SqlConnection(connectionstring);
            cnn.Open();
            string sql = "SELECT * FROM " + RT;
            command = new SqlCommand(sql, cnn);
            
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                FoodBox.Items.Add(dataReader.GetValue(1).ToString().Trim() + " " + dataReader.GetValue(2).ToString().Trim() + " BD");
                DrinkBox.Items.Add(dataReader.GetValue(3).ToString().Trim() + " " + dataReader.GetValue(4).ToString().Trim() + " BD");
            }
        }


        private double price = 0;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            initRT();
        }

        string dish;
        string drink = "";
        public void button1_Click(object sender, EventArgs e)
        {
            if (FoodBox.SelectedItem != null)
            {
                string[] foodnPrice = FoodBox.SelectedItem.ToString().Split(' ');
                int i = foodnPrice.Length;
                dish = foodnPrice[0] + " " + foodnPrice[1] + " " + foodnPrice[2];
                if (i > 3)
                {
                    dish += foodnPrice[3];
                }
                price = double.Parse(foodnPrice[i-2]);
            }
            else
            {
                dish = "No dish";
            }

            if (DrinkBox.SelectedItem != null)
            {
                string[] drinknPrice = DrinkBox.SelectedItem.ToString().Split(' ');
                int i = drinknPrice.Length;
                drink = drinknPrice[0] + " " + drinknPrice[1] + " " + drinknPrice[2];
                if (i > 3)
                {
                    drink += drinknPrice[3];
                }
                price += double.Parse(drinknPrice[i-2]);
            }
            else
            {
                drink = "No drink";
            }

            LastForm frm = new LastForm(Id);
            price *= days;
            frm.setRTPrice(price);
            frm.setAll(Type, CheckIn, CheckOut, rt , ttlPrice);
            price += ttlPrice;
            frm.setRest( dish , drink , price);
            this.Hide();
            frm.ShowDialog();
        }


        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
