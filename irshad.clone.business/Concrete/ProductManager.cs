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
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal=productDal;
        }

        public IResult Add(Product product)
        {
            _productDal.Add(product);
            return new SuccessResult();
        }

        public IDataResult<List<ProductDetailDto>> GetAll()
        {
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductsDetails());
        }

        public IDataResult<List<ProductDetailDto>> GetByCatalogId(int id)
        {
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductsDetails().Where(p=>p.CatalogId == id).ToList());
        }

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
            return new SuccessDataResult<ProductDetailDto>(_productDal.GetProductsDetails().FirstOrDefault(p => p.ProductId==id));
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
