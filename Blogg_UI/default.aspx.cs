
using Blog_BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blogg_UI
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MakaleGetir();

        }
        private void MakaleGetir()
        {
            MakaleController ml = new MakaleController();

            rptArticles.DataSource = ml.MakaleleriListele();
            rptArticles.DataBind();

        }

    }
}