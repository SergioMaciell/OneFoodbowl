using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OneFoodBowl.web.Data.Entities
{
    public class Recipe : IEntity
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} es requerido")]
        [Display(Name = "Receta")]
        [MaxLength(30, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres")]
        public string Name { get; set; }
        [Required(ErrorMessage = "{0} es requerido")]
        [Display(Name = "Breve descripción")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres")]
        public string Description { get; set; }
        [Display(Name = "Foto receta")]
        public string ImageUrl { get; set; }

        public RecipeType RecipeType { get; set; }
    }
}
