using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Model
{
    public class Admin
    {
        [Required]
        [Key]
        public string username { get; set; }


        [Required]
        [Column(TypeName = "varchar(100)")]
        public string password { get; set; } = string.Empty;

       

        
    }
}
