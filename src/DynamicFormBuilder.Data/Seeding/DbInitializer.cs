using DynamicFormBuilder.Data.Context;
using DynamicFormBuilder.Domain.Entities;

namespace DynamicFormBuilder.Data.Seeding;

public static class ApplicationDbContextSeed
{
    public static async Task SeedAsync(ApplicationDbContext context)
    {
        if (!context.Forms.Any())
        {
            var forms = new List<FormDefinition>
            {
                new FormDefinition
                {
                    Id = Guid.NewGuid(),
                    Title = "Formulario de Registro",
                    Components = new List<FormComponent>
                    {
                        new FormComponent
                        {
                            Key = "name",
                            Type = "textfield",
                            Label = "Nombre Completo",
                            Placeholder = "Ingrese su nombre",
                            Validate = new FormValidation { Required = true }
                        },
                        new FormComponent
                        {
                            Key = "email",
                            Type = "email",
                            Label = "Correo Electrónico",
                            Placeholder = "ejemplo@correo.com",
                            Validate = new FormValidation { Required = true }
                        }
                    }
                },
                new FormDefinition
                {
                    Id = Guid.NewGuid(),
                    Title = "Encuesta de Satisfacción",
                    Components = new List<FormComponent>
                    {
                        new FormComponent
                        {
                            Key = "rating",
                            Type = "number",
                            Label = "Puntuación",
                            Placeholder = "1 a 5",
                            Validate = new FormValidation { Required = true }
                        },
                        new FormComponent
                        {
                            Key = "comments",
                            Type = "textarea",
                            Label = "Comentarios",
                            Placeholder = "Escribe tus comentarios",
                            Validate = new FormValidation { Required = false }
                        }
                    }
                },
                new FormDefinition
                {
                    Id = Guid.NewGuid(),
                    Title = "Formulario de Reserva",
                    Components = new List<FormComponent>
                    {
                        new FormComponent
                        {
                            Key = "date",
                            Type = "datetime",
                            Label = "Fecha de la Reserva",
                            Placeholder = "",
                            Validate = new FormValidation { Required = true }
                        },
                        new FormComponent
                        {
                            Key = "guests",
                            Type = "number",
                            Label = "Cantidad de personas",
                            Placeholder = "Ej: 2",
                            Validate = new FormValidation { Required = true }
                        }
                    }
                },
                new FormDefinition
                {
                    Id = Guid.NewGuid(),
                    Title = "Formulario de Contacto",
                    Components = new List<FormComponent>
                    {
                        new FormComponent
                        {
                            Key = "subject",
                            Type = "textfield",
                            Label = "Asunto",
                            Placeholder = "Motivo de contacto",
                            Validate = new FormValidation { Required = true }
                        },
                        new FormComponent
                        {
                            Key = "message",
                            Type = "textarea",
                            Label = "Mensaje",
                            Placeholder = "Escribe tu mensaje",
                            Validate = new FormValidation { Required = true }
                        }
                    }
                },
                new FormDefinition
                {
                    Id = Guid.NewGuid(),
                    Title = "Formulario de Dirección",
                    Components = new List<FormComponent>
                    {
                        new FormComponent
                        {
                            Key = "street",
                            Type = "textfield",
                            Label = "Calle",
                            Placeholder = "Ej: Calle 123",
                            Validate = new FormValidation { Required = true }
                        },
                        new FormComponent
                        {
                            Key = "city",
                            Type = "textfield",
                            Label = "Ciudad",
                            Placeholder = "Ej: Santo Domingo",
                            Validate = new FormValidation { Required = true }
                        }
                    }
                },
                new FormDefinition
                {
                    Id = Guid.NewGuid(),
                    Title = "Formulario de Empleo",
                    Components = new List<FormComponent>
                    {
                        new FormComponent
                        {
                            Key = "position",
                            Type = "textfield",
                            Label = "Puesto Solicitado",
                            Placeholder = "",
                            Validate = new FormValidation { Required = true }
                        },
                        new FormComponent
                        {
                            Key = "experience",
                            Type = "textarea",
                            Label = "Experiencia previa",
                            Placeholder = "",
                            Validate = new FormValidation { Required = false }
                        }
                    }
                },
                new FormDefinition
                {
                    Id = Guid.NewGuid(),
                    Title = "Formulario de Pago",
                    Components = new List<FormComponent>
                    {
                        new FormComponent
                        {
                            Key = "card",
                            Type = "textfield",
                            Label = "Número de Tarjeta",
                            Placeholder = "XXXX-XXXX-XXXX-XXXX",
                            Validate = new FormValidation { Required = true }
                        },
                        new FormComponent
                        {
                            Key = "cvv",
                            Type = "number",
                            Label = "CVV",
                            Placeholder = "XXX",
                            Validate = new FormValidation { Required = true }
                        }
                    }
                },
                new FormDefinition
                {
                    Id = Guid.NewGuid(),
                    Title = "Formulario de Inscripción",
                    Components = new List<FormComponent>
                    {
                        new FormComponent
                        {
                            Key = "studentName",
                            Type = "textfield",
                            Label = "Nombre del Estudiante",
                            Placeholder = "",
                            Validate = new FormValidation { Required = true }
                        },
                        new FormComponent
                        {
                            Key = "grade",
                            Type = "number",
                            Label = "Grado",
                            Placeholder = "",
                            Validate = new FormValidation { Required = true }
                        }
                    }
                },
                new FormDefinition
                {
                    Id = Guid.NewGuid(),
                    Title = "Formulario Médico",
                    Components = new List<FormComponent>
                    {
                        new FormComponent
                        {
                            Key = "symptoms",
                            Type = "textarea",
                            Label = "Síntomas",
                            Placeholder = "",
                            Validate = new FormValidation { Required = false }
                        },
                        new FormComponent
                        {
                            Key = "medications",
                            Type = "textfield",
                            Label = "Medicamentos actuales",
                            Placeholder = "",
                            Validate = new FormValidation { Required = false }
                        }
                    }
                },
                new FormDefinition
                {
                    Id = Guid.NewGuid(),
                    Title = "Formulario de Reclamación",
                    Components = new List<FormComponent>
                    {
                        new FormComponent
                        {
                            Key = "claimType",
                            Type = "select",
                            Label = "Tipo de Reclamo",
                            Placeholder = "",
                            Validate = new FormValidation { Required = true },
                            Data = new FormComponentData
                            {
                                Values = new List<FormComponentValue>
                                {
                                    new FormComponentValue { Label = "Opción A0", Value = "opcion_a0" },
                                    new FormComponentValue { Label = "Opción B0", Value = "opcion_b0" },
                                }
                            }
                        },
                        new FormComponent
                        {
                            Key = "details",
                            Type = "textarea",
                            Label = "Detalles",
                            Placeholder = "Describe el problema",
                            Validate = new FormValidation { Required = true },
                            
                        }
                    }
                }
            };

            await context.Forms.AddRangeAsync(forms);
            await context.SaveChangesAsync();
        }
    }
}