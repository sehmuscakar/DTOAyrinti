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
    public class UniversityDal : BaseRepository<University, ProjeContext>, IUniversityDal
    {
        public IList<UniversityListDto> GetUniversityListDal()
        {
            using (var context = new ProjeContext())
            {
                var a = context.Universities.Select(university => new UniversityListDto()
                {
                    Id = university.Id,
                    Name = university.Name,
                    City = university.City,
                    CreatedAt = university.CreatedAt,
                    CreatedUserName = university.User.Name + " " + university.User.Surname,// user ismini ve soyismini çektim burada 

                });
                return a.ToList();
            }
        }
    }
}
