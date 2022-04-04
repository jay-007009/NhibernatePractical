using NhibernatePractical.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NhibernatePractical.BLL.InterFaces
{
   public interface IFirmBLL
    {
        public string Create(FirmDTO firms);
        public string Delete(int id);
        public List<FirmDTO> GetAll();
        public FirmDTO GetWithId(int id);
        public string Update(int id, FirmDTO firm);

        public FirmViewModel GetCity();
    }
}
