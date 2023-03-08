using System;

namespace PlgRequest.Models
{
    public class BudgetPeriod
    {
        public long ID { get; set; }
        public string BudgetYear { get; set; }
        public string BudgetMonth { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<DateTime> CreatedDate { get; set; }
    }
}