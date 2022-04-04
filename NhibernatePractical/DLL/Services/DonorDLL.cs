using NHibernate;
using NhibernatePractical.DLL.Interfaces;
using NhibernatePractical.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NhibernatePractical.DLL.Services
{
    public class DonorDLL :IDonor
    {
        public string CreateDonor(DonorDTO donors)
        {
            try
            {
                using (ISession session = NHibernateSession.OpenSession())
                {
                    using (var transaction = session.BeginTransaction())
                    {
                        session.Save(donors);
                        transaction.Commit();
                        return "Donor Created Successfully";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Donor Creation Failed Error:{ex.Message}";
            }
        }

        public string DeleteDonor(int id)
        {
            try
            {
                using (ISession session = NHibernateSession.OpenSession())
                {
                    var donorDelete = session.Get<DonorDTO>(id);
                    using (var transaction = session.BeginTransaction())
                    {
                        session.Delete(donorDelete);
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


        public List<DonorDTO> GetAllDonor()
        {
            try
            {
                using (ISession session = NHibernateSession.OpenSession())
                {
                    using (var transaction = session.BeginTransaction())
                    {
                        var donors = session.CreateCriteria<DonorDTO>().List<DonorDTO>();
                        transaction.Commit();
                        return (List<DonorDTO>)donors;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DonorDTO GetDonorWithId(int id)
        {
            try
            {
                using (ISession session = NHibernateSession.OpenSession())
                {
                    using (var transaction = session.BeginTransaction())
                    {
                        var donor = session.Get<DonorDTO>(id);
                        return donor;

                    }
                }
            }
            catch
            {
                throw new Exception();
            }
        }


    }
}
