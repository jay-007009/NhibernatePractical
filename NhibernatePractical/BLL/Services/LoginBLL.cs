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

        public bool CheckIsActive(int id)
        {
            return _userDLL.CheckIsActive(id);
        }

        public bool CheckUserActive(UserDTO user)
        {
            return _userDLL.CheckUserActive(user);
        }
    }
}
