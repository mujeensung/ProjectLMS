using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Libary_Ver0._1
{
    public partial class add : Form
    {
        public add()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Insert_Click(object sender, EventArgs e)
        {
            DBManager db = new DBManager();
            try
            {
                stBookData bookdata = new stBookData(Convert.ToInt32(tbBookcode.Text),
                                                    tbTitle.Text,
                                                    tbAuthor.Text);

                db.insert(bookdata);
                tbAuthor.Text = "";
                tbBookcode.Text = "";
                tbTitle.Text = "";
                MessageBox.Show("register a book.");
            }
            catch (FormatException)
            {
                MessageBox.Show("error");
                tbAuthor.Text = "";
                tbBookcode.Text = "";
                tbTitle.Text = "";
            }
            catch (OverflowException)
            {
                MessageBox.Show("error");
                tbAuthor.Text = "";
                tbBookcode.Text = "";
                tbTitle.Text = "";
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fm = new Form1();
            fm.Owner = this;
            fm.Show();
        }
    }
}
