using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TwitterClone.Models;

namespace TwitterClone.Service.UserService
{
    public interface IUserService
    {
        
        Task<List<User>> GetUsersAsync();
        event Action<User> OnUserSelected;
        void SetSelectedUser(User user);
    }
}