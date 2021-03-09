using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.API.Models
{
    public class ClientBillClothes
    {
        [Key]
        public int ClientBillId {get; set;}

        public int ClothId {get; set;}

        public int Quentity {get; set;}

        public double Sale{get; set;} 
        [ForeignKey("ClientBillId")]
        public virtual ClientBill ClientBill{get; set;}
        [ForeignKey("ClothId")]
        public virtual Cloth Cloth {get; set;}

    }
}