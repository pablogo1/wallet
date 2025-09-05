namespace ExpenseRegistry;

using ExpenseRegistry.Features.Setup.Categories;
using ExpenseRegistry.Persistence;

using MassTransit;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

public static class ConfigureServices
{
    public static void AddExpenseRegistry(this IServiceCollection services)
    {
        services.AddDbContext<ExpenseRegistryDbContext>(options =>
        {
            options.UseSqlite("Data Source=./expense-registry.db");
        });

        services.AddMediator(cfg =>
        {
            cfg.AddConsumer<CreateCategoryGroupCommandConsumer>();
        });

    }
}
