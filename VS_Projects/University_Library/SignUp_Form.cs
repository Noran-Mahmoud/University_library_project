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
using University_Library.University_LibraryDataSetTableAdapters;

namespace University_Library
{
    public partial class SignUp_Form : Form
    {
        public SignUp_Form()
        {
            InitializeComponent();
        }

        private void SignUp_Form_Load(object sender, EventArgs e)
        {
            level.Hide();
            txt_lvl.Hide();
            access_code.Hide();
            txt_accessCode.Hide();
            SID.Hide();
            txt_SID.Hide();
        }


        private void address_Click(object sender, EventArgs e)
        {

        }

        private void login_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form login = new Login_Form();
            login.Show();
            this.Hide();
        }

        private void admin_flag_CheckedChanged(object sender, EventArgs e)
        {
            access_code.Show();
            txt_accessCode.Show();
            level.Hide();
            txt_lvl.Hide();
            SID.Hide();
            txt_SID.Hide();
        }

        private void signUp_btn_Click(object sender, EventArgs e)
        {
            bool admin_check = admin_flag.Checked;
            bool std_check = std_flag.Checked;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=NORANPC\\SQLEXPRESS;Initial Catalog=University_Library;Integrated Security=True;TrustServerCertificate=True";
            con.Open();

            SqlCommand addUser = new SqlCommand("insert into ACCOUNT (USER_NAME, PASSWORD, FNAME, LNAME, EMAIL, ADMIN_FLAG,LEVEL, SID, ACCESS_CODE) " +
                "Values(@USER_NAME, @PASSWORD, @FNAME, @LNAME, @EMAIL, @ADMIN_FLAG, @LEVEL, @SID, @ACCESS_CODE);", con);


            //check if username unique
            SqlCommand uniqueUserQuery = new SqlCommand("select USER_NAME from ACCOUNT where USER_NAME = @USER_NAME", con);
            uniqueUserQuery.Parameters.AddWithValue("@User_NAME", txt_username.Text);
            bool isUnique = string.IsNullOrEmpty(Convert.ToString(uniqueUserQuery.ExecuteScalar()));
            if (!isUnique)
            {
                MessageBox.Show("Username already in use");
                return;
            }

            //required feilds
            if(string.IsNullOrEmpty(txt_username.Text) || string.IsNullOrEmpty(txt_password.Text) 
                || string.IsNullOrEmpty(txt_fname.Text) || string.IsNullOrEmpty(txt_lname.Text) 
                || string.IsNullOrEmpty(txt_email.Text) || string.IsNullOrEmpty(txt_phone.Text) && (admin_check || std_check))
            {
                MessageBox.Show("Some feilds are not complete!");
                return;
            }


            addUser.Parameters.AddWithValue("@USER_NAME", txt_username.Text);
            addUser.Parameters.AddWithValue("@PASSWORD", txt_password.Text);
            addUser.Parameters.AddWithValue("@FNAME", txt_fname.Text);
            addUser.Parameters.AddWithValue("@LNAME", txt_lname.Text);
            addUser.Parameters.AddWithValue("@EMAIL", txt_email.Text);
            addUser.Parameters.AddWithValue("@ADMIN_FLAG", admin_check);
            if (admin_check)
            {
                if (string.IsNullOrEmpty(txt_accessCode.Text))
                {
                    MessageBox.Show("Some feilds are not complete!");
                    return;
                }

                //check if Access Code unique
                SqlCommand uniqueACQuery = new SqlCommand("select ACCESS_CODE from ACCOUNT where ACCESS_CODE = @ACCESS_CODE", con);
                uniqueACQuery.Parameters.AddWithValue("@ACCESS_CODE", txt_accessCode.Text);
                bool isUniqueAC = string.IsNullOrEmpty(Convert.ToString(uniqueACQuery.ExecuteScalar()));
                if (!isUniqueAC)
                {
                    MessageBox.Show("Access Code already in use");
                    return;
                }

                addUser.Parameters.AddWithValue("@ACCESS_CODE", txt_accessCode.Text);
                addUser.Parameters.AddWithValue("@LEVEL", DBNull.Value);
                addUser.Parameters.AddWithValue("@SID", DBNull.Value);
            }
            else{
                if (string.IsNullOrEmpty(txt_SID.Text))
                {
                    MessageBox.Show("Some feilds are not complete!");
                    return;
                }

                //check if Studint ID unique
                SqlCommand uniqueSIDQuery = new SqlCommand("select SID from ACCOUNT where SID = @SID", con);
                uniqueSIDQuery.Parameters.AddWithValue("@SID", txt_SID.Text);
                bool isUniqueSID = string.IsNullOrEmpty(Convert.ToString(uniqueSIDQuery.ExecuteScalar()));
                if (!isUniqueSID)
                {
                    MessageBox.Show("Student ID already in use");
                    return;
                }

                //assign null to level
                if (string.IsNullOrEmpty(txt_lvl.Text)) {
                    addUser.Parameters.AddWithValue("@LEVEL", DBNull.Value);
                }
                else{
                    addUser.Parameters.AddWithValue("@LEVEL", txt_lvl.Text);
                }
                addUser.Parameters.AddWithValue("@SID", txt_SID.Text);
                addUser.Parameters.AddWithValue("@ACCESS_CODE", DBNull.Value);
            }

            addUser.ExecuteNonQuery();
            SqlCommand getUserID = new SqlCommand("select USERID from ACCOUNT where USER_NAME = '"+txt_username.Text+"';", con);
            int str = Convert.ToInt32(getUserID.ExecuteScalar());
            SqlCommand phoneQuery = new SqlCommand("insert into PHONE_NO_ Values(@PHONE_NO_, "+str+");", con);

            phoneQuery.Parameters.AddWithValue("@PHONE_NO_", txt_phone.Text);

            getUserID.ExecuteNonQuery();
            phoneQuery.ExecuteNonQuery();

            if (!string.IsNullOrEmpty(txt_phone2.Text)){
                SqlCommand phoneQuery2 = new SqlCommand("insert into PHONE_NO_ Values(@PHONE_NO, " + str + ");", con);
                phoneQuery2.Parameters.AddWithValue("@PHONE_NO", txt_phone2.Text);
                phoneQuery2.ExecuteNonQuery();
            }

            con.Close();
            Form login = new Login_Form();
            login.Show();
            this.Hide();
        }

        private void std_flag_CheckedChanged(object sender, EventArgs e)
        {
            access_code.Hide();
            txt_accessCode.Hide();
            level.Show();
            txt_lvl.Show();
            SID.Show();
            txt_SID.Show();
        }

    }
}
