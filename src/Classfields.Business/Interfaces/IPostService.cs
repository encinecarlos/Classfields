using System;
using System.Threading.Tasks;
using Classfields.Business.Models;

namespace Classfields.Business.Interfaces
{
    public interface IPostService
    {
        Task Add(Post post);
        Task Update(Post post);
        Task Destroy(Guid id);
    }
}