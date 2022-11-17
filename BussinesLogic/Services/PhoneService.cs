using AutoMapper;
using BussinesLogic.DTOs;
using BussinesLogic.Interfaces;
using Data.Data;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic.Services
{
    public class PhoneService : IPhoneService
    {
        private readonly PhoneShopDbContext context;
        private readonly IMapper mapper;

        public PhoneService(PhoneShopDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<PhoneDto>> GetAllAsync()
        {
            var phones = await context.Phones.Include(x => x.OperationSystem).ToListAsync();
            return mapper.Map<IEnumerable<PhoneDto>>(phones);
        }

        public async Task<PhoneDto> GetByIdAsync(int id)
        {
            var phone = await context.Phones.Include(x => x.OperationSystem).FirstOrDefaultAsync(x => x.Id == id);

            return mapper.Map<PhoneDto>(phone);
        }

        public async Task CreateAsync(PhoneDto phone)
        {
            await context.Phones.AddAsync(mapper.Map<Phone>(phone));
            await context.SaveChangesAsync();
        }

        public async Task EditAsync(PhoneDto phone)
        {
            var data = await context.Phones.AsNoTracking().FirstOrDefaultAsync(x => x.Id == phone.Id);
            if (data == null) return;

            context.Phones.Update(mapper.Map<Phone>(phone));
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var phone = await context.Phones.FindAsync(id);
            if (phone == null) return;

            context.Phones.Remove(phone);
            await context.SaveChangesAsync();
        }
    }
}
