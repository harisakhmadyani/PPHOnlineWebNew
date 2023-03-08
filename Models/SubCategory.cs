using System.Collections.Generic;

namespace PlgRequest.Models
{
    public class SubCategory
    {
        public string st { get; set; }
        public IEnumerable<Subcat> data { get; set; }
        
    }

    public class Subcat {
        public string SubCategoryID { get; set; }
        public string SubCategoryName { get; set; }
    }
}