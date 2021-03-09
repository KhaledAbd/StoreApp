using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.API.Models
{
    public class CategoryPrefered
    {

        [Key]
        public int CategoryId {get; set;} 

        [ForeignKey("CategoryId")]
        public virtual Category Category {get; set;}
        
        public int ClientId{get; set; }
        [ForeignKey("ClientId")]
        public virtual Cleint Cleint{get; set;}
    }
}