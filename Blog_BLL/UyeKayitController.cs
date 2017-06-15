using Blog_DAL.Repositories;
using Blog_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_BLL
{
   public class UyeKayitController
    {
       UyeKayitManagement um = new UyeKayitManagement();
       public bool UyeEkle(Guid UyeID,string Ad,string Soyad,DateTime dogumtarihi,bool cinsiyet,string tel,string adres,int ilceID)
       {
           UyeKisisel uk = new UyeKisisel();
           uk.Ad = Ad;
           uk.Soyad = Soyad;
           uk.DogumTarihi = dogumtarihi;
           uk.Cinsiyet = cinsiyet;
           uk.Telefon = tel;
           uk.Adres = adres;
           uk.IlceID = ilceID;
          return um.Add(uk);
       }
    }
}
