using Chinook.Framework.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Profile_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            // Assuming the customer is logged in, we could
            // get his/her customer ID. But, for now, pretend
            // the id is 1.
            int custId = 1;
            CustomerManager manager = new CustomerManager();
            var theProfile = manager.GetProfile(custId);
            // Now, put the data in the controls on the page.
            // TODO: Resume here....
            FirstName.Text = theProfile.FirstName;
            LastName.Text = theProfile.LastName;
            CompanyName.Text = theProfile.CompanyName;
            StreetAddress.Text = theProfile.StreetAddress;
            City.Text = theProfile.City;
            State.Text = theProfile.State;
            Country.Text = theProfile.Country;
            PostalCode.Text = theProfile.PostalCode;
        }
    }
}