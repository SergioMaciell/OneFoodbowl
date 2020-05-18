namespace OneFoodBowl.web.Models
{
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using OneFoodBowl.web.Data.Entities;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class CustomerViewModel : Customer
    {
        [Display(Name = "Imagen")]
        public IFormFile ImageFile { get; set; }
        [Display(Name = "Género")]
        public int GenderId { get; set; }
        public IEnumerable<SelectListItem> Genders { get; set; }
    }
}
