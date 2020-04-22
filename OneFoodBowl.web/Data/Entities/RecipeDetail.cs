namespace OneFoodBowl.web.Data.Entities
{
    using System.ComponentModel.DataAnnotations;
    public class RecipeDetail : IEntity
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} es requerido")]
        [Display(Name = "Intrucciones")]
        [MaxLength(1000, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres")]
        public string Instruction { get; set; }

        [Display(Name = "Foto platillo")]
        public string IamgeUrl { get; set; }

        [Required(ErrorMessage = "{0} es requerido")]
        [Display(Name = "Ingredientes")]
        [MaxLength(1000, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres")]
        public string Ingredients { get; set; }
        public Recipe Recipe { get; set; }
    }
}
