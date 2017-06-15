using Blog_DAL.Repositories;
using Blog_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_BLL
{
   public class IlcelerController
    {
        IlcelerManagement ım;
        public IlcelerController()
        {
            ım = new IlcelerManagement();
        }

        public ICollection<Ilceler> IlceGetir(int ID) {

            return (ICollection<Ilceler>)ım.IlceGetir(ID);
        }

    }
}
