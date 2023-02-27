using irshad.clone.core.DataAccess;
using irshad.clone.entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irshad.clone.data.Abstract
{
    public interface ICommentDal : IEntityRepository<Comment>
    {
    }
}
