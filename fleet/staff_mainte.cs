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
    public partial class staff_mainte : Form
    {
        Baseconnection con = new Baseconnection();
        public staff_mainte()
        {
            InitializeComponent();
            fillcombo();
            Getid();
        }
        public void Getid()
        {
            string abiid;
            string query = "select id from maintena order by id Desc";
            SqlDataReader dr = con.ret_dr(query);
            if (dr.Read())
            {
                int id = int.Parse(dr[0].ToString()) + 1;
                abiid = id.ToString("00");

            }
            else if (Convert.IsDBNull(dr))
            {
                abiid = ("01");
            }
            else
            {
                abiid = ("01");
            }
            textBox4.Text = abiid.ToString();


        }
        public void fillcombo()
        {
            comboBox1.Items.Clear();
            string str = "select distinct[Name] from assigna";
            SqlDataReader sd = con.ret_dr(str);
            while (sd.Read())
            {
                comboBox1.Items.Add(sd[0].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "insert into maintena values('" + textBox4.Text + "','" + comboBox1.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
            if (con.exec1(query) > 0)
            {
                MessageBox.Show("values added");
                comboBox1.Text = "";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = "select * from assigna where Name='" + comboBox1.Text + "'";
            SqlDataReader sd = con.ret_dr(str);
            while (sd.Read())
            {

                textBox1.Text = sd[2].ToString();
            }
        }
    }
}
