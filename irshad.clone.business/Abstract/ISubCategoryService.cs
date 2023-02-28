using irshad.clone.core.Utilities.Results.Abstract;
using irshad.clone.entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace irshad.clone.business.Abstract
{
    public interface ISubCategoryService
    {
        IResult Add(SubCategory subCategory);
        IResult Remove(int id);
        IResult Update(SubCategory subCategory);
        IDataResult<List<SubCategory>> GetAll();
        IDataResult<SubCategory> Get(int id);
    }
}
