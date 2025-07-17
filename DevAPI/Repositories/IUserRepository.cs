using DevAPI.Entities;

namespace DevAPI.Repositories
{
    public interface IUserRepository
    {
        Task AddUserAsync(User user);
        Task<bool> EmailExistsAsync(string email);

    }
}
