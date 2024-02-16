namespace API.DTOs
{
    public class RegisterDto : LoginDto
    {
        public new string Username { get; set; }
        public string Email { get; set; }
    }
}