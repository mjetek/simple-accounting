using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Script.Serialization;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace SimpleAccounting.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [Display(Name="Company")]
        public string Name { get; set; }
        public string Website { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        [Required]
        [JsonIgnore]
        public string Password { get; set; }
        public string Status { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }
}