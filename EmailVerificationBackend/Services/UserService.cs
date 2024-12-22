using EmailVerificationBackend.Models;
using EmailVerificationBackend.Repositories;

namespace EmailVerificationBackend.Services
{
    public class UserService
    {
        private readonly UserRepository _userRepository;

        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void CreateUser(string email, string password)
        {
            var user = new User
            {
                Email = email,
                PasswordHash = password // Жишээ болгож оруулав, үүнийг хэшлэх хэрэгтэй
            };

            _userRepository.AddUser(user);
        }
    }
}
