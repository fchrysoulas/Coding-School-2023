using Epsilon.CodingSchool.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epslion.CodingSchool.Web.Blazor.Shared
{
    public class TodoCommentEditDto
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Text { get; set; }

        [Required]  
        public int? TodoId { get; set; }
        public List<TodoListDto> Todos { get; set; } = new();
    }
}
