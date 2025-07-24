using Microsoft.EntityFrameworkCore;
using DynamicFormBuilder.Data.Context;

using DynamicFormBuilder.Domain.Entities;
using DynamicFormBuilder.Domain.Interfaces;

namespace DynamicFormBuilder.Data.Repositories;

public class FormRepository(ApplicationDbContext context) : IFormRepository
{
    private readonly ApplicationDbContext _context = context;

    public async Task<FormDefinition> AddAsync(FormDefinition form)
    {
        form.Id = Guid.NewGuid();
        _context.Forms.Add(form);
        await _context.SaveChangesAsync();
        return form;
    }

    public async Task<FormDefinition?> UpdateAsync(Guid id, FormDefinition form)
    {
        var existing = await _context.Forms.FindAsync(id);
        if (existing is null) return null;

        existing.Title = form.Title;
        existing.Components = form.Components;

        await _context.SaveChangesAsync();

        return existing;
    }

    public async Task<FormDefinition?> GetByIdAsync(Guid id)
        => await _context.Forms.FindAsync(id);

    public async Task<IEnumerable<FormDefinition>> GetAllAsync()
        => await _context.Forms.ToListAsync();

    public IQueryable<FormDefinition> GetQueryable()
        => _context.Forms.AsQueryable();

    public async Task<int> CountAsync() => await _context.Forms.CountAsync();

    public async Task<IEnumerable<FormDefinition>> GetPagedAsync(int skip, int take)
        => await _context.Forms.Skip(skip).Take(take).ToListAsync();

}