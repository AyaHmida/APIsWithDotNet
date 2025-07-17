using DevAPI.Entities;

namespace DevAPI.Services
{
    public interface IUserService
    {
        Task RegisterAsync(User user);

    }
}
