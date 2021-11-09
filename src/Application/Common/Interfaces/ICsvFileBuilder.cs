using Heroes_of_Pelor.Application.TodoLists.Queries.ExportTodos;
using System.Collections.Generic;

namespace Heroes_of_Pelor.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
    }
}
