using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace BookrentalTest
{
    public partial class RentYourBook : System.Web.UI.Page
    {

        Image file;
        String sqlCon = @"Data Source=DESKTOP-545QOH3;Initial Catalog=BookRental;Integrated Security=True";
        int authorId = 0;
        int bookId = 0;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCo = new SqlConnection(sqlCon))
            {
                sqlCo.Open();
                SqlCommand sqlCmd = new SqlCommand("Insert into Author (author_name,author_surname) values (@author_name ,@author_surname)", sqlCo);

                sqlCmd.Parameters.AddWithValue("@author_id", authorId);
                sqlCmd.Parameters.AddWithValue("@author_name", TextBox1.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@author_surname", TextBox2.Text.Trim());
                sqlCmd.ExecuteNonQuery();

                SqlCommand sqlCmdA = new SqlCommand("Insert into Book (book_title,book_isbn,author_id) values (@book_title ,@book_isbn,@author_id)", sqlCo);

                sqlCmdA.Parameters.AddWithValue("@book_id", bookId);
                sqlCmdA.Parameters.AddWithValue("@book_title", TextBox3.Text.Trim());
                sqlCmdA.Parameters.AddWithValue("@book_isbn", TextBox4.Text.Trim());
                 sqlCmd.Parameters.AddWithValue("@author_id", authorId);
                sqlCmdA.ExecuteNonQuery();
                //MessageBox.Show("Registration is successful");



            }
        }
    }
}