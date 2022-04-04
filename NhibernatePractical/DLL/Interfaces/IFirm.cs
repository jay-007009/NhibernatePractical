using NhibernatePractical.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NhibernatePractical.DLL.Interfaces
{
   public  interface IFirm
    {
        public string CreateFirm(FirmDTO firms);
        public string DeleteFirm(int id);
        public List<FirmDTO> GetAllFirm();

        public FirmDTO GetFirmWithId(int id);
        public string UpdateFirm(int id, FirmDTO firm);
        public FirmViewModel GetAddress();

    }
}
