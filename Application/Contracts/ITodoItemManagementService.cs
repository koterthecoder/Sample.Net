using Domain;

namespace Application.Contracts
{
    public interface ITodoItemManagementService
    {
        TodoItem GetByAccountId(long accountId);
        TodoItem Upsert(TodoItem item);
    }
}
