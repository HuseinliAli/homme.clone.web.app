using irshad.clone.core.Utilities.Results.Abstract;
using irshad.clone.entities.Concrete;
using System.Collections.Generic;

namespace irshad.clone.business.Abstract
{
    public interface ICommentService
    {
        IResult Add(Comment comment);
        IResult Remove(int id);
        IResult Activate(Comment comment);
        IDataResult<List<Comment>> GetAll();
        IDataResult<List<Comment>> GetCommentByProductId(int id);
    }
}
