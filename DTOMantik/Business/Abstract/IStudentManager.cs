using DataAccesss.Entities;
using DataAccesss.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public interface IStudentManager
    {
           IList<Student> GetList();//normal listeleme metodu

        IList<StudentListDto> GetStudentListManager(); // dto ile listeleme

        void Add(Student student);

        void Update(Student student);

        void Remove(Student student);

        Student GetById(int id);
    }
}
