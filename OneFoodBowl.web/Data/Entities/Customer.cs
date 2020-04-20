

namespace OneFoodBowl.web.Data.Entities
{
    using System;
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string ImageUrl { get; set; }
        public string FullName => $"{LastName} {FirstName}";
        public Gender Gender { get; set; }
    }
}
