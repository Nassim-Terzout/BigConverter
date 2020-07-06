using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Binary
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            G.D.ShowDialog();

        }

        private void b1_Click(object sender, EventArgs e)
        {
            this.Hide();
            G.B.ShowDialog();
        }

        private void b2_Click(object sender, EventArgs e)
        {
            this.Hide();
            G.H.ShowDialog();
        }

        private void b3_Click(object sender, EventArgs e)
        {
            this.Hide();
            G.O.ShowDialog();

        }

        private void b5_Click(object sender, EventArgs e)
        {
            this.Hide();
            G.A.ShowDialog();

        }
    }
}
