using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebProjectPart2
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            addActiveClass();

        }

        private void addActiveClass()
        {
            switch (Page.Title)
            {
                case "Home Page":
                    home.Attributes.Add("class", "active");
                    break;

                case "Product":
                    product.Attributes.Add("class", "active");
                    break;

                case "Service":
                    service.Attributes.Add("class", "active");
                    break;

                case "About":
                    about.Attributes.Add("class", "active");
                    break;

                case "ContactUs":
                    Contact.Attributes.Add("class", "active");
                    break;
            }
        }
    }
}