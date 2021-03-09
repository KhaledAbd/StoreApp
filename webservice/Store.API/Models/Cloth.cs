using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Store.API.Models
{
    public class Cloth
    {
        [Key]
        public int Code {get; set;}

        public bool MainPhoto {get; set;}

        public string PhotoUrl {get; set;}

        public string PublicId {get; set;}

        public string Description {get; set;}

        public long Color {get; set;}

        public virtual Size Size {get; set;}

        public int Quentity {get; set;}

        public double Price {get; set;}

        public double Sale {get; set;}

        public bool isApproved {get; set;}

        public string ModelName {get; set;}

        public virtual Category Category {get; set;}

        public virtual TypeCloth TypeCloth {get; set;}
        
        public virtual ICollection<ClientBillClothes> ClientBillClothes {get; set;}

    }
}