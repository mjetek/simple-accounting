using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace SimpleAccounting.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }
        public string Email { get; set; }
        [Required]
        [JsonIgnore]
        public string Password { get; set; }
        [JsonIgnore]
        public Company Company { get; set; }
        public int CompanyId { get; set; }
    }
}