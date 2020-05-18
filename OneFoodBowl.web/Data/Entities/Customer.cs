namespace OneFoodBowl.web.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Customer : IEntity
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} es requerido")]
        [Display(Name = "Nombres")]
        [MaxLength(30, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "{0} es requerido")]
        [Display(Name = "Apellidos")]
        [MaxLength(30, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres")]       
        public string LastName { get; set; }

        [Required(ErrorMessage = "{0} es requerido")]
        [Display(Name = "Dirección")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres")]       
        public string Address { get; set; }

        [Required(ErrorMessage = "{0} es requerido")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd/mm/yyyy}", ApplyFormatInEditMode =false)]
        [Display(Name ="Fecha de nacimiento")]       
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "{0} es requerido")]
        [Display(Name = "Estatura")]
        //[MaxLength(4, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres")]        
        public double Height { get; set; }

        [Required(ErrorMessage = "{0} es requerido")]
        [Display(Name = "Peso")]
        //[MaxLength(5, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres")]       
        public double Weight { get; set; }

        [Display(Name = "Fotografía")]       
        public string ImageUrl { get; set; }

        [Display(Name = "Nombre completo")]       
        public string FullName => $"{LastName} {FirstName}";
        
        public Gender Gender { get; set; }
        //public User User { get; set; }
    }
}
