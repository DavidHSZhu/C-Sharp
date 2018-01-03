using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CustomerBill
{
    /* purpose:this class is for reading and writing data to text file 
   * Created by:Haishui Zhu
   * Created on Nov 26,2017
   * 
   * 
   * 
   * ***************/
    public static class CustomerDB
    {
        const string path = "Customers.txt"; // located in bin/Debug
        public static List<Customer> ReadCustomers()//read initial customer recorders from text file
        {
            List<Customer> Customers = new List<Customer>(); // empty list of customer instance
            FileStream fs = null;
            StreamReader sr = null;
            string line; // line is used to get recorder in text file
            string[] parts; // for splitting the line

            try
            {
                // opens the file if exists, otherwise creates empty
                fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);//open or create depends on where customers.txt exits or not
                sr = new StreamReader(fs);//customer recorders sets
                // read data from the file and store in arrays
                while (!sr.EndOfStream) // while there is data in sr
                {
                    line = sr.ReadLine();     //get a specific customer recorder
                    parts = line.Split(','); // split on the commas
                    Customer c = new Customer(); // generate customer instance without any internal properties
                    c.AccountNo=Convert.ToInt32(parts[0]);//set accountno to a customer instance
                    c.CustomerName = parts[1];//set name to a customer instance
                    c.CustomerType = parts[2];//set customer type to a customer instance
                    c.ChargeAmount = Convert.ToDecimal(parts[3]);//set amount of bill to a customer instance
                    c.getCharge();//calcualte the totla charges grouped by customer types
                    c.getTotalCharge();//sum up charges of all customers
                    Customers.Add(c);// add a customer instance into customers collection
                }

            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.GetType().ToString() + ": " + ex.Message, "error ");//when cant open or create text file,show excepation information
            }

            finally
            {
                if (sr != null) sr.Close(); // close the file if opened
            }
            return Customers;
        }

        public static void SaveCustomers(List<Customer> Customers)//save customer recorders from listbox to text file
        {
            FileStream fs;
            StreamWriter sw = null;
            string line;
            try
            {
                // open the file for writing
                fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                sw = new StreamWriter(fs);
                // write data
                foreach (Customer c in Customers)
                {
                    
                    sw.WriteLine(c.ToString());//write  customer instance into txt file
                }
                MessageBox.Show("You have successfuly saved your customer information!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetType().ToString() + ": " + ex.Message, "error ");
            }
            finally
            {
                if (sw != null) sw.Close(); // close the file if opened
            }
        }

    }
}
