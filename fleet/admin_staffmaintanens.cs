using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fleet
{
    public partial class admin_staffmaintanens : Form
    {
        Baseconnection con = new Baseconnection();
        public admin_staffmaintanens()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {

            string str = "select * from fleet2";
            DataSet ds = con.ret_ds(str);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;



        }

        private void button3_Click(object sender, EventArgs e)
        {

            string query = "delete from fleet2 where username= '"+textBox1.Text+"'";
            if (con.exec1(query) > 0)
            {
                MessageBox.Show("value deleted");

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
