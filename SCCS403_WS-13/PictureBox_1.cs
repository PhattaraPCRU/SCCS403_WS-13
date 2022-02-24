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
    public partial class PictureBox_1 : Form
    {
        string res = "/../../../../res/";
        public PictureBox_1()
        {
            InitializeComponent();
        }

        private void radHamster_CheckedChanged(object sender, EventArgs e)
        {
            picb1.ImageLocation = StartPosition +"/../../../../res/hamster_img.jpg";
            picb1.Load();
        }

        private void radShark_CheckedChanged(object sender, EventArgs e)
        {
            picb1.ImageLocation = StartPosition+res+"shark_img.jpg";
            picb1.Load();
        }

        private void radSnake_CheckedChanged(object sender, EventArgs e)
        {
            picb1.ImageLocation = StartPosition + res + "snake_img.jpg";
            picb1.Load();
        }

        private void radTiger_CheckedChanged(object sender, EventArgs e)
        {
            picb1.ImageLocation = StartPosition + res + "tiger_img.jpg";
            picb1.Load();
        }
    }
}
