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
    public partial class ListBox_1 : Form
    {
        string[] faculty =
            {
                "วิทยาศาสตร์",
                "ครุศาสตร์",
                "มนุษศาสตร์",
                "วิทยาการจังการ",
                "เทคโนโลยีอุตสาหกรรม"
            }, program =
            {
                "คอมพิวเตอร์ธุรกิจ",
                "คอมพิวเตอร์ศึกษา",
                "วิทยาการคอมพิวเตอร์",
                "เทคโนโลยีสารสนเทศ",
                "คอมพิวเอต์อุตสาหกรรม",
                "ภาษาอังกฤษ",
                "รัฐประศาสนศาสตร์",
                "อุตสาหกรรมท่องเที่ยว"
            };
        public ListBox_1()
        {
            InitializeComponent();
        }

        private void ListBox_1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < faculty.Length; i++)
            {
                libxFaculty.Items.Add(faculty[i]);
            }
            for (int i = 0; i < program.Length; i++)
            {
                libxProgram.Items.Add(program[i]);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("คุณเลือกคณะ " + faculty[libxFaculty.SelectedIndex] + "\nโปรแกรมวิชา "+program[libxProgram.SelectedIndex],"ผลการเลือก");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
