using irshad.clone.data.Abstract;
using irshad.clone.entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace irshad.clone.data.Concrete.EntityFramework
{
    public class EfMaterialDal : EfEntityRepositoryBase<Material, HommeCloneContext>, IMaterialDal
    {
    }
}
