using Blog_DAL.IRepositories;
using Blog_Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_DAL.Repositories
{
    public class SehirManagement:AbstractManagement,ICrudRepository<int,Sehirler>
    {

        public bool Add(Sehirler obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Sehirler obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int key)
        {
            throw new NotImplementedException();
        }

        public ICollection<Sehirler> GetAll()
        {
            List<Sehirler> SehirList = new List<Sehirler>();

            SqlCommand cmd = new SqlCommand("Select * from Sehirler", _conn);
         
            if (_conn.State == ConnectionState.Closed)
            {
                _conn.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Sehirler sehir = new Sehirler();
                    
                    sehir.SehirID = Convert.ToInt32(dr["SehirID"]);
                    sehir.SehirAd = dr["SehirAd"].ToString();                   
                    SehirList.Add(sehir);
                }
            }
            cmd.Dispose();
            _conn.Dispose();

            return SehirList;
        }

        public Sehirler Get(int key)
        {
            throw new NotImplementedException();
        }

        public bool Update(Sehirler obj)
        {
            throw new NotImplementedException();
        }
    }
}
