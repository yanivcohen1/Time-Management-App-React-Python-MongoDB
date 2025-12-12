using AuthApi.Models;

namespace AuthApi.Services;

public interface ITodoService
{
    Task<TodoResponse> GetTodosAsync(string userId, int page, int size, string sortBy, bool sortDesc, Status? status, string? search, DateTime? dueDateStart, DateTime? dueDateEnd);
    Task<Todo> CreateTodoAsync(Todo todo);
    Task<Todo?> UpdateTodoAsync(string id, string userId, TodoUpdate update);
    Task<bool> DeleteTodoAsync(string id, string userId);
    Task<Dictionary<string, int>> GetStatusStatsAsync(string userId);
    Task<List<object>> GetWorkloadStatsAsync(string userId);
}
