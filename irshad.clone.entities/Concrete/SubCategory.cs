using irshad.clone.core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace irshad.clone.entities.Concrete
{
    public class SubCategory : IEntity
    {
        public int SubCategoryId { get; set; }
        public int CategoryId { get; set; }
        public string SubCategoryName { get; set; }
    }
}
