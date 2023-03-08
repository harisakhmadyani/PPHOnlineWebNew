using Microsoft.AspNetCore.Http;

namespace PlgRequest.Models
{
    public class InputPriceDtoUpload : InputPriceDto
    {
        public IFormFile file { get; set; }
    }
}