﻿using System;
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
    public partial class frmRemoveCompany : Form
    {
        public frmRemoveCompany()
        {
            InitializeComponent();
        }

        private void RemoveCompany_Load(object sender, EventArgs e)
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

        private void button6_Click(object sender, EventArgs e)
        {
            frmCompanyList companyList = new frmCompanyList();
            this.Hide();
            companyList.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmAddEmployer addEmployer = new frmAddEmployer();
            this.Hide();
            addEmployer.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Company has been removed");
        }
    }
}
