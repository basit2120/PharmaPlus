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
    public partial class frmAddEmployer : Form
    {
        public frmAddEmployer()
        {
            InitializeComponent();
        }

        public string conSt = "Data Source=DESKTOP-L1Q6T8J\\BASITSQL;Initial Catalog=PharrmaPlus;Integrated Security=True";


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {
            frmRemoveEmployer removeEmployer = new frmRemoveEmployer();
            this.Hide();
            removeEmployer.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmEmployerList employerList = new frmEmployerList();
            this.Hide();
            employerList.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Employ has been Added");

            SqlConnection con = new SqlConnection(conSt);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string data = "insert into AddEmploy(EmployerName,CellNo,CNIC,Gender,Email,Address,City,DOB) values('" + textBox1.Text + "','" + int.Parse(textBox5.Text) + "' , '" + int.Parse(textBox5.Text) + "' , '" + comboBox3.Text + "', '" + textBox4.Text + "', '" + textBox2.Text + "','" + textBox3.Text + "', '" + DateTime.Parse(dateTimePicker1.Text.ToString()) + "')";
                SqlCommand cmd = new SqlCommand(data, con);
                try
                {

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("added in database");

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

