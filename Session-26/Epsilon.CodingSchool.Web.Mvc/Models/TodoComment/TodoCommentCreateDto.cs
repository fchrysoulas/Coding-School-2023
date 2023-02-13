﻿using Microsoft.AspNetCore.Mvc.Rendering;

namespace Epsilon.CodingSchool.Web.Mvc.Models.TodoComment
{
    public class TodoCommentCreateDto
    {
        public string Text { get; set; } = null!;
        public int TodoId { get; set; }
        public List<SelectListItem> Todos { get; } = new List<SelectListItem>();
    }
}
