namespace DynamicFormBuilder.Domain.Entities
{
    public class FormComponent
    {
        public string Key { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string Label { get; set; } = string.Empty;
        public string Placeholder { get; set; } = string.Empty;
        public FormValidation Validate { get; set; } = new();
    }
}