using irshad.clone.business.Abstract;
using irshad.clone.business.Constants;
using irshad.clone.business.Constants.SuccessMessages;
using irshad.clone.core.Utilities.Results.Abstract;
using irshad.clone.core.Utilities.Results.Concrete;
using irshad.clone.data.Abstract;
using irshad.clone.entities.Concrete;
using irshad.clone.entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace irshad.clone.business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal=productDal;
        }

        public IResult Add(Product product)
        {
            _productDal.Add(product);
            return new SuccessResult(ProductSuccess.Added);
        }

        public IDataResult<List<ProductDetailDto>> GetAll()
        {
            return new SuccessDataResult<List<ProductDetailDto>>(
                _productDal.GetProductDetails(), ProductSuccess.Listed);
        }

        public IDataResult<List<ProductDetailDto>> GetByCatalogId(int id)
        {
            throw new NotImplementedException();
        }

        //public IDataResult<List<ProductDetailDto>> GetByCatalogId(int id)
        //{
        //    return new SuccessDataResult<List<ProductDetailDto>>(
        //       _productDal.GetAll(), ProductSuccess.Listed);
        //}

        public IDataResult<List<ProductDetailDto>> GetByCategoryId(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<ProductDetailDto>> GetByColorId(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<ProductDetailDto> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<ProductDetailDto>> GetByMaterialId(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<ProductDetailDto>> GetBySubCategoryId(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<ProductDetailDto>> GetByUnitPrice(decimal min, decimal max)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public IResult Remove(Product product)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
