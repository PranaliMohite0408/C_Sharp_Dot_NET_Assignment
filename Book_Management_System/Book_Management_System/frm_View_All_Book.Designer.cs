namespace Book_Management_System
{
    partial class frm_View_All_Book
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_View_All_Book = new System.Windows.Forms.DataGridView();
            this.bookIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publicationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.book_Management_SystemDataSet = new Book_Management_System.Book_Management_SystemDataSet();
            this.book_DetailsTableAdapter = new Book_Management_System.Book_Management_SystemDataSetTableAdapters.Book_DetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_All_Book)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.book_Management_SystemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_View_All_Book
            // 
            this.dgv_View_All_Book.AutoGenerateColumns = false;
            this.dgv_View_All_Book.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_View_All_Book.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_View_All_Book.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_View_All_Book.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_All_Book.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookIDDataGridViewTextBoxColumn,
            this.bookNameDataGridViewTextBoxColumn,
            this.publicationsDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dgv_View_All_Book.DataSource = this.bookDetailsBindingSource;
            this.dgv_View_All_Book.Location = new System.Drawing.Point(41, 132);
            this.dgv_View_All_Book.Name = "dgv_View_All_Book";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_View_All_Book.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_View_All_Book.RowTemplate.Height = 28;
            this.dgv_View_All_Book.Size = new System.Drawing.Size(1696, 423);
            this.dgv_View_All_Book.TabIndex = 0;
            // 
            // bookIDDataGridViewTextBoxColumn
            // 
            this.bookIDDataGridViewTextBoxColumn.DataPropertyName = "Book_ID";
            this.bookIDDataGridViewTextBoxColumn.HeaderText = "Book_ID";
            this.bookIDDataGridViewTextBoxColumn.Name = "bookIDDataGridViewTextBoxColumn";
            // 
            // bookNameDataGridViewTextBoxColumn
            // 
            this.bookNameDataGridViewTextBoxColumn.DataPropertyName = "Book_Name";
            this.bookNameDataGridViewTextBoxColumn.HeaderText = "Book_Name";
            this.bookNameDataGridViewTextBoxColumn.Name = "bookNameDataGridViewTextBoxColumn";
            // 
            // publicationsDataGridViewTextBoxColumn
            // 
            this.publicationsDataGridViewTextBoxColumn.DataPropertyName = "Publications";
            this.publicationsDataGridViewTextBoxColumn.HeaderText = "Publications";
            this.publicationsDataGridViewTextBoxColumn.Name = "publicationsDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // bookDetailsBindingSource
            // 
            this.bookDetailsBindingSource.DataMember = "Book_Details";
            this.bookDetailsBindingSource.DataSource = this.book_Management_SystemDataSet;
            // 
            // book_Management_SystemDataSet
            // 
            this.book_Management_SystemDataSet.DataSetName = "Book_Management_SystemDataSet";
            this.book_Management_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // book_DetailsTableAdapter
            // 
            this.book_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // frm_View_All_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1776, 655);
            this.Controls.Add(this.dgv_View_All_Book);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_View_All_Book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View All Book";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.dgv_View_All_Book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_All_Book)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.book_Management_SystemDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_View_All_Book;
        private Book_Management_SystemDataSet book_Management_SystemDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publicationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bookDetailsBindingSource;
        private Book_Management_SystemDataSetTableAdapters.Book_DetailsTableAdapter book_DetailsTableAdapter;
    }
}