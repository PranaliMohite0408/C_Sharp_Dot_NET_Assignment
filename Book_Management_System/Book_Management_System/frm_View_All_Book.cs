using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Book_Management_System
{
    public partial class frm_View_All_Book : Form
    {
        public frm_View_All_Book()
        {
            InitializeComponent();
        }

        private void dgv_View_All_Book_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'book_Management_SystemDataSet.Book_Details' table. You can move, or remove it, as needed.
            this.book_DetailsTableAdapter.Fill(this.book_Management_SystemDataSet.Book_Details);

        }
    }
}
