using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Student_Management_System_03
{
    public partial class MDI_Student_Management_System : Form
    {
        public MDI_Student_Management_System()
        {
            InitializeComponent();
        }

        private void MDI_Student_Management_System_Load(object sender, EventArgs e)
        {
            lbl_Logged_In_Uname.Text = Global_Vars.Uname;
        }

        private void newStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_New_Student obj = new Add_New_Student();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void searchStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Search_Student obj = new frm_Search_Student();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
            
        }

        private void viewAllStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_View_All_Students obj = new frm_View_All_Students();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            frm_Login obj = new frm_Login();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();

        }

        
    }
}
