using Heroes_of_Pelor.Application.Common.Mappings;
using Heroes_of_Pelor.Domain.Entities;
using System.Collections.Generic;

namespace Heroes_of_Pelor.Application.TodoLists.Queries.GetTodos
{
    public class TodoListDto : IMapFrom<TodoList>
    {
        public TodoListDto()
        {
            Items = new List<TodoItemDto>();
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public string Colour { get; set; }

        public IList<TodoItemDto> Items { get; set; }
    }
}
