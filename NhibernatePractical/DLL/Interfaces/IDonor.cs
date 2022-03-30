using NhibernatePractical.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NhibernatePractical.DLL.Interfaces
{
  public  interface IDonor
    {
        public List<DonorDTO> GetAllDonor();
        public string CreateDonor(DonorDTO donors);
        public string DeleteDonor(int id);
    }
}
