using irshad.clone.core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace irshad.clone.entities.Concrete
{
    public class Category : IEntity
    {
        public int CategoryId { get; set; }
        public int CatalogId { get; set; }
        public string CategoryName { get; set; }
    }
}
