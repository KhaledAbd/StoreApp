using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.API.Models
{
    public class OwnerFactory
    {
        [Key]
        public int UserId { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string phone { get; set; }

        public int LogoId { get; set; }


        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        [ForeignKey("LogoId")]
        public virtual Photo Logo { get; set; }

    }
}