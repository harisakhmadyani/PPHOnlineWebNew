using System;

namespace PlgRequest.Models
{
    public class InputPriceDto
    {
        public string item { get; set; }
        public string cur { get; set; }
        public decimal qnty { get; set; }
        public decimal qtyrt { get; set; }
        public decimal price { get; set; }
        public DateTime valid { get; set; }
        public DateTime deliv { get; set; }
        public long id { get; set; }
        public string remark { get; set; }
        public string newitem { get; set; }
        public string factory { get; set; }
        public string filename { get; set; }
        public string changename { get; set; }
    }
}

// string item, string cur, decimal price, DateTime valid, DateTime deliv, long id, string remark