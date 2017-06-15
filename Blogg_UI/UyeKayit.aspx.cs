using Blog_BLL;
using Blog_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blogg_UI
{
    public partial class UyeKayit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SehirListele();
            }
            
        }
        private void SehirListele() {
            SehirlerController sc = new SehirlerController();
            ddlSehirler.DataSource = sc.SehirGetir();
            ddlSehirler.DataTextField = "SehirAd";
            ddlSehirler.DataValueField = "SehirID";
            ddlSehirler.DataBind();
            ddlSehirler.Items.Insert(0, "Lütfen bir il seçiniz");
        }

        protected void ddlSehirler_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            IlcelerController ıc = new IlcelerController();
            ddlIlceler.DataSource = ıc.IlceGetir(Convert.ToInt32(ddlSehirler.SelectedValue));
            ddlIlceler.DataTextField = "IlceAdi";
            ddlIlceler.DataValueField = "IlceID";
            ddlIlceler.DataBind();
            ddlIlceler.Items.Insert(0, "Lütfen bir ilçe seçiniz");
        }
        DtoUyeKisiselUserController ukuc = new DtoUyeKisiselUserController();

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            //Guid uyeID = (Guid)Membership.GetUser(txtKullaniciAdi.Text).ProviderUserKey;
            //UyeKayitController ukc = new UyeKayitController();
            //Guid UyeID = new Guid();
            //ukc.UyeEkle(UyeID,txtAd.Text,txtSoyad.Text,Convert.ToDateTime(txtDogumTarih.Text),rdbBay.Checked,txtTelefon.Text,txtAdres.Text,Convert.ToInt32(ddlIlceler.SelectedValue));
            if (!(ddlIlceler.SelectedValue == "0" || ddlSehirler.SelectedValue == "0"))
            {
                DtoUyeKisiselUser dto = new DtoUyeKisiselUser();
                dto.Ad = txtAd.Text;
                dto.Soyad = txtSoyad.Text;
                dto.Adres = txtAdres.Text;
                dto.Cinsiyet = rdbBay.Checked;
                dto.DogumTarihi = Convert.ToDateTime(txtDogumTarih.Text);
                dto.Email = txtEmail.Text;
                dto.IlceID = Convert.ToInt32(ddlIlceler.SelectedValue);
                dto.Password = txtSifre.Text;
                dto.PasswordQuestion = "Kopek";
                dto.PasswordAnswer = "dogi";
                dto.Telefon = txtTelefon.Text;
                dto.UserName = txtKullaniciAdi.Text;
                dto.IsApproved = true;

                ukuc.Kaydet(dto);
            }

        }
    }
}