using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;
using TwitterClone.Models;

namespace TwitterClone.Service.PostService
{
    public class PostService : IPostService
    {
        private readonly HttpClient _httpClient;
        public PostService(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }
        public async Task<List<Posts>> GetAllPosts()
        {
            var post = await _httpClient.GetFromJsonAsync<List<Posts>>("https://jsonplaceholder.typicode.com/posts");
            return post;
        }
    }
}