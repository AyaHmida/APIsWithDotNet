using DevAPI.DTOs;
using DevAPI.Entities;

namespace DevAPI.Services
{
    public interface IUserService
    {
        Task RegisterAsync(UserRegisterDto dto);
        Task UpdateUserAsync(int id, UserUpdateDto dto);

        Task DeleteUserAsync(int id);




    }
}
