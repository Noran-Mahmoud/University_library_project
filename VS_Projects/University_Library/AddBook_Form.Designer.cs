namespace University_Library
{
    partial class AddBook_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.ISBN = new System.Windows.Forms.Label();
            this.Category = new System.Windows.Forms.Label();
            this.Publish_Year = new System.Windows.Forms.Label();
            this.Publisher = new System.Windows.Forms.Label();
            this.Author_Name = new System.Windows.Forms.Label();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.txt_isbn = new System.Windows.Forms.TextBox();
            this.txt_category = new System.Windows.Forms.TextBox();
            this.txt_year = new System.Windows.Forms.TextBox();
            this.txt_publisher = new System.Windows.Forms.TextBox();
            this.txt_authorName = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.bOOKBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.university_LibraryDataSet = new University_Library.University_LibraryDataSet();
            this.bOOKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bOOKTableAdapter = new University_Library.University_LibraryDataSetTableAdapters.BOOKTableAdapter();
            this.universityLibraryDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aUTHORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aUTHORTableAdapter = new University_Library.University_LibraryDataSetTableAdapters.AUTHORTableAdapter();
            this.bOOKBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bOOKBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.txt_bookCopies = new System.Windows.Forms.TextBox();
            this.Book_Copies = new System.Windows.Forms.Label();
            this.bOOKBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.bOOKBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.txt_category2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.university_LibraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityLibraryDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTHORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(403, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Book";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(308, 81);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(36, 16);
            this.title.TabIndex = 1;
            this.title.Text = "Title:";
            // 
            // ISBN
            // 
            this.ISBN.AutoSize = true;
            this.ISBN.Location = new System.Drawing.Point(308, 130);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(41, 16);
            this.ISBN.TabIndex = 2;
            this.ISBN.Text = "ISBN:";
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.Location = new System.Drawing.Point(309, 184);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(65, 16);
            this.Category.TabIndex = 3;
            this.Category.Text = "Category:";
            // 
            // Publish_Year
            // 
            this.Publish_Year.AutoSize = true;
            this.Publish_Year.Location = new System.Drawing.Point(308, 237);
            this.Publish_Year.Name = "Publish_Year";
            this.Publish_Year.Size = new System.Drawing.Size(86, 16);
            this.Publish_Year.TabIndex = 4;
            this.Publish_Year.Text = "Publish Year:";
            // 
            // Publisher
            // 
            this.Publisher.AutoSize = true;
            this.Publisher.Location = new System.Drawing.Point(308, 296);
            this.Publisher.Name = "Publisher";
            this.Publisher.Size = new System.Drawing.Size(66, 16);
            this.Publisher.TabIndex = 5;
            this.Publisher.Text = "Publisher:";
            // 
            // Author_Name
            // 
            this.Author_Name.AutoSize = true;
            this.Author_Name.Location = new System.Drawing.Point(309, 352);
            this.Author_Name.Name = "Author_Name";
            this.Author_Name.Size = new System.Drawing.Size(88, 16);
            this.Author_Name.TabIndex = 6;
            this.Author_Name.Text = "Author Name:";
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(516, 78);
            this.txt_title.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(120, 22);
            this.txt_title.TabIndex = 7;
            // 
            // txt_isbn
            // 
            this.txt_isbn.Location = new System.Drawing.Point(516, 127);
            this.txt_isbn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_isbn.Name = "txt_isbn";
            this.txt_isbn.Size = new System.Drawing.Size(120, 22);
            this.txt_isbn.TabIndex = 8;
            // 
            // txt_category
            // 
            this.txt_category.Location = new System.Drawing.Point(516, 181);
            this.txt_category.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_category.Name = "txt_category";
            this.txt_category.Size = new System.Drawing.Size(120, 22);
            this.txt_category.TabIndex = 9;
            // 
            // txt_year
            // 
            this.txt_year.Location = new System.Drawing.Point(516, 234);
            this.txt_year.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_year.Name = "txt_year";
            this.txt_year.Size = new System.Drawing.Size(120, 22);
            this.txt_year.TabIndex = 10;
            // 
            // txt_publisher
            // 
            this.txt_publisher.Location = new System.Drawing.Point(516, 293);
            this.txt_publisher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_publisher.Name = "txt_publisher";
            this.txt_publisher.Size = new System.Drawing.Size(120, 22);
            this.txt_publisher.TabIndex = 11;
            // 
            // txt_authorName
            // 
            this.txt_authorName.Location = new System.Drawing.Point(516, 349);
            this.txt_authorName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_authorName.Name = "txt_authorName";
            this.txt_authorName.Size = new System.Drawing.Size(120, 22);
            this.txt_authorName.TabIndex = 12;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(406, 465);
            this.add_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(98, 38);
            this.add_btn.TabIndex = 13;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
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
            // universityLibraryDataSet1BindingSource
            // 
            this.universityLibraryDataSet1BindingSource.DataSource = this.university_LibraryDataSet;
            this.universityLibraryDataSet1BindingSource.Position = 0;
            // 
            // aUTHORBindingSource
            // 
            this.aUTHORBindingSource.DataMember = "AUTHOR";
            this.aUTHORBindingSource.DataSource = this.university_LibraryDataSet;
            // 
            // aUTHORTableAdapter
            // 
            this.aUTHORTableAdapter.ClearBeforeFill = true;
            // 
            // bOOKBindingSource1
            // 
            this.bOOKBindingSource1.DataMember = "BOOK";
            this.bOOKBindingSource1.DataSource = this.university_LibraryDataSet;
            // 
            // bOOKBindingSource2
            // 
            this.bOOKBindingSource2.DataMember = "BOOK";
            this.bOOKBindingSource2.DataSource = this.university_LibraryDataSet;
            // 
            // txt_bookCopies
            // 
            this.txt_bookCopies.Location = new System.Drawing.Point(516, 402);
            this.txt_bookCopies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_bookCopies.Name = "txt_bookCopies";
            this.txt_bookCopies.Size = new System.Drawing.Size(120, 22);
            this.txt_bookCopies.TabIndex = 16;
            this.txt_bookCopies.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Book_Copies
            // 
            this.Book_Copies.AutoSize = true;
            this.Book_Copies.Location = new System.Drawing.Point(309, 405);
            this.Book_Copies.Name = "Book_Copies";
            this.Book_Copies.Size = new System.Drawing.Size(118, 16);
            this.Book_Copies.TabIndex = 15;
            this.Book_Copies.Text = "Number of Copies:";
            this.Book_Copies.Click += new System.EventHandler(this.label2_Click);
            // 
            // bOOKBindingSource3
            // 
            this.bOOKBindingSource3.DataMember = "BOOK";
            this.bOOKBindingSource3.DataSource = this.university_LibraryDataSet;
            // 
            // bOOKBindingSource5
            // 
            this.bOOKBindingSource5.DataMember = "BOOK";
            this.bOOKBindingSource5.DataSource = this.university_LibraryDataSet;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Location = new System.Drawing.Point(12, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 38);
            this.button1.TabIndex = 31;
            this.button1.Text = "< Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_category2
            // 
            this.txt_category2.Location = new System.Drawing.Point(696, 181);
            this.txt_category2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_category2.Name = "txt_category2";
            this.txt_category2.Size = new System.Drawing.Size(120, 22);
            this.txt_category2.TabIndex = 32;
            this.txt_category2.TextChanged += new System.EventHandler(this.txt_category2_TextChanged);
            // 
            // AddBook_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 514);
            this.Controls.Add(this.txt_category2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_bookCopies);
            this.Controls.Add(this.Book_Copies);
            this.Controls.Add(this.add_btn);
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
            this.Name = "AddBook_Form";
            this.Text = "Add Book Form";
            this.Load += new System.EventHandler(this.AddBook_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.university_LibraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityLibraryDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTHORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label ISBN;
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.Label Publish_Year;
        private System.Windows.Forms.Label Publisher;
        private System.Windows.Forms.Label Author_Name;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.TextBox txt_isbn;
        private System.Windows.Forms.TextBox txt_category;
        private System.Windows.Forms.TextBox txt_year;
        private System.Windows.Forms.TextBox txt_publisher;
        private System.Windows.Forms.TextBox txt_authorName;
        private System.Windows.Forms.Button add_btn;
        private University_LibraryDataSet university_LibraryDataSet;
        private System.Windows.Forms.BindingSource bOOKBindingSource;
        private University_LibraryDataSetTableAdapters.BOOKTableAdapter bOOKTableAdapter;
        private System.Windows.Forms.BindingSource universityLibraryDataSet1BindingSource;
        private System.Windows.Forms.BindingSource aUTHORBindingSource;
        private University_LibraryDataSetTableAdapters.AUTHORTableAdapter aUTHORTableAdapter;
        private System.Windows.Forms.BindingSource bOOKBindingSource1;
        private System.Windows.Forms.BindingSource bOOKBindingSource2;
        private System.Windows.Forms.TextBox txt_bookCopies;
        private System.Windows.Forms.Label Book_Copies;
        private System.Windows.Forms.BindingSource bOOKBindingSource3;
        private System.Windows.Forms.BindingSource bOOKBindingSource4;
        private System.Windows.Forms.BindingSource bOOKBindingSource5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_category2;
    }
}