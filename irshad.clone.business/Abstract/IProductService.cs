using irshad.clone.core.Utilities.Results.Abstract;
using irshad.clone.entities.Concrete;
using irshad.clone.entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace irshad.clone.business.Abstract
{
    public interface IProductService
    {
        IResult Add(Product product);
        IResult Remove(int id);
        IResult Update(Product product);
        IDataResult<List<Product>> GetAll();
        IDataResult<List<ProductDetailDto>> GetAllWithImages();
        IDataResult<List<ProductDetailDto>> GetByCatalogId(int id);
        IDataResult<List<ProductDetailDto>> GetByCategoryId(int id);
        IDataResult<List<ProductDetailDto>> GetBySubCategoryId(int id);
        IDataResult<List<ProductDetailDto>> GetByMaterialId(int id);
        IDataResult<List<ProductDetailDto>> GetByColorId(int id);
        IDataResult<List<ProductDetailDto>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<ProductDetailDto> GetById(int id);
    }
}
