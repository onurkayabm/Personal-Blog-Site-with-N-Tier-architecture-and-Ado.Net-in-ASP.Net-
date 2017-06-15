using Blog_DAL.IRepositories;
using Blog_Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_DAL
{
    public class CategoryManagement : AbstractManagement, ICrudRepository<int, Kategoriler>
    {
        public bool Add(Kategoriler obj)
        {
            throw new NotImplementedException();
            //SqlCommand cmd = new SqlCommand("Insert into Categories (CategoryName,Description) values(@CategoryName,@Description)", _conn);
            //cmd.Parameters.AddWithValue("@CategoryName", obj.KategoriAdi);
            //cmd.Parameters.AddWithValue("@Description", obj.Description);

            //if (_conn.State == ConnectionState.Closed)
            //{
            //    _conn.Open();
            //}
            //try
            //{
            //    if (cmd.ExecuteNonQuery() > 0)
            //    {
            //        return true;
            //    }
            //    else
            //    {
            //        return false;
            //    }
            //}
            //catch (Exception)
            //{
            //    return false;
            //}
            //finally
            //{
            //    cmd.Dispose();
            //    _conn.Dispose();

            //}
        }

        public bool Delete(Kategoriler obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int key)
        {
            throw new NotImplementedException();
        }

        public ICollection<Kategoriler> GetAll()
        {
            List<Kategoriler> categoryList = new List<Kategoriler>();

            SqlCommand cmd = new SqlCommand("select * from Kategoriler", _conn);
            if (_conn.State == ConnectionState.Closed)
            {
                _conn.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Kategoriler category = new Kategoriler();
                    category.KategoriID = Convert.ToInt32(dr["KategoriID"]);
                    category.KategoriAdi = dr["KategoriAdi"].ToString();
                    
                    categoryList.Add(category);
                }
            }
            cmd.Dispose();
            _conn.Dispose();

            return categoryList;
        }

        public Kategoriler Get(int key)
        {
            //Kategoriler category = null;
            //SqlCommand cmd = new SqlCommand("select * from Categories where CategoryID=@CategoryID", _conn);
            //cmd.Parameters.AddWithValue("@CategoryID", key);
            //if (_conn.State == ConnectionState.Closed)
            //{
            //    _conn.Open();
            //}
            //SqlDataReader dr = cmd.ExecuteReader();

            //if (dr.HasRows)
            //{
            //    while (dr.Read())
            //    {
            //        category = new Kategoriler();
            //        category.CategoryID = Convert.ToInt32(dr["CategoryID"]);
            //        category.CategoryName = dr["CategoryName"].ToString();
            //        category.Description = dr["Description"].ToString();
            //        category.Picture = dr["Picture"];

            //    }
            //}
            //cmd.Dispose();
            //_conn.Close();

            //return category;
            throw new NotImplementedException();
        }

        public bool Update(Kategoriler obj)
        {
            throw new NotImplementedException();
        }
    }
}
