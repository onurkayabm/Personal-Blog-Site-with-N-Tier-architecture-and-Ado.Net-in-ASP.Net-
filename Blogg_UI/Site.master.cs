using Blog_BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blogg_UI
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            kategorigetir();
        }
             private void kategorigetir()
        {
                 
            CategoryController cc = new CategoryController();
            rptCategories.DataSource = cc.KategoriGetir2();
            rptCategories.DataBind();
           
        }
    
    }
}