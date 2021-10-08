using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_Management_System_03
{
    public partial class frm_Search_Student : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Student_Mgt_System;Integrated Security=True");
        public frm_Search_Student()
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

        private void frm_Search_Student_Load(object sender, EventArgs e)
        {

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();
            SqlCommand cmd = new SqlCommand("Select * from Student_Details where Roll_No = " + tb_Roll_No.Text + " ", Con);
            var obj = cmd.ExecuteReader();

            if (obj.Read())
            {
                tb_Name.Text = obj.GetString(obj.GetOrdinal("Name"));
                tb_Mobile_Number.Text = (obj["Mobile_No"].ToString());
                dtp_DOB.Text = (obj["DOB"].ToString());
                tb_Course.Text = obj.GetString(obj.GetOrdinal("Course"));

            }
            else
            {
                MessageBox.Show("Invalid Roll Number !!!");
                tb_Roll_No.Clear();
                tb_Roll_No.Focus();
            }
            Con_Close();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tb_Roll_No.Clear();
            tb_Name.Clear();
            tb_Mobile_Number.Clear();
            tb_Course.Clear();
            dtp_DOB.ResetText();
            tb_Roll_No.Focus();
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }
    }
}
