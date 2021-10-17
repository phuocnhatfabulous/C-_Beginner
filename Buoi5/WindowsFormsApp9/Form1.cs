using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
      private DataTable dt = new DataTable("FoodName");
        public Form1()
        {
            InitializeComponent();
            //Them cot
            dt.Columns.Add("FoodName",
                System.Type.GetType("System.String"));
            dt.Columns.Add("Quantity",
                System.Type.GetType("System.Int32"));
            dt.PrimaryKey = new DataColumn[] { dt.Columns["FoodName"]};


            dataGridView1.DataSource = dt;
        }
        int quantity = 0;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Orderbt_Click(object sender, EventArgs e)
        {
            
        }

        private void OrderClick(object sender, EventArgs e)
        {
            Button CCow = (Button)sender;         
            DataRow r = dt.NewRow();
            DataRow FoundFood = dt.Rows.Find(CCow.Text);
            if(FoundFood!=null)
            {
                int quantity = (int)FoundFood[1];
                FoundFood[1] = quantity + 1;
                return;
            }

            r["FoodName"] = CCow.Text;
            r["Quantity"] = 1;
            dt.Rows.Add(r);          
        }

        private void Deletebt_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndex);
        }
    }
}
