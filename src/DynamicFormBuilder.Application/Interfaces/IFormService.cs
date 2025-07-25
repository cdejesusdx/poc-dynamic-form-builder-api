using DynamicFormBuilder.Application.DTOs;
using DynamicFormBuilder.Application.Common;

namespace DynamicFormBuilder.Application.Interfaces;

public interface IFormService
{
    Task<FormDefinitionDto> AddAsync(FormCreateDto dto);
    Task<FormDefinitionDto?> UpdateAsync(Guid id, FormUpdateDto dto);
    Task<FormDefinitionDto?> GetByIdAsync(Guid id);
    Task<IEnumerable<FormDefinitionDto>> GetAllAsync();
    Task<PagedResult<FormDefinitionDto>> GetPagedAsync(int page, int pageSize);
}

