﻿using System;

namespace online_voting_system.organization
{
    public partial class can_reg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login"].ToString() != "organization")
            {
                Session.Abandon();
                Response.Redirect("../login.aspx");
            }
        }
    }
}