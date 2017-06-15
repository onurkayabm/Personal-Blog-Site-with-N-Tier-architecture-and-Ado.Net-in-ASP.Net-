using Blog_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;

namespace Blog_DAL.IRepositories
{
    interface IUserRepository
    {
        MembershipCreateStatus Add(DtoUser user);
        Guid GetUserID(string UserName);
    }
}
