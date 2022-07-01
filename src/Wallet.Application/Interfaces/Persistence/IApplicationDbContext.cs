using Microsoft.EntityFrameworkCore;

using Wallet.Domain.Entities;

namespace Wallet.Application.Interfaces.Persistence;

public interface IApplicationDbContext
{
    DbSet<TodoItem> TodoItems { get; }

    public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
