using irshad.clone.core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace irshad.clone.entities.Concrete
{
    public class Material : IEntity
    {
        public int MaterialId { get; set; }
        public string MaterialName { get; set; }
    }
}
