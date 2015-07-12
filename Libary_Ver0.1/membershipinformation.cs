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
            DBManager db = new DBManager();
            db.DBOpen();
            DataSet ds = db.GetmemberData(tbID.Text,tbName.Text);
            dataGridView1.DataSource = ds.Tables[0];

        }
    }
}
