using DevAPI.Entities;
using DevAPI.Repositories;

namespace DevAPI.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task RegisterAsync(User user)
        {
            bool emailExists = await _userRepository.EmailExistsAsync(user.Email);

            if (emailExists)
            {
                throw new Exception("This email is already registered.");
            }

            await _userRepository.AddUserAsync(user);
        }


    }
}
