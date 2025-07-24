using FluentValidation;

using DynamicFormBuilder.Application.DTOs;

namespace DynamicFormBuilder.API.Validators;

public class FormUpdateDtoValidator : AbstractValidator<FormUpdateDto>
{
    public FormUpdateDtoValidator()
    {
        RuleFor(x => x.Title).NotEmpty().MaximumLength(100);
        RuleFor(x => x.Components).NotEmpty();
    }
}
