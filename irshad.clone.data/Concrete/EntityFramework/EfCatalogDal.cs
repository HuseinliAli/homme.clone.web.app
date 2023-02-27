using irshad.clone.data.Abstract;
using irshad.clone.entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace irshad.clone.data.Concrete.EntityFramework
{
    public class EfCatalogDal : EfEntityRepositoryBase<Catalog, HommeCloneContext> ,ICatalogDal
    {     
    }
}
