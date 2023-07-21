using Business.Abstract;
using DataAccesss.Abstract;
using DataAccesss.Entities;
using DataAccesss.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UniversityManager : IUniversityManager
    {
        private readonly IUniversityDal _universityDal;

        public UniversityManager(IUniversityDal universityDal)
        {
            _universityDal = universityDal;
        }

        public void Add(University university)
        {
            university.CreatedAt = DateTime.Now;
           _universityDal.Add(university);
        }

        public University GetById(int id)
        {
            Expression<Func<University, bool>> filter = x => x.Id == id;
            return _universityDal.Get(filter);
        }

        public IList<UniversityListDto> GetUniversityListManager()
        {
            var data = _universityDal.GetUniversityListDal();
            return data;
        }

        public IList<University> GetList()
        {
            var verilistele = _universityDal.GetActiveList();
            return verilistele;
        }

        public void Remove(University university)
        {
          _universityDal.Delete(university);
        }

        public void Update(University university)
        {
            university.UpdatedAt = DateTime.Now;
            _universityDal.Update(university);
        }
    }
}
