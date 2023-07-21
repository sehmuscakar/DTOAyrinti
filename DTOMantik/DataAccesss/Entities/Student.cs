using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesss.Entities
{
   public class Student:BaseEntity//çoklu
    {
      
        public string Name { get; set; }

        public string Surname { get; set; }

      
        public string Cinsiyet { get; set; }

        public int UniversityID { get; set; }//tekli olduğu için foriren key dir bu 
        public University University { get; set; }
    }
}
