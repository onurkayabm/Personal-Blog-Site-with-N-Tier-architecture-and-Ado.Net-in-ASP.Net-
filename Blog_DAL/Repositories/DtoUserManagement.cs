using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using Blog_DAL.IRepositories;
using Blog_DTO;

namespace Blog_DAL.Repositories
{
    public class DtoUserManagement : IUserRepository
    {
        public MembershipCreateStatus Add(DtoUser user)
        {
            MembershipCreateStatus status;
            Membership.CreateUser(user.UserName, user.Password, user.Email, user.PasswordQuestion, user.PasswordAnswer, user.IsApproved, out status);
            return status;
        }

        public Guid GetUserID(string UserName)
        {
            return (Guid)Membership.GetUser(UserName).ProviderUserKey;
        }
    }
}
