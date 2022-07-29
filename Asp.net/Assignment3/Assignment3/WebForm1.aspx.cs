using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string[] s = new string[] { "Select", "Self", "Mother","Father","Wife","Child","Relative" };
                for (int i = 0; i < s.Length; i++)
                {
                    DropDownList1.Items.Add(s[i]);
                }
            }

            DateVal.MaximumValue = DateTime.Today.ToShortDateString();
            DateVal.MinimumValue = DateTime.Today.ToShortDateString();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = DropDownList1.Text;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Label8.Text = "The details are saved ";
            }

            else
            {
                Response.Write("Could not save data as the validations failed");
            }
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            //if(args.Value=="")
            //{
            //    args.IsValid = false;
            //}
            //else
            //{
            //    string RegX= "^(\+91[\-\s] ?)?[0]?[91]?(91)?[789]\d{9})$";

            //    args.Value = RegX;
            //}
        }

        protected void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}