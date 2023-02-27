using irshad.clone.entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace irshad.clone.business.Abstract
{
    public interface ICatalogService
    {
        List<Catalog> GetAll();
    }
}
