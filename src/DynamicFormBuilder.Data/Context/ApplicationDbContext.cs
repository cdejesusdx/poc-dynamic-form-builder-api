using System.Text.Json;
using Microsoft.EntityFrameworkCore;

using DynamicFormBuilder.Domain.Entities;

namespace DynamicFormBuilder.Data.Context;

public class ApplicationDbContext : DbContext
{
    public DbSet<FormDefinition> Forms => Set<FormDefinition>();

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<FormDefinition>()
            .Property(f => f.Components)
            .HasConversion(
                v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null),
                v => JsonSerializer.Deserialize<List<FormComponent>>(v, (JsonSerializerOptions)null));
    }
}