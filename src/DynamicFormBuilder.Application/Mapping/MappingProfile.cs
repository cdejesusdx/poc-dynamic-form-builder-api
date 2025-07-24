using AutoMapper;
using DynamicFormBuilder.Application.DTOs;
using DynamicFormBuilder.Domain.Entities;

namespace DynamicFormBuilder.Application.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<FormCreateDto, FormDefinition>();
        CreateMap<FormUpdateDto, FormDefinition>();
        CreateMap<FormDefinition, FormResponseDto>();

        CreateMap<FormComponentDto, FormComponent>().ReverseMap();
        CreateMap<FormValidationDto, FormValidation>().ReverseMap();
    }
}