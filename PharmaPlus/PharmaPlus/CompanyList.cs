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
    public partial class frmCompanyList : Form
    {
        public frmCompanyList()
        {
            InitializeComponent();
        }

        public string conSt = "Data Source=DESKTOP-L1Q6T8J\\BASITSQL;Initial Catalog=PharrmaPlus;Integrated Security=True";


        private void button4_Click(object sender, EventArgs e)
        {
            frmAddCompany addCompany = new frmAddCompany();
            this.Hide();
            addCompany.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmRemoveCompany removeCompany = new frmRemoveCompany();
            this.Hide();
            removeCompany.Show();
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

        private void frmCompanyList_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conSt);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string show = "select * from AddCompany";
                DataTable table = new DataTable();
                SqlDataAdapter dat = new SqlDataAdapter(show, con);
                dat.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conSt);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {

                string show = "select * from AddCompany where CompanyName like '" + textBox1.Text + "%'";
                //   string show = string.Format("select * from AddStock where Itemname like {0} AND ItemType=={1}", textBox1.Text, comboBox1.Text);
                DataTable table = new DataTable();
                SqlDataAdapter dat = new SqlDataAdapter(show, con);

                dat.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conSt);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {

                string show = "select * from AddCompany where ContactPerson like '" + textBox1.Text + "%'";
                //   string show = string.Format("select * from AddStock where Itemname like {0} AND ItemType=={1}", textBox1.Text, comboBox1.Text);
                DataTable table = new DataTable();
                SqlDataAdapter dat = new SqlDataAdapter(show, con);

                dat.Fill(table);
                dataGridView1.DataSource = table;
            }

        }
    }
}
