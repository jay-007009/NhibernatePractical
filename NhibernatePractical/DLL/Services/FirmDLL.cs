using NHibernate;
using NhibernatePractical.DLL.Interfaces;
using NhibernatePractical.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NhibernatePractical.DLL.Services
{
    public class FirmDLL :IFirm
    {
        public string CreateFirm(FirmDTO firms)
        {
            try
            {
                using (ISession session = NHibernateSession.OpenSession())
                {
                    UserDTO user = new UserDTO
                    {
                        UserName = firms.Users.UserName,
                        Password = firms.Users.Password
                    };
                    session.Save(user);
                    firms.Users.UserId = user.UserId;

                    session.Save(firms);

                    return "Firm Created Successfully";
                }
            }
            catch (Exception ex)
            {
                return $"Firm Creation Failed Error:{ex.Message}";
            }
        }

        public string DeleteFirm(int id)
        {
            try
            {
                using (ISession session = NHibernateSession.OpenSession())
                {
                    var firmDelete = session.Get<FirmDTO>(id);
                    var user = session.Get<UserDTO>(firmDelete.Users.UserId);
                    using (var transaction = session.BeginTransaction())
                    {
                        session.Delete(user);

                        transaction.Commit();
                    }
                }
                return "Delete Successfully...";
            }
            catch (Exception ex)
            {
                return $"Delete Failed....{ex.Message}";
            }
        }

        public List<FirmDTO> GetAllFirm()
        {
            try
            {
                using (ISession session = NHibernateSession.OpenSession())
                {
                    using (var transaction = session.BeginTransaction())
                    {
                        var firms = session.CreateCriteria<FirmDTO>().List<FirmDTO>();
                        transaction.Commit();
                        return (List<FirmDTO>)firms;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public FirmDTO GetFirmWithId(int id)
        {
            try
            {
                using (ISession session = NHibernateSession.OpenSession())
                {
                    using (var transaction = session.BeginTransaction())
                    {
                        var firm = session.Get<FirmDTO>(id);
                        return firm;

                    }
                }
            }
            catch
            {
                throw new Exception();
            }
        }

        public string UpdateFirm(int id, FirmDTO firm)
        {
            try
            {
                using (ISession session = NHibernateSession.OpenSession())
                {
                    using (var transaction = session.BeginTransaction())
                    {
                        var firms = session.Get<FirmDTO>(id);
                        firms.FirmName = firm.FirmName;
                        firms.FirmCityName = firm.FirmCityName;
                        firms.FirmStateName = firm.FirmStateName;
                        firms.AddressLine1 = firm.AddressLine1;
                        firms.AddressLine2 = firm.AddressLine2;
                        firms.DonationLimit = firm.DonationLimit;
                        
                        firms.ModificationDate = firm.ModificationDate;
                        firms.RegisterDate = firm.RegisterDate;
                        firms.RegisterNo = firm.RegisterNo;
                        session.Update(firms);

                        transaction.Commit();
                        return "Updated Successfully...";

                    }
                }
            }
            catch
            {
                return "Update Failed...";
            }
        }



    }
}
