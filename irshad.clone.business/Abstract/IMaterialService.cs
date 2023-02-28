using irshad.clone.core.Utilities.Results.Abstract;
using irshad.clone.entities.Concrete;
using System.Collections.Generic;

namespace irshad.clone.business.Abstract
{
    public interface IMaterialService
    {
        IResult Add(Material material);
        IResult Remove(int id);
        IResult Update(Material material);
        IDataResult<List<Material>> GetAll();
        IDataResult<Material> Get(int id);
    }
}
