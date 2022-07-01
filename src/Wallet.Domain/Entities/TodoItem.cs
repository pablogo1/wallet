namespace Wallet.Domain.Entities;

public class TodoItem : BaseAuditableEntity
{
    public TodoItem()
    {
        Title = String.Empty;
    }

    public string Title { get; set; }
}