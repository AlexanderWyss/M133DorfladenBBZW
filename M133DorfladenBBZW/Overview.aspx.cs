using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace M133DorfladenBBZW
{
    public partial class Overview : System.Web.UI.Page
    {
        public List<Product> Products;
        protected void Page_Load(object sender, EventArgs e)
        {
            Products  = new CSVReader().ReadProducts();
            items.DataSource = Products;
            items.DataBind();
        }

        protected string GetImage(object name)
        {
            return ResolveUrl("~/Images/" + name);
        }
    }
}