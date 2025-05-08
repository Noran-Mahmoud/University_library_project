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
    public partial class EditUser_Form : Form
    {
        public EditUser_Form()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void EditUser_Form_Load(object sender, EventArgs e)
        {

            SqlConnection connect = new SqlConnection();
            connect.ConnectionString = "Data Source=NORANPC\\SQLEXPRESS;Initial Catalog=University_Library;Integrated Security=True;TrustServerCertificate=True";
            connect.Open();


            SqlCommand getUserName = new SqlCommand("SELECT USER_NAME FROM ACCOUNT WHERE USERID = '"+Login_Form.userId+"'", connect);     
            string userName = Convert.ToString(getUserName.ExecuteScalar());
            txt_username.Text = userName;

            SqlCommand getPassword = new SqlCommand("SELECT PASSWORD FROM ACCOUNT WHERE USERID = '"+Login_Form.userId+"'", connect);
            string Password = Convert.ToString(getPassword.ExecuteScalar());
            txt_password.Text = Password;

            SqlCommand getFname = new SqlCommand("SELECT FNAME FROM ACCOUNT WHERE USERID = '" + Login_Form.userId + "'", connect);
            string fname = Convert.ToString(getFname.ExecuteScalar());
            txt_fname.Text = fname;

            SqlCommand getLname = new SqlCommand("SELECT LNAME FROM ACCOUNT WHERE USERID = '" + Login_Form.userId + "'", connect);
            string lname = Convert.ToString(getLname.ExecuteScalar());
            txt_lname.Text = lname;

            SqlCommand getEmail= new SqlCommand("SELECT EMAIL FROM ACCOUNT WHERE USERID = '" + Login_Form.userId + "'", connect);
            string Email = Convert.ToString(getEmail.ExecuteScalar());
            txt_email.Text = Email;

            SqlCommand getLevel = new SqlCommand("SELECT LEVEL FROM ACCOUNT WHERE USERID = '" + Login_Form.userId + "'", connect);
            string Level = Convert.ToString(getLevel.ExecuteScalar());
            txt_level.Text = Level;

            SqlCommand getAccessCode = new SqlCommand("SELECT ACCESS_CODE FROM ACCOUNT WHERE USERID = '" + Login_Form.userId + "'", connect);
            string accessCode = Convert.ToString(getAccessCode.ExecuteScalar());
            txt_accessCode.Text = accessCode;

            SqlCommand getSID = new SqlCommand("SELECT SID FROM ACCOUNT WHERE USERID = '" + Login_Form.userId + "'", connect);
            string Sid = Convert.ToString(getSID.ExecuteScalar());
            txt_SID.Text = Sid;

            SqlCommand getPhoneNo = new SqlCommand("SELECT PHONE_NO_ FROM PHONE_NO_ WHERE USERID = '" + Login_Form.userId + "'", connect);
            string PhoneNo = Convert.ToString(getPhoneNo.ExecuteScalar());
            txt_phone.Text = PhoneNo;


            SqlCommand checkAdmin = new SqlCommand("SELECT ADMIN_FLAG FROM ACCOUNT WHERE USERID = '" + Login_Form.userId + "'", connect);
            bool Admin_check = Convert.ToBoolean(checkAdmin.ExecuteScalar());

            if (Admin_check)
            {
                AccessCode.Show();
                level.Hide();
                SID.Hide();
                txt_accessCode.Show();
                txt_level.Hide();
                txt_SID.Hide();
            }
            else
            {
                AccessCode.Hide();
                level.Show();
                SID.Show();
                txt_accessCode.Hide();
                txt_level.Show();
                txt_SID.Show();
            }

            connect.Close();
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection();
            connect.ConnectionString = "Data Source=NORANPC\\SQLEXPRESS;Initial Catalog=University_Library;Integrated Security=True;TrustServerCertificate=True";
            connect.Open();
            SqlCommand editUser = new SqlCommand("Update ACCOUNT set FNAME = @FNAME, lNAME = @LNAME, USER_NAME = @USER_NAME, PASSWORD = @PASSWORD, EMAIL = @EMAIL, ACCESS_CODE = @ACCESSCODE, LEVEL = @LEVEL, SID = @SID Where USERID = '"+Login_Form.userId+"';", connect);
            SqlCommand editPhoneNo = new SqlCommand("Update TOP(1) PHONE_NO_ set PHONE_NO_ = @PHONENO where USERID = '" + Login_Form.userId + "';", connect);


            //check if username unique
            SqlCommand uniqueUserQuery = new SqlCommand("select USER_NAME from ACCOUNT where USER_NAME = @username AND USERID <> '" + Login_Form.userId + "' ;", connect);
            uniqueUserQuery.Parameters.AddWithValue("@username", txt_username.Text);

            bool isUnique = string.IsNullOrEmpty(Convert.ToString(uniqueUserQuery.ExecuteScalar()));
            if (!isUnique)
            {
                MessageBox.Show("Username already in use");
                return;
            }

            //required feilds
            if (string.IsNullOrEmpty(txt_username.Text) || string.IsNullOrEmpty(txt_password.Text)
                || string.IsNullOrEmpty(txt_fname.Text) || string.IsNullOrEmpty(txt_lname.Text)
                || string.IsNullOrEmpty(txt_email.Text) || string.IsNullOrEmpty(txt_phone.Text))
            {
                MessageBox.Show("Some feilds are not complete!");
                return;
            }

            editUser.Parameters.AddWithValue("@USER_NAME", txt_username.Text);
            editUser.Parameters.AddWithValue("@PASSWORD", txt_password.Text);
            editUser.Parameters.AddWithValue("@FNAME", txt_fname.Text);
            editUser.Parameters.AddWithValue("@LNAME", txt_lname.Text);
            editUser.Parameters.AddWithValue("@EMAIL", txt_email.Text);
            editPhoneNo.Parameters.AddWithValue("@PHONENO", txt_phone.Text);
            

            SqlCommand checkAdmin = new SqlCommand("SELECT ADMIN_FLAG FROM ACCOUNT WHERE USERID = '" + Login_Form.userId + "'", connect);
            bool Admin_check = Convert.ToBoolean(checkAdmin.ExecuteScalar());

            if (Admin_check)
            {
                // check if the Acess code is NULL
                if (string.IsNullOrEmpty(txt_accessCode.Text))
                {
                    MessageBox.Show("Some feilds are not complete!");
                    return;
                }

                // check if the access code is unique
                SqlCommand uniqueAccessCode = new SqlCommand("select ACCESS_CODE from ACCOUNT where ACCESS_CODE = @accessCode AND USERID <> '" + Login_Form.userId + "' ;", connect);
                uniqueAccessCode.Parameters.AddWithValue("@accessCode", txt_accessCode.Text);
                bool isAccessUnique = string.IsNullOrEmpty(Convert.ToString(uniqueAccessCode.ExecuteScalar()));
                if (!isAccessUnique)
                {
                    MessageBox.Show("Access Code already in use");
                    return;
                }
                editUser.Parameters.AddWithValue("@LEVEL", DBNull.Value);
                editUser.Parameters.AddWithValue("@SID", DBNull.Value);
                editUser.Parameters.AddWithValue("@ACCESSCODE", txt_accessCode.Text);
            }
            else
            {
                // check if the SID is NULL
                if (string.IsNullOrEmpty(txt_SID.Text))
                {
                    MessageBox.Show("Some feilds are not complete!");
                    return;
                }


                //check if Studint ID unique
                SqlCommand uniqueSIDQuery = new SqlCommand("select SID from ACCOUNT where SID = @sid AND USERID <> '" + Login_Form.userId + "' ;", connect);
                uniqueSIDQuery.Parameters.AddWithValue("@sid", txt_SID.Text);
                bool isUniqueSID = string.IsNullOrEmpty(Convert.ToString(uniqueSIDQuery.ExecuteScalar()));
                if (!isUniqueSID)
                {
                    MessageBox.Show("Student ID already in use");
                    return;
                }
                if (string.IsNullOrEmpty(txt_level.Text))
                {
                    editUser.Parameters.AddWithValue("@LEVEL", DBNull.Value);
                }
                else
                {
                    editUser.Parameters.AddWithValue("@LEVEL", txt_level.Text);
                }
                editUser.Parameters.AddWithValue("@SID", txt_SID.Text);
                editUser.Parameters.AddWithValue("@ACCESSCODE", DBNull.Value);
            }

            
            editUser.ExecuteNonQuery();
            editPhoneNo.ExecuteNonQuery();
            
            MessageBox.Show("User details Saved.");
            this.Hide();
            SqlCommand checkAdminQuery = new SqlCommand("SELECT ADMIN_FLAG FROM ACCOUNT WHERE USERID = '" + Login_Form.userId + "'", connect);
            bool Admincheck = Convert.ToBoolean(checkAdminQuery.ExecuteScalar());
            if(Admincheck)
            {
                Form adminform = new Admin_Form();
                adminform.Show();
            }
            else
            {
                Form studentform = new Student_Form();
                studentform.Show();
            }
            connect.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection();
            connect.ConnectionString = "Data Source=NORANPC\\SQLEXPRESS;Initial Catalog=University_Library;Integrated Security=True;TrustServerCertificate=True";
            connect.Open();
            SqlCommand checkAdminQuery = new SqlCommand("SELECT ADMIN_FLAG FROM ACCOUNT WHERE USERID = '" + Login_Form.userId + "'", connect);
            bool Admincheck = Convert.ToBoolean(checkAdminQuery.ExecuteScalar());
            if (Admincheck)
            {
                this.Hide();
                Form admnForm = new Admin_Form();
                admnForm.Show();
            }
            else
            {
                this.Hide();
                Form studentForm = new Student_Form();
                studentForm.Show();
            }
   
            
            connect.Close();
        }
    }
}
