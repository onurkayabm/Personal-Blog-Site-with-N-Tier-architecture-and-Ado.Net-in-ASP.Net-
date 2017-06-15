using Blog_DAL.Repositories;
using Blog_DTO;
using Blog_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace Blog_BLL
{
   public class MakaleController
    {
       MakaleManagement mm = new MakaleManagement();
       MakaleListeleManagement ml = new MakaleListeleManagement();
        MakaleGetir mg = new MakaleGetir();
        MakaleGetirManagement mgm = new MakaleGetirManagement();
        MakaleOkunmaManagement mom = new MakaleOkunmaManagement();
        Makaleler mk = new Makaleler();
       public bool MakaleEkle(string baslik,string icerik,int kategoriID,Guid yazarID) 
       {
           Makaleler mk = new Makaleler();
           mk.Baslik = baslik;
           mk.Icerik = icerik;
           mk.KategoriID = kategoriID;
           mk.YazarID = yazarID;

           return mm.Add(mk);
       }
       public ICollection<MakaleListele> MakaleleriListele() 
       {
           return (ICollection<MakaleListele>)ml.GetAll();
       
       }
        public MakaleGetir MakaleGetirbyID(int makaleID)
        {
           
            mg.MakaleID = makaleID;
            return mgm.Get(makaleID);
            

        }

        public bool makaleokunma(int id)
        {
            mk.MakaleID = id;
            return mom.Update(id);

        }

    }
}
