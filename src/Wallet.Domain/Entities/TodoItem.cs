namespace Wallet.Domain.Entities;

public class TodoItem : BaseAuditableEntity
{
    public TodoItem()
    {
        Title = String.Empty;
        IsComplete = false;
    }

    public string Title { get; set; }
    public bool IsComplete { get; set; }

    public void Complete()
    {
        IsComplete = true;
    }
}