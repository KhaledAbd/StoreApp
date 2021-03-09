using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.API.Models
{
    public class BillsClothes
    {
        [Key]
        public int ClothesCode {get; set;}

        public int BillsId {get; set;}

        public int Quentity {get; set;}
        
        public double PriceFactory {get; set;}

        [ForeignKey("ClothesCode")]
        public virtual Cloth Cloth {get; set;}

        [ForeignKey("BillsId")]
        public virtual Bill Bill {get; set;}
    }
}