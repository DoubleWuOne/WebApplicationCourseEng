using System.Linq;
using AutoMapper;
using WebApplicationCourseEng.DTOs;
using WebApplicationCourseEng.Entities;
using WebApplicationCourseEng.Extensions;

namespace WebApplicationCourseEng.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<AppUser, MemberDto>()
                .ForMember(dest
                    => dest.PhotoUrl, opt
                    => opt.MapFrom(src
                        => src.Photos.FirstOrDefault(x => x.IsMain).Url))
                .ForMember(dest => dest.Age, opt =>
                    opt.MapFrom(src => src.DateOfBirth.CalculateAge()));
            CreateMap<Photo, PhotoDto>();
            CreateMap<MemberUpdateDto, AppUser>();
        }
    }
}
