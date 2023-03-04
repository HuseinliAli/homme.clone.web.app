using irshad.clone.core.Utilities.Results.Abstract;
using irshad.clone.entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace irshad.clone.business.Abstract
{
    public interface ICategoryService
    {
        IResult Add(Category category);
        IResult Remove(int id);
        IResult Update(Category category);
        IDataResult<List<Category>> GetAll();
        IDataResult<Category> Get(int id);
        IDataResult<List<Category>> GetByCatalogId(int id);
    }
}
