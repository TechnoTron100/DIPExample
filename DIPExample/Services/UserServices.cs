using DIPExample.Data;
using DIPExample.Models;

namespace DIPExample.Services
{
    public class UserServices : IUserServices
    {
        private readonly UContext _uContext;
        public UserServices(UContext uContext)
        {
            _uContext = uContext;
        }

        public async Task<User> CreateUser(User user)
        {
            var res = await _uContext.Users.AddAsync(user);
            return user;
        }
    }
}
