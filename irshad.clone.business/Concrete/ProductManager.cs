using irshad.clone.business.Abstract;
using irshad.clone.business.Constants;
using irshad.clone.business.Constants.SuccessMessages;
using irshad.clone.core.Utilities.Results.Abstract;
using irshad.clone.core.Utilities.Results.Concrete;
using irshad.clone.data.Abstract;
using irshad.clone.data.Concrete.EntityFramework;
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
            return new SuccessResult(ProductSuccess.Added);
        }

        public IDataResult<List<Product>> GetAll()
        {
            return new SuccessDataResult<List<Product>> (_productDal.GetAll(), ProductSuccess.Listed);
        }

        public IDataResult<List<ProductDetailDto>> GetAllWithImages()
        {
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductsDetails(), ProductSuccess.Listed);
        }

        public IDataResult<List<ProductDetailDto>> GetByCatalogId(int id)
        {
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductsDetails().Where(p=>p.CatalogId == id).ToList(), ProductSuccess.Listed);
        }

        public IDataResult<List<ProductDetailDto>> GetByCategoryId(int id)
        {
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductsDetails().Where(p => p.CategoryId == id).ToList(), ProductSuccess.Listed);
        }

        public IDataResult<List<ProductDetailDto>> GetByColorId(int id)
        {
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductsDetails().Where(p => p.ColorId == id).ToList(), ProductSuccess.Listed);
        }

        public IDataResult<ProductDetailDto> GetById(int id)
        {
            return new SuccessDataResult<ProductDetailDto>(_productDal.GetProductsDetails().FirstOrDefault(p => p.ProductId==id), ProductSuccess.Listed);
        }

        public IDataResult<List<ProductDetailDto>> GetByMaterialId(int id)
        { 
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductsDetails().Where(p=>p.MaterialId == id).ToList(), ProductSuccess.Listed);
        }

        public IDataResult<List<ProductDetailDto>> GetBySubCategoryId(int id)
        {
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductsDetails().Where(p => p.SubCategoryId == id).ToList(), ProductSuccess.Listed);
        }

        public IDataResult<List<ProductDetailDto>> GetByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductsDetails().Where(p=>p.Price >=min && p.Price<=max).ToList(), ProductSuccess.Listed);
        }

        public IResult Remove(int id)
        {
            var delete = _productDal.Get(c => c.ProductId == id);
            _productDal.Delete(delete);
            return new SuccessResult(ProductSuccess.Removed);
        }

        public IResult Update(Product product)
        {
            _productDal.Update(product);
            return new SuccessResult(ProductSuccess.Updated);
        }
    }
}
