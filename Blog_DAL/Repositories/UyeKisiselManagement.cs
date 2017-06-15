using Blog_DAL.IRepositories;
using Blog_Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_DAL.Repositories
{
    public class UyeKisiselManagement : AbstractManagement, ICrudRepository<Guid, UyeKisisel>
    {
        public bool Add(UyeKisisel obj)
        {
            SqlCommand cmd = new SqlCommand("insert into UyeKisisel (UyeID,Ad,Soyad,Cinsiyet,DogumTarihi,Telefon,Adres,IlceID) values(@UyeID,@Ad,@Soyad,@Cinsiyet,@DogumTarihi,@Telefon,@Adres,@IlceID)", _conn);

            cmd.Parameters.AddWithValue("@UyeID", obj.UyeID);
            cmd.Parameters.AddWithValue("@Ad", obj.Ad);
            cmd.Parameters.AddWithValue("@Soyad", obj.Soyad);
            cmd.Parameters.AddWithValue("@Cinsiyet", obj.Cinsiyet);
            cmd.Parameters.AddWithValue("@DogumTarihi", obj.DogumTarihi);
            cmd.Parameters.AddWithValue("@Telefon", obj.Telefon);
            cmd.Parameters.AddWithValue("@Adres", obj.Adres);
            cmd.Parameters.AddWithValue("@IlceID", obj.IlceID);
            bool isCompleted = false;
            try
            {
                _conn.Open();
                int EtkilenenSatirSayisi = cmd.ExecuteNonQuery();
                if (EtkilenenSatirSayisi > 0)
                {
                    isCompleted = true;
                }
            }
            catch (Exception)
            {
                isCompleted = false;
                throw;
            }
            finally
            {
                cmd.Dispose();
                _conn.Dispose();
            }
            return isCompleted;
        }

        public bool Delete(Guid key)
        {
            throw new NotImplementedException();
        }

        public bool Delete(UyeKisisel obj)
        {
            throw new NotImplementedException();
        }

        public UyeKisisel Get(Guid key)
        {
            throw new NotImplementedException();
        }

        public ICollection<UyeKisisel> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(UyeKisisel obj)
        {
            throw new NotImplementedException();
        }
    }
}
