namespace DynamicFormBuilder.Application.DTOs
{
    public class FormComponentDto
    {
        public string Key { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string Label { get; set; } = string.Empty;
        public string Placeholder { get; set; } = string.Empty;
        public FormValidationDto Validate { get; set; } = new();

        public string? DefaultValue { get; set; }
        public FormComponentDataDto? Data { get; set; }
    }

    public class FormValidationDto
    {
        public bool Required { get; set; }
    }

    public class FormComponentDataDto
    {
        public List<FormComponentValueDto>? Values { get; set; }
    }

    public class FormComponentValueDto
    {
        public string Label { get; set; } = default!;
        public string Value { get; set; } = default!;
    }
}