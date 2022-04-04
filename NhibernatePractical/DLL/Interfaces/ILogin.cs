using NhibernatePractical.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NhibernatePractical.DLL.Interfaces
{
   public interface ILogin
    {
        public bool CheckUserActive(string username, string password);
        public void CheckIsActive(int id);
    }
}
