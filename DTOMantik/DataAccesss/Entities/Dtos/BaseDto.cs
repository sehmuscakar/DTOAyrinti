using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesss.Entities.Dtos
{
    public class BaseDto
    {
        public int Id { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedUserName { get; set; }
    }
}
