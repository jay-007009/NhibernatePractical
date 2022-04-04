using NhibernatePractical.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NhibernatePractical.BLL.InterFaces
{
   public interface IDonorBLL
    {
        public string CreateDonor(DonorDTO donor);
        public string DeleteDonor(int id);
        public List<DonorDTO> GetAllDonor();
        public DonorDTO GetDonorWithId(int id);
    }
}
