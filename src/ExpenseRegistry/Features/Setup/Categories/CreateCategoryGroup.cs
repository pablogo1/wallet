namespace ExpenseRegistry.Features.Setup.Categories;

using MassTransit;
using System.Threading.Tasks;

public sealed record CreateCategoryGroupCommand(string Name);

public class CreateCategoryGroupCommandConsumer : IConsumer<CreateCategoryGroupCommand>
{
    public Task Consume(ConsumeContext<CreateCategoryGroupCommand> context)
    {
        throw new NotImplementedException();
    }
}