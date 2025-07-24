using FluentValidation;
using DynamicFormBuilder.Domain.Entities; 

namespace DynamicFormBuilder.API.Validators
{
    public class FormComponentValidator : AbstractValidator<FormComponent>
    {
        public FormComponentValidator()
        {
            RuleFor(x => x.Key).NotEmpty();
            RuleFor(x => x.Type).NotEmpty();
            RuleFor(x => x.Label).NotEmpty();
            RuleFor(x => x.Validate).NotNull().SetValidator(new FormValidationValidator());
        }
    }
}
