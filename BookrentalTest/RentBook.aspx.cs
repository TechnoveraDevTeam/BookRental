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
        public static double dayprices = 0;
        public static int bookID;
        public static int orderTerm;

        protected void Page_Load(object sender, EventArgs e)
        {

            //chk7Days.Checked = true;
            //chk14Days.Checked = false;
            //chk21Days.Checked = false;

            if (!IsPostBack)
            {

               // chk7Days.Focus();

                SqlConnection con = new SqlConnection("Data Source=DESKTOP-89T6LHC;Initial Catalog=BookRental;Integrated Security=True");
                con.Open();

                SqlDataReader reader = null;

                string selectQuery = " SELECT [book_id], [title], [author_name], [publisher_name],[publisher_year], [ISBN] FROM[BookRental].[dbo].[Books] where[book_id] = '1' ";
                SqlCommand com = new SqlCommand(selectQuery, con);

                reader = com.ExecuteReader();

                if (reader.Read())
                {
                    //int myInt = int.Parse(TextBoxD1.Text);
                    bookID = int.Parse(reader["book_id"].ToString());
                    lbl_bookTitle.Text = reader["title"].ToString();
                    lbl_author.Text = reader["author_name"].ToString();
                    lbl_publisher.Text = reader["publisher_name"].ToString();
                    lbl_publicationDate.Text = reader["publisher_year"].ToString();
                    lbl_isbn.Text = reader["ISBN"].ToString();
                    lbl_status.Text = "Available";

                }


                con.Close();

            }

        }

        protected void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Btn_addToCart_Click(object sender, EventArgs e)
        {
           


            //int bookId = 1; // this value mus be from the selected book ( Static bookId)
            //decimal bookprice7 = 5; // this value get it from book table
            //decimal bookprice14 = 5;
            //decimal bookprice21 = 5;
            //decimal totalPrice = 20;
            DateTime startDate;
            DateTime endDate;
            string location;

            
            int userId = 1;

            /*********************************************************************************/
            // order id will be generetated.
            DateTime orderDate = DateTime.Today;
            int orderquantity = 1;
            int orderTerm = 7; //   enddate - startdate. The timeframe from collection to return date 
            decimal orderPrice= Convert.ToDecimal(dayprices);
           
            // user id 

            // create command
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-89T6LHC;Initial Catalog=BookRental;Integrated Security=True");
            
            con.Open();

           // string selectQuery = " SELECT [book_id], [price] FROM [BookRental].[dbo].[Books] ";
            SqlCommand com = new SqlCommand("spInsertOrder", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@order_date", orderDate);
            com.Parameters.AddWithValue("@order_quantity", orderquantity);
            com.Parameters.AddWithValue("@order_terms", orderTerm);
            com.Parameters.AddWithValue("@order_price", orderPrice);
            com.Parameters.AddWithValue("@book_id", bookID);
            com.Parameters.AddWithValue("@user_id", userId);
           // con.Open();

            //sqlCommand.CommandType = CommandType.Text;
            //sqlCommand.Connection = con;

            //READ FROM DATABASE
            SqlDataReader reader = com.ExecuteReader();
           
           
           //if (reader.Read())
           //{
           //         string strBookId = reader["book_id"].ToString();
           //         string strBookPrice = reader["price"].ToString();

           //}
            
   
            con.Close();

        }

        protected void Drp_LocationList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void day7_CheckedChanged(object sender, EventArgs e)
        {

            double day7Price = 25.00;
            dayprices = day7Price;
            orderTerm = 7;

            lbl_totalPrice.Text = "25.00";

        }

        protected void day14_CheckedChanged(object sender, EventArgs e)
        {
            double day14Price = 45.00;
            dayprices = day14Price;
            orderTerm = 14;
            lbl_totalPrice.Text = "45.00";
        }

        protected void day21_CheckedChanged(object sender, EventArgs e)
        {
            double day21Price = 65.00;
            dayprices = day21Price;
            orderTerm = 21;
            lbl_totalPrice.Text = " 65.00";
        }

        protected void dayCustom_CheckedChanged(object sender, EventArgs e)
        {
            orderTerm = Convert.ToInt32((DateTime.Today - DateTime.Today).TotalDays);
            lbl_totalPrice.Text = " 50.00";
        }
    }
}


/*

/this is the button you click to get the calendar
       protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
{
    if (Calendar1.Visible)
    {
        Calendar1.Visible = false;
    }
    else
    {
        Calendar1.Visible = true;
    }

}
//this is the selected Date then passed on the textbox
protected void Calendar1_SelectionChanged(object sender, EventArgs e)
{
    pDate.Text = Calendar1.SelectedDate.ToShortDateString();
    Calendar1.Visible = false;
}
protected void Page_Load(object sender, EventArgs e)
{
    //this is to make the calander invisible till calandar clicked
    if (!IsPostBack)
    {
        Calendar1.Visible = false;
    }
}