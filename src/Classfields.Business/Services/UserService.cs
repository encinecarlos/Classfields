using System;
using System.Linq;
using System.Threading.Tasks;
using Classfields.Business.Interfaces;
using Classfields.Business.Models;
using Classfields.Business.Models.Validations;

namespace Classfields.Business.Services
{
    public class UserService : BaseService, IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(INotificator notificator, IUserRepository userRepository) : base(notificator)
        {
            _userRepository = userRepository;
        }

        public async Task Add(User user)
        {
            if (!ExecuteValidation(new UserValidation(), user)) return;

            if (_userRepository.Search(u => u.Email == user.Email).Result.Any())
            {
                Notify("A User with this E-mail already exists!");
                return;
            }

            await _userRepository.Save(user);
            return;
        }

        public async Task Update(User user)
        {
            if (!ExecuteValidation(new UserValidation(), user)) return;

            if (_userRepository.Search(u => u.Email == user.Email && u.Id != user.Id).Result.Any())
            {
                Notify("A User with this E-mail already exists!");
                return;
            }


            await _userRepository.Update(user);
            return;
        }

        public async Task Destroy(Guid id)
        {
            if (_userRepository.GetUserPosts(id).Result.Post.Any()) return;

            var user = await _userRepository.Destroy(id);

            return;
        }

        public void Dispose()
        {
            _userRepository?.Dispose();
        }
    }
}