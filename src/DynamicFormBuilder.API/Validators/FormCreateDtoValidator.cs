using FluentValidation;

using DynamicFormBuilder.Application.DTOs;

namespace DynamicFormBuilder.API.Validators;

public class FormCreateDtoValidator : AbstractValidator<FormCreateDto>
{
    public FormCreateDtoValidator()
    {
        RuleFor(x => x.Title).NotEmpty();
        RuleForEach(x => x.Components).SetValidator(new FormComponentValidator());
    }
}