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
    public partial class membershipinformation : Form
    {
        public membershipinformation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentDB db = new StudentDB();
            db.DBOpen();
            DataSet ds = db.GetData(Convert.ToInt32(tbStudentNumber.Text), tbName.Text.ToString());
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void membershipinformation_Load(object sender, EventArgs e)
        {

        }
    }
}
