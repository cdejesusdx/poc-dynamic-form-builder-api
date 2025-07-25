namespace DynamicFormBuilder.Domain.Entities
{
    public class FormComponent
    {
        public string Key { get; set; } = default!;
        public string Type { get; set; } = default!;
        public string Label { get; set; } = default!;
        public string Placeholder { get; set; } = string.Empty;
        public string? DefaultValue { get; set; }

        public FormValidation Validate { get; set; } = new();
        public FormComponentData? Data { get; set; }
    }

    public class FormComponentData
    {
        public List<FormComponentValue>? Values { get; set; }
    }

    public class FormComponentValue
    {
        public string Label { get; set; } = default!;
        public string Value { get; set; } = default!;
    }
}