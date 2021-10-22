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
namespace WindowsFormsApp9
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection cnn;
            connectionString = @"Data Source=ONNHTF40C\SQLEXPRESS;Initial Catalog=Test1;Integrated Security=True";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            //SqlDataAdapter adapter = new SqlDataAdapter();
            String sql, Output = "";

            sql = "Select FoodName, Quantity from menu";
            /*
            sql = "insert into menu (FoodName, Quantity) values('"+"Burger heo"+"',2)";
            
              * sql = "delete menu where Quantity = 1";
             */
            command = new SqlCommand(sql, cnn);
            /* vd 4
            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();
            */
            
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + "\n";
            }
            MessageBox.Show(Output);
            dataReader.Close();
            
            command.Dispose();
            cnn.Close();
        }
    }
}
