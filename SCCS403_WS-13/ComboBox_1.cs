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
    public partial class ComboBox_1 : Form
    {
        string[] edu =
        {
            "ต่ำกว่าปริญญาตรี",
            "ปริญญาตรี",
            "ปริญญาโท",
            "ปริญญาเอก"
        }, work =
        {
            "ข้าราชการ",
            "พนักงานเอกชน",
            "ธุรกิจส่วนตัว",
            "รับจ้าง"
        };
        public ComboBox_1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (cmbEdu.SelectedIndex is 0 or 1 or 2 or 3 || cmbWork.SelectedIndex is 0 or 1 or 2 or 3)
            {
                MessageBox.Show("คุณจบการศึกษา " + edu[cmbEdu.SelectedIndex] + "\nคุณประกอบอาชีพ " + work[cmbWork.SelectedIndex], "ผลการเลือก");
            }
            else
            {
                MessageBox.Show("Please Select!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComboBox_1_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < edu.Length; i++)
            {
                cmbEdu.Items.Add(edu[i]);
            }
            for(int i=0; i < work.Length; i++)
            {
                cmbWork.Items.Add(work[i]);
            }
        }
    }
}
