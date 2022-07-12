
using Wallet.Application.Interfaces;

namespace Wallet.Infrastructure.ApplicationServices
{
    internal class DateTimeService : IDateTimeService
    {
        public DateTime Now => DateTime.Now;

        public DateTime UtcNow => DateTime.UtcNow;

        public DateTime Today => DateTime.Today;
    }
}
