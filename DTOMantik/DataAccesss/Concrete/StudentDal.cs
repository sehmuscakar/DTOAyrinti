using CoreLayer.DataAccess.EntityFramework;
using DataAccesss.Abstract;
using DataAccesss.Context;
using DataAccesss.Entities;
using DataAccesss.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesss.Concrete
{
    public class StudentDal : BaseRepository<Student, ProjeContext>, IStudentDal
    {
        public IList<StudentListDto> GetStudentListDal()
        {
            using (var context = new ProjeContext())
            {
                var a = context.Students.Select(student => new StudentListDto() //Where(i => i.IsActive) bunuda ekleyebilirsin istersen 
                {
                    Id = student.Id,
                    Name = student.Name,
                    Surname = student.Surname,
                    Cinsiyet = student.Cinsiyet,
                   CreatedAt = student.CreatedAt,
                    UniversityName = student.University.Name,//üniverste adını çektim 
                    CreatedUserName = student.User.Name + " " + student.User.Surname,// user ismini ve soyismini çektim burada 

                });
                return a.ToList();
            }
        }
    }
}
