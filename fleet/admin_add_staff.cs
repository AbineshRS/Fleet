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
    public partial class admin_add_staff : Form
    {
        Baseconnection con = new Baseconnection();
        public admin_add_staff()
        {
            InitializeComponent();
            Getid();
        }
        public void Getid()
        {
            string abiid;
            string query = "select id from fleeta order by id Desc";
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
            textBox7.Text = abiid.ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "insert into fleeta values('" + textBox7.Text + "','" + textBox1.Text + "' ,'" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + comboBox1.Text + "','" + dateTimePicker1.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
            if (con.exec1(query) > 0)
            {
                MessageBox.Show("values added");
                textBox7.Text = "";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                dateTimePicker1.Text = "";
                comboBox1.Text = "";
            }
        }

        private void admin_add_staff_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Enter your Username";
            textBox2.Text = "Enter your Password";
            textBox6.Text = "Enter your full address";
            textBox1.ForeColor = Color.CadetBlue;
            textBox2.ForeColor = Color.CadetBlue;
            textBox6.ForeColor = Color.CadetBlue;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter your Username")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Enter your Username";
                textBox1.ForeColor = Color.CadetBlue;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Enter your Password")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Enter your Password";
                textBox2.ForeColor = Color.CadetBlue;
            }
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            if (textBox6.Text == "Enter your full address")
            {
                textBox6.Text = "";
                textBox6.ForeColor = Color.Black;
            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                textBox6.Text = "Enter your full address";
                textBox6.ForeColor = Color.CadetBlue;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
