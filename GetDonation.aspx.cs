using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GetDonation : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userKey"] == null)
        {
            Response.Redirect("default.aspx");
        }
        //if (!IsPostBack)
        //    FillGrantList;
        int key = (int)Session["userKey"];
        ServiceReference1.Donation[] donation = sc.GetDonation(key);
        GridView.DataSource = donation;
        GridView.DataBind();
    }

    ServiceReference1.ServiceClient sc = new ServiceReference1.ServiceClient();

    protected void GridView_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }
}