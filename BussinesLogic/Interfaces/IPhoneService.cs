using BussinesLogic.DTOs;
using Data.Models;

namespace BussinesLogic.Interfaces
{
    public interface IPhoneService
    {
        Task<IEnumerable<PhoneDto>> GetAllAsync();
        Task<PhoneDto> GetByIdAsync(int id);
        Task CreateAsync(PhoneDto phone);
        Task EditAsync(PhoneDto phone);
        Task DeleteAsync(int id);
    }
}
