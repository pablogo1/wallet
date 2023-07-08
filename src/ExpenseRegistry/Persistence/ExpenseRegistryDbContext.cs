using ExpenseRegistry.Domain;

using Microsoft.EntityFrameworkCore;

namespace ExpenseRegistry.Persistence;
internal class ExpenseRegistryDbContext : DbContext
{
    public ExpenseRegistryDbContext(DbContextOptions<ExpenseRegistryDbContext> options)
        : base(options)
    {
    }

    // public DbSet<ExpenseRecord> ExpenseRecords => Set<ExpenseRecord>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
