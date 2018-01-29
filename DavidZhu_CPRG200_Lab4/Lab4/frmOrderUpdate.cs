using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{ /*************************
     * Description:set new shippedDate and update it back to database
     * Date:Jan 9 ,2018
     * Authour:Haishu Zhu
     * Course Code:CPRG200
     **************************/
    public partial class frmOrderUpdate : Form
    {
        public Order updateOrder;
        public frmOrderUpdate()
        {
            InitializeComponent();
        }

        private void frmOrderUpdate_Load(object sender, EventArgs e)
        {
            txtOrderID.Enabled = false;
            txtOrderDate.Enabled = false;
            txtReqiuredDate.Enabled = false;
            txtPreShipDate.Enabled = false;

            txtOrderID.Text = updateOrder.OrderID.ToString();
            txtOrderDate.Text = updateOrder.OrderDate.HasValue ? String.Format("{0:MM/dd/yyyy}", updateOrder.OrderDate) : string.Empty;
            txtReqiuredDate.Text = updateOrder.RequiredDate.HasValue ? String.Format("{0:MM/dd/yyyy}", updateOrder.RequiredDate) : string.Empty;
            txtPreShipDate.Text = updateOrder.ShippedDate.HasValue ? String.Format("{0:MM/dd/yyyy}", updateOrder.ShippedDate) : string.Empty;
            txtUpdateShipDate.Text = updateOrder.ShippedDate.HasValue ? String.Format("{0:MM/dd/yyyy}", updateOrder.ShippedDate) : string.Empty;
             
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //if validation
            Order newupdateOrder = new Order();
            newupdateOrder.OrderID = updateOrder.OrderID;
            newupdateOrder.CustomerID = updateOrder.CustomerID;
            newupdateOrder.OrderDate = updateOrder.OrderDate;
            newupdateOrder.RequiredDate = updateOrder.RequiredDate;

            
            if (txtUpdateShipDate.Text =="")
            {
                newupdateOrder.ShippedDate = null;
                try
                {
                    if (!OrdersDB.UpdateOrder(updateOrder, newupdateOrder))
                    {
                        MessageBox.Show("Recorder has been updated or deleted by another user!");
                        this.DialogResult = DialogResult.Retry;


                    }
                    else
                    {
                        this.DialogResult = DialogResult.OK;
                        updateOrder = newupdateOrder;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if(validation.IsDateTime(txtOrderDate)&& validation.IsDateTime(txtReqiuredDate)&&validation.IsDateTime(txtUpdateShipDate)&&validation.IsEarlyOrder(Convert.ToDateTime(txtReqiuredDate.Text),Convert.ToDateTime(txtUpdateShipDate.Text))&&validation.IsLateOrder(Convert.ToDateTime(txtOrderDate.Text),Convert.ToDateTime(txtUpdateShipDate.Text)))
            {
               // newupdateOrder.ShippedDate = DateTime.ParseExact(txtUpdateShipDate.Text, "MM-dd-yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None); ;
                newupdateOrder.ShippedDate = Convert.ToDateTime(txtUpdateShipDate.Text);

                try
                {
                    if (!OrdersDB.UpdateOrder(updateOrder, newupdateOrder))
                    {
                        MessageBox.Show("Recorder has been updated or deleted by another user!");
                        this.DialogResult = DialogResult.Retry;


                    }
                    else
                    {
                        this.DialogResult = DialogResult.OK;
                        updateOrder = newupdateOrder;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();//close current window
        }
    }
}
