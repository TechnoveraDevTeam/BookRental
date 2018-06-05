using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookrentalTest
{
    public partial class RentBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Btn_addToCart_Click(object sender, EventArgs e)
        {
           


            int bookId = 1; // this value mus be from the selected book ( Static bookId)
            decimal bookprice; // this value get it from book table
            decimal totalPrice;
            DateTime startDate;
            DateTime endDate;
            string location;
            string userId;

            // Drp_LocationList.SelectedItem.Selected;

            // create command
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-89T6LHC;Initial Catalog=BookRental;Integrated Security=True");
            con.Open();

            SqlCommand sqlCommand = new SqlCommand(" SELECT [book_id], [book_price] FROM [BookRental].[dbo].[Book] ");
            //sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Connection = con;

            //READ FROM DATABASE
            SqlDataReader reader = null;
            reader = sqlCommand.ExecuteReader();

            while (reader.Read())
            {
                string strBookId = reader["book_id"].ToString();
                string strBookPrice = reader["book_price"].ToString();

            }
            con.Close();

        }
    } 
}