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
    public partial class admin_addvechile : Form
    {
        Baseconnection con = new Baseconnection();
        public admin_addvechile()
        {
            InitializeComponent();
            Getid();
        }
        public void Getid()
        {
            string abiid;
            string query = "select id from addvechiclea order by id Desc";
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
            textBox1.Text = abiid.ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "insert into addvechiclea values('" + textBox1.Text + "','" + vechilenum.Text + "','" + comboBox1.Text + "')";
            if (con.exec1(query) > 0)
            {
                MessageBox.Show("Vechicle added");
                textBox1.Text = "";
                comboBox1.Text = "";
                vechilenum.Text = "";
            }
        }

        private void admin_addvechile_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "Select company name";

        }
    }
}
