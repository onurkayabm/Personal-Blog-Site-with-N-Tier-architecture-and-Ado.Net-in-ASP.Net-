using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_DAL
{
   public abstract class AbstractManagement
    {
       public SqlConnection _conn = new SqlConnection("Server=.\\sqlexpress;DataBase=EsnaflarDB;Integrated Security=true;MultipleActiveResultSets=true");
        
    }
}
