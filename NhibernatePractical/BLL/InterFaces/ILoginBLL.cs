using NhibernatePractical.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NhibernatePractical.BLL.InterFaces
{
   public interface ILoginBLL
    {
        public bool CheckIsActive(int id);
        public bool CheckUserActive(UserDTO user);
    }
}
