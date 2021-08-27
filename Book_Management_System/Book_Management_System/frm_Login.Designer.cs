namespace Book_Management_System
{
    partial class frm_Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Login_Form = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.lbl_Note = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Login_Form
            // 
            this.lbl_Login_Form.AutoSize = true;
            this.lbl_Login_Form.BackColor = System.Drawing.Color.Navy;
            this.lbl_Login_Form.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Login_Form.Font = new System.Drawing.Font("Modern No. 20", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login_Form.ForeColor = System.Drawing.Color.White;
            this.lbl_Login_Form.Location = new System.Drawing.Point(354, 9);
            this.lbl_Login_Form.Name = "lbl_Login_Form";
            this.lbl_Login_Form.Size = new System.Drawing.Size(513, 98);
            this.lbl_Login_Form.TabIndex = 0;
            this.lbl_Login_Form.Text = "Login Form";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Username.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Username.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.ForeColor = System.Drawing.Color.Red;
            this.lbl_Username.Location = new System.Drawing.Point(173, 236);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(214, 50);
            this.lbl_Username.TabIndex = 1;
            this.lbl_Username.Text = "Username";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Password.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Password.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.ForeColor = System.Drawing.Color.Red;
            this.lbl_Password.Location = new System.Drawing.Point(173, 376);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(205, 50);
            this.lbl_Password.TabIndex = 2;
            this.lbl_Password.Text = "Password";
            // 
            // tb_Username
            // 
            this.tb_Username.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Username.Location = new System.Drawing.Point(714, 236);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(350, 42);
            this.tb_Username.TabIndex = 1;
            // 
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.Location = new System.Drawing.Point(714, 376);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(350, 42);
            this.tb_Password.TabIndex = 2;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.White;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_Save.Location = new System.Drawing.Point(479, 620);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(198, 68);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // lbl_Note
            // 
            this.lbl_Note.AutoSize = true;
            this.lbl_Note.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Note.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Note.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Note.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_Note.Location = new System.Drawing.Point(304, 512);
            this.lbl_Note.Name = "lbl_Note";
            this.lbl_Note.Size = new System.Drawing.Size(83, 37);
            this.lbl_Note.TabIndex = 4;
            this.lbl_Note.Text = "Note";
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 700);
            this.Controls.Add(this.lbl_Note);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.lbl_Login_Form);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frm_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Login_Form;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label lbl_Note;


    }
}

