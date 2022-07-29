using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment1
{
    public partial class fruits : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string[] s = new string[] { "Select", "Mango", "Apple", "Grapes", "Orange" };
                for (int i = 0; i < s.Length; i++)
                {
                    DropDownList1.Items.Add(s[i]);
                }
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = DropDownList1.Text;
            Image1.ImageUrl = "~/Images/" + s + ".jpg";

        }
               protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = DropDownList1.SelectedIndex.ToString();
            if (DropDownList1.Text == "Apple")
            {
                Label1.Text = "300 per kg";
            }
            else if (DropDownList1.Text == "Grapes")
            {
                Label1.Text = "100 per kg";
            }
            else if (DropDownList1.Text == "Orange")
            {
                Label1.Text = "200 per kg";
            }
            else if (DropDownList1.Text == "Mango")
            {
                Label1.Text = "220 per kg";
            }
            else
            {
                Label1.Text = "Empty";
            }
        }
    }
}