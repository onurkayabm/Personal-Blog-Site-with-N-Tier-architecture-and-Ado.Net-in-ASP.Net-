using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog_Entity;
using Blog_DAL.IRepositories;
using System.Data.SqlClient;
using System.Data;
using Blog_DTO;

namespace Blog_DAL.Repositories
{
    public class MakaleManagement:AbstractManagement,ICrudRepository<int,Makaleler>
    {
        public bool Add(Makaleler obj)
        {
            SqlCommand cmd = new SqlCommand("insert into Makaleler(Baslik,Icerik,KategoriID,YazarID) values (@Baslik,@Icerik,@KatID,@YazarID) ", _conn);
            cmd.Parameters.AddWithValue("@Baslik", obj.Baslik);
            cmd.Parameters.AddWithValue("@Icerik",obj.Icerik);
            cmd.Parameters.AddWithValue("@KatID",obj.KategoriID);
            cmd.Parameters.AddWithValue("@YazarID",obj.YazarID);
            if (_conn.State==ConnectionState.Closed)
            {
                _conn.Open();
            }
            _conn.Open();
            int ess = 0;
            ess = cmd.ExecuteNonQuery();
            try
            {
                
                   
                
                if (ess > 0)
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

        public bool Delete(Makaleler obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int key)
        {
            throw new NotImplementedException();
        }

        public ICollection<Makaleler> GetAll()
        {
            throw new NotImplementedException();
        }

        public Makaleler Get(int key)
        {
            throw new NotImplementedException();
        }

        public bool Update(Makaleler obj)
        {
            throw new NotImplementedException();
        }
    }
}
