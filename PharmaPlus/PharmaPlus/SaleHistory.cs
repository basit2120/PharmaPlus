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
    public partial class frmSaleHistory : Form
    {
        public frmSaleHistory()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmSaleStock SaleStock = new frmSaleStock();
            this.Hide();
            SaleStock.Show();
        }
    }
}
