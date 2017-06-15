using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog_DAL.IRepositories;
using Blog_Entity;
using Blog_DTO;
using System.Data.SqlClient;
using System.Data;

namespace Blog_DAL.Repositories
{
    public class YorumManagement : AbstractManagement,YorumGetir
    {
        public bool Add(Yorumlar obj)
        {
            SqlCommand cmd = new SqlCommand("insert into Yorumlar (AdSoyad,YorumIcerik,Email,MakaleID,Websitesi,Onaylandimi) values(@ad,@Icerik,@Email,@MakaleID,@Site,@Onaylandimi)", _conn);

            cmd.Parameters.Add("@ad", SqlDbType.NVarChar, 50).Value = obj.AdSoyad;
            cmd.Parameters.Add("@Icerik", SqlDbType.NVarChar, 100).Value = obj.YorumIcerik;
            cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 150).Value =obj.Email;
            cmd.Parameters.Add("@Site", SqlDbType.NVarChar, 50).Value = obj.WebSitesi;
            cmd.Parameters.Add("@Onaylandimi", SqlDbType.Bit).Value = true;
            cmd.Parameters.Add("@MakaleID", SqlDbType.Int).Value = obj.MakaleID;


            int ess = 0;
            try
            {
                if (_conn.State == ConnectionState.Closed)
                {
                    _conn.Open();
                }
               ess= cmd.ExecuteNonQuery();

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
            if (ess>0)
            {
                return true;
                
            }
            else
            {
                return false;
            }
        }

        public bool Delete(int key)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Yorumlar obj)
        {
            throw new NotImplementedException();
        }

        public Yorumlar Get(int key)
        {
            throw new NotImplementedException();
        }

        public ICollection<Yorumlar> GetAll()
        {
            throw new NotImplementedException();

        }

        public bool Update(Yorumlar obj)
        {
            throw new NotImplementedException();
        }

        public ICollection<Yorumlar> YorumGetir(int key)
        {
            Yorumlar yr = new Yorumlar();
            List<Yorumlar> yrmliste = new List<Yorumlar>();
            SqlCommand cmd = new SqlCommand("Select AdSoyad,YorumIcerik,yorumTarihi from Yorumlar where MakaleID=@ID ", _conn);
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = key;
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
                        yr.AdSoyad = dr["AdSoyad"].ToString();
                        yr.YorumIcerik = dr["YorumIcerik"].ToString();
                        yr.yorumTarihi = Convert.ToDateTime(dr["yorumTarihi"]);
                        yrmliste.Add(yr);

                    }

                }


            }
            catch (Exception)
            {


            }
            finally
            {

                _conn.Close();
            }
            return yrmliste;
        }
    }
}
