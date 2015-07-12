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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            add a = new add();
            a.Owner = this;
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            Form1 fm = new Form1();
            fm.Owner = this;
            fm.Show();
            
            
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void Mbinformation_Click(object sender, EventArgs e)
        {
            membershipinformation fm = new membershipinformation();
            fm.Owner = this;
            fm.Show();
        }

        private void Mbmanager_Click(object sender, EventArgs e)
        {
            Member fm = new Member();
            fm.Owner = this;
            fm.Show();
        }

        private void loan_Click(object sender, EventArgs e)
        {
            loan fm = new loan();
            fm.Owner = this;
            fm.Show();
        }


    }
}
