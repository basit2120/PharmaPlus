using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmaPlus
{
    public partial class frmRemoveEmployer : Form
    {
        string temp_name;
        public frmRemoveEmployer()
        {
            InitializeComponent();
        }

        public string conSt = "Data Source=DESKTOP-L1Q6T8J\\BASITSQL;Initial Catalog=PharrmaPlus;Integrated Security=True";


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
            frmAddEmployer addEmployer = new frmAddEmployer();
            this.Hide();
            addEmployer.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmEmployerList employerList = new frmEmployerList();
            this.Hide();
            employerList.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Employ has been removed");
        }

        private void frmRemoveEmployer_Load(object sender, EventArgs e)
        {
            RemoveEmploy employ = RemoveEmployUtile.removeEmploy;
            //UpdateStock stock = UpdateStockUtile.updateStock;

            //textBox1.Text = stock.ItemName1;
            textBox1.Text = employ.EmployNmae1;

            textBox5.Text = employ.CellNo1.ToString();


            textBox6.Text = employ.CNIC1.ToString();

            comboBox3.Text = employ.Gender1;


            textBox4.Text = employ.Email1;

            textBox2.Text = employ.Address1;

            textBox3.Text = employ.City1;
            dateTimePicker1.Text = employ.DOB1.ToString();
            temp_name = employ.EmployNmae1;
        }
    }
}
