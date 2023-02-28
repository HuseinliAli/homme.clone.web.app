using irshad.clone.business.Abstract;
using irshad.clone.business.Constants.SuccessMessages;
using irshad.clone.core.Utilities.Results.Abstract;
using irshad.clone.core.Utilities.Results.Concrete;
using irshad.clone.data.Abstract;
using irshad.clone.entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irshad.clone.business.Concrete
{
    public class CommentManager : ICommentService
    {
        private ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal=commentDal;
        }

        public IResult Activate(Comment comment)
        {
            _commentDal.Update(comment);
            return new SuccessResult(CommentSuccess.StatusActivated);
        }

        public IResult Add(Comment comment)
        {
            _commentDal.Add(comment);
            return new SuccessResult(CommentSuccess.Added);
        }

        public IDataResult<List<Comment>> GetAll()
        {
            return new SuccessDataResult<List<Comment>>(
                _commentDal.GetAll(), CommentSuccess.Listed);
        }

        public IDataResult<List<Comment>> GetCommentByProductId(int id)
        {
            return new SuccessDataResult<List<Comment>>(
                _commentDal.GetAll(c=>c.ProductId == id).ToList(), CommentSuccess.Listed);
        }

        public IResult Remove(int id)
        {
            var delete = _commentDal.Get(c=>c.CommentId==id);
            _commentDal.Delete(delete);
            return new SuccessResult(CommentSuccess.Removed);
        }
    }
}
