using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Model
{
    public class Employee
    {
        [Key]
        [Column(TypeName = "varchar(6)")]

        public string employee_id { get; set; }

        [Required]
        [Column(TypeName ="varchar(20)")]
        public string employee_name { get; set; }

        [Required]
        [Column(TypeName = "varchar(25)")]
        public string designation { get; set; }

        [Required]
        [Column(TypeName = "varchar(25)")]
        public string department { get; set; }

        [Required]
        [Column(TypeName = "varchar(1)")]
        public char gender { get; set; }

        [Required]
        [Column(TypeName = "Date")]
        public DateTime date_of_birth { get;set; }
        public DateTime date_of_joining { get; set; }
    }
}
