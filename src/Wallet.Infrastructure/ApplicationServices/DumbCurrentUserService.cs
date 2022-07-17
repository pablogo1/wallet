using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Wallet.Application.Interfaces;

namespace Wallet.Infrastructure.ApplicationServices
{
    internal class DumbCurrentUserService : ICurrentUserService
    {
        public string UserId => "userX";
    }
}
