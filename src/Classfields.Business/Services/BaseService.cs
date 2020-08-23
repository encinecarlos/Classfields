using Classfields.Business.Interfaces;
using Classfields.Business.Models;
using Classfields.Business.Notifications;
using FluentValidation;
using FluentValidation.Results;

namespace Classfields.Business.Services
{
    public class BaseService
    {
        private readonly INotificator _notificator;

        public BaseService(INotificator notificator)
        {
            _notificator = notificator;
        }

        protected void Notify(ValidationResult result)
        {
            foreach (var error in result.Errors)
            {
                Notify(error.ErrorMessage);
            }
        }

        protected void Notify(string message)
        {
            _notificator.Handle(new Notification(message));
        }

        protected bool ExecuteValidation<TV, TE>(TV validation, TE entity)
            where TV : AbstractValidator<TE> where TE : Entity
        {
            var validator = validation.Validate(entity);

            if (validator.IsValid) return true;
            
            Notify(validator);
            
            return false;
        } 
    }
}