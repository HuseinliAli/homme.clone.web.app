using irshad.clone.data.Abstract;
using irshad.clone.entities.Concrete;

namespace irshad.clone.data.Concrete.EntityFramework
{
    public class EfColorDal : EfEntityRepositoryBase<Color, HommeCloneContext>, IColorDal
    {
    }
}
