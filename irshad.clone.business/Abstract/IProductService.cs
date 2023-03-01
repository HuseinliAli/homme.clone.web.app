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
        IResult Remove(Product product);
        IResult Update(Product product);
        IDataResult<List<ProductDetailDto>> GetAll();
        IDataResult<List<ProductDetailDto>> GetByCatalogId(int id);
        IDataResult<List<ProductDetailDto>> GetByCategoryId(int id);
        IDataResult<List<ProductDetailDto>> GetBySubCategoryId(int id);
        IDataResult<List<ProductDetailDto>> GetByMaterialId(int id);
        IDataResult<List<ProductDetailDto>> GetByColorId(int id);
        IDataResult<List<ProductDetailDto>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<ProductDetailDto> GetById(int id);
    }
}
