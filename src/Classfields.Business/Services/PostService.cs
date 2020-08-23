using System;
using System.Threading.Tasks;
using Classfields.Business.Interfaces;
using Classfields.Business.Models;
using Classfields.Business.Models.Validations;

namespace Classfields.Business.Services
{
    public class PostService : BaseService, IPostService
    {
        private IPostRepository _postRepository;

        public PostService(INotificator notificator, IPostRepository postRepository) : base(notificator)
        {
            _postRepository = postRepository;
        }

        public async Task Add(Post post)
        {
            if (!ExecuteValidation(new PostValidation(), post)) return;

            await _postRepository.Save(post);
            return;
        }

        public async Task Update(Post post)
        {
            if (!ExecuteValidation(new PostValidation(), post)) return;

            await _postRepository.Update(post);
            return;
        }

        public async Task Destroy(Guid id)
        {
            await _postRepository.Destroy(id);
        }

        public void Dispose()
        {
            _postRepository?.Dispose();
        }
    }
}