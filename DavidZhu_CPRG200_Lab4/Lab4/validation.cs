using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{   /*************************
     * Description:validate datatime fields
     * Date:Jan 9 ,2018
     * Authour:Haishu Zhu
     * Course Code:CPRG200
     **************************/
    public static class validation
    {
      
        //check input is empty 
        public static bool IsDateTime(TextBox tb)//tell if qualitied the datetime format

        {
            DateTime dt;
            if (DateTime.TryParse(tb.Text,out dt))
            {
                return true;//it is datetime format
                
            }
            else
            {
                MessageBox.Show("You are inputing a wrong DateTime Value in " + tb.Tag + "!", "DateTime Error!");
                return false;

            }
            
        }
        //check numerical input value
        public static bool IsDtNull(DateTime? dt)//tell if the filed is empty
        {
            if (dt == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IsLateOrder(DateTime? ordertime, DateTime? shiptime)//tell the shippedDate is earlier than orderDate or later RequiredDate
        {
            if (shiptime > ordertime)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Shipment Date should be later than Order Date!","Date Error!");
                return false;
            }
        }
        public static bool IsEarlyOrder(DateTime? requiretime, DateTime? shiptime)//tell the shippedDate is earlier than orderDate or later RequiredDate
        {
            if (requiretime > shiptime)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Shipment Date should be earlier than Order Date!", "Date Error!");
                return false;
            }
        }
    }
}
