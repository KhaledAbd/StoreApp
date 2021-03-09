using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.API.Models
{
    public class Employee
    {
        [Key]
        public int UserId {get; set;}
        public double Salary{get; set;}

        public double Incentives {get; set;}

        public double Allowances {get; set;}
        [ForeignKey("UserId")]
        public virtual User User {get; set;}


    }
}