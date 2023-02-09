using System.ComponentModel.DataAnnotations;

namespace Epsilon.CodingSchool.Web.Mvc.Models.Todo;

public class TodoEditDto
{
    public int Id { get; set; }

    [Display(Name = "Τίτλος")]
    [MaxLength(10, ErrorMessage = "Πολύ μεγάλος Τίτλος")]
    public string Title { get; set; } = null!;
}
