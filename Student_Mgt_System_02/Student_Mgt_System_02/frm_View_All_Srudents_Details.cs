using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Student_Mgt_System_02
{
    public partial class frm_View_All_Srudents_Details : Form
    {
        public frm_View_All_Srudents_Details()
        {
            InitializeComponent();
        }

        private void frm_View_All_Srudents_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'student_Mgt_SystemDataSet.Student_Details' table. You can move, or remove it, as needed.
            this.student_DetailsTableAdapter.Fill(this.student_Mgt_SystemDataSet.Student_Details);

        }
    }
}
