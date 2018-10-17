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
    public partial class frmAddCompany : Form
    {
        public frmAddCompany()
        {
            InitializeComponent();
        }

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
            MessageBox.Show("Company has been Added");
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
