using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;
using TwitterClone.Models;

namespace TwitterClone.Service.CommentService
{
    public class CommentService : ICommentService
    {
        private readonly HttpClient _httpClient;
        public CommentService(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }
        public async Task<List<Comments>> GetAllPostComments(int postID)
        {
            var responste =  await _httpClient.GetFromJsonAsync<List<Comments>>($"https://jsonplaceholder.typicode.com/comments?postId={postID}");
            return responste;
        }

    }
}