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
    public partial class staff : Form
    {
        public staff()
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
            staff_changepass obj = new staff_changepass();
            obj.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            staff_trip obj = new staff_trip();
            obj.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            staff_mainte obj = new staff_mainte();
            obj.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            loin2 obj = new loin2();
            obj.Show();
        }
    }
}
