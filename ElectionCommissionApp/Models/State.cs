using System.ComponentModel.DataAnnotations;

namespace ElectionCommissionApp.Models
{
    public class State
    {
        [Key]
        public int StateId { get; set; }
        [Required]
        [MaxLength(25, ErrorMessage = "Name should not exceed 25 characters" )]
        public string StateName { get; set; }
    }
}
