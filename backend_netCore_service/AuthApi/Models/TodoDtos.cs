using System.ComponentModel.DataAnnotations;

namespace AuthApi.Models;

public class TodoCreate
{
    [Required]
    public required string Title { get; set; }
    public string? Description { get; set; }
    public Status Status { get; set; } = Status.BACKLOG;
    public DateTime? DueDate { get; set; }
    public string? Duration { get; set; }
}

public class TodoUpdate
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    public Status? Status { get; set; }
    public DateTime? DueDate { get; set; }
    public string? Duration { get; set; }
}

public class TodoResponse
{
    public IEnumerable<Todo> Items { get; set; } = new List<Todo>();
    public long Total { get; set; }
    public int Page { get; set; }
    public int Size { get; set; }
    public long Pages { get; set; }
}
