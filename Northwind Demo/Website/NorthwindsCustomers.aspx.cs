using Northwind.Application.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class NorthwindsCustomers : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void CustomerGridView_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {
        CustomerGridView.SelectedIndex = e.NewSelectedIndex;
        //if (e.NewSelectedIndex >= 0)
        //{
        //    var selectedRow = CustomerGridView.Rows[e.NewSelectedIndex] as GridViewRow;
        //    if (selectedRow != null)
        //    {
        //        CustomerGridView.SelectedIndex = e.NewSelectedIndex;
        //        CustomerGridView.selected
        //        var controller = new SalesController();
        //        var history = controller.GetCustomerHistory();
        //    }
        //}
    }

    protected void CustomerGridView_SelectedIndexChanged(object sender, EventArgs e)
    {
        MessageLabel.Text = $"Primary key is {CustomerGridView.SelectedValue}";
        var controller = new SalesController();
        var history = controller.GetCustomerHistory(CustomerGridView.SelectedValue.ToString());
        SelectedCustomerOrders.DataSource = history.Orders;
        SelectedCustomerOrders.DataBind();
    }
}