﻿using ExpenseRegistry.Domain;

using Microsoft.EntityFrameworkCore;

namespace ExpenseRegistry.Persistence;
internal class ExpenseRegistryDbContext : DbContext
{
    public DbSet<ExpenseRecord> ExpenseRecords => Set<ExpenseRecord>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
