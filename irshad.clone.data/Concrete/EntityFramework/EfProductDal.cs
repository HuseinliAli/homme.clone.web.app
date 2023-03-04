using irshad.clone.data.Abstract;
using irshad.clone.entities.Concrete;
using irshad.clone.entities.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace irshad.clone.data.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, HommeCloneContext>, IProductDal
    {

        public List<ProductDetailDto> GetProductsDetails()
        {
            using (HommeCloneContext context = new HommeCloneContext())
            {
                var result = from p in context.Products
                             join ca in context.Catalogs on p.CatalogId equals ca.CatalogId
                             join cat in context.Categories on p.CategoryId equals cat.CategoryId
                             join sc in context.SubCategories on p.SubCategoryId equals sc.SubCategoryId
                             join co in context.Colors on p.ColorId equals co.ColorId
                             join m in context.Materials on p.MaterialId equals m.MaterialId
                             join pI in context.ProductImages on p.ProductId equals pI.ProductId
                             select new ProductDetailDto
                             {
                                 ProductId = p.ProductId,
                                 CatalogId = ca.CatalogId,
                                 CatalogName = ca.CatalogName,
                                 ColorId = co.ColorId,
                                 ColorName=co.ColorName,
                                 MaterialName = m.MaterialName,
                                 ProductName = p.ProductName,      
                                 Description = p.Description,
                                 ProductCode = p.ProductCode,
                                 Favorite = p.Favorite,
                                 Price = p.Price,
                                 Size=p.Size,
                                 ImagesPath = context.ProductImages.Where(query=>query.ProductId == p.ProductId).ToList(),
                                 CategoryId = cat.CategoryId,
                                 CategoryName =cat.CategoryName,
                                 MaterialId=m.MaterialId,
                                 SubCategoryId = sc.SubCategoryId,
                                 SubCategoryName = sc.SubCategoryName,
                                 DateAdded = p.DateAdded
                             };
                var list = result.ToList();
                var distinct = list.GroupBy(id => id.ProductId).Select(p => p.FirstOrDefault()).ToList();
                return distinct;        
            }
        }
    }
}
