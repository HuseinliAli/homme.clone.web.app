using irshad.clone.core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace irshad.clone.entities.Concrete
{
    public class Product : IEntity
    {
        public Product()
        {
            Favorite = false;
            DateAdded = DateTime.Now;
        }
        public int ProductId { get; set; }
        public int CatalogId { get; set; }
        public int CategoryId { get; set; }
        public int? SubCategoryId { get; set; }
        public int MaterialId { get; set; }
        public int ColorId { get; set; }
        public int ProductCode { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string Size { get; set; }
        public int UnistInStock { get; set; }
        public string Description { get; set; }
        public bool Favorite { get; set; }
        public DateTime DateAdded { get; set; }
        public List<ProductImage> ProductImages { get; set; }
    }
}
