using FluentValidation;
using DynamicFormBuilder.Domain.Entities;

namespace DynamicFormBuilder.API.Validators
{
    public class FormValidationValidator : AbstractValidator<FormValidation>
    {
        public FormValidationValidator()
        {
            RuleFor(x => x.Required).NotNull();
        }
    }
}