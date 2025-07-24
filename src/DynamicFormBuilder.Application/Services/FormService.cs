using AutoMapper;

using DynamicFormBuilder.Domain.Entities;
using DynamicFormBuilder.Application.DTOs;
using DynamicFormBuilder.Domain.Interfaces;
using DynamicFormBuilder.Application.Common;
using DynamicFormBuilder.Application.Interfaces;

namespace DynamicFormBuilder.Application.Services;

public class FormService : IFormService
{
    private readonly IFormRepository _formRepository;
    private readonly IMapper _mapper;

    public FormService(IFormRepository formRepository, IMapper mapper)
    {
        _formRepository = formRepository;
        _mapper = mapper;
    }

    public async Task<FormResponseDto> AddAsync(FormCreateDto dto)
    {
        var entity = _mapper.Map<FormDefinition>(dto);
        var created = await _formRepository.AddAsync(entity);
        return _mapper.Map<FormResponseDto>(created);
    }

    public async Task<FormResponseDto?> UpdateAsync(Guid id, FormUpdateDto dto)
    {
        var existing = await _formRepository.GetByIdAsync(id);
        if (existing == null)
            return null;

        _mapper.Map(dto, existing);
        await _formRepository.UpdateAsync(id, existing);
        return _mapper.Map<FormResponseDto>(existing);
    }

    public async Task<FormResponseDto?> GetByIdAsync(Guid id)
    {
        var entity = await _formRepository.GetByIdAsync(id);
        return entity == null ? null : _mapper.Map<FormResponseDto>(entity);
    }

    public async Task<IEnumerable<FormResponseDto>> GetAllAsync()
    {
        var all = await _formRepository.GetAllAsync();
        return _mapper.Map<IEnumerable<FormResponseDto>>(all);
    }

    public async Task<PagedResult<FormResponseDto>> GetPagedAsync(int page, int pageSize)
    {
        var skip = (page - 1) * pageSize;
        var items = await _formRepository.GetPagedAsync(skip, pageSize);
        var totalCount = await _formRepository.CountAsync();

        return new PagedResult<FormResponseDto>
        {
            TotalCount = totalCount,
            Items = _mapper.Map<IEnumerable<FormResponseDto>>(items)
        };
    }
}
