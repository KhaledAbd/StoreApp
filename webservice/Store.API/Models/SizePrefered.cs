using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.API.Models
{
    public class SizePrefered
    {
        [Key]
        public int SizeId{get; set;}
        public int CleintId{get; set;}

        [ForeignKey("SizeId")]
        public virtual Size Size {get; set;}
        [ForeignKey("CleintId")]
        public virtual Cleint Cleint{get; set;}
    }
}