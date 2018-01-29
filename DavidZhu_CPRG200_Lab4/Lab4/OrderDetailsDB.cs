using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public static class OrderDetailsDB
    {
        
        public static List<OrderDetail> GetRelativeDetails(int orderID)
        {
            List<OrderDetail> orderDetails = new List<OrderDetail>();
            SqlConnection con = NorthWndDB.GetConnection();
            string selectQuery = "select OrderID,ProductID,UnitPrice,Quantity,Discount " +
                                "from [Order Details] "+
                                "where OrderID =@orderID";

            SqlCommand selectCommand = new SqlCommand(selectQuery, con);
            selectCommand.Parameters.AddWithValue("@orderID", orderID);
            try
            {
                con.Open();//open connection
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())// read the customer if exists                
                {
                    OrderDetail od1 = new OrderDetail();//create new
                    //
                    od1.OrderID =Convert.ToInt32(reader["OrderID"]);
                    od1.ProductID = Convert.ToInt32(reader["ProductID"]);
                    od1.UnitPrice = Convert.ToDecimal(reader["UnitPrice"]);
                    od1.Quantity = Convert.ToInt32(reader["Quantity"]);
                    od1.Discount = Convert.ToDecimal(reader["Discount"]);
                    orderDetails.Add(od1);
                }
                

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();//close connection
            }

            return orderDetails;
        }
        public static decimal GetTotalCharge(int orderID)//get totalcharge for a specific OrderID
        {
            SqlConnection con = NorthWndDB.GetConnection();
            string totalQuery = "select sum(UnitPrice*(1-discount)*Quantity) as totalCharge " +//apply SUM function in SQL Query
                                "from [Order Details] " +
                                "where orderID=@orderid";
            
            SqlCommand selectCommand = new SqlCommand(totalQuery, con);
            selectCommand.Parameters.AddWithValue("@orderid", orderID);
            try
            {
                con.Open();
                SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read())
                {
                    return Convert.ToDecimal(reader["totalCharge"]);//if there are recorders for this orderID
                }
                else
                {
                    return 0;//if ther is no ORDID then return 0
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }

        }
    }
}
