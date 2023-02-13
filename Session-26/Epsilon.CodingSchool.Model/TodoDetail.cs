namespace Epsilon.CodingSchool.Model;

public class TodoDetail : EntityBase
{
    public DateTime CreateDate { get; set; } = DateTime.Now;
    public DateTime? FinishDate { get; set; }

    // Relations
    public int TodoId { get; set; }
    public Todo Todo { get; set; } = null!;
}