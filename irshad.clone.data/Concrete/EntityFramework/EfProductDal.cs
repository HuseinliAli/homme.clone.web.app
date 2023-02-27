using irshad.clone.data.Abstract;
using irshad.clone.entities.Concrete;
using irshad.clone.entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace irshad.clone.data.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, HommeCloneContext>, IProductDal
    {
        public List<ProductDetailDto> GetByCatalogId(int id)
        {
            throw new NotImplementedException();
        }

        //public List<ProductDetailDto> GetByCatalogId(int id)
        //{
        //    using (HommeCloneContext context = new HommeCloneContext())
        //    {
        //        var result = GetProductDetails();
        //        result.Where()
        //    }
        //}

        public List<ProductDetailDto> GetProductDetails()
        {
            using (HommeCloneContext context = new HommeCloneContext())
            {
                var result = from p in context.Products
                             join ca in context.Catalogs
                             on p.CatalogId equals ca.CatalogId
                             join cat in context.Categories
                             on p.CategoryId equals cat.CategoryId
                             join sc in context.SubCategories
                             on p.SubCategoryId equals sc.SubCategoryId
                             join co in context.Colors
                             on p.ColorId equals co.ColorId
                             join m in context.Materials
                             on p.MaterialId equals m.MaterialId
                             join pImage in context.ProductImages
                             on p.ProductId equals pImage.ProductId
                             select new ProductDetailDto
                             {
                                 CatalogId = ca.CatalogId,
                                 CatalogName = ca.CatalogName,
                                 ColorId = co.ColorId,
                                 ColorName=co.ColorName,
                                 MaterialName = m.MaterialName,
                                 ProductId = p.ProductId,
                                 ProductName = p.ProductName,      
                                 Description = p.Description,
                                 ProductCode = p.ProductCode,
                                 Favorite = p.Favorite,
                                 Price = p.Price,
                                 Size=p.Size,
                                 ImagePath = pImage.ImagePath
                             };
                return result.ToList();             
            }
        }
    }
}
