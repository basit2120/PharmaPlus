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
    public partial class frmAddCompany : Form
    {
        public frmAddCompany()
        {
            InitializeComponent();
        }

        public string conSt = "Data Source=DESKTOP-L1Q6T8J\\BASITSQL;Initial Catalog=PharrmaPlus;Integrated Security=True";


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

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

        private void button8_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Company has been Added");
            SqlConnection con = new SqlConnection(conSt);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string data = "insert into AddCompany(CompanyName,Address,City,Telephone,ContactPerson,PhoneNo,Email,Wedsite) values('" + textBox1.Text + "','" + textBox5.Text + "' , '" + textBox2.Text + "' , '" + int.Parse(textBox6.Text) + "', '" + textBox4.Text + "', '" + int.Parse(textBox7.Text) + "','" + textBox3.Text + "', '" + textBox8.Text + "')";
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

        private void button5_Click(object sender, EventArgs e)
        {
            frmRemoveCompany removeCompany = new frmRemoveCompany();
            this.Hide();
            removeCompany.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmCompanyList companyList = new frmCompanyList();
            this.Hide();
            companyList.Show();
        }
    }
}
