using irshad.clone.business.Abstract;
using irshad.clone.business.Constants.SuccessMessages;
using irshad.clone.core.Utilities.Results.Abstract;
using irshad.clone.core.Utilities.Results.Concrete;
using irshad.clone.data.Abstract;
using irshad.clone.entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace irshad.clone.business.Concrete
{
    public class CatalogManager : ICatalogService
    {
        private ICatalogDal _catalogDal;

        public CatalogManager(ICatalogDal catalogDal)
        {
            _catalogDal=catalogDal;
        }

        public IResult Add(Catalog catalog)
        {
            _catalogDal.Add(catalog);
            return new SuccessResult(CatalogSuccess.Added);
        }

        public IDataResult<Catalog> Get(int id)
        { 
            return new SuccessDataResult<Catalog>(_catalogDal.Get(c => c.CatalogId == id));
        }

        public IDataResult<List<Catalog>> GetAll()
        {
            return new SuccessDataResult<List<Catalog>>(_catalogDal.GetAll(),CatalogSuccess.Listed);
        }

        public IResult Remove(int id)
        {
            var delete = _catalogDal.Get(c => c.CatalogId == id);
            _catalogDal.Delete(delete);
            return new SuccessResult(CatalogSuccess.Removed);
        }

        public IResult Update(Catalog catalog)
        {
            _catalogDal.Update(catalog);
            return new SuccessResult(CatalogSuccess.Updated);
        }
    }
}
