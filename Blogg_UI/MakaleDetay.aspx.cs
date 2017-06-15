using Blog_BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blogg_UI
{
    public partial class MakaleDetay : System.Web.UI.Page
    {

        YorumController yc = new YorumController();
        MakaleController mc = new MakaleController();
        protected void Page_Load(object sender, EventArgs e)
        {

            okunmasayisi();

            makale();

            yorumlar();
           
            

        }
        private void makale()
        {

            mc.MakaleGetirbyID(Convert.ToInt32(Request.QueryString["mid"]));
            ViewState["MakaleID"] = Convert.ToInt32(Request.QueryString["mid"]);
            ltrBaslik.Text = mc.MakaleGetirbyID(Convert.ToInt32(Request.QueryString["mid"])).Baslik;
            ltrGonderen.Text = mc.MakaleGetirbyID(Convert.ToInt32(Request.QueryString["mid"])).Gonderen;
            ltrIcerik.Text = mc.MakaleGetirbyID(Convert.ToInt32(Request.QueryString["mid"])).Icerik;
            ltrOkunmaSayisi.Text = mc.MakaleGetirbyID(Convert.ToInt32(Request.QueryString["mid"])).OkunmaSayisi.ToString();
            ltrTarih.Text = mc.MakaleGetirbyID(Convert.ToInt32(Request.QueryString["mid"])).KayitTarihi.ToString();
        }

        private void yorumlar()
        {
            rptYorumlar.DataSource = yc.yorumsırala(Convert.ToInt32(Request.QueryString["mid"]));
            rptYorumlar.DataBind();

        }

        private void YorumEkle()
        {
            yc.YorumKaydet(txtAdsoyad.Text, txtYorum.Text, txtEmail.Text, txtWebsite.Text, Convert.ToInt32(Request.QueryString["mid"]));
        }

        protected void lnkKaydet_Click(object sender, EventArgs e)
        {
            YorumEkle();
        }

        private void okunmasayisi() {

            mc.makaleokunma(Convert.ToInt32(Request.QueryString["mid"]));
        }
    }
}