using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logbook_v1._2
{
    public partial class Form2 : Form
    {
        //Prop
        public string StudentName { get; set; }

        public string Surname { get; set; }

        public string Father { get; set; }

        public Image Profile { get; set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Btn_LoadPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "jpg files|*.jpg| png files|*.png";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = dialog.FileName;
                PicB_Profile.ImageLocation = fileName;
            }
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            StudentName = Txtb_Name.Text;
            Surname = Txtb_Surname.Text;
            Father = Txtb_Father.Text;
            Profile = PicB_Profile.Image;
            DialogResult = DialogResult.OK;
        }

        private void Txtb_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(Txtb_Name.Text) && !string.IsNullOrWhiteSpace(Txtb_Surname.Text) && !string.IsNullOrWhiteSpace(Txtb_Father.Text))
            {
                Btn_Save.Enabled = true;
            }
        }
    }
}
