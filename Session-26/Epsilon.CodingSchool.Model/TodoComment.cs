using System.ComponentModel.DataAnnotations;

namespace Epsilon.CodingSchool.Model;

public class TodoComment : EntityBase
{
    public TodoComment(string text)
    {
        Text = text;
    }

    [Required] public string Text { get; set; }

    // Relations
    public int TodoId { get; set; }
    public Todo Todo { get; set; } = null!;
}

