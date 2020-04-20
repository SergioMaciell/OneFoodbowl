﻿using System.Collections.Generic;

namespace OneFoodBowl.web.Data.Entities
{
    public class Gender:IEntity 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Customer> Customers { get; set; }
    }
}
