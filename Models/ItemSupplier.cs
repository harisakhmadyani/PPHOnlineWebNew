using System.Collections.Generic;

namespace PlgRequest.Models
{
    public class ItemSupplier
    {
        public string st { get; set; }
        public IEnumerable<ItemSupp> data { get; set; }        
    }

    public class ItemSupp
    {
        public string ItemID { get; set; }
        public string ItemName { get; set; }
        public string ItemDesc { get; set; }
        public string SupplierID { get; set; }
        public string NewItemID { get; set; }  
    }
}