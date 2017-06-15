using Blog_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog_Entity;
using Blog_DAL.Repositories;
using Blog_DTO;
namespace Blog_BLL
{
   public class CategoryController
    {
        





        CategoryManagement cm;
        KategoriGetirManagement km;
        public CategoryController()
        {
            cm = new CategoryManagement();
            km = new KategoriGetirManagement();
        }
        public List<Kategoriler> VeriGonder()
        {
            return (List<Kategoriler>)cm.GetAll();
        }

        public ICollection<KategoriGetirMakaleSayisi> KategoriGetir2() {
            return (ICollection<KategoriGetirMakaleSayisi>)km.GetAll();
        
        }
        public ICollection<Kategoriler> KategoriGetir()
        {
            return (ICollection<Kategoriler>)cm.GetAll();
        }

        public bool VeriKaydet(string ad, int ID)
        {
            Kategoriler category = new Kategoriler();
            category.KategoriAdi = ad;
            category.KategoriID = ID;
            return cm.Add(category);
        }

    }
}
