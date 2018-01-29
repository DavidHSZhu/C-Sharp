using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class frmOrderMaintenance : Form
    /*************************
* Description:how to display order info and sum the total charges from orderdetails
* Date:Jan 9 ,2018
* Authour:Haishu Zhu
* Course Code:CPRG200
**************************/
    {
        public List<int> orderIDs = new List<int>();
        public Order order1;
        public frmOrderMaintenance()
        {
            InitializeComponent();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {   
          

        }

        private void OrderMaintenance_Load(object sender, EventArgs e)
        {   //initialize the text box
            txtCustomerID.Enabled = false;
            txtOrderDate.Enabled = false;
            txtRequiredDate.Enabled = false;
            txtShippedDate.Enabled = false;
            txtTotalCharge.Enabled = false;

            List<int> orderId = new List<int>(); //empty list
            try
            {
                orderId = OrdersDB.GetAllOrderID();//get all orderID from TABLE order
                cmbOrderID.DataSource = orderId;//set all of orderID to combox to list them
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmOrderUpdate updateOrderForm = new frmOrderUpdate(); //create a object of orderupdate form

            updateOrderForm.updateOrder = order1;//pass current modifing order object to modify window
            DialogResult result = updateOrderForm.ShowDialog();//get return value from updateorder window
            if (result == DialogResult.OK)
            {
                order1 = updateOrderForm.updateOrder;//pass updated object of updateOrder from updateorderWindow back to current order1 in mainform
                OrderDisplay();
            }
            else if (result == DialogResult.Retry)
            {
              //  this.GetOrder(order.OrderID);

            }
        }
        public void OrderDisplay()
        {
            //tell datatime fields is empty or not ,if null set null value ,if not format a new datetime format string
            txtCustomerID.Text = order1.CustomerID;//theDate.HasValue ? theDate.Value.ToYMD() : string.Empty
            txtOrderDate.Text = order1.OrderDate.HasValue ? String.Format("{0:MM/dd/yyyy}", order1.OrderDate) : string.Empty;

            txtRequiredDate.Text = order1.RequiredDate.HasValue ? String.Format("{0:MM/dd/yyyy}", order1.RequiredDate) : string.Empty;
            txtShippedDate.Text = order1.ShippedDate.HasValue ? String.Format("{0:MM/dd/yyyy}", order1.ShippedDate) : string.Empty;


        }

        private void cmbOrderID_SelectedIndexChanged(object sender, EventArgs e)//select ORDERID and dispaly all of info related to it
        {
            order1 = new Order();
            List<OrderDetail> orderDetails = new List<OrderDetail>();
            order1 = OrdersDB.GetOrder(Convert.ToInt32(cmbOrderID.Text));//get specific ORDER recorder and return it to order1 
            //need display method 

            OrderDisplay();//display order info
            orderDetails = OrderDetailsDB.GetRelativeDetails(order1.OrderID);//get related orderdetails info from TABLE order details
            dgvOrderDetail.DataSource = orderDetails;//set gridviewer datasource equals to orderdetails and display it
            if (orderDetails.Count > 0)//there are relative details
            {
                //call summary of  total charges from order details in TABLE ORDER DETAILS
                txtTotalCharge.Text = OrderDetailsDB.GetTotalCharge(order1.OrderID).ToString("c");
            }
            else
            {
                txtTotalCharge.Text = null;

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
