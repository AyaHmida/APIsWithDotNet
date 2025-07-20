using DevAPI.DTOs;
using DevAPI.Entities;

namespace DevAPI.Services
{
    public interface IUserService
    {
        Task RegisterAsync(UserRegisterDto dto);

    }
}
