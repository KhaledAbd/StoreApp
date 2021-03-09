using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.API.Models
{
    public class TypeClothPrefered
    {
        [Key]
        public int TypeClothId {get; set;}

        [ForeignKey("TypeClothId")]
        public virtual TypeCloth TypeCloth {get; set;}

        public  int CleintId{get; set;}

        [ForeignKey("CleintId")]
        public virtual Cleint Cleint{get; set;}

    }
}