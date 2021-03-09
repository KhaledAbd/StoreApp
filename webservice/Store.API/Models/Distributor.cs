using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.API.Models
{
    public class Distributor
    {
        [Key]
        [Column(Order = 1)]
        public int UserId { get; set; }
        public string CarNumbers { get; set; }
        public string Type { get; set; }

        public double Percantage{get; set;}

        public double Salary{get; set;}

        public double NumOfgears{get; set;}

        [ForeignKey("UserId")]
        public virtual User User{get; set;}
    }
}