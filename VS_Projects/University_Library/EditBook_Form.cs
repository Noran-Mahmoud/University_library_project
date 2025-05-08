using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_Library
{
    public partial class EditBook_Form : Form
    {
        public EditBook_Form()
        {
            InitializeComponent();
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            if (txt_title.Text != "" && txt_authorName.Text != "" && txt_isbn.Text != "" && txt_category.Text != "" && txt_year.Text != "" && txt_publisher.Text != "" )
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=NORANPC\\SQLEXPRESS;Initial Catalog=University_Library;Integrated Security=True;TrustServerCertificate=True";
                con.Open();

                SqlCommand editBook = new SqlCommand("Update BOOK set PUBLISHER = @PUBLISHER, PUBLISH_YEAR = @PUBLISH_YEAR, TITLE = @TITLE, AUTHORID = @AUTHOR_ID where ISBN = @ISBN ", con);

                editBook.Parameters.AddWithValue("@PUBLISHER", txt_publisher.Text);
                editBook.Parameters.AddWithValue("@PUBLISH_YEAR", txt_year.Text);
                editBook.Parameters.AddWithValue("@TITLE", txt_title.Text);
                editBook.Parameters.AddWithValue("@ISBN", txt_isbn.Text);



                ///////////////////////////////////////////



                SqlCommand getAuthorID = new SqlCommand("select AUTHORID from AUTHOR where NAME = @NAME;", con);
                getAuthorID.Parameters.AddWithValue("@NAME", txt_authorName.Text);
                int AuthorID = Convert.ToInt32(getAuthorID.ExecuteScalar());
                editBook.Parameters.AddWithValue("@AUTHOR_ID", AuthorID);


                ///////////////////////////////////////////////

                SqlCommand getBookID = new SqlCommand("select BOOK_ID from Book where ISBN = '" + txt_isbn.Text + "'", con);
                int bookid = Convert.ToInt32(getBookID.ExecuteScalar());

                SqlCommand editCategory = new SqlCommand("update TOP(1) CATEGORY set GENRE = @GENRE where BOOK_ID = '"+ bookid + "'", con);
                editCategory.Parameters.AddWithValue("@GENRE", txt_category.Text);


                editBook.ExecuteNonQuery();
                getAuthorID.ExecuteNonQuery();
                editCategory.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Saved Successfully", "DONE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("All boxes must be filled", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                

        }

        private void EditBook_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'university_LibraryDataSet.BOOK' table. You can move, or remove it, as needed.
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=NORANPC\\SQLEXPRESS;Initial Catalog=University_Library;Integrated Security=True;TrustServerCertificate=True";
            con.Open();
            string query = "SELECT Title, ISBN, AUTHOR.NAME AS Author_Name ,CATEGORY.GENRE, PUBLISHER, PUBLISH_YEAR, BORROWED, AVAILABLE " +
                "FROM BOOK inner join CATEGORY on CATEGORY.BOOK_ID = BOOK.BOOK_ID inner join AUTHOR on BOOK.AUTHORID = AUTHOR.AUTHORID";

            SqlCommand browse = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(browse);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void updatedata_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=NORANPC\\SQLEXPRESS;Initial Catalog=University_Library;Integrated Security=True;TrustServerCertificate=True";
            con.Open();
            string query = "SELECT Title, ISBN, AUTHOR.NAME AS Author_Name ,CATEGORY.GENRE, PUBLISHER, PUBLISH_YEAR, BORROWED, AVAILABLE " +
                "FROM BOOK inner join CATEGORY on CATEGORY.BOOK_ID = BOOK.BOOK_ID inner join AUTHOR on BOOK.AUTHORID = AUTHOR.AUTHORID";

            SqlCommand browse = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(browse);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form admnForm = new Admin_Form();
            admnForm.Show();
        }

        private void txt_isbn_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
