using Blog_DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog_Entity;
using System.Data.SqlClient;

namespace Blog_DAL.Repositories
{
    public class MakaleOkunmaManagement : AbstractManagement, OkunmaSayisi
    {
        public bool Add(Makaleler obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int key)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Makaleler obj)
        {
            throw new NotImplementedException();
        }

        public Makaleler Get(int key)
        {
            throw new NotImplementedException();
        }

        public ICollection<Makaleler> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Makaleler obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(int key)
        {
            SqlCommand cmd = new SqlCommand("Update Makaleler set OkunmaSayisi=isnull(OkunmaSayisi,0)+1 where MakaleID=@MakaleID", _conn);
            cmd.Parameters.AddWithValue("@MakaleID", key);
           
            _conn.Open();

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally {
                _conn.Close();
                
            }
            return true;
           
        }
    }
}
