using AutoMapper;

using DynamicFormBuilder.Domain.Entities;
using DynamicFormBuilder.Application.DTOs;

namespace DynamicFormBuilder.Application.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        // FormDefinition
        CreateMap<FormDefinition, FormDefinitionDto>().ReverseMap();
        CreateMap<FormDefinition, FormCreateDto>().ReverseMap();
        CreateMap<FormDefinition, FormUpdateDto>().ReverseMap();

        // FormComponent
        CreateMap<FormComponent, FormComponentDto>().ReverseMap();

        // FormValidation
        CreateMap<FormValidation, FormValidationDto>().ReverseMap();

        // FormComponentData
        CreateMap<FormComponentData, FormComponentDataDto>().ReverseMap();

        // FormComponentValue
        CreateMap<FormComponentValue, FormComponentValueDto>().ReverseMap();
    }
}