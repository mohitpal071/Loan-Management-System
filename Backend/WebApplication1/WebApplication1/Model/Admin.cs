using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Model
{
    public class Admin
    {
        [Required]
        [Column(TypeName = "varchar(250)")]
        public string AdminName { get; set; }

        [Key]
        [Column(TypeName = "varchar(6)")]
        public string AdminId { get; set; }

        [Required]
        [Column(TypeName = "varchar(10)")]
        public string Password { get; set; }
    }
}
