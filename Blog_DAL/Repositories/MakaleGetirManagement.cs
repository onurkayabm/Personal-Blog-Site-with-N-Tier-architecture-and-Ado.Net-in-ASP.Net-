using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog_DTO;
using Blog_DAL.IRepositories;
using System.Data.SqlClient;
using System.Data;

namespace Blog_DAL.Repositories
{
    public class MakaleGetirManagement : AbstractManagement, ICrudRepository<int, MakaleGetir>
    {
        public bool Add(MakaleGetir obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int key)
        {
            throw new NotImplementedException();
        }

        public bool Delete(MakaleGetir obj)
        {
            throw new NotImplementedException();
        }

        public MakaleGetir Get(int key)
        {
            MakaleGetir obj = new MakaleGetir();
            SqlCommand cmd = new SqlCommand("select m.Icerik,m.Baslik,m.KayitTarihi,a.UserName,OkunmaSayisi from Makaleler as m join aspnet_users as a on a.UserId=m.YazarID where m.MakaleID=@mid", _conn);
            cmd.Parameters.Add("@mid", SqlDbType.Int).Value = key;
            try
            {
                if (_conn.State == ConnectionState.Closed)
                {
                    _conn.Open();
                }
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    obj.Baslik = dr["Baslik"].ToString();
                    obj.Gonderen = dr["UserName"].ToString();
                    obj.Icerik = dr["Icerik"].ToString();
                    obj.KayitTarihi = Convert.ToDateTime(dr["KayitTarihi"].ToString());
                    obj.OkunmaSayisi = Convert.ToInt32(dr["OkunmaSayisi"]);
                    
                }
               

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                _conn.Close();
                
            }
            return obj;
        }

        public ICollection<MakaleGetir> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(MakaleGetir obj)
        {
            throw new NotImplementedException();
        }
    }
}
