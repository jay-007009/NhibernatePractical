using NhibernatePractical.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NhibernatePractical.BLL.InterFaces
{
   public interface ILoginBLL
    {
        public void CheckIsActive(int id);
        public bool CheckUserActive(string username,string password);
    }
}
