using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Reflection;
using System.Windows.Forms;

namespace University_Library
{
    public partial class Admin_Form : Form
    {
        public Admin_Form()
        {
            InitializeComponent();
        }

        private void addBook_btn_Click(object sender, EventArgs e)
        {
            Form addform = new AddBook_Form();
            this.Hide();
            addform.Show();
        }

        private void Admin_Form_Load(object sender, EventArgs e)
        {

        }

        private void editBook_btn_Click(object sender, EventArgs e)
        {
            Form editform = new EditBook_Form();
            this.Hide();
            editform.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void browse_btn_Click(object sender, EventArgs e)
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

        private void search_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=NORANPC\\SQLEXPRESS;Initial Catalog=University_Library;Integrated Security=True;TrustServerCertificate=True";
            con.Open();
            string query = "SELECT Title, ISBN, AUTHOR.NAME AS Author_Name ,CATEGORY.GENRE, PUBLISHER, PUBLISH_YEAR, BORROWED, AVAILABLE " +
                "FROM BOOK inner join CATEGORY on CATEGORY.BOOK_ID = BOOK.BOOK_ID inner join AUTHOR on BOOK.AUTHORID = AUTHOR.AUTHORID where 1=1 ";

            if (!string.IsNullOrEmpty(txt_authorName.Text))
                query += "AND BOOK.AUTHORID = (SELECT AUTHORID from Author where AUTHOR.NAME = @Aname) ";
            if (!string.IsNullOrEmpty(txt_ISBN.Text))
                query += "AND ISBN = @isbn ";
            if (!string.IsNullOrEmpty(txt_year.Text))
                query += "AND PUBLISH_YEAR = @year ";


            SqlCommand searchQuery = new SqlCommand(query, con);
            if (!string.IsNullOrEmpty(txt_ISBN.Text))
                searchQuery.Parameters.AddWithValue("@isbn", txt_ISBN.Text);
            if (!string.IsNullOrEmpty(txt_year.Text))
                searchQuery.Parameters.AddWithValue("@year", txt_year.Text);
            if (!string.IsNullOrEmpty(txt_authorName.Text))
                searchQuery.Parameters.AddWithValue("@Aname", txt_authorName.Text);

            SqlDataAdapter da = new SqlDataAdapter(searchQuery);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void editUser_btn_Click(object sender, EventArgs e)
        {
            Form editform = new EditUser_Form();
            this.Hide();
            editform.Show();
        }

        private void btn_deleteBook_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=NORANPC\\SQLEXPRESS;Initial Catalog=University_Library;Integrated Security=True;TrustServerCertificate=True";
            con.Open();

            SqlCommand checkISBN = new SqlCommand("select ISBN from BOOK WHERE ISBN = '" + txt_ISBN.Text + "'", con);
            int tempISBN = Convert.ToInt32(checkISBN.ExecuteScalar());
            if (string.IsNullOrEmpty(txt_ISBN.Text))
            {
                MessageBox.Show("Please write an ISBN to delete book!");
                return;
            }
            int currISBN = Convert.ToInt32(txt_ISBN.Text);

            if (currISBN == tempISBN)
            {
                //get bookID
                SqlCommand getBookID = new SqlCommand("select BOOK_ID from Book where ISBN = '" + txt_ISBN.Text + "'", con);
                int bookid = Convert.ToInt32(getBookID.ExecuteScalar());

                //check if borrowed
                SqlCommand countBorrowed = new SqlCommand("select Count(*) from BORROW where BOOK_ID = '" + bookid + "'", con);
                int cntBorrow = Convert.ToInt32(countBorrowed.ExecuteScalar());
                if (cntBorrow == 0 && !string.IsNullOrEmpty(txt_ISBN.Text))
                {
                    SqlCommand deleteBook = new SqlCommand("delete from Book where BOOK_ID = '" + bookid + "'", con);
                    SqlCommand deleteCopy = new SqlCommand("delete from Book_COPY where BOOK_ID = '" + bookid + "'", con);
                    SqlCommand deleteCategory = new SqlCommand("delete from CATEGORY where BOOK_ID = '" + bookid + "'", con);
                    deleteCopy.ExecuteNonQuery();
                    deleteCategory.ExecuteNonQuery();
                    deleteBook.ExecuteNonQuery();
                    MessageBox.Show("Deleted Successfully.");
                }
                else
                {
                    MessageBox.Show("Can't delete a borrowed book!");
                }
            }
            else
            {
                MessageBox.Show("This ISBN does not exist!");
                return;
            }

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form login = new Login_Form();
            login.Show();
            this.Hide();
        }
    }
}
