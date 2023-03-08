using System.Collections.Generic;

namespace PlgRequest.Models
{
    public class InputGet : InputPrice
    {
        public string SupplierName { get; set; }
        public string ItemName { get; set; }
        public string UOMName { get; set; }
    }

    public class InputGets{
        public string st { get; set; }
        public IEnumerable<InputGet> data { get; set; }
    }


}