using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab34
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            try
            {
                this.productsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.northwndDataSet);
                MessageBox.Show("Recorder has been modified successfully!");
            }
            catch (DBConcurrencyException)
            {
                MessageBox.Show("Another User updated data.Try again!", "Concurrency Error");
                this.order_DetailsTableAdapter.Fill(this.northwndDataSet.Order_Details);
                this.categoriesTableAdapter.Fill(this.northwndDataSet.Categories);
                this.suppliersTableAdapter.Fill(this.northwndDataSet.Suppliers);
                this.productsTableAdapter.Fill(this.northwndDataSet.Products);
            }
            catch (SqlException ex)//exeption that comes from data provider
            {

                MessageBox.Show("Database error #" + ex.Number + ":\n" + ex.Message);
            }
            
            catch (DataException ex)//
            {

                MessageBox.Show(ex.Message, ex.GetType().ToString());
                productsBindingSource.CancelEdit();
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'northwndDataSet.Order_Details' table. You can move, or remove it, as needed.
                this.order_DetailsTableAdapter.Fill(this.northwndDataSet.Order_Details);
                // TODO: This line of code loads data into the 'northwndDataSet.Categories' table. You can move, or remove it, as needed.
                this.categoriesTableAdapter.Fill(this.northwndDataSet.Categories);
                // TODO: This line of code loads data into the 'northwndDataSet.Suppliers' table. You can move, or remove it, as needed.
                this.suppliersTableAdapter.Fill(this.northwndDataSet.Suppliers);
                // TODO: This line of code loads data into the 'northwndDataSet.Products' table. You can move, or remove it, as needed.
                this.productsTableAdapter.Fill(this.northwndDataSet.Products);
            }
            catch (SqlException ex)//exeption that comes from data provider
            {

                MessageBox.Show("Database error #" + ex.Number + ":\n" + ex.Message);
            }


        }



        private void productsBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            try
            {
                productsBindingSource.MovePrevious();
            }
            catch (NoNullAllowedException ex)
            {
                MessageBox.Show(ex.GetType().ToString() + ":\n" + ex.Message, "Add Error");
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            try { productsBindingSource.MoveFirst(); }

            catch (NoNullAllowedException ex)
            {
                MessageBox.Show(ex.GetType().ToString() + ":\n" + ex.Message, "Add Error");
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            try
            {
                productsBindingSource.AddNew();
            }
            catch (NoNullAllowedException ex)
            {
                MessageBox.Show(ex.GetType().ToString() + ":\n" + ex.Message, "Add Error");
            }

        }


    }
}
