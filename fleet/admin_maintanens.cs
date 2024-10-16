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
    public partial class admin_maintanens : Form
    {
        //Baseconnection con = new Baseconnection();
        public admin_maintanens()
        {
            InitializeComponent();
            fillcombo();
            fillgrid();

        }
        Baseconnection con = new Baseconnection();
        public void fillgrid()
        {
            string str = "select * from maintena";
            DataSet ds = con.ret_ds(str);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }
        public void fillgrid2()
        {
            string str = "select * from maintena where Name='" + comboBox1.Text + "'";
            DataSet ds = con.ret_ds(str);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }
        public void fillcombo()
        {
            comboBox1.Items.Clear();
            string str = "select distinct[Name] from maintena";
            SqlDataReader sd = con.ret_dr(str);
            while (sd.Read())
            {
                comboBox1.Items.Add(sd[0].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = "select * from maintena where Name='" + comboBox1.Text + "'";
            SqlDataReader sd = con.ret_dr(str);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            fillgrid2();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            fillgrid();
        }

        private void admin_maintanens_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "Select name";
        }
    }
}
