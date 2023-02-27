using irshad.clone.core.Utilities.Results.Abstract;
using irshad.clone.entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace irshad.clone.business.Abstract
{
    public interface IProductImageService
    {
        IResult Add(IFormFile formFile, ProductImage productImage);
        IResult Update(IFormFile formFile, ProductImage productImage);
        IResult Delete(ProductImage productImage);

        IDataResult<List<ProductImage>> GetAllImagesByProductId(int id);
        IDataResult<List<ProductImage>> GetAll();
        IDataResult<ProductImage> GetById(int id);
    }
}
