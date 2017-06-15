using Blog_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_DAL.IRepositories
{
    interface OkunmaSayisi:ICrudRepository<int,Makaleler>
    {
        bool Update(int key);
    }
}
