namespace ExpenseRegistry.Features.Setup.Categories;

using MassTransit;
using System.Threading.Tasks;

public sealed record CreateCategoryGroup(string Name);

public class CreateCategoryGroupCommandConsumer : IConsumer<CreateCategoryGroup>
{
    public async Task Consume(ConsumeContext<CreateCategoryGroup> context)
    {
        await context.RespondAsync<NewCategoryGroupViewModel>(new NewCategoryGroupViewModel
        {
            Name = context.Message.Name
        });
    }
}