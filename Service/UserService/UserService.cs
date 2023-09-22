using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;
using TwitterClone.Models;

namespace TwitterClone.Service.UserService
{
    public class UserService : IUserService
    {
        private User selectedUser;
        private readonly HttpClient _httpClient;

        public event Action<User> OnUserSelected;

        public UserService(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        public async Task<List<User>> GetUsersAsync()
        {
            var users = await _httpClient.GetFromJsonAsync<List<User>>("https://jsonplaceholder.typicode.com/users");
            return users;
        }

        public async Task<User> GetSelectedUser()
        {
            return selectedUser;
        }

        public void SetSelectedUser(User user)
        {
            selectedUser = user;
            OnUserSelected?.Invoke(selectedUser);
        }
    }
}