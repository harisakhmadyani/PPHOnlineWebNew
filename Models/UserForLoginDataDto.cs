namespace PlgRequest.Models
{
    public class UserForLoginDataDto
    {
        public string Token { get; set; }
        public UserForLoginDetail user{ get; set; }
    }
}