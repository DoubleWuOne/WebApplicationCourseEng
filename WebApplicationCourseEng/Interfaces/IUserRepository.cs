using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplicationCourseEng.DTOs;
using WebApplicationCourseEng.Entities;

namespace WebApplicationCourseEng.Interfaces
{
    public interface IUserRepository
    {
        void Update(AppUser user);
        Task<bool> SaveAllAsync();
        Task<IEnumerable<AppUser>> GetUserAsync();
        Task<AppUser> GetUserByIdAsync(int id);
        Task<AppUser> GetUserByUsernameAsync(string username);

        Task<IEnumerable<MemberDto>> GetMembersAsync();
        Task<MemberDto> GetMemberAsync(string username);
    }
}
