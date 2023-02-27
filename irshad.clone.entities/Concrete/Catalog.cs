using irshad.clone.core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace irshad.clone.entities.Concrete
{
    public class Catalog : IEntity
    {
        public int CatalogId { get; set; }
        public string CatalogName { get; set; }
    }
}
