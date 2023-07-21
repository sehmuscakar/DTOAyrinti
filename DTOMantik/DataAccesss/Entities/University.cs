using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesss.Entities
{
   public class University:BaseEntity
    {
       
        public string Name { get; set; }
      
        public string City { get; set; }
     
    public List<Student> students { get; set; }

    }
}
