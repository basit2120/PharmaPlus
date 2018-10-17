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
    public partial class frmCompanyList : Form
    {
        public frmCompanyList()
        {
            InitializeComponent();
        }

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
    }
}
