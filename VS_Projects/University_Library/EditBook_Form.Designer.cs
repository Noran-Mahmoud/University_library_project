namespace University_Library
{
    partial class EditBook_Form
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
            this.edit_btn = new System.Windows.Forms.Button();
            this.txt_authorName = new System.Windows.Forms.TextBox();
            this.txt_publisher = new System.Windows.Forms.TextBox();
            this.txt_year = new System.Windows.Forms.TextBox();
            this.txt_category = new System.Windows.Forms.TextBox();
            this.txt_isbn = new System.Windows.Forms.TextBox();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.Author_Name = new System.Windows.Forms.Label();
            this.Publisher = new System.Windows.Forms.Label();
            this.Publish_Year = new System.Windows.Forms.Label();
            this.Category = new System.Windows.Forms.Label();
            this.ISBN = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.university_LibraryDataSet = new University_Library.University_LibraryDataSet();
            this.bOOKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bOOKTableAdapter = new University_Library.University_LibraryDataSetTableAdapters.BOOKTableAdapter();
            this.updatedata_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.university_LibraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // edit_btn
            // 
            this.edit_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edit_btn.Location = new System.Drawing.Point(61, 668);
            this.edit_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(135, 48);
            this.edit_btn.TabIndex = 27;
            this.edit_btn.Text = "Save Details";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // txt_authorName
            // 
            this.txt_authorName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_authorName.Location = new System.Drawing.Point(835, 235);
            this.txt_authorName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_authorName.Name = "txt_authorName";
            this.txt_authorName.Size = new System.Drawing.Size(134, 26);
            this.txt_authorName.TabIndex = 26;
            // 
            // txt_publisher
            // 
            this.txt_publisher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_publisher.Location = new System.Drawing.Point(835, 168);
            this.txt_publisher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_publisher.Name = "txt_publisher";
            this.txt_publisher.Size = new System.Drawing.Size(134, 26);
            this.txt_publisher.TabIndex = 25;
            // 
            // txt_year
            // 
            this.txt_year.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_year.Location = new System.Drawing.Point(835, 96);
            this.txt_year.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_year.Name = "txt_year";
            this.txt_year.Size = new System.Drawing.Size(134, 26);
            this.txt_year.TabIndex = 24;
            // 
            // txt_category
            // 
            this.txt_category.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_category.Location = new System.Drawing.Point(287, 238);
            this.txt_category.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_category.Name = "txt_category";
            this.txt_category.Size = new System.Drawing.Size(134, 26);
            this.txt_category.TabIndex = 23;
            // 
            // txt_isbn
            // 
            this.txt_isbn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_isbn.Location = new System.Drawing.Point(287, 168);
            this.txt_isbn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_isbn.Name = "txt_isbn";
            this.txt_isbn.Size = new System.Drawing.Size(134, 26);
            this.txt_isbn.TabIndex = 22;
            this.txt_isbn.TextChanged += new System.EventHandler(this.txt_isbn_TextChanged);
            // 
            // txt_title
            // 
            this.txt_title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_title.Location = new System.Drawing.Point(287, 92);
            this.txt_title.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(134, 26);
            this.txt_title.TabIndex = 21;
            // 
            // Author_Name
            // 
            this.Author_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Author_Name.AutoSize = true;
            this.Author_Name.Location = new System.Drawing.Point(659, 240);
            this.Author_Name.Name = "Author_Name";
            this.Author_Name.Size = new System.Drawing.Size(107, 20);
            this.Author_Name.TabIndex = 20;
            this.Author_Name.Text = "Author Name:";
            // 
            // Publisher
            // 
            this.Publisher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Publisher.AutoSize = true;
            this.Publisher.Location = new System.Drawing.Point(658, 171);
            this.Publisher.Name = "Publisher";
            this.Publisher.Size = new System.Drawing.Size(78, 20);
            this.Publisher.TabIndex = 19;
            this.Publisher.Text = "Publisher:";
            // 
            // Publish_Year
            // 
            this.Publish_Year.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Publish_Year.AutoSize = true;
            this.Publish_Year.Location = new System.Drawing.Point(658, 100);
            this.Publish_Year.Name = "Publish_Year";
            this.Publish_Year.Size = new System.Drawing.Size(102, 20);
            this.Publish_Year.TabIndex = 18;
            this.Publish_Year.Text = "Publish Year:";
            // 
            // Category
            // 
            this.Category.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Category.AutoSize = true;
            this.Category.Location = new System.Drawing.Point(124, 240);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(77, 20);
            this.Category.TabIndex = 17;
            this.Category.Text = "Category:";
            // 
            // ISBN
            // 
            this.ISBN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ISBN.AutoSize = true;
            this.ISBN.Location = new System.Drawing.Point(124, 171);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(51, 20);
            this.ISBN.TabIndex = 16;
            this.ISBN.Text = "ISBN:";
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(125, 96);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(42, 20);
            this.title.TabIndex = 15;
            this.title.Text = "Title:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(478, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Edit Book";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(61, 296);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(990, 330);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // university_LibraryDataSet
            // 
            this.university_LibraryDataSet.DataSetName = "University_LibraryDataSet";
            this.university_LibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // updatedata_btn
            // 
            this.updatedata_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updatedata_btn.Location = new System.Drawing.Point(916, 668);
            this.updatedata_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.updatedata_btn.Name = "updatedata_btn";
            this.updatedata_btn.Size = new System.Drawing.Size(135, 48);
            this.updatedata_btn.TabIndex = 29;
            this.updatedata_btn.Text = "Update Data";
            this.updatedata_btn.UseVisualStyleBackColor = true;
            this.updatedata_btn.Click += new System.EventHandler(this.updatedata_btn_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Location = new System.Drawing.Point(14, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 48);
            this.button1.TabIndex = 30;
            this.button1.Text = "< Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditBook_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 752);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.updatedata_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.txt_authorName);
            this.Controls.Add(this.txt_publisher);
            this.Controls.Add(this.txt_year);
            this.Controls.Add(this.txt_category);
            this.Controls.Add(this.txt_isbn);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.Author_Name);
            this.Controls.Add(this.Publisher);
            this.Controls.Add(this.Publish_Year);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.ISBN);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EditBook_Form";
            this.Text = "Edit Book Form";
            this.Load += new System.EventHandler(this.EditBook_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.university_LibraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.TextBox txt_authorName;
        private System.Windows.Forms.TextBox txt_publisher;
        private System.Windows.Forms.TextBox txt_year;
        private System.Windows.Forms.TextBox txt_category;
        private System.Windows.Forms.TextBox txt_isbn;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.Label Author_Name;
        private System.Windows.Forms.Label Publisher;
        private System.Windows.Forms.Label Publish_Year;
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.Label ISBN;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private University_LibraryDataSet university_LibraryDataSet;
        private System.Windows.Forms.BindingSource bOOKBindingSource;
        private University_LibraryDataSetTableAdapters.BOOKTableAdapter bOOKTableAdapter;
        private System.Windows.Forms.Button updatedata_btn;
        private System.Windows.Forms.Button button1;
    }
}