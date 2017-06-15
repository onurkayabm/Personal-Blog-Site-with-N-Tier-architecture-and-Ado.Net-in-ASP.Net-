using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_DAL.IRepositories
{
    interface IDelete<Tkey, Tvalue> where Tvalue : class
    {
        bool Delete(Tvalue obj);
        bool Delete(Tkey key);
    }
}
