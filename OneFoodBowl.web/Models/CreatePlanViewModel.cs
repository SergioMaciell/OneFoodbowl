using Microsoft.AspNetCore.Mvc.Rendering;
using OneFoodBowl.web.Data.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OneFoodBowl.web.Models
{
    public class CreatePlanViewModel : CreatePlan
    {
        [Display(Name = "Género")]
        public int RecipeDetailId { get; set; }
        public IEnumerable<SelectListItem> RecipeDetails { get; set; }
    }
}
