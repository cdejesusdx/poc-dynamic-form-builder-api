namespace DynamicFormBuilder.Application.DTOs
{
    public class FormComponentDto
    {
        public string Key { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string Label { get; set; } = string.Empty;
        public string Placeholder { get; set; } = string.Empty;
        public FormValidationDto Validate { get; set; } = new();
    }

    public class FormValidationDto
    {
        public bool Required { get; set; }
    }
}