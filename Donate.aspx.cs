using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Donate : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        if (Session["userKey"] == null)
        {
            Response.Redirect("default.aspx");
        }
        //float amount = AmountTextBox.Text;

        decimal amount = Convert.ToDecimal(AmountTextBox.Text);
        //string explantion = GrantExplanationBox.Text;
        //int type = Convert.ToInt16(TypeKeyTextBox.Text);
        int userKey = (int)Session["userKey"];

        ServiceReference1.ServiceClient sc =
            new ServiceReference1.ServiceClient();

        ServiceReference1.Donation donation = new ServiceReference1.Donation();

        donation.DonationAmount = amount;
        //grant.GrantRequestExplanation = explantion;
        donation.DonationDate = DateTime.Now;
        //donation.DonationKey = type;
        donation.PersonKey = userKey;


        bool result = sc.Donate(donation);
        if (result)
        {
            Response.Redirect("GetDonation.aspx");
        }
        else
        {
            ErrorLabel.Text = "Invalid Login";
        }
    }
}