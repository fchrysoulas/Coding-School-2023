using Epsilon.CodingSchool.Model;
using System.ComponentModel.DataAnnotations;

namespace Epsilon.CodingSchool.Web.Mvc.Models.Todo;

public class TodoCreateDto
{
    [Display(Name = "Τίτλος")]
    [MaxLength(10, ErrorMessage = "Πολύ μεγάλος Τίτλος")]
    public string Title { get; set; } = null!;

    public TodoType TodoType { get; set; }
}
