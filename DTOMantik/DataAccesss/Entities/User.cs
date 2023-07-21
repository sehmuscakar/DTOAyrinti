using CoreLayer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesss.Entities
{
    public class User : IEntity
    {
        [Key] // base entityden miras almadığı iiçin key değeri ver yoksa sıkıntı olabilir
        public int Id { get; set; }
     
        public string Name { get; set; }
  
        public string Surname { get; set; }
     
        public IList<Student> Students { get; set; }

        public IList<University> Universities { get; set;}




    


    }
}
