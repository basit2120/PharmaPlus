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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Hide();
            login.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmAddStock f1 = new frmAddStock();
            this.Hide();
            f1.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmSaleStock f2 = new frmSaleStock();
            this.Hide();
            f2.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frmAddEmployer f3 = new frmAddEmployer();
            this.Hide();
            f3.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            frmAddCompany f4 = new frmAddCompany();
            this.Hide();
            f4.Show();
        }
    }
}
