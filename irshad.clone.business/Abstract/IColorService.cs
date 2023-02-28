using irshad.clone.core.Utilities.Results.Abstract;
using irshad.clone.entities.Concrete;
using System.Collections.Generic;

namespace irshad.clone.business.Abstract
{
    public interface IColorService
    {
        IResult Add(Color color);
        IResult Remove(int id);
        IResult Update(Color color);
        IDataResult<List<Color>> GetAll();
        IDataResult<Color> Get(int id);
    }
}
