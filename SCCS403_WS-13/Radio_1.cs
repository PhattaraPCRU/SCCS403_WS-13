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
    public partial class Radio_1 : Form
    {
        public Radio_1()
        {
            InitializeComponent();
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void radCyan_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Cyan;
        }

        private void radOrange_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
        }

        private void radPink_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Pink;
        }
    }
}
