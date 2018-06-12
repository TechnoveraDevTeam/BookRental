using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using BookrentalTest.Entity;
using BookrentalTest.AccountDAO;

namespace BookrentalTest
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //Just added to test the remember me function 04-06-2018
            //if(!Page.IsPostBack)
            //{
            //    Account account = checkCookies();
            //    if(account != null)
            //    {
            //        UserDao dao = new UserDao();
            //        if(dao.login(account.Username, account.Password))
            //        {
            //            Session["Username"] = account.Username;
            //            //Response.Redirect("Register.aspx");
            //        }
            //        else
            //            Response.Write("<script>alert('Invalid account');</script>");
           
            //    }
            //}
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {

            //// Just added 04-06-2018 Another version to login
            //UserDao userdao = new UserDao();
            //if(userdao.login(this.txtLogUsername.Text, this.txtLogPassword.Text))
            //{
            //    Session["username"] = this.txtLogUsername.Text;
            //    if(this.ckRemember.Checked)
            //    {

            //        //Username
            //        HttpCookie ckUsername = new HttpCookie("Username");
            //        ckUsername.Value = this.txtLogUsername.Text;
            //        ckUsername.Expires.AddDays(1);
            //        Response.Cookies.Add(ckUsername);


            //        //Password
            //        HttpCookie ckPassword = new HttpCookie("Password");
            //        ckPassword.Value = this.txtLogPassword.Text;
            //        ckPassword.Expires.AddDays(1);
            //        Response.Cookies.Add(ckPassword);
            //    }
            //    Response.Redirect("Register.aspx");
            //}
            //else
            //{
            //    Response.Write("<script>alert('Invalid account');</script>");
            //}


            SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-S02SRM9\MSSQLSERVER01;Initial Catalog=UserRegistrationDB;Integrated Security=True");
            string query = "select * from tblUser Where Username = '" + txtLogUsername.Text.Trim() + "' and password = '" + txtLogPassword.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlCon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if (dtbl.Rows.Count == 1)
            {
                Response.Write("<script>alert('Successfully login');</script>");
                /// Register register = new Register();
                ///this.Hide();
                ///register.Show();
            }
            else
            {
                Response.Write("<script>alert('Check your username or password');</script>");
                ///MessageBox.Show("Check your username or password");
            }
        }

        ///Trying Remember me function
        private void Init_Data()
        {
            if (Properties.Settings.Default.username != string.Empty)
            {
                if (Properties.Settings.Default.remember == "yes")
                {
                    txtUsername.Text = Properties.Settings.Default.username;
                    txtPassword.Text = Properties.Settings.Default.password;
                    ckRemember.Checked = true;
                }
                else
                {
                    txtUsername.Text = Properties.Settings.Default.username;
                }
            }
        }

        private void Save_Data()
        {
            if (ckRemember.Checked)
            {
                ///Properties.Settings.Default.username = txtUsername.Text;
                ///Properties.Settings.Default.password = txtPassword.Text;
                ///Properties.Settings.Default.remember = "yes";
                ///Properties.Settings.Default.Save();
            }
            else
            {
                ///Properties.Settings.Default.username = txtUsername.Text;
                ///Properties.Settings.Default.password = "";
                /// Properties.Settings.Default.remember = "no";
                ///Properties.Settings.Default.Save();
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }


        //public Account checkCookies()
        //{
        //    Account account = null;
        //    string username = string.Empty, password = string.Empty;
        //    if(Request.Cookies["username"] != null)

        //        username = Request.Cookies["username"].Value;

        //    if (Request.Cookies["password"] != null)
        //        password = Request.Cookies["password"].Value;

        //    if(!String.IsNullOrEmpty(username) && !String.IsNullOrEmpty(username))
        //        account = new Account { Username = username, Password = password };
        //    return account;

        //}

    }
}