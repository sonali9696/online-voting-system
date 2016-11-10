﻿using System;

namespace online_voting_system.admin
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["login"].ToString() != "admin")
            {
                Session.Abandon();
                Response.Redirect("../default.aspx");
            }
            else
            {
                username_text.Text = Session["username"].ToString();
            }
        }
    }
}