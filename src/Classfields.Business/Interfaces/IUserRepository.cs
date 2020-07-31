using System.Threading.Tasks;
using Classfields.Business.Models;

namespace Classfields.Business.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User> GetUserPosts();
    }
}