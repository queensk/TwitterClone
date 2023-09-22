using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TwitterClone.Models;

namespace TwitterClone.Service.CommentService
{
    public interface ICommentService
    {
        Task<List<Comments>> GetAllPostComments(int postID);
    }
}