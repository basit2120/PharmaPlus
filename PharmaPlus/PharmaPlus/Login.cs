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

namespace PharmaPlus
{
    public partial class frmLogin : Form
    {
        public string conSt = "Data Source=DESKTOP-L1Q6T8J\\BASITSQL;Initial Catalog=PharrmaPlus;Integrated Security=True";
       
        public frmLogin()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            


            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string pass=textBox2.Text;
            //SqlConnection con = new SqlConnection(conSt);
            //con.Open();
            //if (con.State == System.Data.ConnectionState.Open)
            //{
            //    string check = "select * from Login where password='" + pass + "'";
            //    SqlCommand c = new SqlCommand(check, con);
            //    MessageBox.Show(c.ExecuteNonQuery().ToString()+textBox2.Text);
            //    if (c.ExecuteNonQuery() > 0)
            //    {
            //        MessageBox.Show("already exist");
            //    }
    

            //    }
            if(textBox1.Text=="admin" && textBox2.Text == "admin")
            {
                this.Hide();
                frmHome form = new frmHome();
                form.Show();
            }
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Please Enter ID and Password");
            }
            if (textBox1.Text != "admin" || textBox2.Text != "admin")
            {
                MessageBox.Show("Please Enter correct ID and Password");
            }



        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
