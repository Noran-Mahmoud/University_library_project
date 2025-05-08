namespace University_Library
{
    partial class Student_Form
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
            this.editUser_btn = new System.Windows.Forms.Button();
            this.txt_ISBN = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.university_LibraryDataSet = new University_Library.University_LibraryDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_year = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_authorName = new System.Windows.Forms.TextBox();
            this.borrow_btn = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            this.browse_btn = new System.Windows.Forms.Button();
            this.bOOKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bOOKTableAdapter = new University_Library.University_LibraryDataSetTableAdapters.BOOKTableAdapter();
            this.bOOKBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.university_LibraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // editUser_btn
            // 
            this.editUser_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editUser_btn.AutoSize = true;
            this.editUser_btn.Location = new System.Drawing.Point(65, 44);
            this.editUser_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editUser_btn.Name = "editUser_btn";
            this.editUser_btn.Size = new System.Drawing.Size(196, 38);
            this.editUser_btn.TabIndex = 0;
            this.editUser_btn.Text = "Update User Details";
            this.editUser_btn.UseVisualStyleBackColor = true;
            this.editUser_btn.Click += new System.EventHandler(this.editUser_btn_Click);
            // 
            // txt_ISBN
            // 
            this.txt_ISBN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_ISBN.Location = new System.Drawing.Point(216, 121);
            this.txt_ISBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ISBN.Name = "txt_ISBN";
            this.txt_ISBN.Size = new System.Drawing.Size(115, 22);
            this.txt_ISBN.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(65, 286);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(857, 234);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // university_LibraryDataSet
            // 
            this.university_LibraryDataSet.DataSetName = "University_LibraryDataSet";
            this.university_LibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "ISBN:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Publish Year:";
            // 
            // txt_year
            // 
            this.txt_year.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_year.Location = new System.Drawing.Point(216, 171);
            this.txt_year.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_year.Name = "txt_year";
            this.txt_year.Size = new System.Drawing.Size(115, 22);
            this.txt_year.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Author Name:";
            // 
            // txt_authorName
            // 
            this.txt_authorName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_authorName.Location = new System.Drawing.Point(216, 222);
            this.txt_authorName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_authorName.Name = "txt_authorName";
            this.txt_authorName.Size = new System.Drawing.Size(115, 22);
            this.txt_authorName.TabIndex = 6;
            // 
            // borrow_btn
            // 
            this.borrow_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.borrow_btn.Location = new System.Drawing.Point(809, 165);
            this.borrow_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.borrow_btn.Name = "borrow_btn";
            this.borrow_btn.Size = new System.Drawing.Size(161, 34);
            this.borrow_btn.TabIndex = 8;
            this.borrow_btn.Text = "Borrow Book";
            this.borrow_btn.UseVisualStyleBackColor = true;
            this.borrow_btn.Click += new System.EventHandler(this.borrow_btn_Click);
            // 
            // search_btn
            // 
            this.search_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.search_btn.Location = new System.Drawing.Point(430, 165);
            this.search_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(97, 34);
            this.search_btn.TabIndex = 9;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // browse_btn
            // 
            this.browse_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.browse_btn.Location = new System.Drawing.Point(620, 165);
            this.browse_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.browse_btn.Name = "browse_btn";
            this.browse_btn.Size = new System.Drawing.Size(109, 34);
            this.browse_btn.TabIndex = 10;
            this.browse_btn.Text = "Browse All";
            this.browse_btn.UseVisualStyleBackColor = true;
            this.browse_btn.Click += new System.EventHandler(this.browse_btn_Click);
            // 
            // bOOKBindingSource
            // 
            this.bOOKBindingSource.DataMember = "BOOK";
            this.bOOKBindingSource.DataSource = this.university_LibraryDataSet;
            // 
            // bOOKTableAdapter
            // 
            this.bOOKTableAdapter.ClearBeforeFill = true;
            // 
            // bOOKBindingSource1
            // 
            this.bOOKBindingSource1.DataMember = "BOOK";
            this.bOOKBindingSource1.DataSource = this.university_LibraryDataSet;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(904, 11);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 38);
            this.button2.TabIndex = 32;
            this.button2.Text = "Log Out";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Student_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1012, 577);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.browse_btn);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.borrow_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_authorName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_year);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_ISBN);
            this.Controls.Add(this.editUser_btn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Student_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Form";
            this.Load += new System.EventHandler(this.Student_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.university_LibraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editUser_btn;
        private System.Windows.Forms.TextBox txt_ISBN;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_year;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_authorName;
        private System.Windows.Forms.Button borrow_btn;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button browse_btn;
        private University_LibraryDataSet university_LibraryDataSet;
        private System.Windows.Forms.BindingSource bOOKBindingSource;
        private University_LibraryDataSetTableAdapters.BOOKTableAdapter bOOKTableAdapter;
        private System.Windows.Forms.BindingSource bOOKBindingSource1;
        private System.Windows.Forms.Button button2;
    }
}

