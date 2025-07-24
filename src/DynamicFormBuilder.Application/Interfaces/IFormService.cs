using DynamicFormBuilder.Application.DTOs;
using DynamicFormBuilder.Application.Common;

namespace DynamicFormBuilder.Application.Interfaces;

public interface IFormService
{
    Task<FormResponseDto> AddAsync(FormCreateDto dto);
    Task<FormResponseDto?> UpdateAsync(Guid id, FormUpdateDto dto);
    Task<FormResponseDto?> GetByIdAsync(Guid id);
    Task<IEnumerable<FormResponseDto>> GetAllAsync();
    Task<PagedResult<FormResponseDto>> GetPagedAsync(int page, int pageSize);
}

