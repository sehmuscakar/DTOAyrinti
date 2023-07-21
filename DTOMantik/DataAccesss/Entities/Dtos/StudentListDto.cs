using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesss.Entities.Dtos
{
    public class StudentListDto:BaseDto
    {
     
        public string Name { get; set; }
      
        public string Surname { get; set; }

        public string Cinsiyet { get; set; }
    
        public string UniversityName { get; set; } //bunu universte ile ilişiki olduğu için yaptık 
    }
}
