using DIPExample.Models;

namespace DIPExample.Services
{
    public interface IUserServices
    {
        public Task<User> CreateUser(User user);
    }
}
