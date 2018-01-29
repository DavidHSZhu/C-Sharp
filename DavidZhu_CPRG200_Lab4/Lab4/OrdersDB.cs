using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
  public static  class OrdersDB//this class is in charge of all data munipulation for Table Order such insert ,update select statement
    { 
        public static Order GetOrder(int orderID)//get one recorder where the orderId is a specific value

        {
            
            Order order = null;//instantiated new object of class Order
            SqlConnection con = NorthWndDB.GetConnection();//get connected to database
            string selectQuery = "select OrderID,CustomerID,OrderDate,RequiredDate,ShippedDate " +
                                "from Orders " +
                                "where OrderID=@orderID";//variable orderID is passed through GetORder method

            SqlCommand selectCommand = new SqlCommand(selectQuery, con);//bulid up command to excute the SELECTE query statement
            selectCommand.Parameters.AddWithValue("@orderID", orderID);// assign value to @orderID in SELECT statement
            try
            {
                con.Open();//open connection
                SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);//only get one row from SELECT query statement
                if (reader.Read())// read the customer if exists                
                {
                    order = new Order();//create new customer object
                    //get the indexID of a specific column in database table,reference from https://stackoverflow.com/questions/19058824/using-column-name-when-using-sqldatareader-isdbnull
                    int OrderDateIndex = reader.GetOrdinal("OrderDate");//get column IndexId of "orderDate"
                    int RequiredDateIndex = reader.GetOrdinal("RequiredDate");//get column IndexId of "RequiredDate"
                    int ShippedDateIndex = reader.GetOrdinal("ShippedDate");//get column IndexId of "ShippedDate"

                    //tell whether the culomun is null or not,especially for datetime? type columns
                    order.OrderID = (int)reader["OrderID"];//(int) doesnt always work normally
                    order.CustomerID= reader["CustomerID"].ToString();//even if customerid is null ,still ok ,string support null value
                    //get column of ORderDate and tell whether it is null or not by internal function_IsNBNull, if yes,set it NULL, IF not ,convert it to DateTime type
                    order.OrderDate = reader.IsDBNull(OrderDateIndex) ? (DateTime?)null : (DateTime?)reader["OrderDate"];
                    //get column of RequiredDate and tell whether it is null or not by internal function_IsNBNull, if yes,set it NULL, IF not ,convert it to DateTime type
                    order.RequiredDate = reader.IsDBNull(RequiredDateIndex) ? (DateTime?)null : Convert.ToDateTime(reader["RequiredDate"].ToString());
                    //get column ofShippedDate and tell whether it is null or not by internal function_IsNBNull, if yes,set it NULL, IF not ,convert it to DateTime type
                    order.ShippedDate = reader.IsDBNull(ShippedDateIndex) ? (DateTime?)null : Convert.ToDateTime(reader["ShippedDate"].ToString());
                }
                else
                {

                    MessageBox.Show("There is no any recorder on OrderID:" + orderID.ToString(), "Data Info");
                }

            }
            catch (SqlException ex)//catch SqlDatabase Exception
            {
                throw ex;
            }
            finally
            {
                con.Close();//close connection
            }
            return order;
            

        }
        //get all OrderID from TABLE ORDER 
        public static List<int> GetAllOrderID()

        {
            List<int> orderIDs = new List<int>();//new list to store all OrderID
            Order order = new Order();
            SqlConnection con = NorthWndDB.GetConnection();//connect to database
            string selectQuery = "select OrderID " +
                                "from Orders " +
                                "order by OrderID Asc";

            SqlCommand selectCommand = new SqlCommand(selectQuery, con);
           
            try
            {
                con.Open();//open connection
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())// read all rows if exists                
                {
                    order = new Order();//create new customer object
                    order.OrderID = (int)reader["OrderID"];//(int) doesnt always work normally
                    orderIDs.Add(order.OrderID);//add object of Order class into List
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
            return orderIDs;
        }

        //update the field of "shippedDate"
        public static bool UpdateOrder(Order oldOrder, Order newOrder)
        {
            bool successful = false;
            SqlConnection connection = NorthWndDB.GetConnection();//connect to database

            //define update query command
            string updateString = "update Orders set " +
                                  "ShippedDate = @NewShippedDate " +
                                  "where " + // update succeeds only if record not changed by other users
                                  "CustomerID = @OldCustomerID and " +//make sure the customerID still equals to old value when you excute update operation
                                  "OrderDate = @OldOrderDate and " +//make sure the OrderDate still equals to old value when you excute update operation
                                  "RequiredDate = @OldRequiredDate and " +//make sure the requireddate still equals to old value when you excute update operation
                                  "(ShippedDate  = @OldShippedDate or " +//current ShippedDate equals to old value in case someone has updated it before you

                                  "ShippedDate IS NULL and @OldShippedDate IS NULL)";//this is very important and from jolanta,even if column shippeddate is null and outside variable @OldshippedDate is null.they are not equal in SQL expression
            SqlCommand updateCommand = new SqlCommand(updateString, connection);
            updateCommand.Parameters.AddWithValue("@OldCustomerID", oldOrder.CustomerID);
            updateCommand.Parameters.AddWithValue("@OldOrderDate", oldOrder.OrderDate);
            updateCommand.Parameters.AddWithValue("@OldRequiredDate", oldOrder.RequiredDate);
            if (oldOrder.ShippedDate != null)//not null
            {
                updateCommand.Parameters.AddWithValue("@OldShippedDate", oldOrder.ShippedDate);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldShippedDate", DBNull.Value);//when datetime type is null then set the value is DBNull.value
            }
            if (newOrder.ShippedDate != null)//not null
            {
                updateCommand.Parameters.AddWithValue("@NewShippedDate", newOrder.ShippedDate);//when datetime type is null then set the value is DBNull.value
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewShippedDate", DBNull.Value);
            }

            try
            {
                connection.Open();
                int count = updateCommand.ExecuteNonQuery();
                if (count == 1) successful = true;//updated a order from database successfully

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return successful;
        }
    }
}
