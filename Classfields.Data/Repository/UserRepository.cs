using System;
using System.Threading.Tasks;
using Classfields.Business.Interfaces;
using Classfields.Business.Models;
using Classfields.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Classfields.Data.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(MyDbContext context) : base(context)
        {
        }

        public async Task<User> GetUserPosts(Guid Id)
        {
            return await Context.Users.AsNoTracking()
                .Include(u => u.Post)
                .FirstOrDefaultAsync(c => c.Id == Id);
        }
    }
}