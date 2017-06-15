using Blog_DAL.Repositories;
using Blog_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_BLL
{
   public class YorumController
    {
        Yorumlar yrm = new Yorumlar();
        YorumManagement ym = new YorumManagement();

        public ICollection<Yorumlar> yorumsırala(int makaleid)
        {
            yrm.MakaleID = makaleid;
            return (ICollection<Yorumlar>)ym.YorumGetir(makaleid);
        }

        public bool YorumKaydet(string ad,string icerik,string mail,string website, int makaleID)
        {
            yrm.MakaleID = makaleID;
            yrm.AdSoyad = ad;
            yrm.YorumIcerik = icerik;
            yrm.Email = mail;
            yrm.WebSitesi = website;
            return ym.Add(yrm);

        }
    }
}
