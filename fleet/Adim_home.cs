using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fleet
{
    public partial class Adim_home : Form
    {
        public Adim_home()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to exit application?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
                
        }

        private void label1_Click(object sender, EventArgs e)
        {

            admin_add_staff obj = new admin_add_staff();
            obj.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            admin_collection obj = new admin_collection();
            obj.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            admin_staffupdates obj = new admin_staffupdates();
            obj.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            admin_maintanens obj = new admin_maintanens();
            obj.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            admin_assignvech obj = new admin_assignvech();
            obj.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            admin_addvechile obj = new admin_addvechile();
            obj.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            loin2 obj = new loin2();
            obj.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            admin_deletevechile obj = new admin_deletevechile();
            obj.Show();
        }
    }
}
