using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_Mgt_System_02
{
    public partial class frm_Search : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Student_Mgt_System;Integrated Security=True");
        public frm_Search()
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

        private void frm_Search_Load(object sender, EventArgs e)
        {
            tb_Roll_No.Focus();
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
                tb_DOB.Text = (obj["DOB"].ToString());
                tb_Course.Text = obj.GetString(obj.GetOrdinal("Course"));
            }
            else
            {
                MessageBox.Show("Invalid Roll Number!!!");
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
            tb_DOB.Clear();
            tb_Course.Clear();
            tb_Roll_No.Focus();
        }

        private void btn_Add_New_Student_Click(object sender, EventArgs e)
        {
            frm_Add_New_Student obj = new frm_Add_New_Student();
            obj.Show();
            this.Hide();
        }

        private void btn_View_All_Students_Click(object sender, EventArgs e)
        {
            frm_View_All_Srudents_Details obj = new frm_View_All_Srudents_Details();
            obj.Show();
            this.Hide();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            frm_Login obj = new frm_Login();

            obj.Show();
            this.Hide();
        }
        

    }
}
