using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleAccounting.Models
{
    public class Account
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public Account Parent { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public string Category { get; set; }
        public string Origin { get; set; }
        public int TypeId { get; set; }
        public AccountType Type { get; set; }
        [JsonIgnore]
        public int CompanyId { get; set; }
    }
}