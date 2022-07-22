using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Logbook_v1._2
{
    public partial class StudentUC : UserControl
    {
        //Properties
        public string StudentFullName { get; set; }
        public int StudentID { get; set; } = 1;
        public Image Image { get; set; }

        //fields
        static public int CountDmds { get; private set; } = 5;
        private int dmds;
        private bool[] isClicked = new bool[3];

        public StudentUC()
        {
            InitializeComponent();
            
            CB_Class.OnSelectedIndexChanged += new EventHandler(OnItemSelected);
            CB_Review.OnSelectedIndexChanged += new EventHandler(OnItemSelected);
            Btn_Cancel.Click += new EventHandler(MouseClicc);
            Btn_Diamond1.Click += new EventHandler(MouseClicc);
            Btn_Diamond2.Click += new EventHandler(MouseClicc);
            Btn_Diamond3.Click += new EventHandler(MouseClicc);
            RB_Absent.CheckedChanged += new EventHandler(RBChecked);
            RB_Late.CheckedChanged += new EventHandler(RBChecked);
        }

        private void StudentUC_Paint(object sender, PaintEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(StudentFullName))
                Lbl_StudentFullName.Text = StudentFullName;
            if (Image != null)
                Picb_Profile.Image = Image;
            Lbl_StudentID.Text = StudentID.ToString();
            var g = new GraphicsPath();
            g.AddEllipse(0, 0, Picb_Profile.Width, Picb_Profile.Height);
            Picb_Profile.Region = new Region(g);

        }

        private void OnItemSelected(object sender, EventArgs e)
        {
            if (sender is ComboBox ms)
            {
                if (ms.SelectedItem.ToString() == "-")
                {
                    ms.Items.Clear();
                    ms.Items.AddRange(new object[] { "12", "11", "10", "9", "8", "7", "6", "5", "4", "3", "2", "1" });
                }
                else
                {
                    string[] temp = new string[] { "12", "11", "10", "9", "8", "7", "6", "5", "4", "3", "2", "1" };
                    string str = ms.SelectedItem.ToString();
                    ms.Items.Clear();
                    ms.Items.Add("-");
                    foreach (var item in temp)
                    {
                        if (item != str)
                            ms.Items.Add(item);
                    }
                    ms.Text = str;
                }
            }
        }

        private void Btn_Diamond_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                if (btn.Name == "Btn_Diamond1" && CountDmds > 0 && !isClicked[1])
                {
                    Btn_Diamond1.Image = Properties.Resources.diamond_blue;
                }
                else if (btn.Name == "Btn_Diamond2" && CountDmds > 1 - dmds && !isClicked[2])
                {
                    Btn_Diamond1.Image = Properties.Resources.diamond_blue;
                    Btn_Diamond2.Image = Properties.Resources.diamond_blue;
                }
                else if (btn.Name == "Btn_Diamond3" && CountDmds > 2 - dmds && !isClicked[2])
                {
                    Btn_Diamond1.Image = Properties.Resources.diamond_blue;
                    Btn_Diamond2.Image = Properties.Resources.diamond_blue;
                    Btn_Diamond3.Image = Properties.Resources.diamond_blue;
                }
            }
        }

        private void Btn_Diamond_MouseLeave(object sender, EventArgs e)
        {

            if (!isClicked[0])
            {
                Btn_Diamond1.Image = Properties.Resources.diamond_grey;
            }
            if (!isClicked[1])
            {
                Btn_Diamond2.Image = Properties.Resources.diamond_grey;
            }
            if (!isClicked[2])
            {
                Btn_Diamond3.Image = Properties.Resources.diamond_grey;
            }
        }

        private void Btn_Cancel_MouseEnter(object sender, EventArgs e)
        {
            Btn_Cancel.Image = Properties.Resources.cancel_blue;
        }

        private void Btn_Cancel_MouseLeave(object sender, EventArgs e)
        {
            Btn_Cancel.Image = Properties.Resources.cancel_grey;
        }

        public void InTimeCheck() => RB_InTime.Checked = true;

        //Event
        public event EventHandler MouseClickDiamond;
       
        public event EventHandler InTimeUnchecked;

        private void MouseClicc(object sender, EventArgs e)
        {
            if (MouseClickDiamond != null)
            {
                Button btn = sender as Button;
                if (btn.Name == "Btn_Diamond1" && CountDmds > 0 && !isClicked[0])
                {
                    CountDmds -= 1;
                    dmds = 1;
                    isClicked[0] = true;
                }
                else if (btn.Name == "Btn_Diamond2" && CountDmds > 1 - dmds && !isClicked[2])
                {
                    CountDmds -= 2 - dmds;
                    dmds = 2;
                    isClicked[0] = true;
                    isClicked[1] = true;
                }
                else if (btn.Name == "Btn_Diamond3" && CountDmds > 2 - dmds && !isClicked[2])
                {
                    CountDmds -= 3 - dmds;
                    dmds = 3;
                    isClicked[0] = true;
                    isClicked[1] = true;
                    isClicked[2] = true;
                }
                else if (btn.Name == "Btn_Cancel")
                {
                    if (dmds > 0)
                    {
                        CountDmds += dmds;
                        dmds = 0;
                    }
                    isClicked[0] = false;
                    isClicked[1] = false;
                    isClicked[2] = false;
                    Btn_Diamond_MouseLeave(null, null);
                }
                MouseClickDiamond.Invoke(sender, e);
            }
        }

        private void RBChecked(object sender, EventArgs e)
        {
            if (InTimeUnchecked != null)
                InTimeUnchecked.Invoke(sender, e);
        }
    }
}
