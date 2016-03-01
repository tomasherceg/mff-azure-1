using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MffAzure1Demo
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TestButton_Click(object sender, EventArgs e)
        {
            var i = 15;
            Page.Title = i.ToString();
        }
    }
}