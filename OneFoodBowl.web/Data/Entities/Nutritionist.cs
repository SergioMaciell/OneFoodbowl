﻿using OneFoodBowl.web.Data.Entities;

namespace OneFoodBowl.web.Data
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Nutritionist : IEntity
    {
        public int Id { get; set; }
        public DateTime HireDate { get; set; }

        [Required(ErrorMessage = "{0} es requerido")]
        [Display(Name = "Nombres")]
        [MaxLength(30, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "{0} es requerido")]
        [Display(Name = "Apellidos")]
        [MaxLength(30, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "{0} es requerido")]
        [Display(Name = "Nombres")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres")]
        public string Address { get; set; }

        [Display(Name = "Fotografía")]
        public string ImageUrl { get; set; }

        [Display(Name = "Nombre completo")]
        public string FullName => $"{LastName} {FirstName}";

        public Gender Gender { get; set; }

        //public User User { get; set; }
    }
}
