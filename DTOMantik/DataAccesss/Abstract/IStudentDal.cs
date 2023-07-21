using CoreLayer.DataAccess;
using DataAccesss.Entities;
using DataAccesss.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesss.Abstract
{
    public interface IStudentDal:IEntityRepository<Student>
    {

        IList<StudentListDto> GetStudentListDal();
    }
}
