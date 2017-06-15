using Blog_DAL.IRepositories;
using Blog_Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;

namespace Blog_DAL.Repositories
{
   public class UyeKayitManagement:AbstractManagement,ICrudRepository<Guid,UyeKisisel>
    {
       
        public bool Add(UyeKisisel obj)
        {
            //MembershipCreateStatus durum;

            //Membership.CreateUser(txtKullaniciAdi.Text, txtSifre.Text, txtEmail.Text, "Kopek", "dogi", true, out durum);

            //if (durum==MembershipCreateStatus.Success)
           
            
             
                SqlCommand cmd = new SqlCommand("insert into UyeKisisel (UyeID,Ad,Soyad,DogumTarihi,Cinsiyet,Telefon,Adres,IlceID) values (@UyeID,@Ad,@Soyad,@DogumTarihi,@Cinsiyet,@Telefon,@Adres,@IlceID)", _conn);
                cmd.Parameters.AddWithValue("@UyeID", obj.UyeID);
                cmd.Parameters.AddWithValue("@Ad", obj.Ad);
                cmd.Parameters.AddWithValue("@Soyad", obj.Soyad);
                cmd.Parameters.AddWithValue("@DogumTarihi", obj.DogumTarihi);
                cmd.Parameters.AddWithValue("@Telefon", obj.Telefon);
                cmd.Parameters.AddWithValue("@Cinsiyet", obj.Cinsiyet);
                cmd.Parameters.AddWithValue("@Adres", obj.Adres);
                cmd.Parameters.AddWithValue("@IlceID", obj.IlceID);

                try
                {
                    if (_conn.State == ConnectionState.Closed)
                    {
                        _conn.Open();
                    }
                    if (cmd.ExecuteNonQuery()>0)
                    {
                        return true;
                    } 
                    else
                    {
                        return false;
                    }
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    cmd.Dispose();
                    _conn.Dispose();

                }

            
        }

        public bool Delete(UyeKisisel obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Guid key)
        {
            throw new NotImplementedException();
        }

        public ICollection<UyeKisisel> GetAll()
        {
            throw new NotImplementedException();
        }

        public UyeKisisel Get(Guid key)
        {
            throw new NotImplementedException();
        }

        public bool Update(UyeKisisel obj)
        {
            throw new NotImplementedException();
        }
    }
}
