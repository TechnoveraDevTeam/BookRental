using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace BookrentalTest
{
    public partial class Register : System.Web.UI.Page
    {
        string selectedRole;
        string connectionstring = @"Data Source=DESKTOP-S02SRM9\MSSQLSERVER01;Initial Catalog=UserRegistrationDB;Integrated Security=True;";
        int userid = 0;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
           
            //Trying the dropdownlist 
            if (dropdownRole.SelectedValue == "-1")
            {
                Response.Write("Please select role");
            }
            else
            {
                selectedRole = dropdownRole.SelectedItem.Text;              
            }

            ////Trying something 
            ////Username

            ////Remove session
            //Session.Remove("Username");
            //HttpCookie ckUsername = new HttpCookie("Username");
            //ckUsername.Expires = DateTime.Now.AddDays(-1);
            //Response.Cookies.Add(ckUsername);

            ////Password
            //HttpCookie ckPassword = new HttpCookie("Password");
            //ckPassword.Expires = DateTime.Now.AddDays(-1);
            //Response.Cookies.Add(ckPassword);

            //Response.Redirect("Login.aspx");

            using (SqlConnection sqlCon = new SqlConnection(connectionstring))
            {

                if (validateInputData() == true)
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("UserRegistration", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@UserID", userid);
                    sqlCmd.Parameters.AddWithValue("@FirstName", txtName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@LastName", txtSurname.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Contact", txtContact.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@role", selectedRole);
                    sqlCmd.ExecuteNonQuery();
                    Clear();
                }
            }
        }

        internal void Show()
        {
            throw new NotImplementedException();
        }

        void Clear()
        {
            txtName.Text = txtSurname.Text = txtContact.Text = txtUsername.Text = txtPassword.Text = dropdownRole.Text = "";
        }
     

        //Validate inputed data
        public bool validateInputData()
        {
            //Getting data inputed by the user
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string contact = txtContact.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            bool valid = true;

            //Checking password length
            if (password.Length < 8)
            {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Password must contain atleast 8 digits');</script>");
                    valid = false;
            }

            //Checking password length
            if (password.Length > 12)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Password must contain atleast 12 digits');</script>");
                valid = false;
            }

            //Checking if the password doesnt contain white space
            foreach (char c in password)
            {
                if (Char.IsWhiteSpace(c))
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Password must not conatin space');</script>");
                    valid = false;
                }
            }

            foreach (char c in name)
            {
                if (Char.IsDigit(c))
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Name must not contain digits');</script>");
                    valid = false;
                }
              
            }

            //surname
            foreach (char c in surname)
            {
                if (Char.IsDigit(c))
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Surname must not contain digits');</script>");
                    valid = false;
                }
            }


            //contact detaild
            foreach (char c in contact)
            {
                if (Char.IsLetter(c))
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Contact must not contain letters');</script>");
                    valid = false;
                }

            }

            //Validate conatct length
            if (contact.Length != 10)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Contact must have 10 digits');</script>");
                valid = false;
            }

            if(isPhoneValid(contact) == false)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Enter the correct contact');</script>");
                valid = false;
            }
            return valid;
        }

       //Method for validation the contact details
       public bool isPhoneValid(String phone)
         {
                bool isValid = false;

                String[] validNum = { "076", "071", "082", "083", "073", "072", "081", "079", "061", "062", "060", "063", "074",
                "078", "084", "080", "086", "088", "085", "077", "075", "087", "089" };

                String num = phone.Substring(0, 3);

                for (int x = 0; x < validNum.Length; x++)
                {
                    if (num.Equals(validNum[x]))
                    {
                        isValid = true;
                    }
                }
                return isValid;
        }


    }


}