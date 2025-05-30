using System.Collections.Generic;
using System.Linq;
using UserServiceAPI.Models;

namespace UserServiceAPI.Services
{
    public class UserService
    {
        private readonly List<User> _users;

        public UserService()
        {
            _users = new List<User>
            {
                new User { Id = 1, Name = "John Doe", Email = "john@example.com" },
                new User { Id = 2, Name = "Jane Smith", Email = "jane@example.com" }
            };
        }

        public List<User> GetAllUsers() => _users;

        public User GetUserById(int id) => _users.FirstOrDefault(u => u.Id == id);

        public void AddUser(User user) => _users.Add(user);
    }
}
