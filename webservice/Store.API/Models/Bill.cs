using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Store.API.Models
{
    public class Bill
    {
        [Key]
        public int id {set; get;}

        public DateTime DateOfBills{get; set;}

        public double payed {get; set;}

        public virtual Photo PhotoUrl{get; set;}  

        public virtual OwnerFactory OwnerFactory {set; get;}

        public virtual Employee regiteredId {set; get;}

        public virtual ICollection<BillsClothes> BillsClothes {get; set;}
    }
}