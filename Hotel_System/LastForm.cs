using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hotel_System
{
    public partial class LastForm : Form
    {
        private int Id;

        public LastForm()
        {
            InitializeComponent();
        }
        public LastForm(int id)
        {
            InitializeComponent();
            Id = id;
            setData();
        }

        private void setData()
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
            dataL.Text = "Id: " + dataReader.GetValue(0).ToString().Trim() + "\n" + "Name: " + dataReader.GetValue(1).ToString().Trim() + "\n" +
                "Mobile Number: " + dataReader.GetValue(2).ToString().Trim();
        }
        private void LastForm_Load(object sender, EventArgs e)
        {

        }


        public void setAll(string type , string checkIn , string checkOut , string RT , double totalPrice)
        {
            TypeL.Text += type + " " + totalPrice + " BD";
            CheckInL.Text += checkIn;
            CheckOutL.Text += checkOut;
            RTL.Text += RT + " Restaurant";
        }

        public void setRTPrice(double price)
        {
            RTPrice.Text = price + " BD";
        }

        public void setRest(string dish , string drink , double price)
        {
            DishL.Text += dish;
            DrinkL.Text += drink;
            PriceL.Text += price + " BD";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DialogResult conf = MessageBox.Show("Are you sure?", "Conforming", MessageBoxButtons.YesNo);
            if (conf ==DialogResult.Yes)
            {
                this.Dispose();
            }
        }
    }
}
