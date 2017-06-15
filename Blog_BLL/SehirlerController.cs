using Blog_DAL.Repositories;
using Blog_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_BLL
{
   public class SehirlerController
    {
       SehirManagement sm;
       public SehirlerController()
       {
           sm = new SehirManagement();
       }

       public ICollection<Sehirler> SehirGetir()
       {
           return (ICollection<Sehirler>)sm.GetAll();
       }

    }
}
