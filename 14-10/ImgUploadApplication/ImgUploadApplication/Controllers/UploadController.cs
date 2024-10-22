using ImgUploadApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace ImgUploadApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> CreateUser([FromForm]User user)
        {
            if (user.ProfilePicture != null)
            {
                var folderPath = Path.Combine(Directory.GetCurrentDirectory(), "Uploads");
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                var filePath = Path.Combine(folderPath,user.ProfilePicture.FileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await user.ProfilePicture.CopyToAsync(stream);
                }
                    var response = new
                    {
                        Success = true,
                        Message = $"User {user.Name} created successfully!",
                        ProfilePictureName = user?.ProfilePicture?.FileName,
                        Code = StatusCodes.Status200OK
                    };
                    return Ok(response);
            }
            return BadRequest();
        }
    }
}
