namespace OneFoodBowl.web.Data.Entities
{
    using System.ComponentModel.DataAnnotations;
    public class CreatePlan : IEntity
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} es requerido")]
        [Display(Name = "Género")]
        [MaxLength(25, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres")]
        public string Name { get; set; }
        public Recipe Recipe { get; set; }

    }
}
