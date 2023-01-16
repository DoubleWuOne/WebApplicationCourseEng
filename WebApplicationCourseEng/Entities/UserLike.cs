using System.Collections.Generic;

namespace WebApplicationCourseEng.Entities
{
    public class UserLike
    {
        public AppUser SourceUser { get; set; }
        public int SourdeUserId { get; set; }
        public AppUser TargetUser { get; set; }
        public int TargetUserId { get; set; }
    }
}
