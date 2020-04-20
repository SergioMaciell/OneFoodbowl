using System.Collections.Generic; 
using System.ComponentModel.DataAnnotations;

namespace OneFoodBowl.web.Data.Entities
{
    public class Gender:IEntity 
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="{0} es requerido")]
        [Display(Name ="Género")]
        [MaxLength(9, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres")]
        public string Name { get; set; }
        public ICollection<Customer> Customers { get; set; }
        public ICollection<Nutritionist> Nutritionists { get; set; }
    }
}
