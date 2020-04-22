using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using OneFoodBowl.web.Data;
using System.Collections.Generic;

namespace OneFoodBowl.web.Models
{
    public class NutritionistViewModel : Nutritionist
    {
        public IFormFile ImageFile { get; set; }
        public int GenderId { get; set; }
        public IEnumerable<SelectListItem> Genders { get; set; }
    }
}
