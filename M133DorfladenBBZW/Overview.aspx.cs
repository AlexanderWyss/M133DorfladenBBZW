using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace M133DorfladenBBZW
{
    public partial class Overview : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Product> products = new CSVReader().ReadProducts();
            foreach (var product in products)
            {
                test.InnerText += product.ToString();
            }
        }
    }
}