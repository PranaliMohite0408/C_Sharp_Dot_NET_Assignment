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
    public partial class frm_View_All_Students : Form
    {
        public frm_View_All_Students()
        {
            InitializeComponent();
        }

        private void frm_View_All_Students_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'student_Mgt_SystemDataSet.Student_Details' table. You can move, or remove it, as needed.
            this.student_DetailsTableAdapter.Fill(this.student_Mgt_SystemDataSet.Student_Details);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
