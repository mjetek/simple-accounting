using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleAccounting.Models
{
    public class JournalEntry
    {
        public int Id { get; set; }
        public string Sequency { get; set; }
        public int Period { get; set; }
        public DateTime Date { get; set; }
        public Account Account { get; set; }
        public string Description { get; set; }
        public decimal Debts { get; set; }
        public decimal Credit { get; set; }
    }
}