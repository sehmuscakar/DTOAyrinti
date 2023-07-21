using Business.Abstract;
using DataAccesss.Abstract;
using DataAccesss.Concrete;
using DataAccesss.Entities;
using DataAccesss.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class StudentManager : IStudentManager
    {
        private readonly IStudentDal _studentDal;

        public StudentManager(IStudentDal studentDal)
        {
            _studentDal = studentDal;
        }

        public void Add(Student student)
        {
            var roworder = _studentDal.GetActiveList().Count();
            student.RowOrder= roworder+1;
            student.CreatedAt= DateTime.Now;    
           _studentDal.Add(student);
        }

        public Student GetById(int id)
        {
            Expression<Func<Student, bool>> filter = x => x.Id == id;
            return _studentDal.Get(filter);
        }

        public IList<StudentListDto> GetStudentListManager()// dto ile listeleme
        {
            var data = _studentDal.GetStudentListDal();
            return data;
        }

        public IList<Student> GetList() //normal listeleme
        {
            var data = _studentDal.GetActiveList();
            return data;
        }

        public void Remove(Student student)
        {
            _studentDal.Delete(student);
        }

        public void Update(Student student)
        {
            student.UpdatedAt= DateTime.Now;
           _studentDal.Update(student);
        }
    }
}
