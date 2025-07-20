using DevAPI.DTOs;
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

        public async Task RegisterAsync(UserRegisterDto dto)
        {
            bool emailExists = await _userRepository.EmailExistsAsync(dto.Email);
            if (emailExists)
            {
                throw new Exception("This email is already registered.");
            }

            // Convert DTO to User entity
            var user = new User
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Email = dto.Email,
                PasswordHash = _passwordHasher.HashPassword(null, dto.Password),
                Role = "User"
            };

            await _userRepository.AddUserAsync(user);
        }

    }

}
