using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Book_Management_System
{
    public partial class frm_Add_Book : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Book_Management_System;Integrated Security=True");

        public frm_Add_Book()
        {
            InitializeComponent();
        }

        void Con_Open()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
        }
        void Con_Close()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
            }
        }

        private void frm_Add_Book_Load(object sender, EventArgs e)
        {

        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == (char)Keys.ShiftKey) || (e.KeyChar == (char)Keys.CapsLock)))
            {
                e.Handled = true;
            }
        }

        private void Only_Char(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == (char)Keys.ShiftKey) || (e.KeyChar == (char)Keys.CapsLock)))
            {
                e.Handled = true;
            }
        }

        private void Alpha_Numeric(object sender, KeyPressEventArgs e)
        {
            if( ! ((char.IsLetterOrDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar) == (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if(tb_Book_ID.Text != "" && tb_Book_Name.Text != "" && tb_Publications.Text != "" && tb_Book_Price.Text != "")
            {
                SqlCommand Cmd = new SqlCommand("insert into Book_Details values(" + tb_Book_ID.Text + ",'" + tb_Book_Name.Text + "','" + tb_Publications.Text + "'," + tb_Book_Price.Text + ") ", Con);

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Save Successfully !!!");
          
            }
            else
            {
                MessageBox.Show("First Fill All the Fields !!!!");
            }


            Con_Close();
        }

        private void btn_View_All_Book_Click(object sender, EventArgs e)
        {
            frm_View_All_Book obj = new frm_View_All_Book();
            obj.Show();
            this.Hide();
        }
    }
}
