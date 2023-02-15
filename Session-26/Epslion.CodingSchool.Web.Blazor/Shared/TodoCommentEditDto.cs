using Epsilon.CodingSchool.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epslion.CodingSchool.Web.Blazor.Shared
{
    public class TodoCommentEditDto
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int TodoId { get; set; }
        public List<TodoListDto> Todos { get; set; } = new();
    }
}
