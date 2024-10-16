using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fleet
{
    public partial class loin2 : Form
    {
        public loin2()
        {
            InitializeComponent();
        }
        Baseconnection con = new Baseconnection();
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Admin" && textBox3.Text == "pwd" && comboBox1.Text == "Admin")
            {
                MessageBox.Show(textBox1.Text, "Welcome Owner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Adim_home obj = new Adim_home();
                obj.Show();
            }
            else if (comboBox1.Text == "Staff")
            {
                string query = "select * from fleeta where Username='" + textBox1.Text + "' and Password='" + textBox3.Text + "'";
                SqlDataReader sd = con.ret_dr(query);
                if (sd.Read())
                {
                    MessageBox.Show(textBox1.Text, "Welcome User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    staff obj = new staff();
                    obj.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Username or password");
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to exit application?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MessageBox.Show("closing...");
                Application.Exit();
            }
        }

        private void loin2_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Enter your Username";
            comboBox1.Text = "Select user type";
            textBox1.ForeColor = Color.Blue;
            comboBox1.ForeColor = Color.Blue;
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
                textBox1.ForeColor = Color.Blue;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {

        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Select your user type")
            {
                comboBox1.Text = "";
                comboBox1.ForeColor = Color.Black;
            }
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {

        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Enter your password")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Enter your password";
                textBox3.ForeColor = Color.Blue;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
