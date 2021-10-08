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
    public partial class frm_Login : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Student_Mgt_System;Integrated Security=True");

        public frm_Login()
        {
            InitializeComponent();
        }

        void Con_open()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
        }
        void Con_close()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
            }
        }


        private void frm_Login_Load(object sender, EventArgs e)
        {
            tb_Username.Focus();
            lbl_Note.Text = "Please Enter your Username && Password";
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            Con_open();

            SqlCommand cmd = new SqlCommand("Select count(*) from User_Details where Username = '" + tb_Username.Text + "' and Password = '" + tb_Password.Text + "'", Con);

            if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
            {
                MessageBox.Show("Login successfull!!");
                Global_Vars.Uname = "Welcome" + tb_Username.Text;


                if (tb_Username.Text == "Admin")
                {
                    Global_Vars.URole = 1;
                }
                else if (tb_Username.Text == "a")
                {
                    Global_Vars.URole = 2;
                }

                MDI_Student_Management_System obj = new MDI_Student_Management_System();
                obj.Show();
                this.Hide();

                Con_close();
            }
            else
            {
                lbl_Note.Text = "Please Enter Your Valid Details";
            }
            tb_Username.Text = "";
            tb_Password.Text = "";
            tb_Username.Focus();
        }

    }
}
