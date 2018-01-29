using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Order//this class is corresponding to table ORDER,to store the data structure of this table
    {
        public Order()//constructor 
        { }
        public int OrderID { get; set; }//OrderId is primary key,not null
        public string  CustomerID { get; set; }//CustomerID is nullable field
        public DateTime? OrderDate { get; set; }//OrderDate is type of datetime but should be nullable
        public DateTime? RequiredDate { get; set; }//RequiredDate is type of datetime but should be nullable
        public DateTime? ShippedDate { get; set; }//ShippedDate is type of datetime but should be nullable
    }
}
