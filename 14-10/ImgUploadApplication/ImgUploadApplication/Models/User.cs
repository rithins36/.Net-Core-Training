namespace ImgUploadApplication.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public IFormFile ProfilePicture { get; set; }
    }
}
