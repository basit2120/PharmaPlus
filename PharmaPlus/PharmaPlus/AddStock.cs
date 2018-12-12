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
    public partial class frmAddStock : Form
    {
        public frmAddStock()
        {
            InitializeComponent();
        }
        public string conSt = "Data Source=DESKTOP-L1Q6T8J\\BASITSQL;Initial Catalog=PharrmaPlus;Integrated Security=True";


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            this.Hide();
            home.Show();
        }

        private void Stock_Load(object sender, EventArgs e)
        {

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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Hide();
            login.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmUpdateStoke updateStoke = new frmUpdateStoke();
            this.Hide();
            updateStoke.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conSt);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                float result;
                string data =
"insert into AddStock(Itemname,ItemQuantity,PricePerPiece,ItemType,Milligram,ManufacturedBy,MLNumber,ExpirationDate) values('" + textBox1.Text + "','" + int.Parse(textBox5.Text) + "' , '" + int.Parse(textBox2.Text) + "' , '" + comboBox1.Text + "', '" + float.TryParse(textBox4.Text, out result) + "', '" + comboBox3.Text + "','" + textBox3.Text + "', '" + DateTime.Parse(dateTimePicker1.Text.ToString()) + "')";

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
    }
}
