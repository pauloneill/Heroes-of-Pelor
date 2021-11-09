using Heroes_of_Pelor.Domain.Common;
using Heroes_of_Pelor.Domain.Entities;

namespace Heroes_of_Pelor.Domain.Events
{
    public class TodoItemCompletedEvent : DomainEvent
    {
        public TodoItemCompletedEvent(TodoItem item)
        {
            Item = item;
        }

        public TodoItem Item { get; }
    }
}
