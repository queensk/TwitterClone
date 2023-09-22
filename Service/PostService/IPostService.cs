using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TwitterClone.Models;

namespace TwitterClone.Service.PostService
{
    public interface IPostService
    {
        Task<List<Posts>> GetAllPosts();
    }
}