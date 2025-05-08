using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_Library
{
    public partial class AddBook_Form : Form
    {
        public AddBook_Form()
        {
            InitializeComponent();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (txt_title.Text != "" && txt_authorName.Text != "" && txt_isbn.Text != "" && txt_category.Text != "" && txt_year.Text != "" && txt_publisher.Text != "" && txt_bookCopies.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=NORANPC\\SQLEXPRESS;Initial Catalog=University_Library;Integrated Security=True;TrustServerCertificate=True";

                // Get the author ID
                SqlCommand getAuthorID = new SqlCommand("select AUTHORID from AUTHOR where NAME = @AuthorName", con);
                getAuthorID.Parameters.AddWithValue("@AuthorName", txt_authorName.Text);

                con.Open();
                object authorIdObj = getAuthorID.ExecuteScalar();

                if (authorIdObj != null)
                {
                    int authoridstr = Convert.ToInt32(authorIdObj);

                    // Insert the book
                    SqlCommand cmd = new SqlCommand("Insert Into BOOK (TITLE,ISBN,PUBLISH_YEAR,PUBLISHER,AUTHORID,BORROWED,AVAILABLE) values (@Title, @ISBN, @PublishYear, @Publisher, @AuthorID,@borrowed,@available)", con);
                    cmd.Parameters.AddWithValue("@Title", txt_title.Text);
                    cmd.Parameters.AddWithValue("@ISBN", txt_isbn.Text);
                    cmd.Parameters.AddWithValue("@PublishYear", txt_year.Text);
                    cmd.Parameters.AddWithValue("@Publisher", txt_publisher.Text);
                    cmd.Parameters.AddWithValue("@AuthorID", authoridstr);
                    cmd.Parameters.AddWithValue("@borrowed", 0);
                    cmd.Parameters.AddWithValue("@available", 1);

                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Done, A new book was added.", "SAVED", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Get the book ID
                    SqlCommand getBookID = new SqlCommand("select BOOK_ID from Book where ISBN = @ISBN", con);
                    getBookID.Parameters.AddWithValue("@ISBN", txt_isbn.Text);
                    int bookid = Convert.ToInt32(getBookID.ExecuteScalar());

                    // Insert the category
                    SqlCommand categoryQuery = new SqlCommand("insert into Category (GENRE, BOOK_ID) values(@GENRE, @BookID)", con);
                    categoryQuery.Parameters.AddWithValue("@GENRE", txt_category.Text);
                    categoryQuery.Parameters.AddWithValue("@BookID", bookid);
                    categoryQuery.ExecuteNonQuery();

                    if (!string.IsNullOrEmpty(txt_category2.Text))
                    {
                        SqlCommand categoryquery2 = new SqlCommand("insert into CATEGORY Values(@GENRE, " + bookid + ");", con);
                        categoryquery2.Parameters.AddWithValue("@GENRE", txt_category2.Text);
                        categoryquery2.ExecuteNonQuery();
                    }

                    // Insert book copies
                    for (int i = 1; i <= Convert.ToInt32(txt_bookCopies.Text); i++)
                    {

                        SqlCommand intobookCopies = new SqlCommand("insert into BOOK_COPY (BOOK_ID, COPY_ID) values (@BookID, @CopyID)", con);
                        intobookCopies.Parameters.AddWithValue("@BookID", bookid);
                        intobookCopies.Parameters.AddWithValue("@CopyID", i);
                        intobookCopies.ExecuteNonQuery();

                    }

                }
                else
                {
                    MessageBox.Show("Author not found. Please add the author first.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                con.Close();
            }
            else
            {
                MessageBox.Show("All boxes must be filled", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AddBook_Form_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form admnForm = new Admin_Form();
            admnForm.Show();      
        }

        private void txt_category2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
