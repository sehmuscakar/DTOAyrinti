using DataAccesss.Entities;
using DataAccesss.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUniversityManager
    {
        IList<UniversityListDto> GetUniversityListManager();

          IList<University> GetList();

        void Add(University university);

        void Update(University university);

        void Remove(University university);

        University GetById(int id);


    }
}
