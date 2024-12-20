﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class customer_homepage : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            string mobile = Session["mobile_num"] as string;
            Response.Write(mobile);
        }
        protected void service_plan_direct(object sender, EventArgs e)
        {
            string mobile = Session["mobile_num"] as string;
         
            Session["mob"] = mobile;
            Response.Redirect("Service_plans.aspx");
        }
        protected void other_serviceplan(object sender, EventArgs e)
        {
           
            Response.Redirect("other_plans.aspx");
        }

        protected void ActiveBenefits(object sender, EventArgs e)
        {
            Response.Redirect("ActiveBenefitsView.aspx");

        }

        protected void UnresolvedTickets(object sender, EventArgs e)
        {
            Response.Redirect("No_of_unresolved_tickets.aspx");

        }

        protected void HighestVoucherValue(object sender, EventArgs e)
        {
            Response.Redirect("HighestVoucherValueView.aspx");
        }

        protected void RemainingAmount(object sender, EventArgs e)
        {
            Response.Redirect("RemainingAmountView.aspx");
        }


        protected void ExtraAmount(object sender, EventArgs e)
        {
            Response.Redirect("ExtraAmountView.aspx");
        }


        protected void Top10SuccessfulPayments(object sender, EventArgs e)
        {
            Response.Redirect("Top10SuccessfulPayments.aspx");
        }

    }
}