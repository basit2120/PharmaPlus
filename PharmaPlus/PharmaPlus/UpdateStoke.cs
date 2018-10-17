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
    public partial class frmUpdateStoke : Form
    {
        public frmUpdateStoke()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmAddStock addStock = new frmAddStock();
            this.Hide();
            addStock.Show();
        }

        private void UpdateStoke_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmRemoveStock removeStock = new frmRemoveStock();
            this.Hide();
            removeStock.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmViewStock viewStock = new frmViewStock();
            this.Hide();
            viewStock.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Product has been updated");
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
