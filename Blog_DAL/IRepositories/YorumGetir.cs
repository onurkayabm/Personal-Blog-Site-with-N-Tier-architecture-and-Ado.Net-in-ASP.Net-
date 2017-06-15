using Blog_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_DAL.IRepositories
{
    interface YorumGetir:ICrudRepository<int,Yorumlar>
    {
        ICollection<Yorumlar> YorumGetir(int key);
    }
}
