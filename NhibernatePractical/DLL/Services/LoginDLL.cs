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
        public bool CheckUserActive(string userName, string password)
        {
            try
            {
                using (ISession session = NHibernateSession.OpenSession())
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        var user = session.Query<UserDTO>().FirstOrDefault(y => y.UserName == userName && y.Password == password && y.IsActive == true);

                        transaction.Commit();
                        if (user == null)
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
            catch
            {
                throw new Exception();
            }
        }
        public bool CheckIsActive(int id)
        {
            using (ISession session = NHibernateSession.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {

                    var userStatus = session.Get<FirmDTO>(id);
                    var user = session.Get<UserDTO>(userStatus.UserList.UserId);

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
