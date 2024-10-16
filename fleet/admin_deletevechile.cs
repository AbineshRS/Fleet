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
    public partial class admin_deletevechile : Form
    {
        public admin_deletevechile()
        {
            InitializeComponent();
            fillcombo();
        }
        Baseconnection con = new Baseconnection();
        public void fillcombo()
        {
            comboBox1.Items.Clear();
            string str = "select vehicleNumber from addvechiclea";
            SqlDataReader sd = con.ret_dr(str);
            while (sd.Read())
            {
                comboBox1.Items.Add(sd[0].ToString());
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to permanently delete?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                string query = "delete from  addvechiclea where vehicleNumber='" + comboBox1.Text + "'";
                if (con.exec1(query) > 0)
                {
                    MessageBox.Show("value deleted");
                    fillcombo();
                    comboBox1.Text = "";
                    textBox1.Text = "";
                }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = "select * from addvechiclea where vehicleNumber='" + comboBox1.Text + "'";
            SqlDataReader sd = con.ret_dr(str);
            if (sd.Read())
            {
                textBox1.Text = sd[2].ToString();
                textBox2.Text = sd[0].ToString();
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {

        }

        private void admin_deletevechile_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "Select vechicle number";
        }
    }
}
