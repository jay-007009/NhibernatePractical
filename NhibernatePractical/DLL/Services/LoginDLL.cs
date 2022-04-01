using NHibernate;
using NhibernatePractical.DLL.Interfaces;
using NhibernatePractical.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NhibernatePractical.DLL.Services
{
    public class LoginDLL : ILogin
    {
        public bool CheckUserActive(UserDTO user)
        {
            try
            {
                using (ISession session = NHibernateSession.OpenSession())
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        var users = session.Query<UserDTO>().FirstOrDefault(y => y.UserName == user.UserName && y.Password == user.Password && y.IsActive == true);

                        transaction.Commit();
                        if (users == null)
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                }
            }
            catch(Exception e)
            {
                throw e;
            }
        }
        public bool CheckIsActive(int id)
        {
            using (ISession session = NHibernateSession.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {

                    var userStatus = session.Get<FirmDTO>(id);
                    var user = session.Get<UserDTO>(userStatus.Users.UserId);

                    transaction.Commit();
                    if (user.IsActive)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
        }
    }
}
