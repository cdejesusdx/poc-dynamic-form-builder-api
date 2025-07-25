namespace DynamicFormBuilder.Application.DTOs;

public class FormDefinitionDto
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public List<FormComponentDto> Components { get; set; } = new();
    public DateTime CreatedAt { get; set; }
}