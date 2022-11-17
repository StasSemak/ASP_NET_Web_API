using BussinesLogic.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic.Interfaces
{
    public interface IAccountService
    {
        public Task Register(UserDto user);
        public Task Login(string email, string password);
        public Task Logout();
    }
}
