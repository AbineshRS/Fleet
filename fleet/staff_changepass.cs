using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace fleet
{
    public partial class staff_changepass : Form
    {
        Baseconnection con = new Baseconnection();
        public staff_changepass()
        {
            InitializeComponent();
            fillgrid();
        }
        public void fillgrid()
        {
            string str = "select * from fleeta";
            DataSet ds = con.ret_ds(str);

        }

        private void button1_Click(object sender, EventArgs e)
        {




            string query = "update fleeta set Password='" + textBox2.Text + "' where Password='" + textBox1.Text + "'";
            if (con.exec1(query) > 0)
            {
                MessageBox.Show("sucess");
                fillgrid();
                //fillcombo();
                textBox1.Text = "";
                textBox2.Text = "";
            }
            else
            {
                MessageBox.Show("fail");
            }
        }

        private void staff_changepass_Load(object sender, EventArgs e)
        {

        }
    }
}
