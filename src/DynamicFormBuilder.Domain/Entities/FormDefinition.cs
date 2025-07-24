﻿namespace DynamicFormBuilder.Domain.Entities
{
    public class FormDefinition
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; } = string.Empty;
        public List<FormComponent> Components { get; set; } = new();
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}