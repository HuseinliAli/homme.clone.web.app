using irshad.clone.core.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace irshad.clone.entities.Concrete
{
    public class ProductImage : IEntity
    {
        public int ProductImageId { get; set; }
        public int ProductId { get; set; }
        public string? ImagePath { get; set; }

        public Product Product { get; set; }
    }
}
