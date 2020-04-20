using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OneFoodBowl.web.Data.Entities
{
    public class RecipeType : IEntity
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} es requerido")]
        [Display(Name = "Tipo de receta")]
        [MaxLength(20, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres")]
        public string Name { get; set; }
        public ICollection<CreatePlan> CreatePlans { get; set; }
    }
}
