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

namespace PharmaPlus
{
    public partial class frmUpdateStoke : Form
    {
        string temp_name;
        public frmUpdateStoke()
        {
            InitializeComponent();
        }
        public string conSt = "Data Source=DESKTOP-L1Q6T8J\\BASITSQL;Initial Catalog=PharrmaPlus;Integrated Security=True";

        private void button4_Click(object sender, EventArgs e)
        {
            frmAddStock addStock = new frmAddStock();
            this.Hide();
            addStock.Show();
        }

        private void UpdateStoke_Load(object sender, EventArgs e)
        {
            UpdateStock stock = UpdateStockUtile.updateStock;
            textBox1.Text = stock.ItemName1;
            textBox5.Text = stock.ItemQuantity1.ToString();
            textBox2.Text = stock.PricePerPiece1.ToString();
            comboBox1.Text = stock.ItemType1;
            textBox4.Text = stock.Milligram1.ToString();
            comboBox3.Text = stock.ManufacturedBy1;
            textBox3.Text = stock.MLNumber1;
            dateTimePicker1.Text = stock.DateAdded1.ToString();
            temp_name = stock.ItemName1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmRemoveStock removeStock = new frmRemoveStock();
            this.Hide();
            removeStock.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmViewStock viewStock = new frmViewStock();
            this.Hide();
            viewStock.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conSt);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string data = String.Format("UPDATE AddStock SET ItemName = '{0}', ItemQuantity = {1} , PricePerPiece = {2} , ItemType  = '{3}' , Milligram = {4} , ManufacturedBy = '{5}' , MLNumber = '{6}' , ExpirationDate = '{7}' WHERE ItemName = '{8}'", textBox1.Text,int.Parse(textBox5.Text),int.Parse(textBox2.Text),comboBox1.Text,int.Parse(textBox4.Text),comboBox3.Text,textBox3.Text, DateTime.Parse(dateTimePicker1.Text.ToString()), temp_name);
                SqlCommand cmd = new SqlCommand(data, con);
                try
                {

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("added in database");
                        //string show = "select * from OnlyName";
                        //DataTable table = new DataTable();
                        //SqlDataAdapter dat = new SqlDataAdapter(show, con);
                        //dat.Fill(table);
                        //dataGridView1.DataSource = table;


                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Error is " + ex.ToString());
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            this.Hide();
            home.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Hide();
            login.Show();
        }
    }
}
