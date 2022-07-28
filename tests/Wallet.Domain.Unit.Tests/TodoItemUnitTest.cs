namespace Wallet.Domain.Unit.Tests;

using Wallet.Domain.Entities;

public class TodoItemUnitTest
{
    [Fact]
    public void Complete_Should_Set_Completed_Flag_To_True()
    {
        TodoItem todoItem = new TodoItem();

        todoItem.Complete();

        todoItem.IsComplete.Should().BeTrue();
    }
}