using Blog_DAL.Repositories;
using Blog_DTO;
using Blog_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;

namespace Blog_BLL
{
   public class DtoUyeKisiselUserController
    {
        DtoUserManagement um = new DtoUserManagement();
        UyeKisiselManagement ukm = new UyeKisiselManagement();
        public string Kaydet(DtoUyeKisiselUser kisiUser)
        {
            DtoUser user = new DtoUser();
            user.UserName = kisiUser.UserName;
            user.Password = kisiUser.Password;
            user.PasswordQuestion = kisiUser.PasswordQuestion;
            user.PasswordAnswer = kisiUser.PasswordAnswer;
            user.IsApproved = kisiUser.IsApproved;
            user.Email = kisiUser.Email;
            MembershipCreateStatus status = um.Add(user);

            bool uyeKisiselKaydiTamamMi = false;
            if (status == MembershipCreateStatus.Success)
            {
                UyeKisisel uyeKisisel = new UyeKisisel();
                uyeKisisel.UyeID = um.GetUserID(kisiUser.UserName);
                uyeKisisel.Ad = kisiUser.Ad;
                uyeKisisel.Soyad = kisiUser.Soyad;
                uyeKisisel.Cinsiyet = kisiUser.Cinsiyet;
                uyeKisisel.DogumTarihi = kisiUser.DogumTarihi;
                uyeKisisel.Adres = kisiUser.Adres;
                uyeKisisel.Telefon = kisiUser.Telefon;
                uyeKisisel.IlceID = kisiUser.IlceID;

                uyeKisiselKaydiTamamMi = ukm.Add(uyeKisisel);
            }

            if (uyeKisiselKaydiTamamMi)
            {
                return "Kayıt Başarılı";
            }
            else
            {
                return "Kayıt sırasında bir hata yaşandığından kayıt yapılamamıştır.";
            }
        }

    }
}
