using irshad.clone.data.Abstract;
using irshad.clone.entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irshad.clone.data.Concrete.EntityFramework
{
    public class EfCommentDal : EfEntityRepositoryBase<Comment, HommeCloneContext>, ICommentDal
    {
    }
}
