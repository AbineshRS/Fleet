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
    public partial class admin_staffupdates : Form
    {
        public admin_staffupdates()
        {
            InitializeComponent();
            fillcombo();
            fillgrid();
        }
        Baseconnection con = new Baseconnection();
        public void fillgrid()
        {
            string str = "select * from fleeta";
            DataSet ds = con.ret_ds(str);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }
        public void fillcombo()
        {
            comboBox1.Items.Clear();
            string str = "select Name from fleeta";
            SqlDataReader sd = con.ret_dr(str);
            while (sd.Read())
            {
                comboBox1.Items.Add(sd[0].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "update fleeta set Username='" + textBox1.Text + "',Password='" + textBox2.Text + "',Name='" + comboBox1.Text + "',Age='" + textBox3.Text + "',Gender='" + comboBox2.Text + "',DOB='" + dateTimePicker1.Text + "',Phone='" + textBox4.Text + "',Address='" + textBox5.Text + "' where Name='" + comboBox1.Text + "'";
            if (con.exec1(query) > 0)
            {
                MessageBox.Show("sucess");
                fillgrid();
                fillcombo();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
                dateTimePicker1.Text = "";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = "select * from fleeta where Name='" + comboBox1.Text + "'";
            SqlDataReader sd = con.ret_dr(str);
            if (sd.Read())
            {
                textBox6.Text = sd[0].ToString();
                textBox1.Text = sd[1].ToString();
                textBox2.Text = sd[2].ToString();
                textBox3.Text = sd[4].ToString();
                comboBox2.Text = sd[5].ToString();
                dateTimePicker1.Text = sd[6].ToString();
                textBox4.Text = sd[7].ToString();
                textBox5.Text = sd[8].ToString();


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to permanently delete?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                string query = "delete from fleeta where Name='" + comboBox1.Text + "'";
                if (con.exec1(query) > 0)
                {
                    MessageBox.Show("value deleted");
                    fillgrid(); fillcombo();
                    textBox1.Text = "";
                    textBox2.Text = "";
                    comboBox1.Text = "";
                    textBox3.Text = "";
                    comboBox2.Text = "";
                    dateTimePicker1.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
