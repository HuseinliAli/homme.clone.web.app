using irshad.clone.business.Abstract;
using irshad.clone.business.Constants;
using irshad.clone.core.Utilities.Helpers;
using irshad.clone.core.Utilities.Results.Abstract;
using irshad.clone.core.Utilities.Results.Concrete;
using irshad.clone.data.Abstract;
using irshad.clone.entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace irshad.clone.business.Concrete
{
    public class ProductImageManager : IProductImageService
    {
        private IProductImageDal _productImageDal;
        private IFileHelper _fileHelper;
        public ProductImageManager(IProductImageDal productImageDal, IFileHelper fileHelper)
        {
            _productImageDal=productImageDal;
            _fileHelper=fileHelper;
        }

        public IResult Add(IFormFile image, ProductImage productImage)
        {
            productImage.ImagePath = _fileHelper.Upload(image, PathConstants.ImagesPath);
            _productImageDal.Add(productImage);
            return new SuccessResult();
        }

        public IResult Delete(ProductImage productImage)
        {
            _fileHelper.Delete(PathConstants.ImagesPath + productImage.ImagePath);
            _productImageDal.Delete(productImage);
            return new SuccessResult();
        }

        public IDataResult<List<ProductImage>> GetAll()
        {
            return new SuccessDataResult<List<ProductImage>>(_productImageDal.GetAll());
        }

        public IDataResult<List<ProductImage>> GetAllImagesByProductId(int id)
        {
            return new SuccessDataResult<List<ProductImage>>
                (_productImageDal.GetAll(pi => pi.ProductId == id).ToList());
        }

        public IDataResult<ProductImage> GetById(int id)
        {
            return new SuccessDataResult<ProductImage>(_productImageDal.Get(p=>p.ProductImageId == id));
        }

        public IResult Update(IFormFile formFile, ProductImage productImage)
        {
            productImage.ImagePath = _fileHelper
                    .Update(formFile,
                            PathConstants.ImagesPath + productImage.ImagePath,
                            PathConstants.ImagesPath);
            _productImageDal.Update(productImage);
            return new SuccessResult();
        }
    }
}
