using NhibernatePractical.BLL.InterFaces;
using NhibernatePractical.DLL.Interfaces;
using NhibernatePractical.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NhibernatePractical.BLL.Services
{
    public class FirmBLL :IFirmBLL
    {
        private readonly IFirm _firmDLL;

        public FirmBLL(IFirm firmDLL)
        {
            _firmDLL = firmDLL;
        }
        public string Create(FirmDTO firms)
        {
            var firmCreate = _firmDLL.CreateFirm(firms);
            return firmCreate;
        }

        public string Delete(int id)
        {
            return _firmDLL.DeleteFirm(id);
        }

        public List<FirmDTO> GetAll()
        {
            return _firmDLL.GetAllFirm();
        }

        public FirmDTO GetWithId(int id)
        {
            return _firmDLL.GetFirmWithId(id);
        }

        public string Update(int id, FirmDTO firm)
        {
            return _firmDLL.UpdateFirm(id, firm);
        }
    }
}
