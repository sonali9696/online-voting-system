﻿using System;

namespace online_voting_system.organization
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["login"].ToString() != "organization")
            {
                Session.Abandon();
                Response.Redirect("../login.aspx");
            }
        }
    }
}