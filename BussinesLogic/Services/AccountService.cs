using AutoMapper;
using BussinesLogic.DTOs;
using BussinesLogic.Interfaces;
using Data.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic.Services
{
    public class AccountService : IAccountService
    {
        private readonly IMapper mapper;
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;

        public AccountService(IMapper mapper, UserManager<User> userManager, SignInManager<User> signInManager)
        {
            this.mapper = mapper;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public async Task Register(UserDto user)
        {
            var dbUser = mapper.Map<User>(user);

            var result = await userManager.CreateAsync(dbUser, user.Password);

            if (!result.Succeeded)
            {
                return;
            }
        }

        public async Task Login(string email, string password)
        {
            var user = await userManager.FindByEmailAsync(email);

            if (user == null || !await userManager.CheckPasswordAsync(user, password))
            {
                throw new Exception("Invalid email or password!");
            }

            await signInManager.SignInAsync(user, true);
        }

        public async Task Logout()
        {
            await signInManager.SignOutAsync();
        }

    }
}
