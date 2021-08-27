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
    public partial class frm_Login : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Book_Management_System;Integrated Security=True");

        public frm_Login()
        {
            InitializeComponent();
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            lbl_Note.Text = "Please Enter Your Username And Password !!";
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (tb_Username.Text == "a" && tb_Password.Text == "a")
            {
                MessageBox.Show("Login Successful!!");

               frm_Add_Book obj = new frm_Add_Book();
                obj.Show();
                this.Hide();
            }
            else
            {
                lbl_Note.Text = "Please Enter Your Valid Username And Password";
                lbl_Note.ForeColor = Color.Black;
            }

            tb_Username.Text = "";
            tb_Password.Text =  "";

            tb_Username.Focus();
        }

  

    }
}
