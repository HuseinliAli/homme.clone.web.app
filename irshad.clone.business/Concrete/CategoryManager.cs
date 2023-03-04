using irshad.clone.business.Abstract;
using irshad.clone.business.Constants.SuccessMessages;
using irshad.clone.core.Utilities.Results.Abstract;
using irshad.clone.core.Utilities.Results.Concrete;
using irshad.clone.data.Abstract;
using irshad.clone.data.Concrete.EntityFramework;
using irshad.clone.entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace irshad.clone.business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal=categoryDal;
        }

        public IResult Add(Category category)
        {
            _categoryDal.Add(category);
            return new SuccessResult(CategorySuccess.Added);
        }

        public IDataResult<Category> Get(int id)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(c => c.CategoryId == id));
        }

        public IDataResult<List<Category>> GetAll()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll(), CategorySuccess.Listed);
        }

        public IDataResult<List<Category>> GetByCatalogId(int id)
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll(c => c.CatalogId ==id).ToList(), CategorySuccess.GotByCatalogId);
        }

        public IResult Remove(int id)
        {
            var delete = _categoryDal.Get(c => c.CategoryId == id);
            _categoryDal.Delete(delete);
            return new SuccessResult(CategorySuccess.Removed);
        }

        public IResult Update(Category catalog)
        {
            _categoryDal.Update(catalog);
            return new SuccessResult(CategorySuccess.Updated);
        }
    }
}
