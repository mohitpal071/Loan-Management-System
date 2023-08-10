using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Model
{
    [Keyless]
    public class Employee_Card_Detail
    {

        public Employee Employee { get; set; }
        public Loan_Card_Master loan_Card_Master { get; set; }


        [Required]
        [Column(TypeName = "Date")]
        public DateTime card_issue_date { get; set; }

        
    }
}
