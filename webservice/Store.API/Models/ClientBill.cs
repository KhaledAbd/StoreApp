using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Store.API.Models
{
    public class ClientBill
    {
        [Key]
        public int Id {get; set;}

        public DateTime DateOfBills {get; set;} 

        public string Location {get; set;}

        public bool TypePaid {get; set;}

        public double paid {get; set;}

        public bool isRecieved {get; set;}

        public virtual ICollection<ClientBillClothes> ClientBillClothes {get; set;}
    }
}