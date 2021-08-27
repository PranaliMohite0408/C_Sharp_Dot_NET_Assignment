namespace Book_Management_System
{
    partial class frm_Add_Book
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
            this.btn_Save = new System.Windows.Forms.Button();
            this.tb_Book_Price = new System.Windows.Forms.TextBox();
            this.tb_Publications = new System.Windows.Forms.TextBox();
            this.tb_Book_Name = new System.Windows.Forms.TextBox();
            this.tb_Book_ID = new System.Windows.Forms.TextBox();
            this.lbl_And_New_Book = new System.Windows.Forms.Label();
            this.lbl_Book_Price = new System.Windows.Forms.Label();
            this.lbl_Publications = new System.Windows.Forms.Label();
            this.lbl_Book_Name = new System.Windows.Forms.Label();
            this.lbl_Book_ID = new System.Windows.Forms.Label();
            this.btn_View_All_Book = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.White;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Red;
            this.btn_Save.Location = new System.Drawing.Point(253, 623);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(168, 68);
            this.btn_Save.TabIndex = 18;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // tb_Book_Price
            // 
            this.tb_Book_Price.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Book_Price.Location = new System.Drawing.Point(778, 509);
            this.tb_Book_Price.MaxLength = 5;
            this.tb_Book_Price.Name = "tb_Book_Price";
            this.tb_Book_Price.Size = new System.Drawing.Size(350, 42);
            this.tb_Book_Price.TabIndex = 14;
            this.tb_Book_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_Publications
            // 
            this.tb_Publications.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Publications.Location = new System.Drawing.Point(778, 400);
            this.tb_Publications.MaxLength = 20;
            this.tb_Publications.Name = "tb_Publications";
            this.tb_Publications.Size = new System.Drawing.Size(350, 42);
            this.tb_Publications.TabIndex = 12;
            this.tb_Publications.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Alpha_Numeric);
            // 
            // tb_Book_Name
            // 
            this.tb_Book_Name.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Book_Name.Location = new System.Drawing.Point(778, 282);
            this.tb_Book_Name.MaxLength = 60;
            this.tb_Book_Name.Name = "tb_Book_Name";
            this.tb_Book_Name.Size = new System.Drawing.Size(350, 42);
            this.tb_Book_Name.TabIndex = 10;
            this.tb_Book_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Char);
            // 
            // tb_Book_ID
            // 
            this.tb_Book_ID.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Book_ID.Location = new System.Drawing.Point(778, 164);
            this.tb_Book_ID.MaxLength = 4;
            this.tb_Book_ID.Name = "tb_Book_ID";
            this.tb_Book_ID.Size = new System.Drawing.Size(350, 42);
            this.tb_Book_ID.TabIndex = 9;
            this.tb_Book_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_And_New_Book
            // 
            this.lbl_And_New_Book.AutoSize = true;
            this.lbl_And_New_Book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_And_New_Book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_And_New_Book.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_And_New_Book.ForeColor = System.Drawing.Color.White;
            this.lbl_And_New_Book.Location = new System.Drawing.Point(398, 9);
            this.lbl_And_New_Book.Name = "lbl_And_New_Book";
            this.lbl_And_New_Book.Size = new System.Drawing.Size(467, 75);
            this.lbl_And_New_Book.TabIndex = 17;
            this.lbl_And_New_Book.Text = "Add New Book";
            // 
            // lbl_Book_Price
            // 
            this.lbl_Book_Price.AutoSize = true;
            this.lbl_Book_Price.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Book_Price.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Book_Price.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Book_Price.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_Book_Price.Location = new System.Drawing.Point(181, 518);
            this.lbl_Book_Price.Name = "lbl_Book_Price";
            this.lbl_Book_Price.Size = new System.Drawing.Size(240, 50);
            this.lbl_Book_Price.TabIndex = 16;
            this.lbl_Book_Price.Text = "Book Price";
            // 
            // lbl_Publications
            // 
            this.lbl_Publications.AutoSize = true;
            this.lbl_Publications.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Publications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Publications.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Publications.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_Publications.Location = new System.Drawing.Point(174, 399);
            this.lbl_Publications.Name = "lbl_Publications";
            this.lbl_Publications.Size = new System.Drawing.Size(267, 50);
            this.lbl_Publications.TabIndex = 15;
            this.lbl_Publications.Text = "Publications";
            // 
            // lbl_Book_Name
            // 
            this.lbl_Book_Name.AutoSize = true;
            this.lbl_Book_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Book_Name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Book_Name.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Book_Name.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_Book_Name.Location = new System.Drawing.Point(174, 283);
            this.lbl_Book_Name.Name = "lbl_Book_Name";
            this.lbl_Book_Name.Size = new System.Drawing.Size(247, 50);
            this.lbl_Book_Name.TabIndex = 13;
            this.lbl_Book_Name.Text = "Book Name";
            // 
            // lbl_Book_ID
            // 
            this.lbl_Book_ID.AutoSize = true;
            this.lbl_Book_ID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Book_ID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Book_ID.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Book_ID.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_Book_ID.Location = new System.Drawing.Point(181, 173);
            this.lbl_Book_ID.Name = "lbl_Book_ID";
            this.lbl_Book_ID.Size = new System.Drawing.Size(192, 50);
            this.lbl_Book_ID.TabIndex = 11;
            this.lbl_Book_ID.Text = "Book ID";
            // 
            // btn_View_All_Book
            // 
            this.btn_View_All_Book.BackColor = System.Drawing.Color.White;
            this.btn_View_All_Book.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View_All_Book.ForeColor = System.Drawing.Color.Red;
            this.btn_View_All_Book.Location = new System.Drawing.Point(707, 623);
            this.btn_View_All_Book.Name = "btn_View_All_Book";
            this.btn_View_All_Book.Size = new System.Drawing.Size(334, 68);
            this.btn_View_All_Book.TabIndex = 19;
            this.btn_View_All_Book.Text = "View All Book";
            this.btn_View_All_Book.UseVisualStyleBackColor = false;
            this.btn_View_All_Book.Click += new System.EventHandler(this.btn_View_All_Book_Click);
            // 
            // frm_Add_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 740);
            this.Controls.Add(this.btn_View_All_Book);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tb_Book_Price);
            this.Controls.Add(this.tb_Publications);
            this.Controls.Add(this.tb_Book_Name);
            this.Controls.Add(this.tb_Book_ID);
            this.Controls.Add(this.lbl_And_New_Book);
            this.Controls.Add(this.lbl_Book_Price);
            this.Controls.Add(this.lbl_Publications);
            this.Controls.Add(this.lbl_Book_Name);
            this.Controls.Add(this.lbl_Book_ID);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Add_Book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Book";
            this.Load += new System.EventHandler(this.frm_Add_Book_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox tb_Book_Price;
        private System.Windows.Forms.TextBox tb_Publications;
        private System.Windows.Forms.TextBox tb_Book_Name;
        private System.Windows.Forms.TextBox tb_Book_ID;
        private System.Windows.Forms.Label lbl_And_New_Book;
        private System.Windows.Forms.Label lbl_Book_Price;
        private System.Windows.Forms.Label lbl_Publications;
        private System.Windows.Forms.Label lbl_Book_Name;
        private System.Windows.Forms.Label lbl_Book_ID;
        private System.Windows.Forms.Button btn_View_All_Book;
    }
}