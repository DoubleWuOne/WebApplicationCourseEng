using WebApplicationCourseEng.Entities;

namespace WebApplicationCourseEng.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
