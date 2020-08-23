using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Classfields.Business.Models;

namespace Classfields.Business.Interfaces
{
    public interface IPostRepository : IRepository<Post>
    {
        Task<IEnumerable<Post>> GetPostsById(Guid id);
        Task<IEnumerable<Post>> GetPostsByUser(Guid userId);
    }
}