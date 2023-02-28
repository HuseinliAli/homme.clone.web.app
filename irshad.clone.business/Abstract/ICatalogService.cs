using irshad.clone.core.Utilities.Results.Abstract;
using irshad.clone.entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace irshad.clone.business.Abstract
{
    public interface ICatalogService
    {
        IResult Add(Catalog catalog);
        IResult Remove(int id);
        IResult Update(Catalog catalog);
        IDataResult<List<Catalog>> GetAll();
        IDataResult<Catalog> Get(int id);
    }
}
