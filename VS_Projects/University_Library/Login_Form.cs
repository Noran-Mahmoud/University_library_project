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
    public partial class Login_Form : Form
    {
        public static int userId;
        public Login_Form()
        {
            InitializeComponent();
        }

        private void signUp_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form signUp = new SignUp_Form();
            signUp.Show();
            this.Hide();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {

            string connectionString = "Data Source=NORANPC\\SQLEXPRESS;Initial Catalog=University_Library;Integrated Security=True;TrustServerCertificate=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = "SELECT * FROM ACCOUNT WHERE USER_NAME = @username AND PASSWORD = @password";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@username", txt_username.Text);
                    cmd.Parameters.AddWithValue("@password", txt_password.Text);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    if (ds.Tables[0].Rows.Count != 0 )
                    {                       
                        SqlCommand getuserId = new SqlCommand("select USERID from ACCOUNT where USER_NAME = @username", con);
                        getuserId.Parameters.AddWithValue("@username", txt_username.Text);
                        userId = Convert.ToInt32(getuserId.ExecuteScalar());
                        SqlCommand getadminflag = new SqlCommand("select ADMIN_FLAG from ACCOUNT where USERID = @userid", con);
                        getadminflag.Parameters.AddWithValue("@userid", userId);
                        bool admin_flag = Convert.ToBoolean(getadminflag.ExecuteScalar());
                        if (!admin_flag)
                        {
                            this.Hide();
                            Form studentForm = new Student_Form();
                            studentForm.Show();
                        }
                        else
                        {
                            this.Hide();
                            Form admnForm = new Admin_Form();
                            admnForm.Show();
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Wrong USERNAME or PASSWORD", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }



        private void txt_password_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
