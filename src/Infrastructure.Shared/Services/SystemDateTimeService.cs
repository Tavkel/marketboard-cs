using marketboard.Application.Interfaces.Services;
using System;

namespace marketboard.Infrastructure.Shared.Services
{
    public class SystemDateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}