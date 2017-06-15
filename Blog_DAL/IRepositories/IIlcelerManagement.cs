using Blog_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_DAL.IRepositories
{
    interface IIlcelerManagement:ICrudRepository<int,Ilceler>
    {
         ICollection<Ilceler> IlceGetir(int SehirID);
    }
}
