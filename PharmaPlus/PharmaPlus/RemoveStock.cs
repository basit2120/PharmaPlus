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
using System.Collections;

namespace PharmaPlus
{
    public partial class frmRemoveStock : Form
    {
        DataTable table = new DataTable();
        public frmRemoveStock()
        {
            InitializeComponent();
        }

        public string conSt = "Data Source=DESKTOP-L1Q6T8J\\BASITSQL;Initial Catalog=PharrmaPlus;Integrated Security=True";

        private void RemoveStock_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conSt);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string show = "select * from AddStock";
                
                SqlDataAdapter dat = new SqlDataAdapter(show, con);
                dat.Fill(table);
                dataGridView1.DataSource = table;
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

        private void button4_Click(object sender, EventArgs e)
        {
            frmAddStock addStock = new frmAddStock();
            this.Hide();
            addStock.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmUpdateStoke updateStoke = new frmUpdateStoke();
            this.Hide();
            updateStoke.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Product has been removed");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmViewStock viewStock = new frmViewStock();
            this.Hide();
            viewStock.Show();
        }


        private void Reload()
        {
            SqlConnection con = new SqlConnection(conSt);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string show = "select * from AddStock";

                SqlDataAdapter dat = new SqlDataAdapter(show, con);
                dat.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        int selected;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection con = new SqlConnection(conSt);
            con.Open();
            selected = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selected];
            string a = Convert.ToString(row.Cells[1].Value);
            if (e.ColumnIndex == 0)
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    //string data = String.Format("DELETE AddStock SET ItemName = '{0}', ItemQuantity = {1} , PricePerPiece = {2} , ItemType  = '{3}' , Milligram = {4} , ManufacturedBy = '{5}' , MLNumber = '{6}' , ExpirationDate = '{7}' WHERE ItemName = '{8}'", textBox1.Text, int.Parse(textBox5.Text), int.Parse(textBox2.Text), comboBox1.Text, int.Parse(textBox4.Text), comboBox3.Text, textBox3.Text, DateTime.Parse(dateTimePicker1.Text.ToString()), temp_name);
                    //SqlCommand cmd = new SqlCommand(data, con);
                    string data = String.Format("DELETE FROM AddStock WHERE ItemName = '{0}'", a);
                    SqlCommand cmd = new SqlCommand(data, con);
                    cmd.ExecuteNonQuery();
                }
            }
            frmRemoveStock removeStock = new frmRemoveStock();
            this.Hide();
            removeStock.Show();
        }
    }
}
