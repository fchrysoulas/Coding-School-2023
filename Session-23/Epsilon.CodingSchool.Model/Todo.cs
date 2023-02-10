using System.ComponentModel.DataAnnotations;

namespace Epsilon.CodingSchool.Model;

public class Todo : EntityBase
{
    public Todo(string title)
    {
        Title = title;
        Comments = new List<TodoComment>();
        Detail = new TodoDetail();
    }

    [Required]
    public string Title { get; set; }

    public bool Finished { get; set; }

    public TodoType TodoType { get; set; }

    // Relations
    public TodoDetail Detail { get; set; }

    public ICollection<TodoComment> Comments { get; set; }
}

public enum TodoType
{
    Other,
    Shopping,
    Cook
}
