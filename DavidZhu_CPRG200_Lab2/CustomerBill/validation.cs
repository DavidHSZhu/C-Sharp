using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CustomerBill
{   /* purpose:this class is for data validation
    * Created by:Haishui Zhu
    * Created on Nov 26,2017
    * 
    * 
    * 
    * ***************/
    public static class validation
    {
        
        //check input is empty 
        public static bool IsPresent(TextBox tb,string txtName)

        {
            bool valid = true;
            if (tb.Text == "")
            {

                MessageBox.Show(txtName + " is required!");
                valid = false;
                tb.Focus();
            }

            return valid;
        }
        //check numerical input value
        public static bool IsNumerical(TextBox tb, string txtName)
        {
            bool valid = true;
            decimal vaule;
            if (!Decimal.TryParse(tb.Text,out vaule))
            {
                MessageBox.Show(txtName + " must be a numerical value");
                valid = false;
                tb.Focus();
            }
            return valid;
        }
        // check non negative input value
        public static bool IsNegative(TextBox tb, string txtName)
        {
            bool valid = true;
            decimal value;

            if (!Decimal.TryParse(tb.Text, out value))//
            {
                valid = false;
                MessageBox.Show(txtName + " must be a numerical value");


            }
            else if (value < 0)
            {
                
                MessageBox.Show(txtName + " must be non negative numerical value");
                valid = false;
                tb.Focus();
            }
            return valid;

          
        }
        //identify the account number is duplicated or not
        public static bool IsRepAcc(TextBox tb, string txtName, List<int> list1)
        {
          
            bool valid = true;
            if (list1.Count!=0)//tell whether there are some accountno in list1 or not
            {
               
                foreach (int p in list1)
                {
                    if (p.ToString() == tb.Text)//if in AccountNo has been used 
                    {
                        
                        MessageBox.Show(txtName +":"+p.ToString()+ " has been used!It should be an unique number!");
                        valid = false;
                    }
                }
                
            }
            return valid;
        } 
    }
}
