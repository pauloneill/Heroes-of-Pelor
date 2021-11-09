using Heroes_of_Pelor.Application.Common.Mappings;
using Heroes_of_Pelor.Domain.Entities;

namespace Heroes_of_Pelor.Application.TodoLists.Queries.ExportTodos
{
    public class TodoItemRecord : IMapFrom<TodoItem>
    {
        public string Title { get; set; }

        public bool Done { get; set; }
    }
}
