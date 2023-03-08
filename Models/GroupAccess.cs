using System;
using System.Collections.Generic;

namespace PlgRequest.Models
{
    public class GroupAccess
    {
        public string st { get; set; }
        public IEnumerable<GrpAcs> data { get; set; }
              
    }

    public class GrpAcs
    {
        public string GroupAccessID { get; set; }
        public string GroupAccessName { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<DateTime> CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<DateTime> UpdatedDate { get; set; }
        public short DeletedStatus  { get; set; }
        public string DeletedBy { get; set; }
        public Nullable<DateTime> DeletedDate { get; set; }  
    }
}