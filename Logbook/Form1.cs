using Logbook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logbook_v1._2
{
    public partial class Form1 : Form
    {

        public List<StudentUC> students;
        public Form1()
        {
            InitializeComponent();
            students = new List<StudentUC>
            {
                new StudentUC(){ Dock = DockStyle.Top, StudentID = 3},
                new StudentUC(){ Dock = DockStyle.Top, StudentID = 2},
                new StudentUC(){Dock = DockStyle.Top, StudentID = 1}
            };
            Pnl_Body.Controls.Add(students[0]);
            Pnl_Body.Controls.Add(students[1]);
            Pnl_Body.Controls.Add(students[2]);
            students.ForEach(s => s.MouseClickDiamond += new EventHandler(MouseClickDiamond));
            students.ForEach(s => s.InTimeUnchecked += new EventHandler(InTimeUnchecked));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ChckB_All_InTime_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is MSChekBox chx && chx.Checked)
            {
                students.ForEach(s => s.InTimeCheck());
            }
        }

        private  void MouseClickDiamond(object sender, EventArgs e)
        {
            Lbl_Diamonds.Text = StudentUC.CountDmds.ToString();
        }
        
        private void InTimeUnchecked(object sender,EventArgs e)
        {
            if(sender is MSRadioButton rb)
            {
                if (rb.Checked == true)
                    ChckB_All_InTime.Checked = false;
            }
        }
       

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void Btn_AddStd_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if(form2.ShowDialog() == DialogResult.OK)
            {
                StudentUC student = new StudentUC();
                student.StudentFullName = form2.StudentName + " " + form2.Surname + " " + form2.Father;
                student.Image = form2.Profile;
                student.StudentID = 1;
                student.Dock = DockStyle.Top;
                student.InTimeUnchecked += new EventHandler(InTimeUnchecked);
                student.MouseClickDiamond += new EventHandler(MouseClickDiamond);
                students.ForEach(s => s.StudentID++);
                students.Add(student);
                Pnl_Body.Controls.Clear();
                Pnl_Body.Controls.AddRange(students.ToArray());
                ChckB_All_InTime.Checked = false;
            }
        }
    }
}
