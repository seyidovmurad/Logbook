
namespace Logbook_v1._2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Pnl_Header = new System.Windows.Forms.Panel();
            this.ChckB_All_InTime = new Logbook.MSChekBox();
            this.Lbl_Diamonds = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Lbl_Comment = new System.Windows.Forms.Label();
            this.Lbl_Class = new System.Windows.Forms.Label();
            this.Lbl_Review = new System.Windows.Forms.Label();
            this.Lbl_CheckEveryone = new System.Windows.Forms.Label();
            this.Lbl_Time = new System.Windows.Forms.Label();
            this.Lbl_StdInfo = new System.Windows.Forms.Label();
            this.Pnl_Teacher = new System.Windows.Forms.Panel();
            this.RB_EsasMlm = new Logbook.MSRadioButton();
            this.RB_EvezOlunur = new Logbook.MSRadioButton();
            this.Lbl_GrpName = new System.Windows.Forms.Label();
            this.Pnl_Body = new System.Windows.Forms.Panel();
            this.Lbl_LessonName = new System.Windows.Forms.Label();
            this.Lbl_Lesson = new System.Windows.Forms.Label();
            this.Btn_AddStd = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.Pnl_Header.SuspendLayout();
            this.Pnl_Teacher.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_Header
            // 
            this.Pnl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.Pnl_Header.Controls.Add(this.ChckB_All_InTime);
            this.Pnl_Header.Controls.Add(this.Lbl_Diamonds);
            this.Pnl_Header.Controls.Add(this.label9);
            this.Pnl_Header.Controls.Add(this.Lbl_Comment);
            this.Pnl_Header.Controls.Add(this.Lbl_Class);
            this.Pnl_Header.Controls.Add(this.Lbl_Review);
            this.Pnl_Header.Controls.Add(this.Lbl_CheckEveryone);
            this.Pnl_Header.Controls.Add(this.Lbl_Time);
            this.Pnl_Header.Controls.Add(this.Lbl_StdInfo);
            this.Pnl_Header.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Pnl_Header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.Pnl_Header.Location = new System.Drawing.Point(14, 101);
            this.Pnl_Header.Name = "Pnl_Header";
            this.Pnl_Header.Size = new System.Drawing.Size(1247, 60);
            this.Pnl_Header.TabIndex = 7;
            // 
            // ChckB_All_InTime
            // 
            this.ChckB_All_InTime.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(102)))));
            this.ChckB_All_InTime.Location = new System.Drawing.Point(595, 31);
            this.ChckB_All_InTime.MinimumSize = new System.Drawing.Size(0, 10);
            this.ChckB_All_InTime.Name = "ChckB_All_InTime";
            this.ChckB_All_InTime.Size = new System.Drawing.Size(23, 19);
            this.ChckB_All_InTime.TabIndex = 7;
            this.ChckB_All_InTime.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(102)))));
            this.ChckB_All_InTime.UseVisualStyleBackColor = true;
            this.ChckB_All_InTime.CheckedChanged += new System.EventHandler(this.ChckB_All_InTime_CheckedChanged);
            // 
            // Lbl_Diamonds
            // 
            this.Lbl_Diamonds.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Diamonds.Image = global::Logbook_v1._2.Properties.Resources.diamond_blue;
            this.Lbl_Diamonds.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Lbl_Diamonds.Location = new System.Drawing.Point(1041, 20);
            this.Lbl_Diamonds.Name = "Lbl_Diamonds";
            this.Lbl_Diamonds.Size = new System.Drawing.Size(49, 22);
            this.Lbl_Diamonds.TabIndex = 6;
            this.Lbl_Diamonds.Text = "5";
            this.Lbl_Diamonds.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(210)))), ((int)(((byte)(253)))));
            this.label9.Location = new System.Drawing.Point(0, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1247, 2);
            this.label9.TabIndex = 5;
            // 
            // Lbl_Comment
            // 
            this.Lbl_Comment.AutoSize = true;
            this.Lbl_Comment.Location = new System.Drawing.Point(1172, 24);
            this.Lbl_Comment.Name = "Lbl_Comment";
            this.Lbl_Comment.Size = new System.Drawing.Size(28, 15);
            this.Lbl_Comment.TabIndex = 6;
            this.Lbl_Comment.Text = "Rəy";
            // 
            // Lbl_Class
            // 
            this.Lbl_Class.AutoSize = true;
            this.Lbl_Class.Location = new System.Drawing.Point(900, 24);
            this.Lbl_Class.Name = "Lbl_Class";
            this.Lbl_Class.Size = new System.Drawing.Size(56, 15);
            this.Lbl_Class.TabIndex = 5;
            this.Lbl_Class.Text = "Sinifdə iş";
            // 
            // Lbl_Review
            // 
            this.Lbl_Review.AutoSize = true;
            this.Lbl_Review.Location = new System.Drawing.Point(782, 24);
            this.Lbl_Review.Name = "Lbl_Review";
            this.Lbl_Review.Size = new System.Drawing.Size(78, 15);
            this.Lbl_Review.TabIndex = 4;
            this.Lbl_Review.Text = "Yoxlama işləri";
            // 
            // Lbl_CheckEveryone
            // 
            this.Lbl_CheckEveryone.AutoSize = true;
            this.Lbl_CheckEveryone.Location = new System.Drawing.Point(546, 10);
            this.Lbl_CheckEveryone.Name = "Lbl_CheckEveryone";
            this.Lbl_CheckEveryone.Size = new System.Drawing.Size(111, 15);
            this.Lbl_CheckEveryone.TabIndex = 1;
            this.Lbl_CheckEveryone.Text = "Hərkəsi qeyd etmək";
            // 
            // Lbl_Time
            // 
            this.Lbl_Time.AutoSize = true;
            this.Lbl_Time.Location = new System.Drawing.Point(352, 24);
            this.Lbl_Time.Name = "Lbl_Time";
            this.Lbl_Time.Size = new System.Drawing.Size(108, 15);
            this.Lbl_Time.TabIndex = 1;
            this.Lbl_Time.Text = "Mystat\'a daxil olub";
            // 
            // Lbl_StdInfo
            // 
            this.Lbl_StdInfo.AutoSize = true;
            this.Lbl_StdInfo.Location = new System.Drawing.Point(124, 24);
            this.Lbl_StdInfo.Name = "Lbl_StdInfo";
            this.Lbl_StdInfo.Size = new System.Drawing.Size(125, 15);
            this.Lbl_StdInfo.TabIndex = 0;
            this.Lbl_StdInfo.Text = "Tələbələrin Ad,Soyadı";
            // 
            // Pnl_Teacher
            // 
            this.Pnl_Teacher.Controls.Add(this.RB_EsasMlm);
            this.Pnl_Teacher.Controls.Add(this.RB_EvezOlunur);
            this.Pnl_Teacher.Location = new System.Drawing.Point(14, 51);
            this.Pnl_Teacher.Name = "Pnl_Teacher";
            this.Pnl_Teacher.Size = new System.Drawing.Size(278, 39);
            this.Pnl_Teacher.TabIndex = 6;
            // 
            // RB_EsasMlm
            // 
            this.RB_EsasMlm.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(135)))), ((int)(((byte)(208)))));
            this.RB_EsasMlm.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RB_EsasMlm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.RB_EsasMlm.Location = new System.Drawing.Point(3, 3);
            this.RB_EsasMlm.MinimumSize = new System.Drawing.Size(0, 21);
            this.RB_EsasMlm.Name = "RB_EsasMlm";
            this.RB_EsasMlm.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.RB_EsasMlm.Size = new System.Drawing.Size(102, 21);
            this.RB_EsasMlm.TabIndex = 2;
            this.RB_EsasMlm.TabStop = true;
            this.RB_EsasMlm.Text = "Əsas müəllim";
            this.RB_EsasMlm.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(135)))), ((int)(((byte)(208)))));
            this.RB_EsasMlm.UseVisualStyleBackColor = true;
            // 
            // RB_EvezOlunur
            // 
            this.RB_EvezOlunur.AutoSize = true;
            this.RB_EvezOlunur.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(135)))), ((int)(((byte)(208)))));
            this.RB_EvezOlunur.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RB_EvezOlunur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.RB_EvezOlunur.Location = new System.Drawing.Point(111, 3);
            this.RB_EvezOlunur.MinimumSize = new System.Drawing.Size(0, 21);
            this.RB_EvezOlunur.Name = "RB_EvezOlunur";
            this.RB_EvezOlunur.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.RB_EvezOlunur.Size = new System.Drawing.Size(154, 21);
            this.RB_EvezOlunur.TabIndex = 2;
            this.RB_EvezOlunur.TabStop = true;
            this.RB_EvezOlunur.Text = "Müəllim əvəz olunur";
            this.RB_EvezOlunur.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(135)))), ((int)(((byte)(208)))));
            this.RB_EvezOlunur.UseVisualStyleBackColor = true;
            // 
            // Lbl_GrpName
            // 
            this.Lbl_GrpName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_GrpName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(132)))), ((int)(((byte)(208)))));
            this.Lbl_GrpName.Location = new System.Drawing.Point(14, 13);
            this.Lbl_GrpName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_GrpName.Name = "Lbl_GrpName";
            this.Lbl_GrpName.Size = new System.Drawing.Size(176, 35);
            this.Lbl_GrpName.TabIndex = 5;
            this.Lbl_GrpName.Text = "FSDE_3205_az";
            // 
            // Pnl_Body
            // 
            this.Pnl_Body.AutoSize = true;
            this.Pnl_Body.Location = new System.Drawing.Point(13, 163);
            this.Pnl_Body.Name = "Pnl_Body";
            this.Pnl_Body.Size = new System.Drawing.Size(1248, 395);
            this.Pnl_Body.TabIndex = 8;
            // 
            // Lbl_LessonName
            // 
            this.Lbl_LessonName.AutoSize = true;
            this.Lbl_LessonName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_LessonName.Location = new System.Drawing.Point(662, 66);
            this.Lbl_LessonName.Name = "Lbl_LessonName";
            this.Lbl_LessonName.Size = new System.Drawing.Size(120, 19);
            this.Lbl_LessonName.TabIndex = 9;
            this.Lbl_LessonName.Text = "Dərsin mövzusu:";
            // 
            // Lbl_Lesson
            // 
            this.Lbl_Lesson.AutoSize = true;
            this.Lbl_Lesson.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Lesson.Location = new System.Drawing.Point(788, 66);
            this.Lbl_Lesson.Name = "Lbl_Lesson";
            this.Lbl_Lesson.Size = new System.Drawing.Size(69, 19);
            this.Lbl_Lesson.TabIndex = 10;
            this.Lbl_Lesson.Text = "Java Intro";
            // 
            // Btn_AddStd
            // 
            this.Btn_AddStd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.Btn_AddStd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_AddStd.ForeColor = System.Drawing.Color.White;
            this.Btn_AddStd.Location = new System.Drawing.Point(1028, 62);
            this.Btn_AddStd.Name = "Btn_AddStd";
            this.Btn_AddStd.Size = new System.Drawing.Size(206, 27);
            this.Btn_AddStd.TabIndex = 11;
            this.Btn_AddStd.Text = "Add Student";
            this.Btn_AddStd.UseVisualStyleBackColor = false;
            this.Btn_AddStd.Click += new System.EventHandler(this.Btn_AddStd_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(135)))), ((int)(((byte)(208)))));
            this.label1.Location = new System.Drawing.Point(169, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 35);
            this.label1.TabIndex = 12;
            this.label1.Text = "(Windows form and WPF (CT-3))";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 530);
            this.Controls.Add(this.Pnl_Teacher);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_AddStd);
            this.Controls.Add(this.Lbl_Lesson);
            this.Controls.Add(this.Lbl_LessonName);
            this.Controls.Add(this.Pnl_Body);
            this.Controls.Add(this.Pnl_Header);
            this.Controls.Add(this.Lbl_GrpName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.Pnl_Header.ResumeLayout(false);
            this.Pnl_Header.PerformLayout();
            this.Pnl_Teacher.ResumeLayout(false);
            this.Pnl_Teacher.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Header;
        private System.Windows.Forms.Label Lbl_Diamonds;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Lbl_Comment;
        private System.Windows.Forms.Label Lbl_Class;
        private System.Windows.Forms.Label Lbl_Review;
        private System.Windows.Forms.Label Lbl_CheckEveryone;
        private System.Windows.Forms.Label Lbl_Time;
        private System.Windows.Forms.Label Lbl_StdInfo;
        private System.Windows.Forms.Panel Pnl_Teacher;
        private Logbook.MSRadioButton RB_EsasMlm;
        private Logbook.MSRadioButton RB_EvezOlunur;
        private System.Windows.Forms.Label Lbl_GrpName;
        private Logbook.MSChekBox ChckB_All_InTime;
        private System.Windows.Forms.Panel Pnl_Body;
        private System.Windows.Forms.Label Lbl_LessonName;
        private System.Windows.Forms.Label Lbl_Lesson;
        private System.Windows.Forms.Button Btn_AddStd;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
    }
}

