using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplicationCourseEng.DTOs;
using WebApplicationCourseEng.Entities;
using WebApplicationCourseEng.Helpers;

namespace WebApplicationCourseEng.Interfaces
{
    public interface IUserRepository
    {
        void Update(AppUser user);
        Task<bool> SaveAllAsync();
        Task<IEnumerable<AppUser>> GetUserAsync();
        Task<AppUser> GetUserByIdAsync(int id);
        Task<AppUser> GetUserByUsernameAsync(string username);

        Task<PagedList<MemberDto>> GetMembersAsync(UserParams userParams);
        Task<MemberDto> GetMemberAsync(string username);
    }
}
