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
        string connectionstring = @"Data Source=DESKTOP-S02SRM9\MSSQLSERVER01;Initial Catalog=UserRegistrationDB;Integrated Security=True;";
        int userid = 0;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionstring))
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
                sqlCmd.Parameters.AddWithValue("@role", txtRole.Text.Trim());
                sqlCmd.ExecuteNonQuery();
                ///Response.Write("<script>alert('Registration is successful');</script>");
                /// MessageBox.Show("Registration is successful");
                Clear();
            }
        }

        internal void Show()
        {
            throw new NotImplementedException();
        }

        void Clear()
        {
            txtName.Text = txtSurname.Text = txtContact.Text = txtUsername.Text = txtPassword.Text = txtRole.Text = "";
        }

    }
}