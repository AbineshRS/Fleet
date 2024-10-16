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
    public partial class admin_assignvech : Form
    {
        Baseconnection con = new Baseconnection();
        public admin_assignvech()
        {
            InitializeComponent();
            fillcombo();
            fillcombo1();
        }
        public void fillcombo()
        {
            comboBox2.Items.Clear();
            string str = "select Name from fleeta";
            SqlDataReader sd = con.ret_dr(str);
            while (sd.Read())
            {
                comboBox2.Items.Add(sd[0].ToString());
            }
        }
        public void fillcombo1()
        {
            comboBox3.Items.Clear();
            string str = "select vehicleNumber from addvechiclea";
            SqlDataReader sd = con.ret_dr(str);
            while (sd.Read())
            {
                comboBox3.Items.Add(sd[0].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "insert into assigna values('" + comboBox2.Text + "','" + comboBox1.Text + "','" + comboBox3.Text + "')";
            if (con.exec1(query) > 0)
            {
                MessageBox.Show("Sucess");
                comboBox2.Text = "";
                comboBox1.Text = "";
                comboBox3.Text = "";
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = "select * from fleeta where Name='" + comboBox2.Text + "'";
            SqlDataReader sd = con.ret_dr(str);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = "select * from addvechiclea where vehicleNumber='" + comboBox3.Text + "'";
            SqlDataReader sd = con.ret_dr(str);
            if (sd.Read())
            {
                comboBox1.Text = sd[2].ToString();
            }
        }

        private void admin_assignvech_Load(object sender, EventArgs e)
        {
            comboBox2.Text = "Select the name";
            comboBox3.Text = "Select vechicle number";
        }
    }
}
