using irshad.clone.core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace irshad.clone.entities.Concrete
{
    public class Color : IEntity
    {
        public int ColorId { get; set; }
        public string ColorName { get; set; }
        public string ColorHexCode { get; set; }
    }
}
