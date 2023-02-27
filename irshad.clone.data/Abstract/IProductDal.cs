using irshad.clone.core.DataAccess;
using irshad.clone.entities.Concrete;
using irshad.clone.entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace irshad.clone.data.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();
        List<ProductDetailDto> GetByCatalogId(int id);
    }
}
