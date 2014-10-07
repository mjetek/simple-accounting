using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimpleAccounting.Models
{
    public class Journal
    {
        public int Id { get; set; }
        public virtual ICollection<JournalEntry> Entries { get; set; }
        [JsonIgnore]
        public int CompanyId { get; set; }
    }
}