using Heroes_of_Pelor.Domain.Common;
using System.Threading.Tasks;

namespace Heroes_of_Pelor.Application.Common.Interfaces
{
    public interface IDomainEventService
    {
        Task Publish(DomainEvent domainEvent);
    }
}
