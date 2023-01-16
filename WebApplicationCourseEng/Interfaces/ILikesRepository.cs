using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplicationCourseEng.DTOs;
using WebApplicationCourseEng.Entities;
using WebApplicationCourseEng.Helpers;

namespace WebApplicationCourseEng.Interfaces
{
    public interface ILikesRepository
    {
        Task<UserLike> GetUserLike(int sourceUserId, int targetUserId);
        Task<AppUser> GetUserWithLikes(int userId);
        Task<PagedList<LikeDto>> GetUserLikes(LikesParams likesParams);
    }
}
