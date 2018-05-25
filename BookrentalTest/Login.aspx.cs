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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
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
               /// Properties.Settings.Default.username = txtUsername.Text;
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

    }
}