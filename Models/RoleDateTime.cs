using System;

namespace PlgRequest.Models
{
    public class RoleDateTime
    {
        public long ID { get; set; }
        public DateTime OpenDate { get; set; }
        public DateTime CloseDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<DateTime> CreatedDate { get; set; }
    }
}