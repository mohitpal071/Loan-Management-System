using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Model
{
    public class Adminclass
    {
        [Required]
        [Key]
        public string AdminId { get; set; }


        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Email { get; set; } = string.Empty;

        public byte[] PasswordHash { get; set; } = new byte[32];

        public byte[] PasswordSalt { get; set; } = new byte[32];

        public string? VerificationToken { get; set; }

        public DateTime VerifiedAt { get; set; }

        public string? PasswordResetToken { get; set; }

        public DateTime ResetTokenExpires { get; set; }
    }
}
