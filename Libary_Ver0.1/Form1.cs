using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Data.SQLite;

namespace Libary_Ver0._1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            BookDB book = new BookDB();
            book.DBOpen();
            int tmp;
            tmp = comboBox.SelectedIndex;
         if (tmp == 0)
         {
             DataSet ds = book.GetData(eItem.TITLE, tb.Text);
             dataGridView1.DataSource = ds.Tables[0];
         }
         else if (tmp == 1)
         {
             DataSet ds = book.GetData(eItem.AUTHOR, tb.Text);
            dataGridView1.DataSource = ds.Tables[0];
         }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            add ad = new add();
            ad.Owner = this;
            ad.Show();

        }

        private void tbTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



    }
}
