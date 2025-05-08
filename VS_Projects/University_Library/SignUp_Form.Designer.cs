namespace University_Library
{
    partial class SignUp_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.fisrtName = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.userType = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.signUp_btn = new System.Windows.Forms.Button();
            this.admin_flag = new System.Windows.Forms.RadioButton();
            this.std_flag = new System.Windows.Forms.RadioButton();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.login_link = new System.Windows.Forms.LinkLabel();
            this.level = new System.Windows.Forms.Label();
            this.txt_lvl = new System.Windows.Forms.TextBox();
            this.txt_SID = new System.Windows.Forms.TextBox();
            this.SID = new System.Windows.Forms.Label();
            this.txt_accessCode = new System.Windows.Forms.TextBox();
            this.access_code = new System.Windows.Forms.Label();
            this.txt_phone2 = new System.Windows.Forms.TextBox();
            this.phone2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(491, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Sign Up";
            // 
            // username
            // 
            this.username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(323, 79);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(87, 20);
            this.username.TabIndex = 29;
            this.username.Text = "Username:";
            // 
            // fisrtName
            // 
            this.fisrtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fisrtName.AutoSize = true;
            this.fisrtName.Location = new System.Drawing.Point(323, 167);
            this.fisrtName.Name = "fisrtName";
            this.fisrtName.Size = new System.Drawing.Size(90, 20);
            this.fisrtName.TabIndex = 30;
            this.fisrtName.Text = "First Name:";
            // 
            // lastName
            // 
            this.lastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lastName.AutoSize = true;
            this.lastName.Location = new System.Drawing.Point(323, 209);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(90, 20);
            this.lastName.TabIndex = 31;
            this.lastName.Text = "Last Name:";
            // 
            // phone
            // 
            this.phone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phone.AutoSize = true;
            this.phone.Location = new System.Drawing.Point(323, 266);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(119, 20);
            this.phone.TabIndex = 32;
            this.phone.Text = "Phone Number:";
            // 
            // email
            // 
            this.email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(323, 331);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(52, 20);
            this.email.TabIndex = 33;
            this.email.Text = "Email:";
            this.email.Click += new System.EventHandler(this.address_Click);
            // 
            // userType
            // 
            this.userType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userType.AutoSize = true;
            this.userType.Location = new System.Drawing.Point(323, 393);
            this.userType.Name = "userType";
            this.userType.Size = new System.Drawing.Size(68, 20);
            this.userType.TabIndex = 34;
            this.userType.Text = "Sign As:";
            // 
            // txt_username
            // 
            this.txt_username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_username.Location = new System.Drawing.Point(638, 73);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(135, 26);
            this.txt_username.TabIndex = 35;
            // 
            // txt_fname
            // 
            this.txt_fname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_fname.Location = new System.Drawing.Point(638, 167);
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(135, 26);
            this.txt_fname.TabIndex = 36;
            // 
            // txt_lname
            // 
            this.txt_lname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_lname.Location = new System.Drawing.Point(638, 209);
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(135, 26);
            this.txt_lname.TabIndex = 37;
            // 
            // txt_phone
            // 
            this.txt_phone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_phone.Location = new System.Drawing.Point(595, 266);
            this.txt_phone.Multiline = true;
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(135, 26);
            this.txt_phone.TabIndex = 38;
            // 
            // txt_email
            // 
            this.txt_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_email.Location = new System.Drawing.Point(638, 325);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(284, 26);
            this.txt_email.TabIndex = 39;
            // 
            // signUp_btn
            // 
            this.signUp_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signUp_btn.Location = new System.Drawing.Point(462, 533);
            this.signUp_btn.Name = "signUp_btn";
            this.signUp_btn.Size = new System.Drawing.Size(110, 48);
            this.signUp_btn.TabIndex = 41;
            this.signUp_btn.Text = "SignUp";
            this.signUp_btn.UseVisualStyleBackColor = true;
            this.signUp_btn.Click += new System.EventHandler(this.signUp_btn_Click);
            // 
            // admin_flag
            // 
            this.admin_flag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.admin_flag.AutoSize = true;
            this.admin_flag.Location = new System.Drawing.Point(595, 393);
            this.admin_flag.Name = "admin_flag";
            this.admin_flag.Size = new System.Drawing.Size(79, 24);
            this.admin_flag.TabIndex = 48;
            this.admin_flag.TabStop = true;
            this.admin_flag.Text = "Admin";
            this.admin_flag.UseVisualStyleBackColor = true;
            this.admin_flag.CheckedChanged += new System.EventHandler(this.admin_flag_CheckedChanged);
            // 
            // std_flag
            // 
            this.std_flag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.std_flag.AutoSize = true;
            this.std_flag.Location = new System.Drawing.Point(734, 391);
            this.std_flag.Name = "std_flag";
            this.std_flag.Size = new System.Drawing.Size(91, 24);
            this.std_flag.TabIndex = 49;
            this.std_flag.TabStop = true;
            this.std_flag.Text = "Student";
            this.std_flag.UseVisualStyleBackColor = true;
            this.std_flag.CheckedChanged += new System.EventHandler(this.std_flag_CheckedChanged);
            // 
            // txt_password
            // 
            this.txt_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_password.Location = new System.Drawing.Point(638, 115);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(135, 26);
            this.txt_password.TabIndex = 51;
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(323, 115);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(82, 20);
            this.password.TabIndex = 50;
            this.password.Text = "Password:";
            // 
            // login_link
            // 
            this.login_link.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login_link.AutoSize = true;
            this.login_link.Location = new System.Drawing.Point(420, 598);
            this.login_link.Name = "login_link";
            this.login_link.Size = new System.Drawing.Size(192, 20);
            this.login_link.TabIndex = 52;
            this.login_link.TabStop = true;
            this.login_link.Text = "Already have an account?";
            this.login_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.login_link_LinkClicked);
            // 
            // level
            // 
            this.level.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.level.AutoSize = true;
            this.level.Location = new System.Drawing.Point(323, 448);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(50, 20);
            this.level.TabIndex = 53;
            this.level.Text = "Level:";
            // 
            // txt_lvl
            // 
            this.txt_lvl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_lvl.Location = new System.Drawing.Point(638, 448);
            this.txt_lvl.Name = "txt_lvl";
            this.txt_lvl.Size = new System.Drawing.Size(135, 26);
            this.txt_lvl.TabIndex = 54;
            // 
            // txt_SID
            // 
            this.txt_SID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_SID.Location = new System.Drawing.Point(638, 503);
            this.txt_SID.Name = "txt_SID";
            this.txt_SID.Size = new System.Drawing.Size(135, 26);
            this.txt_SID.TabIndex = 56;
            // 
            // SID
            // 
            this.SID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SID.AutoSize = true;
            this.SID.Location = new System.Drawing.Point(323, 503);
            this.SID.Name = "SID";
            this.SID.Size = new System.Drawing.Size(91, 20);
            this.SID.TabIndex = 55;
            this.SID.Text = "Student ID:";
            // 
            // txt_accessCode
            // 
            this.txt_accessCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_accessCode.Location = new System.Drawing.Point(638, 471);
            this.txt_accessCode.Name = "txt_accessCode";
            this.txt_accessCode.Size = new System.Drawing.Size(135, 26);
            this.txt_accessCode.TabIndex = 58;
            // 
            // access_code
            // 
            this.access_code.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.access_code.AutoSize = true;
            this.access_code.Location = new System.Drawing.Point(323, 471);
            this.access_code.Name = "access_code";
            this.access_code.Size = new System.Drawing.Size(107, 20);
            this.access_code.TabIndex = 57;
            this.access_code.Text = "Access Code:";
            // 
            // txt_phone2
            // 
            this.txt_phone2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_phone2.Location = new System.Drawing.Point(866, 266);
            this.txt_phone2.Multiline = true;
            this.txt_phone2.Name = "txt_phone2";
            this.txt_phone2.Size = new System.Drawing.Size(135, 26);
            this.txt_phone2.TabIndex = 59;
            // 
            // phone2
            // 
            this.phone2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phone2.AutoSize = true;
            this.phone2.Location = new System.Drawing.Point(741, 269);
            this.phone2.Name = "phone2";
            this.phone2.Size = new System.Drawing.Size(113, 20);
            this.phone2.TabIndex = 60;
            this.phone2.Text = "Other Number:";
            // 
            // SignUp_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 657);
            this.Controls.Add(this.phone2);
            this.Controls.Add(this.txt_phone2);
            this.Controls.Add(this.txt_accessCode);
            this.Controls.Add(this.access_code);
            this.Controls.Add(this.txt_SID);
            this.Controls.Add(this.SID);
            this.Controls.Add(this.txt_lvl);
            this.Controls.Add(this.level);
            this.Controls.Add(this.login_link);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.password);
            this.Controls.Add(this.std_flag);
            this.Controls.Add(this.admin_flag);
            this.Controls.Add(this.signUp_btn);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.txt_lname);
            this.Controls.Add(this.txt_fname);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.userType);
            this.Controls.Add(this.email);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.fisrtName);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.Name = "SignUp_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up Form";
            this.Load += new System.EventHandler(this.SignUp_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label fisrtName;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label userType;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_fname;
        private System.Windows.Forms.TextBox txt_lname;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Button signUp_btn;
        private System.Windows.Forms.RadioButton admin_flag;
        private System.Windows.Forms.RadioButton std_flag;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.LinkLabel login_link;
        private System.Windows.Forms.Label level;
        private System.Windows.Forms.TextBox txt_lvl;
        private System.Windows.Forms.TextBox txt_SID;
        private System.Windows.Forms.Label SID;
        private System.Windows.Forms.TextBox txt_accessCode;
        private System.Windows.Forms.Label access_code;
        private System.Windows.Forms.TextBox txt_phone2;
        private System.Windows.Forms.Label phone2;
    }
}