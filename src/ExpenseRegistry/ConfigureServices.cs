using ExpenseRegistry.Persistence;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ExpenseRegistry;
public static class ConfigureServices
{
    public static void AddExpenseRegistry(this IServiceCollection services)
    {
        services.AddDbContext<ExpenseRegistryDbContext>(options =>
        {
            options.UseSqlite("Data Source=./expense-registry.db");
        });
    }
}
