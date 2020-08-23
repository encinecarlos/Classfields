using System;
using System.Threading.Tasks;
using Classfields.Business.Models;

namespace Classfields.Business.Interfaces
{
    public interface IUserService
    {
        Task Add(User user);
        Task Update(User user);
        Task Destroy(Guid id);
    }
}