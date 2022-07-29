using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment3
{
    public partial class HomeAssign3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (PreviousPage != null && PreviousPage.IsCrossPagePostBack)
            {
                Label1.Text = Application["Count"].ToString();
            }

            else
            {
                Response.Redirect("Assign3Sum2.aspx");
            }
        }
    }
}