using Blog_BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blogg_UI
{
    public partial class MakaleEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            KategoriGetir();
        }

        private void KategoriGetir() 
        {

            CategoryController cc = new CategoryController();
            ddlKategoriler.DataSource = cc.KategoriGetir2();
            ddlKategoriler.DataTextField = "KategoriAdi";
            ddlKategoriler.DataValueField = "KategoriID";
            ddlKategoriler.DataBind();
        }

        private void MakaleEkleme() 
        {
            MakaleController mc = new MakaleController();

            mc.MakaleEkle(txtBaslik.Text, editor1.Value, Convert.ToInt32(ddlKategoriler.SelectedValue), Guid.Parse("acc52a3f-7c49-4c5a-8b03-465d67573202"));

        
        }
      
        protected void btnMakaleKaydet_Click(object sender, EventArgs e)
        {
            MakaleEkleme();
        }

    }
}