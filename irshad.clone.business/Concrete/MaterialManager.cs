using irshad.clone.business.Abstract;
using irshad.clone.business.Constants.SuccessMessages;
using irshad.clone.core.Utilities.Results.Abstract;
using irshad.clone.core.Utilities.Results.Concrete;
using irshad.clone.data.Abstract;
using irshad.clone.entities.Concrete;
using System.Collections.Generic;

namespace irshad.clone.business.Concrete
{
    public class MaterialManager : IMaterialService
    {
        private IMaterialDal _materialDal;

        public MaterialManager(IMaterialDal materialDal)
        {
            _materialDal=materialDal;
        }

        public IResult Add(Material material)
        {
            _materialDal.Add(material);
            return new SuccessResult(MaterialSuccess.Added);
        }

        public IDataResult<Material> Get(int id)
        {
            return new SuccessDataResult<Material>(_materialDal.Get(m => m.MaterialId==id));
        }

        public IDataResult<List<Material>> GetAll()
        {
            return new SuccessDataResult<List<Material>>(_materialDal.GetAll(), MaterialSuccess.Listed);
        }

        public IResult Remove(int id)
        {
            var delete = _materialDal.Get(m => m.MaterialId ==id);
            _materialDal.Delete(delete);
            return new SuccessResult(MaterialSuccess.Removed);
        }

        public IResult Update(Material material)
        {
            _materialDal.Update(material);
            return new SuccessResult(MaterialSuccess.Updated);
        }
    }
}
