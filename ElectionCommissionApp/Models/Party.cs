using Newtonsoft.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace ElectionCommissionApp.Models
{
    public class Party
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(6, ErrorMessage = "Name should not excees 6 character")]
        public string Name { get; set; }
    }
}
