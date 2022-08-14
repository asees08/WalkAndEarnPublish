using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WalkAndEarn
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString.Count > 0)
            {
                if (!String.IsNullOrEmpty(Request.QueryString["Id"].ToString()))
                {
                    lblID.Text = Request.QueryString["Id"].ToString();
                }

                if (!String.IsNullOrEmpty(Request.QueryString["Coins"].ToString()))
                {
                    lblCoins.Text = Request.QueryString["Coins"].ToString();
                }

                if (!String.IsNullOrEmpty(Request.QueryString["Steps"].ToString()))
                {
                    lblSteps.Text = Request.QueryString["Steps"].ToString();
                }

            }
        }
    }
}