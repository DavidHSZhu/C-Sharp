using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerBill
{  /* purpose:munipulate charge bills and info of different customers between text file and window form interface 
    * Created by:Haishui Zhu
    * Created on Nov 26,2017
    * 
    * 
    * 
    * ***************/



    public partial class Form1 : Form
    {

        List<Customer> Customers = null;// list is used for storage of instances of customer class
        List<int> AccountNo = new List<int>();// list is used for storage of ACCountNo which has been taken 
        public Form1()
        {
            InitializeComponent();
        }
        //load contorls and load initial customer info getton from Customer.txt file
        private void Form1_Load(object sender, EventArgs e)
        {
            //drop box setting
            cmbCustTye.Items.Add("R");//R-RESIDENTIAL CUSTOMER
            cmbCustTye.Items.Add("C");//C-COMMERCIAL CUSTOMER
            cmbCustTye.Items.Add("I");//I-INDUSTRIAL CUSTOMER
            cmbCustTye.Text = "R"; //set default value of customer dropbox
            //text boxes setting
            txtBill.Enabled = false;//charge textbox only show value
            txtPowerHour.Visible = false;//hide industrial peakhour
            txtPowerOff.Visible = false;//hide industrial offpeak
            txtAccuntNo.Focus(); //initially focus on Account NO textbox
            txtCustNum.Enabled = false;//disable this box for dispaly of customer numbers
            txtResCharge.Enabled = false;//disable this box for dispaly of all residential charges
            txtCommCharge.Enabled = false;//disable this box for dispaly of all commerical charges
            txtIndCharge.Enabled = false;//disable this box for dispaly of all industrial charges
            txtTotalCharge.Enabled = false;//disable this box for dispaly of all  charges
            // label control setting
            lblPowerHours.Visible = false;//hide powerhour lable
            lblPowerOff.Visible = false;//hide poweroff lable
            //read file

            Customers = CustomerDB.ReadCustomers();//call static class-customerDB's READ method to load original customer data in customer.txt file 
            
            //diplay result
            DisplayCustomers();//display existed customer data to listbox

        }
        //display custom info in listbox
        private void DisplayCustomers()
        {
            AccountNo.Clear();//initialize AccountNo list 
            string line;//as each row in listbox
            lstCustomers.Items.Clear(); // start with empty list box
            lstCustomers.Items.Add("Customer AccountNo:\tCustomerName:\tCustomerType\tCustmerCharges:");//create table header of listbox
            // int CustTotalNum;//total number of customer instances
            //decimal CustToalBill;//total bills of all customer instances
            int CustNum = 0;//initialize 
            foreach (Customer c in Customers )//get each instance of customer 
            {
              
               line = String.Format("{0, -19}", c.AccountNo) + "\t\t" + String.Format("{0, -19}", c.CustomerName) + "\t" + String.Format("{0, -19}", c.CustomerType)+ "\t" + String.Format("{0, -19}", c.ChargeAmount.ToString("c"));
               lstCustomers.Items.Add(line);//display each customer instance info
               AccountNo.Add(c.AccountNo);//store used accountno
               CustNum++;
               
            }
          

            txtCustNum.Text = CustNum.ToString();//display total numbers of all customer instances
            txtResCharge.Text =Customer.ResiTotalCharge.ToString("c");//display all residential customer charges
            txtCommCharge.Text = Customer.CommTotalCharge.ToString("c");//display all commercial customer charges
            txtIndCharge.Text = Customer.IndusTotalCharge.ToString("c");//display all industrial customer charges

            txtTotalCharge.Text = Customer.TotalBill.ToString("c");//display all customer's charges 
           
        }
        // for customer charge calculation and add new customer instance to customers.txt and listbox
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //add new record
            decimal Kwh;//for res and commercial customer calculation
            decimal powerpeak, offpeak;//for industrial customer calculation

           // MessageBox.Show(txtAccuntNo.Text);
            bool saveSign = false;//tell wether to savefile or not ,which depends on validation result
            // if-statement for validtion of residential customer
            if (cmbCustTye.Text == "R" && validation.IsPresent(txtAccuntNo, "AccountNo") && validation.IsNegative(txtAccuntNo, "AccountNo") && validation.IsRepAcc(txtAccuntNo, "AccountNo", AccountNo) && validation.IsPresent(txtCustName, "Customer Name") && validation.IsPresent(txtGenPower, "GenralPower") && validation.IsNumerical(txtGenPower, "GenralPower") && validation.IsNegative(txtGenPower, "GenralPower"))
            {
               
                Kwh = Convert.ToDecimal(txtGenPower.Text);//kwh is powper 
                Customer c = new Customer(Kwh);//residential customer need only one parameter-kwh
                
                txtBill.Text = c.residential_bill().ToString("c");//caculation of residential charges
               
                c.AccountNo = Convert.ToInt32(txtAccuntNo.Text);//get  Account Number of customer
                c.CustomerName = txtCustName.Text;//get customer name
                c.CustomerType = cmbCustTye.Text;//get customer type
                c.ChargeAmount = c.residential_bill();//get customer instance bill-only for one instance
                Customers.Add(c);//add customer instance to list
                c.getCharge();//get total charges of all residential instance
                c.getTotalCharge();//get total charges of all instance
                saveSign = true;//validation is ok and customer recorders is modified so need to save all of modification
                txtAccuntNo.Text = "";//reset AccountNo of customer after calculation
                txtCustName.Text = "";//reset name of customer after calculation
                txtGenPower.Text = "";//reset power of customer after calculation

            }
            // if-statement for validtion of commercial customer
            if (cmbCustTye.Text == "C" && validation.IsPresent(txtAccuntNo, "AccountNo") && validation.IsNegative(txtAccuntNo, "AccountNo") && validation.IsRepAcc(txtAccuntNo, "AccountNo", AccountNo) && validation.IsPresent(txtCustName, "Customer Name") && validation.IsPresent(txtGenPower, "GenralPower") && validation.IsNumerical(txtGenPower, "GenralPower") && validation.IsNegative(txtGenPower, "GenralPower"))
            {
                Kwh = Convert.ToDecimal(txtGenPower.Text);//kwh is powper 
                Customer c = new Customer(Kwh);//residential customer need only one parameter-kwh

                txtBill.Text = c.commercial_bill().ToString("c");//caculation of commercial charges
                c.AccountNo = Convert.ToInt32(txtAccuntNo.Text);//get  Account Number of customer
                c.CustomerName = txtCustName.Text;//get customer name
                c.CustomerType = cmbCustTye.Text;//get customer type
                c.ChargeAmount =c.commercial_bill();//get customer instance bill-only for one instance
                Customers.Add(c);//add customer instance to list
                c.getCharge();//get total charges of all commercial instance
                c.getTotalCharge();//get total charges of all instance
                saveSign = true;//validation is ok and customer recorders is modified so need to save all of modification
                txtAccuntNo.Text = "";//reset AccountNo of customer after calculation
                txtCustName.Text = "";//reset name of customer after calculation
                txtGenPower.Text = "";//reset power of customer after calculation
            }
            // if-statement for validtion of industrial customer
            if (cmbCustTye.Text == "I" && validation.IsPresent(txtAccuntNo, "AccountNo") && validation.IsNegative(txtAccuntNo, "AccountNo") && validation.IsRepAcc(txtAccuntNo, "AccountNo", AccountNo) && validation.IsPresent(txtCustName, "Customer Name") && validation.IsPresent(txtPowerHour, "Power Hours") && validation.IsNumerical(txtPowerHour, "Power Hours") && validation.IsNegative(txtPowerHour, "Power Hours") && validation.IsPresent(txtPowerOff, "Power off") && validation.IsNumerical(txtPowerOff, "Power off") && validation.IsNegative(txtPowerOff, "Power off"))
            {
                powerpeak = Convert.ToDecimal(txtPowerHour.Text);//industrial instance needs powerpeak
                offpeak = Convert.ToDecimal(txtPowerOff.Text);//industiral instance needs offpeak

                Customer c = new Customer(powerpeak,offpeak);//initial industrial  instance with 2 parameters in constructors
                txtBill.Text = c.industrial_bill().ToString("c");//caculation of industrial charges
                c.AccountNo = Convert.ToInt32(txtAccuntNo.Text);//get  Account Number of customer
                c.CustomerName = txtCustName.Text;//get customer name
                c.CustomerType = cmbCustTye.Text;//get customer type
                c.ChargeAmount = c.industrial_bill();//get customer instance bill-only for one instance
                Customers.Add(c);//add customer instance to list
                c.getCharge();// get total charges of all industrial instance
                c.getTotalCharge();//get total charges of all instance
                saveSign = true;//validation is ok and customer recorders is modified so need to save all of modification
                txtAccuntNo.Text = "";//reset AccountNo of customer after calculation
                txtCustName.Text = "";//reset name of customer after calculation
                txtPowerHour.Text = "";//reset powerhorusof customer after calculation
                txtPowerOff.Text = "";//reset poweroff hour customer after calculation

            }
            //if validation is ok then set savesign is true
            if (saveSign)
            {
                try
                {
                    CustomerDB.SaveCustomers(Customers);//save all instances of customer
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while saving the customers: " + ex.GetType().ToString() + " - " + ex.Message);//deal with exception
                }
            }
            DisplayCustomers();//refresh listbox and show latest customers
        }
        //different customertype ,different interface 
        private void cmbCustTye_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCustTye.Text == "R") //for residential 
            {
                //text box setting
                txtBill.Text = "";
                txtPowerHour.Text = "";
                txtPowerOff.Text = "";
                txtPowerHour.Visible = false;
                txtPowerOff.Visible = false;
                txtAccuntNo.Text = "";
                txtCustName.Text = "";
                txtGenPower.Text = "";
                txtGenPower.Visible = true;
                txtAccuntNo.Focus();
                //lable setting
                lblGernPower.Visible = true;
                lblPowerHours.Visible = false;
                lblPowerOff.Visible = false;
            }
            else if (cmbCustTye.Text == "C")//for commercial
            {
                //text box setting
                txtBill.Text = "";
                txtPowerHour.Text = "";
                txtPowerOff.Text = "";
                txtPowerHour.Visible = false;
                txtPowerOff.Visible = false;
                txtAccuntNo.Text = "";
                txtCustName.Text = "";
                txtGenPower.Text = "";
                txtGenPower.Visible = true;
                txtAccuntNo.Focus();
                //lable setting
                lblGernPower.Visible = true;
                lblPowerHours.Visible = false;
                lblPowerOff.Visible = false;

            }
            else//for industrial
            {
                //text box setting
                txtBill.Text = "";
                txtPowerHour.Text = "";
                txtPowerOff.Text = "";
                txtPowerHour.Visible = true;
                txtPowerOff.Visible = true;
                txtAccuntNo.Text = "";
                txtCustName.Text = "";
                txtGenPower.Text = "";
                txtGenPower.Visible = false;
                txtAccuntNo.Focus();
                //lable setting
                lblGernPower.Visible = false;
                lblPowerHours.Visible = true;
                lblPowerOff.Visible = true;

            }
        }

        private void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        //delete existing customer recorders
        private void CustomersDelete(int j)
        {
            Customers.Remove(Customers[j]);//deletle the j element in collection of Customers

        }
        //delete customer recorder from listbox
        private void button1_Click(object sender, EventArgs e)
        {
            //tell whether there is customer recorders in listbox or not
            if (lstCustomers.SelectedIndex == -1) //there is no any customer recorder in listbox
            {
                MessageBox.Show("Please select customer recorder!");

            }
            else
            {
              
               string line = ""; //variable line is used to get customer recorder
               int j = 0;
               bool saveSign = false;//save listbox to text file
               for (int v = 0; v < lstCustomers.SelectedItems.Count; v++)//traversal all of selected items  in listbox
                {
                    line = lstCustomers.SelectedItems[v].ToString();//get selected customer recorders
                    if (line.Substring(0, 19) != "Customer AccountNo:")
                    {
                        string[] customerItem = System.Text.RegularExpressions.Regex.Split(line, @"[\t]+");//split line into fields by \t 

                        for (int i = 0; i < Customers.Count; i++)//traversal all instances in Customers
                        {
                            if (Convert.ToString(Customers[i].AccountNo) == customerItem[0].Trim())//find selected instance in Customers
                            {
                                Customers[i].ChargeAmount = (-1) * Customers[i].ChargeAmount;//get customer instance bill and mutiple by negative 1,which will deduct the bill account                                                                                            
                                Customers[i].getCharge();// refresh total charges of all industrial instance
                                Customers[i].getTotalCharge();//refresh total charges of all instance 
                                j = i;
                                saveSign = true;//set sign to rewrite listbox content to text file


                            }

                        }
                    }
                    else//title is selected
                    {
                        MessageBox.Show ("You can not select title of Customers Recorders!");
                    }
                }
                if (saveSign)

                {
                    CustomersDelete(j);//remove instane from Customers

                    try
                    {
                        CustomerDB.SaveCustomers(Customers);//save all instances of customer
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error while saving the customers: " + ex.GetType().ToString() + " - " + ex.Message);//deal with exception
                    }
                }
                DisplayCustomers();//refresh listbox and show latest customers
            }
         }

        private void butExit_Click(object sender, EventArgs e)
        {
            Application.Exit();//EXIT From application

        }
    }
}
