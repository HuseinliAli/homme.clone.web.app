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
    public class SubCategoryManager: ISubCategoryService
    {
        private ISubCategoryDal _subCategoryDal;

        public SubCategoryManager(ISubCategoryDal subCategoryDal)
        {
            _subCategoryDal=subCategoryDal;
        }


        public IResult Add(SubCategory subCategory)
        {
            _subCategoryDal.Add(subCategory);
            return new SuccessResult(SubCategorySuccess.Added);
        }

        public IDataResult<SubCategory> Get(int id)
        {
            return new SuccessDataResult<SubCategory>(_subCategoryDal.Get(c => c.SubCategoryId == id));
        }

        public IDataResult<List<SubCategory>> GetAll()
        {
            return new SuccessDataResult<List<SubCategory>>(_subCategoryDal.GetAll(), SubCategorySuccess.Listed);
        }

        public IDataResult<List<SubCategory>> GetByCategoryId(int id)
        {
            return new SuccessDataResult<List<SubCategory>>(_subCategoryDal.GetAll(sc=>sc.CategoryId ==id).ToList(), SubCategorySuccess.GotByCategoryId);
        }

        public IResult Remove(int id)
        {
            var delete = _subCategoryDal.Get(c => c.SubCategoryId == id);
            _subCategoryDal.Delete(delete);
            return new SuccessResult(SubCategorySuccess.Removed);
        }

        public IResult Update(SubCategory subCategory)
        {
            _subCategoryDal.Update(subCategory);
            return new SuccessResult(SubCategorySuccess.Updated);
        }
    }
}
