using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCCS403_WS_13
{
    public partial class Radio_2 : Form
    {
        string sport;
        public Radio_2()
        {
            InitializeComponent();
        }

        private void radFootball_CheckedChanged(object sender, EventArgs e)
        {
            sport = "Football";
            MessageBox.Show("You Like To Play " + sport, "Survey", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void radSwiming_CheckedChanged(object sender, EventArgs e)
        {
            sport = "Swiming";
            MessageBox.Show("You Like To Play " + sport, "Survey", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void radTennis_CheckedChanged(object sender, EventArgs e)
        {
            sport = "Tennis";
            MessageBox.Show("You Like To Play " + sport, "Survey", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void radTableTennis_CheckedChanged(object sender, EventArgs e)
        {
            sport = "Table Tennis";
            MessageBox.Show("You Like To Play " + sport, "Survey", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
