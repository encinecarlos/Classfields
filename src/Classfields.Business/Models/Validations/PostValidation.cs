using FluentValidation;

namespace Classfields.Business.Models.Validations
{
    public class PostValidation : AbstractValidator<Post>
    {
        public PostValidation()
        {
            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("The {PropertyName} field is required.")
                .Length(3, 100).WithMessage("The {PropertyName} field must be between {MinLength} and {MaxLength} characters.");

            RuleFor(p => p.Age)
                .NotEmpty().WithMessage("The {PropertyName} field is required.")
                .GreaterThan(18).WithMessage("You must be over {ComparisonValue} years to create this post.");

            RuleFor(p => p.Email)
                .NotEmpty().WithMessage("The {PropertyName} field is required.")
                .EmailAddress()
                .WithMessage("The {PropertyName} field not in a valid E-mail format")
                .MaximumLength(100)
                .WithMessage("The {PropertyName} field must have a maximum of {MaxLength} characters");

            RuleFor(p => p.Ethnicity).NotEmpty().WithMessage("The {PropertyName} field is required.");
            RuleFor(p => p.Eyes).NotEmpty().WithMessage("The {PropertyName} field is required.");
            RuleFor(p => p.Gender).NotEmpty().WithMessage("The {PropertyName} field is required.");
            RuleFor(p => p.Height).NotEmpty().WithMessage("The {PropertyName} field is required.");
            RuleFor(p => p.Hips).NotEmpty().WithMessage("The {PropertyName} field is required.");
            RuleFor(p => p.HairColor).NotEmpty().WithMessage("The {PropertyName} field is required.");
            RuleFor(p => p.Incall).NotEmpty().WithMessage("The {PropertyName} field is required.");
            RuleFor(p => p.Outcall).NotEmpty().WithMessage("The {PropertyName} field is required.");
            RuleFor(p => p.Affiliation).NotEmpty().WithMessage("The {PropertyName} field is required.");
            
            RuleFor(p => p.Phone)
                .NotEmpty().WithMessage("The {PropertyName} field is required.")
                .Matches("^[0-9]").WithMessage("Only numbers are allowed.")
                .MaximumLength(30).WithMessage("The {PropertyName} must be only maximum of {MaxLength} characters");

            RuleFor(p => p.Country)
                .NotEmpty().WithMessage("The {PropertyName} field is required.")
                .Matches("[a-zA-Z]")
                .WithMessage("Only Letters are allowed.");

            RuleFor(p => p.State)
                .NotEmpty().WithMessage("The {PropertyName} field is required.")
                .Matches("[a-zA-Z]")
                .WithMessage("Only Letters are allowed.");

            RuleFor(p => p.City)
                .NotEmpty().WithMessage("The {PropertyName} field is required.")
                .Matches("[a-zA-Z]")
                .WithMessage("Only Letters are allowed.");

            RuleFor(p => p.Status)
                .NotEmpty().WithMessage("The {PropertyName} field is required.");

            RuleFor(p => p.ShortDescription)
                .NotEmpty().WithMessage("The {PropertyName} field is required.")
                .Length(2, 100).WithMessage("The {PropertyName} field must be between {MinLength} and {MaxLength} characters.");

            RuleFor(p => p.Description)
                .NotEmpty().WithMessage("The {PropertyName} field is required.")
                .Length(2, 1000).WithMessage("The {PropertyName} field must be between {MinLength} and {MaxLength} characters.");

            RuleFor(p => p.Weight)
                .NotEmpty().WithMessage("The {PropertyName} field is required.");

            RuleFor(p => p.Bust)
                .NotEmpty().WithMessage("The {PropertyName} field is required.");

            RuleFor(p => p.Cup)
                .NotEmpty().WithMessage("The {PropertyName} field is required.");

            RuleFor(p => p.AvailableTo)
                .NotEmpty().WithMessage("The {PropertyName} field is required.");

            RuleFor(p => p.BumpedAt)
                .NotEmpty().WithMessage("The {PropertyName} field is required.");
        }
    }
}