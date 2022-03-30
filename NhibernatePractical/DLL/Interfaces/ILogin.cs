using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NhibernatePractical.DLL.Interfaces
{
   public interface ILogin
    {
        public bool CheckUserActive(string userName, string password);
        public bool CheckIsActive(int id);
    }
}
