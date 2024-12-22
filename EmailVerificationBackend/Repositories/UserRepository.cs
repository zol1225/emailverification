using EmailVerificationBackend.Models;

namespace EmailVerificationBackend.Repositories
{
    public class UserRepository
    {
        private List<User> _users = new List<User>();

        public void AddUser(User user)
        {
            _users.Add(user);
        }

        public User GetUserByEmail(string email)
        {
            return _users.FirstOrDefault(u => u.Email == email);
        }
    }
}
