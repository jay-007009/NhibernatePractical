using NhibernatePractical.BLL.InterFaces;
using NhibernatePractical.DLL.Interfaces;
using NhibernatePractical.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NhibernatePractical.BLL.Services
{
    public class DonorBLL :IDonorBLL
    {
        private readonly IDonor _donorDLL;

        public DonorBLL(IDonor donorDLL)
        {
            _donorDLL = donorDLL;
        }
        public string CreateDonor(DonorDTO donor)
        {
            return _donorDLL.CreateDonor(donor);
        }

        public string DeleteDonor(int id)
        {
            return _donorDLL.DeleteDonor(id);
        }

        public List<DonorDTO> GetAllDonor()
        {
            return _donorDLL.GetAllDonor();
        }
        public DonorDTO GetDonorWithId(int id)
        {
            return _donorDLL.GetDonorWithId(id);
        }
    }
}
