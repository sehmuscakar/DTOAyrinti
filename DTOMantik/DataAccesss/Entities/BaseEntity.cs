using CoreLayer.Entities.Abstract;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DataAccesss.Entities
{
    public class BaseEntity:IEntity
    {

        public int Id { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? CreatedBy { get; set; }//forein key görevi görür
        public int? UpdatedBy { get; set; }
        public int? DeletedBy { get; set; }
        public bool IsActive { get; set; }
        public int RowOrder { get; set; } //roworder algoritmasını da yaptık student ta 

        public User User { get; set; } // baseEntity nerelerde kullanılırsa ilişki olacak o tablolarla userın  user tekli diğerleri çoklu 

    }
}
