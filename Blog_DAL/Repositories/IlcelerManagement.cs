using Blog_DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog_Entity;
using System.Data.SqlClient;
using System.Data;

namespace Blog_DAL.Repositories
{
    public class IlcelerManagement : AbstractManagement, IIlcelerManagement
    {
        public bool Add(Ilceler obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int key)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Ilceler obj)
        {
            throw new NotImplementedException();
        }

        public Ilceler Get(int key)
        {
            throw new NotImplementedException();
        }

        public ICollection<Ilceler> GetAll()
        {
            throw new NotImplementedException();
        }

        public ICollection<Ilceler> IlceGetir(int SehirID)
        {
           List<Ilceler> ilcelerlist=new List<Ilceler>();
            SqlCommand cmd = new SqlCommand("Select * from Ilceler where SehirID=@SehirID",_conn);
            cmd.Parameters.AddWithValue("@SehirID",SehirID);
           
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
                        Ilceler ılce = new Ilceler();
                        ılce.IlceAdi = dr["IlceAd"].ToString();
                        ılce.IlceID = Convert.ToInt32(dr["IlceID"]);

                        ilcelerlist.Add(ılce);
                    }
                }
                return  ilcelerlist;

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

        public bool Update(Ilceler obj)
        {
            throw new NotImplementedException();
        }
    }
}
