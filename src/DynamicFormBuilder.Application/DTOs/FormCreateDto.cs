using DynamicFormBuilder.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace DynamicFormBuilder.Application.DTOs;

public class FormCreateDto
{

    [Required(ErrorMessage = "El título es obligatorio.")]
    [MaxLength(100, ErrorMessage = "El nombre no puede exceder los 100 caracteres.")]
    public string Title { get; set; } = string.Empty;

    [Required(ErrorMessage = "El esquema JSON es obligatorio.")]
    public List<FormComponent> Components { get; set; } = new();
}