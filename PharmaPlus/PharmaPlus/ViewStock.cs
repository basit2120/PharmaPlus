﻿using System;
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
    public partial class frmViewStock : Form
    {
        public frmViewStock()
        {
            InitializeComponent();
        }

        public string conSt = "Data Source=DESKTOP-L1Q6T8J\\BASITSQL;Initial Catalog=PharrmaPlus;Integrated Security=True";

        private void label1_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            frmAddStock addStock = new frmAddStock();
            this.Hide();
            addStock.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmUpdateStoke updateStoke = new frmUpdateStoke();
            this.Hide();
            updateStoke.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmRemoveStock removeStock = new frmRemoveStock();
            this.Hide();
            removeStock.Show();
        }

        int selected;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selected = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selected];
            if (e.ColumnIndex==0)
            {
                UpdateStock stock = UpdateStockUtile.updateStock;
                stock.ItemName1 = row.Cells[1].Value.ToString();
                stock.ItemQuantity1 = (int)row.Cells[2].Value;
                stock.PricePerPiece1 = (int)row.Cells[3].Value;
                stock.ItemType1 = row.Cells[4].Value.ToString();
                MessageBox.Show(row.Cells[5].Value.GetType().ToString());
                stock.Milligram1 = float.Parse(row.Cells[5].Value.ToString());
                stock.ManufacturedBy1 = row.Cells[6].Value.ToString();
                stock.MLNumber1 = row.Cells[7].Value.ToString();
                stock.DateAdded1 = (DateTime)row.Cells[8].Value;
                frmUpdateStoke updateStoke = new frmUpdateStoke();
                this.Hide();
                updateStoke.Show();
            }


            SqlConnection con = new SqlConnection(conSt);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string show = "select * from AddStock where Itemname = 'txtname.Text'";
            }
        }

        private void frmViewStock_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conSt);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string show = "select * from AddStock";
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

                  string show = "select * from AddStock where Itemname like '" + textBox1.Text + "%'";
                //   string show = string.Format("select * from AddStock where Itemname like {0} AND ItemType=={1}", textBox1.Text, comboBox1.Text);
                DataTable table = new DataTable();
                SqlDataAdapter dat = new SqlDataAdapter(show, con);
                
                dat.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conSt);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                if (comboBox1.Text == "All")
                {
                    string show = "select * from AddStock";
                    DataTable table = new DataTable();
                    SqlDataAdapter dat = new SqlDataAdapter(show, con);
                    dat.Fill(table);
                    dataGridView1.DataSource = table;

                }
                else
                {
                    string show = "select * from AddStock where ItemType =  '" + comboBox1.Text + "'";
               //     string show = "update AddStock where ItemType =  '" + comboBox1.Text + "'";

                    //   string show = string.Format("select * from AddStock where Itemname like {0} AND ItemType=={1}", textBox1.Text, comboBox1.Text);
                    DataTable table = new DataTable();
                    SqlDataAdapter dat = new SqlDataAdapter(show, con);

                    dat.Fill(table);
                    dataGridView1.DataSource = table;
                }
            }
        }
    }
}
