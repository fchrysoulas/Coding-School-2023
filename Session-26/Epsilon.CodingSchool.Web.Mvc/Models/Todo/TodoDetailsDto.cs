using System.ComponentModel.DataAnnotations;

namespace Epsilon.CodingSchool.Web.Mvc.Models.Todo;

public class TodoDetailsDto
{
    public int Id { get; set; }

    [Display(Name = "Τίτλος")]
    [MaxLength(10, ErrorMessage = "Πολύ μεγάλος Τίτλος")]
    public string Title { get; set; } = null!;

    public bool Finished { get; set; }

    public DateTime CreateDate { get; set; }
    public DateTime? FinishDate { get; set; }

    public List<Epsilon.CodingSchool.Model.TodoComment> Comments { get; set; } = new List<Epsilon.CodingSchool.Model.TodoComment>();
}