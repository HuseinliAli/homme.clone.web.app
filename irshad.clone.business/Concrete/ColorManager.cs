using irshad.clone.business.Abstract;
using irshad.clone.business.Constants.SuccessMessages;
using irshad.clone.core.Utilities.Results.Abstract;
using irshad.clone.core.Utilities.Results.Concrete;
using irshad.clone.data.Abstract;
using irshad.clone.data.Concrete.EntityFramework;
using irshad.clone.entities.Concrete;
using System.Collections.Generic;

namespace irshad.clone.business.Concrete
{
    public class ColorManager : IColorService
    {
        private IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal=colorDal;
        }

        public IResult Add(Color material)
        {
            _colorDal.Add(material);
            return new SuccessResult(ColorSuccess.Added);
        }

        public IDataResult<Color> Get(int id)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(c => c.ColorId==id));
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(), ColorSuccess.Listed);
        }

        public IResult Remove(int id)
        {
            var delete = _colorDal.Get(c =>c.ColorId ==id);
            _colorDal.Delete(delete);
            return new SuccessResult(ColorSuccess.Removed);
        }

        public IResult Update(Color color)
        {
            _colorDal.Update(color);
            return new SuccessResult(ColorSuccess.Updated);
        }
    }
}
