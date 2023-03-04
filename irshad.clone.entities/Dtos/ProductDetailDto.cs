using irshad.clone.core.Entities;
using irshad.clone.entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace irshad.clone.entities.Dtos
{
    public class ProductDetailDto : IDto
    {
        public int ProductId { get; set; }
        public int CatalogId { get; set; }
        public int ColorId { get; set; }
        public int CategoryId { get; set; }
        public int? SubCategoryId { get; set; }
        public int MaterialId { get; set; }
        public string CatalogName { get; set; }
        public string CategoryName { get; set; }
        public string SubCategoryName { get; set; }
        public string ProductName { get; set; }
        public string ColorName { get; set; }
        public string MaterialName { get; set; }
        public int ProductCode { get; set; }
        public decimal Price { get; set; }
        public string Size { get; set; }
        public string Description { get; set; }
        public bool Favorite { get; set; }
        public DateTime DateAdded { get; set; }
        public List<ProductImage> ImagesPath { get; set; }
    }
}
