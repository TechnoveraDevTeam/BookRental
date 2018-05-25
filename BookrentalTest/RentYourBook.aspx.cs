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
                SqlCommand sqlCmd = new SqlCommand("Insert into Books (author_name,author_surname) values (@author_name ,@author_surname)", sqlCo);

                
               
                 sqlCmd.Parameters.AddWithValue("@book_id", bookId);
                sqlCmd.Parameters.AddWithValue("@title", title.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@ISBN", isbn.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@category", isbn.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@author_name", aName.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@publisher_name", pName.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@publisher_year", pDate.Text.Trim());
            

                sqlCmd.ExecuteNonQuery();
                //MessageBox.Show("Registration is successful");



            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {

            }
            else { 
}
               
        }
    }
}