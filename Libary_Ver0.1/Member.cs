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
            DBManager db = new DBManager();
            try
            {
                data Data = new data(Convert.ToInt32(tbid.Text),
                                                    tbname.Text,0,0,0,0);

                db._insert(Data);
                tbid.Text = "";
                
                tbname.Text = "";
                MessageBox.Show("register a member.");
            }
            catch (FormatException)
            {
                MessageBox.Show("error");
                tbid.Text = "";
                
                tbname.Text = "";
            }
            catch (OverflowException)
            {
                MessageBox.Show("error");
                tbid.Text = "";
                
                tbname.Text = "";
            }
        }
    }
}
