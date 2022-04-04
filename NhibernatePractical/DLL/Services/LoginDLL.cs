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
        /// <summary>
        /// To Check User Active Or Not 
        /// </summary>
        public bool CheckUserActive(string username,string password)
        {
            try
            {
                using (ISession session = NHibernateSession.OpenSession())
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        var users = session.Query<UserDTO>().FirstOrDefault(y => y.UserName == username && y.Password == password && y.IsActive == true);

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

        /// <summary>
        /// Change The State Of The Active User
        /// </summary>
        public void CheckIsActive(int id)
        {
            using (ISession session = NHibernateSession.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {

                    var user = session.Get<UserDTO>(id);
                    if (user.IsActive)
                    {
                        user.IsActive = false;
                    }
                    else
                    {
                        user.IsActive = true;
                    }
                    session.SaveOrUpdate(user);
                    transaction.Commit();

                }
            }
        }
    }
}
