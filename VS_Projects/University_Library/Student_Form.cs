using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace University_Library
{
    public partial class Student_Form : Form
    {
        public Student_Form()
        {
            InitializeComponent();
        }

        private void Student_Form_Load(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void editUser_btn_Click(object sender, EventArgs e)
        {
            Form editUser = new EditUser_Form();
            editUser.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void borrow_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=NORANPC\\SQLEXPRESS;Initial Catalog=University_Library;Integrated Security=True;TrustServerCertificate=True";
            con.Open();
            SqlCommand checkISBN = new SqlCommand("select ISBN from BOOK WHERE ISBN = '" + txt_ISBN.Text + "'", con);
            int tempISBN = Convert.ToInt32(checkISBN.ExecuteScalar());

            if (string.IsNullOrEmpty(txt_ISBN.Text))
            {
                MessageBox.Show("Please write an ISBN to borrow book!");
                return;
            }
            int currISBN = Convert.ToInt32(txt_ISBN.Text);

            if (currISBN == tempISBN)
            {
                //get bookID
                SqlCommand getBookID = new SqlCommand("select BOOK_ID from Book where ISBN = '" + txt_ISBN.Text + "'", con);
                int bookid = Convert.ToInt32(getBookID.ExecuteScalar());

                //check if book available
                SqlCommand getAval = new SqlCommand("select AVAILABLE from Book where BOOK_ID = @bookID", con);
                getAval.Parameters.AddWithValue("@bookID", bookid);
                bool aval = Convert.ToBoolean(getAval.ExecuteScalar());
                //check if borrowed
                SqlCommand checkBorrowed = new SqlCommand("SELECT BOOK_ID FROM BORROW WHERE BOOK_ID = @bookID AND USERID = @userID", con);
                checkBorrowed.Parameters.AddWithValue("@bookID", bookid);
                checkBorrowed.Parameters.AddWithValue("@userID", Login_Form.userId);
                int borrowed = Convert.ToInt32(checkBorrowed.ExecuteScalar());

                if (aval && borrowed == 0)
                {
                    DateTime now = DateTime.Today;
                    SqlCommand borrow = new SqlCommand("insert into BORROW VALUES ('" + Login_Form.userId + "', '" + bookid + "', '" + now + "', '" + now.AddMonths(1) + "')", con);
                    borrow.ExecuteNonQuery();

                    //update borrowed count
                    SqlCommand cntBorrowed = new SqlCommand("update BOOK set BORROWED = BORROWED+1 where BOOK_ID = '"+bookid+"'", con);
                    cntBorrowed.ExecuteNonQuery();

                    //delete copy of book
                    SqlCommand cntAvalQuery = new SqlCommand("SELECT COUNT(*) FROM BOOK_COPY where BOOK_ID = '" + bookid + "'", con);
                    int cntAval = Convert.ToInt32(cntAvalQuery.ExecuteScalar());

                    if (cntAval >= 1)
                    {
                        SqlCommand deleteCopy = new SqlCommand("delete from BOOK_COPY where COPY_ID = '" + cntAval + "' and BOOK_ID = '" + bookid + "'", con);
                        deleteCopy.ExecuteNonQuery();
                    }
                    if (cntAval == 1)
                    {
                        SqlCommand setUnAval = new SqlCommand("update BOOK set AVAILABLE = 0", con);
                        setUnAval.ExecuteNonQuery();
                    }
                }
                else if (borrowed != 0)
                {
                    MessageBox.Show("You already borrowed this book!");
                    return;
                }
                else
                {
                    MessageBox.Show("This Book is not Available!");
                    return;
                }
                
            }
            else
            {
                MessageBox.Show("This ISBN does not exist!");
                return;
            }
            MessageBox.Show("Borrowed Successfully");
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

        private void button2_Click(object sender, EventArgs e)
        {
            Form login = new Login_Form();
            login.Show();
            this.Hide();
        }
    }
}
