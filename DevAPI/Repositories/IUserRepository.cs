using DevAPI.Entities;

namespace DevAPI.Repositories
{
    public interface IUserRepository
    {
        Task AddUserAsync(User user);
        Task<bool> EmailExistsAsync(string email);

        Task<User> GetUserByIdAsync(int id);
        Task UpdateUserAsync(User user);

        Task DeleteUserAsync(User user);


    }
}
