using Epsilon.CodingSchool.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epslion.CodingSchool.Web.Blazor.Shared
{
    public class TodoEditDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Finished { get; set; }
        public TodoType TodoType { get; set; }
    }
}
