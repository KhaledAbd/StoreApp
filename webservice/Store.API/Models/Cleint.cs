using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.API.Models
{
    public class Cleint
    {
        [Key]
        public int UserId {set; get;}

        public virtual ICollection<CategoryPrefered> CategoryPrefered{get; set;}

        public virtual ICollection<SizePrefered> SizePrefered{get; set;}

        public virtual ICollection<TypeClothPrefered> TypeClothPrefered{get; set;}
        
        public DateTime DateLastPurchase {get; set;}

        public string Activities {get; set;}
        
        [ForeignKey("UserId")]
        public virtual User User{get; set;}
    }
}