using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog_DAL.IRepositories;
using Blog_DTO;
using System.Data.SqlClient;
using System.Data;
namespace Blog_DAL.Repositories
{
   public  class MakaleListeleManagement:AbstractManagement,ICrudRepository<int,MakaleListele>
    {

        public bool Add(MakaleListele obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(MakaleListele obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int key)
        {
            throw new NotImplementedException();
        }

        public ICollection<MakaleListele> GetAll()
        {
            List<MakaleListele> makalegetir = new List<MakaleListele>();
            SqlCommand cmd = new SqlCommand("MakaleListele", _conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                if (_conn.State == ConnectionState.Closed)
                {
                    _conn.Open();
                }
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        MakaleListele ml = new MakaleListele();
                        ml.Baslik = dr["Baslik"].ToString();
                        ml.Icerik = dr["Icerik"].ToString();
                        ml.yorumsayisi = Convert.ToInt32(dr["yorumsayisi"]);
                        ml.Gonderen = dr["Gonderen"].ToString();
                        ml.KayitTarihi = Convert.ToDateTime(dr["KayitTarihi"]);
                        ml.MakaleID = Convert.ToInt32(dr["MakaleID"]);
                        makalegetir.Add(ml);                       
                    }                   
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
            return makalegetir;
        }

        public MakaleListele Get(int key)
        {
            throw new NotImplementedException();
        }

        public bool Update(MakaleListele obj)
        {
            throw new NotImplementedException();
        }
    }
}
