using Heroes_of_Pelor.Application.Common.Interfaces;
using System;

namespace Heroes_of_Pelor.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
