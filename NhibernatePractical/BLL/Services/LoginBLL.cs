using NhibernatePractical.BLL.InterFaces;
using NhibernatePractical.DLL.Interfaces;
using NhibernatePractical.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NhibernatePractical.BLL.Services
{
    public class LoginBLL :ILoginBLL
    {
        private readonly ILogin _userDLL;

        public LoginBLL(ILogin userDLL)
        {
            _userDLL = userDLL;
        }

        public void CheckIsActive(int id)
        {
            _userDLL.CheckIsActive(id);
        }

        public bool CheckUserActive(string username, string Password)
        {
            return _userDLL.CheckUserActive(username, Password);
        }
    }
}
