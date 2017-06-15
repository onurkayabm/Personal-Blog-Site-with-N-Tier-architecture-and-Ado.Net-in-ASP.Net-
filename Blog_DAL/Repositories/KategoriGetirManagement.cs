using Blog_DAL.IRepositories;
using Blog_DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_DAL.Repositories
{
    public class KategoriGetirManagement : AbstractManagement, ICrudRepository<int, KategoriGetirMakaleSayisi>
    {
        public bool Add(KategoriGetirMakaleSayisi obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(KategoriGetirMakaleSayisi obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int key)
        {
            throw new NotImplementedException();
        }

        public ICollection<KategoriGetirMakaleSayisi> GetAll()
        {
            List<KategoriGetirMakaleSayisi> categoryList = new List<KategoriGetirMakaleSayisi>();

            SqlCommand cmd = new SqlCommand("KategoriGetir", _conn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (_conn.State == ConnectionState.Closed)
            {
                _conn.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    KategoriGetirMakaleSayisi category = new KategoriGetirMakaleSayisi();
                    category.KategoriID = Convert.ToInt32(dr["KategoriID"]);
                    category.KategoriAdi = dr["KategoriAdi"].ToString();
                    category.MakaleSayisi= Convert.ToInt32 (dr["MakaleSayisi"]);

                    categoryList.Add(category);
                }
            }
            cmd.Dispose();
            _conn.Dispose();

            return categoryList;
        }

        public KategoriGetirMakaleSayisi Get(int key)
        {
            throw new NotImplementedException();
        }

        public bool Update(KategoriGetirMakaleSayisi obj)
        {
            throw new NotImplementedException();
        }
    }
}
