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
    public partial class Member : Form
    {
        public Member()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void insert_Click(object sender, EventArgs e)
        {
            StudentDB db = new StudentDB();
            try
            {
                db.istudentNum = db.primarykey();
                db.iname = tbName.Text.ToString();
                db.iphone = tbPhone.Text.ToString();
                db.insert();
                tbName.Text = "";
                tbPhone.Text = "";
                MessageBox.Show("register a book.");
            }
            catch (FormatException)
            {
                MessageBox.Show("error");
                tbName.Text = "";
                tbPhone.Text = "";
            }
            catch (OverflowException)
            {
                MessageBox.Show("error");
                tbName.Text = "";
                tbPhone.Text = "";
            }
        }






    }
}
