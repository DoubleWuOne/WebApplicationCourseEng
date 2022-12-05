using Microsoft.AspNetCore.Mvc;
using WebApplicationCourseEng.Helpers;

namespace WebApplicationCourseEng.Controllers
{
    [ServiceFilter(typeof(LogUserActivity))]
    [ApiController]
    [Route("api/[controller]")]
    public class BaseApiController : ControllerBase
    {
    }
}
