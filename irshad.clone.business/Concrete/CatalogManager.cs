using irshad.clone.business.Abstract;
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
        ICatalogDal _catalogDal;

        public List<Catalog> GetAll()
        {
            return _catalogDal.GetAll();
        }
    }
}
