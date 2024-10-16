using fleet;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace fleet
{
    public partial class admin_collection : Form
    {
        //Baseconnection con = new Baseconnection();
        public admin_collection()
        {
            InitializeComponent();
            fillgrid();
            fillcombo();
        }
        Baseconnection con = new Baseconnection();
        public void fillgrid()
        {
            string str = "select * from tripa";
            DataSet ds = con.ret_ds(str);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }
        public void fillcombo()
        {
            comboBox1.Items.Clear();
            string str = "select distinct[Name] from tripa";
            SqlDataReader sd = con.ret_dr(str);
            while (sd.Read())
            {
                comboBox1.Items.Add(sd[0].ToString());
            }
        }
        public void fillgrid2()
        {
            string str = "select * from tripa where Name='" + comboBox1.Text + "'";
            DataSet ds = con.ret_ds(str);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Adim_home obj = new Adim_home();
            obj.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = "select * from tripa where Name='" + comboBox1.Text + "'";
            SqlDataReader sd = con.ret_dr(str);
            if (sd.Read())
            {





            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            fillgrid2();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            fillgrid();
        }

        private void admin_collection_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "select name";
        }
    }
}
