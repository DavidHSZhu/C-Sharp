using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBill
{
    /* purpose:set customer's fields and method to perform charge calucation 
   * Created by:Haishui Zhu
   * Created on Dec 01,2017
   * 
   * 
   * 
   * ***************/
    public class Customer
    {
        // define CONST for CALCULATION for 3 TYPES of  CUSTOMER
        private const decimal RESIDENTIAL_BASEPRICE = 6.0m;//BASE price OF residential
        private const decimal RESIDENTIAL_RATE = 0.052m; // rate of residential
        private const decimal COMMERCIAL_BASEPRICE = 60m;//base price of commericial
        private const decimal COMMERCIAL_RATE = 0.045m;//rate of commercial
        private const decimal INDUSTRIAL_PEAKPRICE = 76m;//base price of industrial in peak hours
        private const decimal INDUSTRIAL_PEAKRATE = 0.065m;//rate of industrail in peak hours
        private const decimal INDUSTRIAL_OFFPRICE = 40m;// base price of industiral off peak hours
        private const decimal INDUSTRIAL_OFFRATE = 0.028m;//rate of industrail off peak hours
        //define three parameter KWH for 3 customers
        private decimal GeneralPower;//kwh for residential and commercial
        private decimal PeakPower;//kwh for industrial
        private decimal OffPower;//kwh for industrial
        // public static int TotalCust;//store all of customer number when each istance is generated;
        public static decimal TotalBill;//store all of customer bill
        public static decimal ResiTotalCharge; //store residential charge
        public static decimal CommTotalCharge;//store commerical charge
        public static decimal IndusTotalCharge;//store industrial charge
        // public properties which have communication with outside of class so use get and set
        public int AccountNo { get; set; }
        public string CustomerName { get; set; }
        public string CustomerType { get; set; }
        public decimal ChargeAmount { get; set; }
        //public parameters for each customer
        public Customer()
        { }
        //overload constructor for residential and commercial
        public Customer(decimal Kwh)
        {
            GeneralPower = Kwh;


        }
        //overload constructor for industrial 
        public Customer(decimal powerpeak, decimal offpeak)
        {
            PeakPower = powerpeak;//set peakpower
            OffPower = offpeak;//set offpeak power

        }

        // to calcualte charge for residentical customers
        public decimal residential_bill()
        {
            decimal totalbill;
            totalbill = RESIDENTIAL_BASEPRICE + GeneralPower * RESIDENTIAL_RATE;//residential bill is equal to baseprice plus acutal charges
            return totalbill;

        }
        //function for calculation of commercial bill which is divided 2 sections 
        public decimal commercial_bill()
        {
            decimal totalbill;
            if (GeneralPower <= 1000m)   //when total power is less than 1000kwh
            {
                totalbill = COMMERCIAL_BASEPRICE; // total commercial bill is equal to baseprice
            }
            else
            {
                totalbill = COMMERCIAL_BASEPRICE + (GeneralPower - 1000m) * COMMERCIAL_RATE;//when total power i greater than 1000kwh,base price plus overflow section
            }
            return totalbill;

        }
        //function for calculation of commercial bill
        public decimal industrial_bill()
        {
            decimal peakbill, offbill;//calculate peakpower charges
            if (PeakPower <= 1000m)
            {
                peakbill = INDUSTRIAL_PEAKPRICE;//when peakpower is less than 1000 kwh
            }
            else
            {
                peakbill = INDUSTRIAL_PEAKPRICE + (PeakPower - 1000m) * INDUSTRIAL_PEAKRATE;//when peakpower is greater than 1000wkh
            }

            if (OffPower <= 1000m)//calculate offpower charges
            {
                offbill = INDUSTRIAL_OFFPRICE;//when offpower is less than 1000 kwh
            }
            else
            {
                offbill = INDUSTRIAL_OFFPRICE + (OffPower - 1000m) * INDUSTRIAL_OFFRATE;//when offpower is greater than 1000wkh
            }

            return peakbill + offbill;

        }

        public decimal getCharge()//get total charges grouped by customer type
        {   
            decimal charge=0m;
            if (CustomerType == "R")
            {
                ResiTotalCharge += ChargeAmount;//sum up residential charges
                
                charge = ResiTotalCharge;
            }
            if (CustomerType == "C")
            {
                CommTotalCharge += ChargeAmount;//sum up commercial charges
                charge = CommTotalCharge;
            }
            if (CustomerType == "I")
            {
                IndusTotalCharge += ChargeAmount;//sum up industrial charges
                charge = IndusTotalCharge;
            }
            return charge;
        }
        public decimal getTotalCharge()

        {
            TotalBill += ChargeAmount;//sum up charges of all customers
            return TotalBill;
        }
        public override string ToString() // overrides system method for CustormerDB->savecustomers()
        {
            return AccountNo.ToString() + ","+CustomerName + ","+CustomerType + ","+ChargeAmount.ToString();
        }

    }
}
