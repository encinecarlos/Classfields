using FluentValidation;

namespace Classfields.Business.Models.Validations
{
    public class UserValidation : AbstractValidator<User>
    {
        public UserValidation()
        {
            RuleFor(u => u.Name)
                .NotEmpty().WithMessage("The field {PropertyName} is required.")
                .Length(2, 50)
                .WithMessage("The {PropertyName} field must be between {MinLength} and {MaxLength} characters.");

            RuleFor(u => u.Email)
                .NotEmpty().WithMessage("The field {PropertyName} is required.")
                .EmailAddress()
                .WithMessage("The {PropertyName} field not in a valid E-mail format")
                .MaximumLength(100)
                .WithMessage("The {PropertyName} field must have a maximum of {MaxLength} characters");

            RuleFor(u => u.Password)
                .NotEmpty().WithMessage("The {PropertyName} field cannot be empty.")
                .Length(6, 100).WithMessage("The filed {PropertyName} must be between {MinLength} and {MaxLength} characters")

        }
    }
}