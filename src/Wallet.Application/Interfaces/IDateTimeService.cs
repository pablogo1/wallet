namespace Wallet.Application.Interfaces;

public interface IDateTimeService
{
    public DateTime Now { get; }
    public DateTime UtcNow { get; }
    public DateTime Today { get; }
}
