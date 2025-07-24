using DynamicFormBuilder.Domain.Entities;

namespace DynamicFormBuilder.Domain.Interfaces;

public interface IFormRepository
{
    Task<FormDefinition> AddAsync(FormDefinition form);
    Task<FormDefinition?> UpdateAsync(Guid id, FormDefinition form);

    Task<FormDefinition?> GetByIdAsync(Guid id);
    Task<IEnumerable<FormDefinition>> GetAllAsync();

    Task<int> CountAsync();
    IQueryable<FormDefinition> GetQueryable();
    Task<IEnumerable<FormDefinition>> GetPagedAsync(int skip, int take);


}