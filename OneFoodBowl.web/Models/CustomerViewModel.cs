namespace OneFoodBowl.web.Models
{
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using OneFoodBowl.web.Data.Entities;
    using System.Collections.Generic;

    public class CustomerViewModel : Customer
    {
        public IFormFile ImageFile { get; set; }
        public int GenderId { get; set; }
        public IEnumerable<SelectListItem> Genders { get; set; }
    }
}
