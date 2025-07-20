using DevAPI.Entities;
using DevAPI.Repositories;
using Microsoft.AspNetCore.Identity;

namespace DevAPI.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IPasswordHasher<User> _passwordHasher; 

        public UserService(IUserRepository userRepository, IPasswordHasher<User> passwordHasher) 
        {
            _userRepository = userRepository;
            _passwordHasher = passwordHasher; 
        }

        public async Task RegisterAsync(User user)
        {
            bool emailExists = await _userRepository.EmailExistsAsync(user.Email);

            string hashedPassword = _passwordHasher.HashPassword(user, user.PasswordHash);
            user.PasswordHash = hashedPassword;

            if (emailExists)
            {
                throw new Exception("This email is already registered.");
            }

            await _userRepository.AddUserAsync(user);
        }
    }

}
