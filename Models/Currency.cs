using System.Collections.Generic;

namespace PlgRequest.Models
{
    public class Currency
    {
        public string st { get; set; }
        public IEnumerable<Curr> data { get; set; }
        
    }

    public class Curr {
        public string CurrencyID { get; set; }
        public string GroupAccess { get; set; }
    }
}