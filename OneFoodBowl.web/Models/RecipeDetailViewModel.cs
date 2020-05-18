using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using OneFoodBowl.web.Data.Entities;

namespace OneFoodBowl.web.Models
{
    public class RecipeDetailViewModel : RecipeDetail
    {
        public IFormFile ImageFile { get; set; }
        public int RecipeTypeId { get; set; }
        public IEnumerable<SelectListItem> RecipeTypes { get; set; }
    }
}
