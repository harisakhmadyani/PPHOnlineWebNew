namespace PlgRequest.Models
{
    public class ChangePasswordDto
    {
        public string oldPassword { get; set; }
        public string newPassword { get; set; }
        public string userId { get; set; }
    }
}