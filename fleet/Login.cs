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
    public partial class Login : Form
    {
        public Login()
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
            if (textBox1.Text == "Admin" && textBox2.Text == "pwd" && comboBox1.Text == "Admin")
            {
                MessageBox.Show("sucess");
                Adim_home obj = new Adim_home();
                obj.Show();
            }
            

            else if (comboBox1.Text == "Staff")
            {
                string query = "select * from fleet2 where Username='" + textBox1.Text + "' and Password='" + textBox2.Text + "'";
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
            textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to exit application?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
